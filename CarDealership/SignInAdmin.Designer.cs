namespace CarDealership {
    partial class SignIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            enterFormButton = new Button();
            backButton = new Button();
            loginTextBox = new TextBox();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // enterFormButton
            // 
            enterFormButton.BackColor = Color.Transparent;
            enterFormButton.BackgroundImageLayout = ImageLayout.Stretch;
            enterFormButton.Cursor = Cursors.Hand;
            enterFormButton.FlatAppearance.BorderSize = 0;
            enterFormButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            enterFormButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            enterFormButton.FlatStyle = FlatStyle.Flat;
            enterFormButton.ForeColor = SystemColors.ButtonFace;
            enterFormButton.Location = new Point(133, 70);
            enterFormButton.Name = "enterFormButton";
            enterFormButton.Size = new Size(75, 23);
            enterFormButton.TabIndex = 0;
            enterFormButton.Text = "Вход";
            enterFormButton.UseVisualStyleBackColor = false;
            enterFormButton.Click += signinFormButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = SystemColors.ButtonFace;
            backButton.Location = new Point(133, 99);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 1;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(45, 12);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(267, 23);
            loginTextBox.TabIndex = 2;
            loginTextBox.Text = "Логин";
            loginTextBox.Enter += loginTextBox_Enter;
            loginTextBox.Leave += loginTextBox_Leave;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(45, 41);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(267, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.Text = "Пароль";
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(333, 134);
            Controls.Add(passwordTextBox);
            Controls.Add(loginTextBox);
            Controls.Add(backButton);
            Controls.Add(enterFormButton);
            Name = "SignIn";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterFormButton;
        private Button backButton;
        private TextBox loginTextBox;
        private TextBox passwordTextBox;
    }
}