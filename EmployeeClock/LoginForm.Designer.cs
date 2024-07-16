namespace EmployeeClock
{
    partial class LoginForm
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
            tz_textBox = new TextBox();
            password_textBox = new TextBox();
            enter_button = new Button();
            changePassword_button = new Button();
            tz_label = new Label();
            password_label = new Label();
            SuspendLayout();
            // 
            // tz_textBox
            // 
            tz_textBox.Location = new Point(182, 39);
            tz_textBox.Name = "tz_textBox";
            tz_textBox.Size = new Size(100, 23);
            tz_textBox.TabIndex = 0;
            // 
            // password_textBox
            // 
            password_textBox.Location = new Point(182, 150);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(100, 23);
            password_textBox.TabIndex = 1;
            // 
            // enter_button
            // 
            enter_button.Location = new Point(182, 268);
            enter_button.Name = "enter_button";
            enter_button.Size = new Size(75, 23);
            enter_button.TabIndex = 2;
            enter_button.Text = "כניסה";
            enter_button.UseVisualStyleBackColor = true;
            enter_button.Click += OnEnterClicked;
            // 
            // changePassword_button
            // 
            changePassword_button.Location = new Point(136, 366);
            changePassword_button.Name = "changePassword_button";
            changePassword_button.Size = new Size(189, 23);
            changePassword_button.TabIndex = 3;
            changePassword_button.Text = "שנה סיסמה";
            changePassword_button.UseVisualStyleBackColor = true;
            changePassword_button.Click += OnForgotPasswordClicked;
            // 
            // tz_label
            // 
            tz_label.AutoSize = true;
            tz_label.Location = new Point(198, 21);
            tz_label.Name = "tz_label";
            tz_label.Size = new Size(68, 15);
            tz_label.TabIndex = 4;
            tz_label.Text = "תעודת זהות";
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(215, 132);
            password_label.Name = "password_label";
            password_label.Size = new Size(42, 15);
            password_label.TabIndex = 5;
            password_label.Text = "סיסמה";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 450);
            Controls.Add(password_label);
            Controls.Add(tz_label);
            Controls.Add(changePassword_button);
            Controls.Add(enter_button);
            Controls.Add(password_textBox);
            Controls.Add(tz_textBox);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tz_textBox;
        private TextBox password_textBox;
        private Button enter_button;
        private Button changePassword_button;
        private Label tz_label;
        private Label password_label;
    }
}