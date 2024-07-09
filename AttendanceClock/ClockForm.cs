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
    }
}
