namespace EmployeeClock
{
    partial class ClockForm
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
            tz_label = new Label();
            lastEntry_label = new Label();
            lastExit_label = new Label();
            cancel_button = new Button();
            exit_button = new Button();
            entry_button = new Button();
            SuspendLayout();
            // 
            // tz_label
            // 
            tz_label.AutoSize = true;
            tz_label.Location = new Point(119, 81);
            tz_label.Name = "tz_label";
            tz_label.Size = new Size(72, 15);
            tz_label.TabIndex = 0;
            tz_label.Text = "ת.ז. העובד    ";
            // 
            // lastEntry_label
            // 
            lastEntry_label.AutoSize = true;
            lastEntry_label.Location = new Point(90, 147);
            lastEntry_label.Name = "lastEntry_label";
            lastEntry_label.Size = new Size(119, 15);
            lastEntry_label.TabIndex = 1;
            lastEntry_label.Text = "תאריך כניסה אחרון    ";
            // 
            // lastExit_label
            // 
            lastExit_label.AutoSize = true;
            lastExit_label.Location = new Point(90, 214);
            lastExit_label.Name = "lastExit_label";
            lastExit_label.Size = new Size(117, 15);
            lastExit_label.TabIndex = 2;
            lastExit_label.Text = "תאריך יציאה אחרון    ";
            // 
            // cancel_button
            // 
            cancel_button.Location = new Point(150, 277);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(75, 23);
            cancel_button.TabIndex = 3;
            cancel_button.Text = "ביטול";
            cancel_button.UseVisualStyleBackColor = true;
            cancel_button.Click += OnCancelClicked;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(81, 368);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(75, 23);
            exit_button.TabIndex = 4;
            exit_button.Text = "יציאה";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += OnExitClicked;
            // 
            // entry_button
            // 
            entry_button.Location = new Point(277, 368);
            entry_button.Name = "entry_button";
            entry_button.Size = new Size(75, 23);
            entry_button.TabIndex = 5;
            entry_button.Text = "כניסה";
            entry_button.UseVisualStyleBackColor = true;
            entry_button.Click += OnEntryClicked;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 450);
            Controls.Add(entry_button);
            Controls.Add(exit_button);
            Controls.Add(cancel_button);
            Controls.Add(lastExit_label);
            Controls.Add(lastEntry_label);
            Controls.Add(tz_label);
            Name = "ClockForm";
            Text = "ClockForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tz_label;
        private Label lastEntry_label;
        private Label lastExit_label;
        private Button cancel_button;
        private Button exit_button;
        private Button entry_button;
    }
}