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
    }
}
