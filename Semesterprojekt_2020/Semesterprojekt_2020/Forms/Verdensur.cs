using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms
{
    public partial class Verdensur : Form
    {
        public Verdensur()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private static TimeZoneInfo east = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard time");
        private void Timer_Tick(object sender, EventArgs e)
        {

            DateTime datetime_eastern = DateTime.Now; //TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow,east);

            Lbltime.Text = datetime_eastern.ToString("HH:mm");
            Lblsecond.Text = datetime_eastern.ToString("ss");
            LblDate.Text = datetime_eastern.ToString("MMMM dd, yyyy");
            LblDay.Text = datetime_eastern.ToString("dddd");

            DateTime sanFranciscoDateTime = datetime_eastern;
            sanFranciscoDateTime = sanFranciscoDateTime.AddHours(-9);
            lblSanFranciscoTime.Text = sanFranciscoDateTime.ToString("HH:mm");


        }

        private void Verdensur_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
