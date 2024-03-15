namespace CarDealership {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            signInButton = new Button();
            exitButton = new Button();
            linkLabel1 = new LinkLabel();
            statusStrip1 = new StatusStrip();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.Transparent;
            signInButton.BackgroundImageLayout = ImageLayout.Stretch;
            signInButton.Cursor = Cursors.Hand;
            signInButton.FlatAppearance.BorderSize = 0;
            signInButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            signInButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.ForeColor = SystemColors.ButtonFace;
            signInButton.Location = new Point(520, 396);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(126, 34);
            signInButton.TabIndex = 0;
            signInButton.Text = "Вход";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Transparent;
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.ForeColor = SystemColors.ButtonFace;
            exitButton.Location = new Point(520, 436);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(126, 34);
            exitButton.TabIndex = 1;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.No;
            linkLabel1.Location = new Point(12, 650);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(10, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = ",";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 652);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1142, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "Ожидание ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1142, 674);
            Controls.Add(statusStrip1);
            Controls.Add(linkLabel1);
            Controls.Add(exitButton);
            Controls.Add(signInButton);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private Button exitButton;
        private LinkLabel linkLabel1;
        private StatusStrip statusStrip1;
    }
}