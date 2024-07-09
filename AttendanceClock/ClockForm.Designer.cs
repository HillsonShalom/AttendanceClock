namespace AttendanceClock
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
            label1 = new Label();
            idLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            backLink = new LinkLabel();
            entryButton = new Button();
            exitButton = new Button();
            lastEntry = new Label();
            lastExit = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(71, 89);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 0;
            label1.Text = "זהות עובד:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            idLabel.Location = new Point(220, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(171, 41);
            idLabel.TabIndex = 1;
            idLabel.Text = "212215982";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.Location = new Point(71, 174);
            label2.Name = "label2";
            label2.Size = new Size(208, 30);
            label2.TabIndex = 2;
            label2.Text = "תאריך כניסה אחרון";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.Location = new Point(72, 302);
            label3.Name = "label3";
            label3.Size = new Size(207, 30);
            label3.TabIndex = 3;
            label3.Text = "תאריך יציאה אחרון";
            // 
            // backLink
            // 
            backLink.AutoSize = true;
            backLink.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            backLink.Location = new Point(220, 458);
            backLink.Name = "backLink";
            backLink.Size = new Size(69, 30);
            backLink.TabIndex = 15;
            backLink.TabStop = true;
            backLink.Text = "ביטול";
            backLink.LinkClicked += backLink_LinkClicked;
            // 
            // entryButton
            // 
            entryButton.BackColor = Color.Green;
            entryButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            entryButton.ForeColor = SystemColors.InactiveCaption;
            entryButton.Location = new Point(53, 532);
            entryButton.Name = "entryButton";
            entryButton.Size = new Size(147, 88);
            entryButton.TabIndex = 16;
            entryButton.Text = "כניסה";
            entryButton.UseVisualStyleBackColor = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Purple;
            exitButton.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            exitButton.ForeColor = SystemColors.InactiveCaption;
            exitButton.Location = new Point(281, 532);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(147, 88);
            exitButton.TabIndex = 17;
            exitButton.Text = "יציאה";
            exitButton.UseVisualStyleBackColor = false;
            // 
            // lastEntry
            // 
            lastEntry.AutoSize = true;
            lastEntry.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lastEntry.ForeColor = Color.Green;
            lastEntry.Location = new Point(151, 223);
            lastEntry.Name = "lastEntry";
            lastEntry.Size = new Size(210, 46);
            lastEntry.TabIndex = 18;
            lastEntry.Text = "11/07/2014";
            // 
            // lastExit
            // 
            lastExit.AutoSize = true;
            lastExit.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lastExit.ForeColor = Color.Purple;
            lastExit.Location = new Point(151, 352);
            lastExit.Name = "lastExit";
            lastExit.Size = new Size(210, 46);
            lastExit.TabIndex = 19;
            lastExit.Text = "11/07/2014";
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(482, 653);
            Controls.Add(lastExit);
            Controls.Add(lastEntry);
            Controls.Add(exitButton);
            Controls.Add(entryButton);
            Controls.Add(backLink);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(idLabel);
            Controls.Add(label1);
            Name = "ClockForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "שעון נוכחות - מסך ראשי";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label idLabel;
        private Label label2;
        private Label label3;
        private LinkLabel backLink;
        private Button entryButton;
        private Button exitButton;
        private Label lastEntry;
        private Label lastExit;
    }
}