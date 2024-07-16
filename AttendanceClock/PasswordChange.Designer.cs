namespace AttendanceClock
{
    partial class PasswordChange
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
            passwordBox = new TextBox();
            idBox = new TextBox();
            newPassword1 = new TextBox();
            newPassword2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            saveAndMove = new Button();
            backLink = new LinkLabel();
            newEmp = new LinkLabel();
            SuspendLayout();
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.FromArgb(255, 192, 255);
            passwordBox.Font = new Font("Segoe UI", 16F);
            passwordBox.Location = new Point(188, 167);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(270, 43);
            passwordBox.TabIndex = 5;
            // 
            // idBox
            // 
            idBox.BackColor = Color.FromArgb(255, 192, 255);
            idBox.Font = new Font("Segoe UI", 16F);
            idBox.Location = new Point(188, 91);
            idBox.Name = "idBox";
            idBox.Size = new Size(270, 43);
            idBox.TabIndex = 6;
            // 
            // newPassword1
            // 
            newPassword1.BackColor = Color.FromArgb(192, 255, 192);
            newPassword1.Font = new Font("Segoe UI", 16F);
            newPassword1.Location = new Point(188, 347);
            newPassword1.Name = "newPassword1";
            newPassword1.Size = new Size(270, 43);
            newPassword1.TabIndex = 7;
            // 
            // newPassword2
            // 
            newPassword2.BackColor = Color.FromArgb(192, 255, 192);
            newPassword2.Font = new Font("Segoe UI", 16F);
            newPassword2.Location = new Point(188, 422);
            newPassword2.Name = "newPassword2";
            newPassword2.Size = new Size(270, 43);
            newPassword2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(53, 100);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 9;
            label1.Text = "תעודת זהות";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(45, 176);
            label2.Name = "label2";
            label2.Size = new Size(137, 30);
            label2.TabIndex = 10;
            label2.Text = "סיסמה ישנה";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(34, 356);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 11;
            label3.Text = "סיסמה חדשה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.Location = new Point(33, 431);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 12;
            label4.Text = "אישור סיסמה";
            // 
            // saveAndMove
            // 
            saveAndMove.BackColor = Color.Purple;
            saveAndMove.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            saveAndMove.ForeColor = SystemColors.InactiveCaption;
            saveAndMove.Location = new Point(208, 519);
            saveAndMove.Name = "saveAndMove";
            saveAndMove.Size = new Size(220, 63);
            saveAndMove.TabIndex = 13;
            saveAndMove.Text = "שנה";
            saveAndMove.UseVisualStyleBackColor = false;
            saveAndMove.Click += saveAndMove_Click;
            // 
            // backLink
            // 
            backLink.AutoSize = true;
            backLink.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            backLink.Location = new Point(84, 536);
            backLink.Name = "backLink";
            backLink.Size = new Size(69, 30);
            backLink.TabIndex = 14;
            backLink.TabStop = true;
            backLink.Text = "ביטול";
            backLink.LinkClicked += backLink_LinkClicked;
            // 
            // newEmp
            // 
            newEmp.AutoSize = true;
            newEmp.Font = new Font("Segoe UI", 14F);
            newEmp.Location = new Point(257, 597);
            newEmp.Name = "newEmp";
            newEmp.Size = new Size(115, 32);
            newEmp.TabIndex = 15;
            newEmp.TabStop = true;
            newEmp.Text = "עובד חדש";
            newEmp.LinkClicked += newEmp_LinkClicked;
            // 
            // PasswordChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(482, 653);
            Controls.Add(newEmp);
            Controls.Add(backLink);
            Controls.Add(saveAndMove);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newPassword2);
            Controls.Add(newPassword1);
            Controls.Add(idBox);
            Controls.Add(passwordBox);
            Name = "PasswordChange";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "שעון נוכחות - החלפת סיסמה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordBox;
        private TextBox idBox;
        private TextBox newPassword1;
        private TextBox newPassword2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button saveAndMove;
        private LinkLabel backLink;
        private LinkLabel newEmp;
    }
}