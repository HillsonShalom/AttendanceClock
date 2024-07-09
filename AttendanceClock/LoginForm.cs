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

        private void moveToClock_Click(object sender, EventArgs e)
        {
            ClockForm cf = new ClockForm(idBox.Text);
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
    }
}
