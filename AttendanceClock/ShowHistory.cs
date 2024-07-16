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
    public partial class ShowHistory : Form
    {
        public ShowHistory()
        {
            InitializeComponent();
        }

        public ShowHistory(string tz)
        {
            InitializeComponent();
            idNumber.Text = tz;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClockForm cf = new ClockForm(idNumber.Text);
            Thread moveBack = new Thread(() =>
            {
                Application.Run(cf);
            });
            moveBack.SetApartmentState(ApartmentState.STA);
            moveBack.Start();
            this.Close();
        }
    }
}
