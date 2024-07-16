namespace EmployeeClock
{
    partial class ChangePasswordForm
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
            oldPassword_textBox = new TextBox();
            newPassword_textBox = new TextBox();
            confirmPassword_textBox = new TextBox();
            tz_label = new Label();
            oldPassword_label = new Label();
            newPassword_label = new Label();
            confirmPassword_label = new Label();
            cancel_button = new Button();
            changePassowrd_button = new Button();
            SuspendLayout();
            // 
            // tz_textBox
            // 
            tz_textBox.Location = new Point(170, 45);
            tz_textBox.Name = "tz_textBox";
            tz_textBox.Size = new Size(100, 23);
            tz_textBox.TabIndex = 0;
            
            // 
            // oldPassword_textBox
            // 
            oldPassword_textBox.Location = new Point(170, 133);
            oldPassword_textBox.Name = "oldPassword_textBox";
            oldPassword_textBox.Size = new Size(100, 23);
            oldPassword_textBox.TabIndex = 1;
            // 
            // newPassword_textBox
            // 
            newPassword_textBox.Location = new Point(168, 219);
            newPassword_textBox.Name = "newPassword_textBox";
            newPassword_textBox.Size = new Size(100, 23);
            newPassword_textBox.TabIndex = 2;
            // 
            // confirmPassword_textBox
            // 
            confirmPassword_textBox.Location = new Point(173, 274);
            confirmPassword_textBox.Name = "confirmPassword_textBox";
            confirmPassword_textBox.Size = new Size(100, 23);
            confirmPassword_textBox.TabIndex = 3;
            // 
            // tz_label
            // 
            tz_label.AutoSize = true;
            tz_label.Location = new Point(192, 27);
            tz_label.Name = "tz_label";
            tz_label.Size = new Size(68, 15);
            tz_label.TabIndex = 4;
            tz_label.Text = "תעודת זהות";
            // 
            // oldPassword_label
            // 
            oldPassword_label.AutoSize = true;
            oldPassword_label.Location = new Point(198, 115);
            oldPassword_label.Name = "oldPassword_label";
            oldPassword_label.Size = new Size(70, 15);
            oldPassword_label.TabIndex = 5;
            oldPassword_label.Text = "סיסמה ישנה";
            // 
            // newPassword_label
            // 
            newPassword_label.AutoSize = true;
            newPassword_label.Location = new Point(192, 201);
            newPassword_label.Name = "newPassword_label";
            newPassword_label.Size = new Size(76, 15);
            newPassword_label.TabIndex = 6;
            newPassword_label.Text = "סיסמה חדשה";
            // 
            // confirmPassword_label
            // 
            confirmPassword_label.AutoSize = true;
            confirmPassword_label.Location = new Point(168, 256);
            confirmPassword_label.Name = "confirmPassword_label";
            confirmPassword_label.Size = new Size(109, 15);
            confirmPassword_label.TabIndex = 7;
            confirmPassword_label.Text = "אישור סיסמה חדשה";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(259, 390);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(75, 23);
            cancel_button.TabIndex = 8;
            cancel_button.Text = "ביטול";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += OnCancelClicked;
            // 
            // changePassowrd_button
            // 
            changePassowrd_button.Location = new Point(68, 390);
            changePassowrd_button.Name = "changePassowrd_button";
            changePassowrd_button.Size = new Size(142, 23);
            changePassowrd_button.TabIndex = 9;
            changePassowrd_button.Text = "החלף סיסמה";
            changePassowrd_button.UseVisualStyleBackColor = true;
            changePassowrd_button.Click += OnChangePassowrdClicked;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 450);
            Controls.Add(changePassowrd_button);
            Controls.Add(cancel_button);
            Controls.Add(confirmPassword_label);
            Controls.Add(newPassword_label);
            Controls.Add(oldPassword_label);
            Controls.Add(tz_label);
            Controls.Add(confirmPassword_textBox);
            Controls.Add(newPassword_textBox);
            Controls.Add(oldPassword_textBox);
            Controls.Add(tz_textBox);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tz_textBox;
        private TextBox oldPassword_textBox;
        private TextBox newPassword_textBox;
        private TextBox confirmPassword_textBox;
        private Label tz_label;
        private Label oldPassword_label;
        private Label newPassword_label;
        private Label confirmPassword_label;
        private Button cancel_button;
        private Button changePassowrd_button;
    }
}