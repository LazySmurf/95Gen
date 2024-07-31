namespace _95Gen
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            WindowTitle.Text = Text;
            Retail_PID.Checked = true;
        }

        private void WindowExitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyPIDLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(PIDLabel.Text);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            //Define PID var to hold generated PID
            string PID = string.Empty;

            if (OEM_PID.Checked) /* User has selected to use OEM algo */
            {
                //OEM PID starts with a number between 1 and 366 followed by a number between 95 and 02
                //Then there is a dash followed by "OEM" followed by another dash
                //Then there is the same Mod7 check as a retail key with the leading digit always being 0
                //Then there is a dash, followed by 5 numerical digits that do not matter
                PID = Create_OEM_PID();
            }
            else /* Default to/User has selected to use Retail algo */
            {
                //Retail PID starts with 3 characters that are not 333,444,555,666,777,888,999 followed by a fourth character (usually a dash but doesn't have to be)
                //Then there are 7 digits which when each digit is added together adds up to a number which is divisible by 7 without a remainder (mod7)

                PID = Create_Retail_PID();
            }

            //Once algo is selected, display generated PID
            if (!string.IsNullOrEmpty(PID))
            {
                PIDLabel.Font = new Font("Consolas", 9, FontStyle.Regular);
                PIDLabel.Text = PID;
                CopyPIDLabel.Visible = true;
            }
        }

        static string Create_OEM_PID()
        {
            //Create the string we will store the final PID in before returning
            string PID = string.Empty;

            Random random = new();

            //First, generate the number between 1 and 366
            int first3 = random.Next(1, 367);
            //Next, pick the number between 95 and 02
            int next2 = random.Next(0, 8);
            string[] OEMyear = { "95", "96", "97", "98", "99", "00", "01", "02" };
            //Then, generate the 5 digit number for the end
            int last5 = random.Next(10000, 100000);

            //To create the PID, we will concat the first 3 numbers and the next 2 together
            PID += first3;
            PID += OEMyear[next2];
            //Followed by the "-OEM-" marker
            PID += "-OEM-";
            //Followed by our mod7 number starting with 0
            PID += GenMod7Num(true);
            //Another dash after that
            PID += "-";
            //Then the last 5 digits we generated.
            PID += last5;

            //And then we return the result!
            return PID;
        }

        static string Create_Retail_PID()
        {
            //Create the string we will store the final PID in before returning
            string PID = string.Empty;

            //Generate the 3 digits for the start of the PID
            Random random = new();
            int[] excludedNumbers = { 333, 444, 555, 666, 777, 888, 999 };
            int number;

            do
            {
                number = random.Next(100, 1000); // Generate a 3-digit number (100-999)
            } while (Array.Exists(excludedNumbers, element => element == number));

            //Once we've generated the first 3 digits, we will add them to the PID string.
            PID += number;
            //Then, we will add a hyphen
            PID += "-";
            //Then, we will add our mod7 number
            PID += GenMod7Num();

            //Then we return the result!
            return PID;
        }

        static string GenMod7Num(bool IsOEMPID = false)
        {
            Random random = new();
            int[] digits = new int[7];
            int sum = 0;

            // Generate 6 random digits and calculate their sum
            for (int i = 0; i < 6; i++)
            {
                if (IsOEMPID && i == 0) //If we have selected the OEM PID creation method, we will set the first digit in the array to 0 always
                {
                    digits[0] = 0;
                }
                else
                {
                    digits[i] = random.Next(0, 10);
                    sum += digits[i];
                }
            }

            // Calculate the 7th digit such that the total sum is divisible by 7
            // We want sum + digits[6] to be divisible by 7
            // Hence, digits[6] should be (7 - sum % 7) % 7
            int remaining = (7 - sum % 7) % 7;
            digits[6] = remaining;
            sum += digits[6];

            // Convert the digits array to a single string
            string result = string.Join("", digits);

            // Return the result and the sum
            return result;
        }










        //===============================\\
        // Handle Dragging Borderless Form \\
        //===================================\\

        private int X1; // These 3 variables are defined here for use with the following functions
        private int Y1; // to allow dragging of the borderless form!
        private Rectangle WR;

        // Handle the elements that you can use to click and drag the window, and also handles snapping to the edges of the screen.
        public MouseEventArgs MouseDownEvents(MouseEventArgs e) // When the mouse is down...
        {
            X1 = e.X; // Set X1 to mouse event's X coord
            Y1 = e.Y; // Set Y1 to mouse event's Y coord
            WR = Screen.GetWorkingArea(this); // Set WR as the working area of the current screen that the window is on.
            return e; // Return e (discarded)
        }

        public MouseEventArgs MouseMoveEvents(MouseEventArgs e) // When the mouse moves...
        {
            if (!(e.Button == MouseButtons.Left))
                return e; // If the mouse button isn't the left mouse button, return e, exit function.
            int NewX = Left + (e.X - X1); // NewX is window's left plus mouse's X subtract X1 (lock X coords together)
            int NewY = Top + (e.Y - Y1); // Same but for Y coord (lock Y coords together)
            int W = Width; // W is window's width
            int H = Height; // H is window's height
            if (NewY >= WR.Top - 15 & NewY <= WR.Top + 15) // If we approach an edge, do some logic to see when we're getting close, then set our position to that edge.
            {
                Top = WR.Top;
            }
            else if (NewY + H > WR.Bottom - 15 & NewY + H < WR.Bottom + 15)
            {
                Top = WR.Bottom - H;
            }
            else
            {
                Top = NewY;
            }
            if (NewX >= WR.Left - 15 & NewX <= WR.Left + 15)
            {
                Left = WR.Left;
            }
            else if (NewX + W > WR.Right - 15 & NewX + W < WR.Right + 15)
            {
                Left = WR.Right - W;
            }
            else
            {
                Left = NewX;
            }
            return e; // Return e (discarded again)
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownEvents(e);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveEvents(e);
        }
    }
}
