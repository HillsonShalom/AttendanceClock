using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendanceClock.service;

namespace AttendanceClock
{
    public partial class PasswordChange : Form
    {
        private string _currentID;
        public PasswordChange(string id)
        {
            InitializeComponent();
            _currentID = id;
            idBox.Text = id;
        }

        public PasswordChange()
        {
            InitializeComponent();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm lf = new LoginForm(idBox.Text);
            Thread moveBack = new Thread(() =>
            {
                Application.Run(lf);
            });
            moveBack.SetApartmentState(ApartmentState.STA);
            moveBack.Start();
            this.Close();
        }

        private void saveAndMove_Click(object sender, EventArgs e)
        {
            if (newPassword1.Text != newPassword2.Text)
            {
                MessageBox.Show("הסיסמאות אינן שוות!", "שגיאה!");
                return;
            }
            if (newPassword1.Text == "" || newPassword1.Text == null) { MessageBox.Show("הכנס סיסמה חדשה"); return; }

            SQLservice sqlUpdate = new SQLservice($"UPDATE Passwords SET EmployeePassword = HASHBYTES('SHA2_256', '{newPassword1.Text}') where EmployeePassword = HASHBYTES('SHA2_256', '{passwordBox.Text}')", "change_password");
            MessageBox.Show(sqlUpdate.res);
        }

        private void newEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (idBox.Text.Length != 9 || string.IsNullOrEmpty(newPassword1.Text) || string.IsNullOrEmpty(newPassword2.Text)){
                MessageBox.Show("הכנס מספר תעודת זהות וסיסמה");
                return;
            }
            
        }
    }
}
