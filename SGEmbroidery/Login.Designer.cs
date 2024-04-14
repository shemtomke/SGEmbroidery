namespace SGEmbroidery
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginButton = new Button();
            label2 = new Label();
            label1 = new Label();
            passwordField = new TextBox();
            usernameField = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.GradientActiveCaption;
            loginButton.Location = new Point(362, 469);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 10;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(348, 408);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 9;
            label2.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(349, 344);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 8;
            label1.Text = "USERNAME";
            // 
            // passwordField
            // 
            passwordField.BackColor = SystemColors.GradientActiveCaption;
            passwordField.BorderStyle = BorderStyle.None;
            passwordField.Location = new Point(297, 436);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(215, 16);
            passwordField.TabIndex = 7;
            passwordField.TextAlign = HorizontalAlignment.Center;
            // 
            // usernameField
            // 
            usernameField.BackColor = SystemColors.GradientActiveCaption;
            usernameField.BorderStyle = BorderStyle.None;
            usernameField.Location = new Point(297, 372);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(215, 16);
            usernameField.TabIndex = 6;
            usernameField.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 300);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(800, 500);
            Controls.Add(pictureBox1);
            Controls.Add(loginButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private Label label2;
        private Label label1;
        private TextBox passwordField;
        private TextBox usernameField;
        private PictureBox pictureBox1;
    }
}