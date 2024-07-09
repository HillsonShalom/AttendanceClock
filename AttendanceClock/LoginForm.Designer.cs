namespace AttendanceClock
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
            label1 = new Label();
            moveToClock = new Button();
            idBox = new TextBox();
            label2 = new Label();
            passwordBox = new TextBox();
            moveToPassChange = new Button();
            idInvalid = new Label();
            passWrong = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16F, FontStyle.Bold);
            label1.Location = new Point(91, 91);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "תעודת זהות";
            // 
            // moveToClock
            // 
            moveToClock.BackColor = Color.Green;
            moveToClock.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            moveToClock.ForeColor = SystemColors.InactiveCaption;
            moveToClock.Location = new Point(141, 417);
            moveToClock.Name = "moveToClock";
            moveToClock.Size = new Size(220, 63);
            moveToClock.TabIndex = 1;
            moveToClock.Text = "כניסה";
            moveToClock.UseVisualStyleBackColor = false;
            moveToClock.Click += moveToClock_Click;
            // 
            // idBox
            // 
            idBox.Font = new Font("Segoe UI", 16F);
            idBox.Location = new Point(91, 141);
            idBox.Name = "idBox";
            idBox.Size = new Size(270, 43);
            idBox.TabIndex = 2;
            idBox.TextChanged += idChange;
            idBox.KeyPress += idTyping;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F, FontStyle.Bold);
            label2.Location = new Point(91, 208);
            label2.Name = "label2";
            label2.Size = new Size(90, 32);
            label2.TabIndex = 3;
            label2.Text = "סיסמה";
            // 
            // passwordBox
            // 
            passwordBox.Font = new Font("Segoe UI", 16F);
            passwordBox.Location = new Point(91, 261);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(270, 43);
            passwordBox.TabIndex = 4;
            // 
            // moveToPassChange
            // 
            moveToPassChange.BackColor = Color.Purple;
            moveToPassChange.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            moveToPassChange.ForeColor = SystemColors.InactiveCaption;
            moveToPassChange.Location = new Point(141, 508);
            moveToPassChange.Name = "moveToPassChange";
            moveToPassChange.Size = new Size(220, 63);
            moveToPassChange.TabIndex = 5;
            moveToPassChange.Text = "החלפת סיסמה";
            moveToPassChange.UseVisualStyleBackColor = false;
            moveToPassChange.Click += moveToPassChange_Click;
            // 
            // idInvalid
            // 
            idInvalid.AutoSize = true;
            idInvalid.ForeColor = Color.FromArgb(192, 0, 0);
            idInvalid.Location = new Point(247, 118);
            idInvalid.Name = "idInvalid";
            idInvalid.Size = new Size(121, 20);
            idInvalid.TabIndex = 6;
            idInvalid.Text = "המספר אינו תקין!";
            idInvalid.Visible = false;
            // 
            // passWrong
            // 
            passWrong.AutoSize = true;
            passWrong.ForeColor = Color.FromArgb(192, 0, 0);
            passWrong.Location = new Point(263, 238);
            passWrong.Name = "passWrong";
            passWrong.Size = new Size(98, 20);
            passWrong.TabIndex = 7;
            passWrong.Text = "סיסמה שגויה!";
            passWrong.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(482, 653);
            Controls.Add(passWrong);
            Controls.Add(idInvalid);
            Controls.Add(moveToPassChange);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(idBox);
            Controls.Add(moveToClock);
            Controls.Add(label1);
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "שעון נוכחות - מסך התחברות";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button moveToClock;
        private TextBox idBox;
        private Label label2;
        private TextBox passwordBox;
        private Button moveToPassChange;
        private Label idInvalid;
        private Label passWrong;
    }
}