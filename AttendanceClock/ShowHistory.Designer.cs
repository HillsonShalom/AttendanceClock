namespace AttendanceClock
{
    partial class ShowHistory
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
            fullName = new Label();
            idNumber = new Label();
            linkLabel1 = new LinkLabel();
            historyTable = new DataGridView();
            entryC = new DataGridViewTextBoxColumn();
            exitC = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)historyTable).BeginInit();
            SuspendLayout();
            // 
            // fullName
            // 
            fullName.AutoSize = true;
            fullName.Font = new Font("Segoe UI", 12F);
            fullName.Location = new Point(12, 22);
            fullName.Name = "fullName";
            fullName.Size = new Size(99, 28);
            fullName.TabIndex = 0;
            fullName.Text = "שם העובד";
            // 
            // idNumber
            // 
            idNumber.AutoSize = true;
            idNumber.Font = new Font("Segoe UI", 12F);
            idNumber.Location = new Point(12, 69);
            idNumber.Name = "idNumber";
            idNumber.Size = new Size(115, 28);
            idNumber.TabIndex = 1;
            idNumber.Text = "תעודת זהות";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(374, 607);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 28);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ביטול";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // historyTable
            // 
            historyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyTable.Columns.AddRange(new DataGridViewColumn[] { entryC, exitC });
            historyTable.Location = new Point(12, 132);
            historyTable.Name = "historyTable";
            historyTable.RowHeadersWidth = 51;
            historyTable.Size = new Size(458, 452);
            historyTable.TabIndex = 3;
            // 
            // entryC
            // 
            entryC.HeaderText = "כניסה";
            entryC.MinimumWidth = 6;
            entryC.Name = "entryC";
            entryC.Width = 125;
            // 
            // exitC
            // 
            exitC.HeaderText = "יציאה";
            exitC.MinimumWidth = 6;
            exitC.Name = "exitC";
            exitC.Width = 125;
            // 
            // ShowHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(482, 653);
            Controls.Add(historyTable);
            Controls.Add(linkLabel1);
            Controls.Add(idNumber);
            Controls.Add(fullName);
            Name = "ShowHistory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "היסטוריה";
            ((System.ComponentModel.ISupportInitialize)historyTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fullName;
        private Label idNumber;
        private LinkLabel linkLabel1;
        private DataGridView historyTable;
        private DataGridViewTextBoxColumn entryC;
        private DataGridViewTextBoxColumn exitC;
    }
}