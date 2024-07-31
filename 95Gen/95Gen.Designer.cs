namespace _95Gen
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            PIDLabel = new Label();
            OEM_PID = new RadioButton();
            Retail_PID = new RadioButton();
            WindowTitle = new Label();
            CopyPIDLabel = new LinkLabel();
            OKButton = new PictureBox();
            WindowExitBox = new PictureBox();
            TitleBar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)OKButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WindowExitBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TitleBar).BeginInit();
            SuspendLayout();
            // 
            // PIDLabel
            // 
            PIDLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PIDLabel.Location = new Point(12, 98);
            PIDLabel.Name = "PIDLabel";
            PIDLabel.Size = new Size(284, 17);
            PIDLabel.TabIndex = 0;
            PIDLabel.Text = "Click OK To Create PID";
            PIDLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OEM_PID
            // 
            OEM_PID.AutoSize = true;
            OEM_PID.Font = new Font("Microsoft Sans Serif", 8.25F);
            OEM_PID.Location = new Point(117, 60);
            OEM_PID.Name = "OEM_PID";
            OEM_PID.Size = new Size(70, 17);
            OEM_PID.TabIndex = 2;
            OEM_PID.TabStop = true;
            OEM_PID.Text = "OEM PID";
            OEM_PID.UseVisualStyleBackColor = true;
            // 
            // Retail_PID
            // 
            Retail_PID.AutoSize = true;
            Retail_PID.Font = new Font("Microsoft Sans Serif", 8.25F);
            Retail_PID.Location = new Point(117, 78);
            Retail_PID.Name = "Retail_PID";
            Retail_PID.Size = new Size(73, 17);
            Retail_PID.TabIndex = 1;
            Retail_PID.TabStop = true;
            Retail_PID.Text = "Retail PID";
            Retail_PID.UseVisualStyleBackColor = true;
            // 
            // WindowTitle
            // 
            WindowTitle.AutoSize = true;
            WindowTitle.BackColor = Color.Transparent;
            WindowTitle.ForeColor = Color.White;
            WindowTitle.Location = new Point(6, 5);
            WindowTitle.Name = "WindowTitle";
            WindowTitle.Size = new Size(134, 15);
            WindowTitle.TabIndex = 3;
            WindowTitle.Text = "Windows 95 PID Creator";
            WindowTitle.MouseDown += Main_MouseDown;
            WindowTitle.MouseMove += Main_MouseMove;
            // 
            // CopyPIDLabel
            // 
            CopyPIDLabel.ActiveLinkColor = Color.DarkBlue;
            CopyPIDLabel.AutoSize = true;
            CopyPIDLabel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CopyPIDLabel.Location = new Point(184, 132);
            CopyPIDLabel.Name = "CopyPIDLabel";
            CopyPIDLabel.Size = new Size(120, 13);
            CopyPIDLabel.TabIndex = 4;
            CopyPIDLabel.TabStop = true;
            CopyPIDLabel.Text = "Copy PID to Clipboard...";
            CopyPIDLabel.Visible = false;
            CopyPIDLabel.LinkClicked += CopyPIDLabel_LinkClicked;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.Transparent;
            OKButton.Location = new Point(129, 119);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(49, 28);
            OKButton.TabIndex = 5;
            OKButton.TabStop = false;
            OKButton.Click += OKButton_Click;
            // 
            // WindowExitBox
            // 
            WindowExitBox.BackColor = Color.Transparent;
            WindowExitBox.Location = new Point(286, 5);
            WindowExitBox.Name = "WindowExitBox";
            WindowExitBox.Size = new Size(18, 15);
            WindowExitBox.TabIndex = 6;
            WindowExitBox.TabStop = false;
            WindowExitBox.Click += WindowExitBox_Click;
            // 
            // TitleBar
            // 
            TitleBar.BackColor = Color.Transparent;
            TitleBar.Location = new Point(2, 0);
            TitleBar.Name = "TitleBar";
            TitleBar.Size = new Size(305, 22);
            TitleBar.TabIndex = 7;
            TitleBar.TabStop = false;
            TitleBar.MouseDown += Main_MouseDown;
            TitleBar.MouseMove += Main_MouseMove;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(308, 158);
            Controls.Add(PIDLabel);
            Controls.Add(CopyPIDLabel);
            Controls.Add(WindowTitle);
            Controls.Add(Retail_PID);
            Controls.Add(OEM_PID);
            Controls.Add(OKButton);
            Controls.Add(WindowExitBox);
            Controls.Add(TitleBar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows 95 PID Creator";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)OKButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)WindowExitBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)TitleBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label PIDLabel;
        private RadioButton OEM_PID;
        private RadioButton Retail_PID;
        private Label WindowTitle;
        private LinkLabel CopyPIDLabel;
        private PictureBox OKButton;
        private PictureBox WindowExitBox;
        private PictureBox TitleBar;
    }
}
