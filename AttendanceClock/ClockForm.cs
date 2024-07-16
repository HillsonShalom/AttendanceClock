using AttendanceClock.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceClock
{
    public partial class ClockForm : Form
    {
        private string _currentID;

        public ClockForm(string id, DateTime lastEntry, DateTime lastExit)
        {
            InitializeComponent();
            _currentID = id;
            idLabel.Text = id;
            this.lastEntry.Text = lastEntry.ToString();
            this.lastExit.Text = lastExit.ToString();
            if (lastEntry > lastExit)
            {
                entryButton.Visible = false;
            }
            else
            {
                exitButton.Visible = false;
            }


        }
        public ClockForm(string id)
        {
            InitializeComponent();
            _currentID = id;
            idLabel.Text = id;
        }

        public ClockForm()
        {
            InitializeComponent();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm(idLabel.Text);
            Thread moveBack = new Thread(() =>
            {
                Application.Run(lf);
            });
            moveBack.SetApartmentState(ApartmentState.STA);
            moveBack.Start();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SQLservice ss = new SQLservice($"UPDATE EmployeeAttendance SET ExitTime = GETDATE() WHERE EntryTime = ( SELECT MAX(EntryTime) FROM EmployeeAttendance ea JOIN Employees e ON ea.EmployeeCode = e.ID WHERE e.EmployeeNat = '{idLabel.Text}');", "insert_date");
            refreshTimes();
            entryButton.Visible = true;
            exitButton.Visible = false;
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            SQLservice ss = new SQLservice($"INSERT INTO EmployeeAttendance (EmployeeCode, EntryTime) SELECT MAX(EmployeeCode), GETDATE() FROM EmployeeAttendance ea JOIN Employees e ON ea.EmployeeCode = e.ID WHERE EmployeeNat = '{idLabel.Text}'", "insert_date");
            refreshTimes();
            exitButton.Visible = true;
            entryButton.Visible = false;
        }

        private void refreshTimes()
        {
            SQLservice sqlc = new SQLservice($"SELECT E.EmployeeNat, MAX(L.EntryTime) AS LastEntry, MAX(L.ExitTime) AS LastExit FROM Employees E JOIN Passwords P ON E.ID = P.EmployeeID JOIN EmployeeAttendance L ON E.ID = L.EmployeeCode WHERE E.EmployeeNat = '{idLabel.Text}' GROUP BY E.EmployeeNat;", "get_last_dates");
            DateTime entry = sqlc.lastEntry;
            DateTime exit = sqlc.lastExit;
            lastEntry.Text = entry.ToString();
            lastExit.Text = exit.ToString();
        }

        private void moveToHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowHistory sh = new ShowHistory(idLabel.Text);
            Thread moveToHis = new Thread(() =>
            {
                Application.Run(sh);
            });
            moveToHis.SetApartmentState(ApartmentState.STA);
            moveToHis.Start();
            this.Close();
        }
    }
}
