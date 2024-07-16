using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceClock.service;

namespace AttendanceClock
{
    public partial class LoginForm : Form
    {
        private string _currentID;
        public LoginForm(string id)
        {
            InitializeComponent();
            _currentID = id;
            idBox.Text = id;
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// First of all the function checks if the fields are not empty
        /// then, it send a query to recieve the data
        /// if recieved, it allowes the used move 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moveToClock_Click(object sender, EventArgs e)
        {
            if (fieldsFull())
            {
                MessageBox.Show("השלם את כל הפרטים", "שגיאה!");
                return;
            }
            SQLservice sqlc = new SQLservice($"SELECT E.EmployeeNat, MAX(L.EntryTime) AS LastEntry, MAX(L.ExitTime) AS LastExit FROM Employees E JOIN Passwords P ON E.ID = P.EmployeeID JOIN EmployeeAttendance L ON E.ID = L.EmployeeCode WHERE P.EmployeePassword = HASHBYTES('SHA2_256', '{passwordBox.Text}') and E.EmployeeNat = '{idBox.Text}' GROUP BY E.EmployeeNat;", "get_last_dates");
            string table = sqlc.res;
            DateTime entry = sqlc.lastEntry;
            DateTime exit = sqlc.lastExit;
            if (table == null)
            {
                MessageBox.Show("סיסמה שגויה!", "שגיאה!");
                return;
            }
            ClockForm cf = new ClockForm(idBox.Text, entry, exit);
            Thread moveToClock = new Thread(() =>
            {
                Application.Run(cf);
            });
            moveToClock.SetApartmentState(ApartmentState.STA);
            moveToClock.Start();
            this.Close();
        }

        private void moveToPassChange_Click(object sender, EventArgs e)
        {
            PasswordChange pc = new PasswordChange(idBox.Text);
            Thread moveToPass = new Thread(() =>
            {
                Application.Run(pc);
            });
            moveToPass.SetApartmentState(ApartmentState.STA);
            moveToPass.Start();
            this.Close();
        }

        private void idTyping(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void idChange(object sender, EventArgs e)
        {
            if (idBox.Text.Length != 9 && idBox.Text.Length != 0)
            {
                idInvalid.Visible = true;
            } else
            {
                idInvalid.Visible = false;
            }
        }

        private bool fieldsFull()
        {
            return (idBox.Text == "" || idInvalid.Visible == true || passwordBox.Text == "");
        }
        
    }
}
