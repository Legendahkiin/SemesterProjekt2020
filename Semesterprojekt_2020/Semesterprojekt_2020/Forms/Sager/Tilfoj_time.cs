using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms.Sager
{
    public partial class Tilfoj_time : Form
    {
        SQLHandler handler = new SQLHandler();
        public Tilfoj_time()
        {
            InitializeComponent();
        }

        private void time_valg_advokat_Click(object sender, EventArgs e)
        {
            Form valgAdvokat = new Valg_advokat();
            valgAdvokat.FormClosed += valgAdvokat_FormClosed;
            valgAdvokat.Show();
        }

        private void valgAdvokat_FormClosed(object sender, FormClosedEventArgs e)
        {
            time_advokat_navn.Text = Valg_advokat.valgMedNavn;
            time_advokatid.Text = Valg_advokat.valgMedID.ToString();
        }

        private void time_opr_Click(object sender, EventArgs e)
        {
            var timeregDato = DateTime.Now.Date;
            handler.OpretTimeReg(Convert.ToInt32(time_advokatid.Text), Sag.sagNummer, Convert.ToInt32(time_antaltimer.Text), Convert.ToInt32(time_antalkm.Text), time_ydelse.SelectedItem.ToString(), "'" + timeregDato.ToString("yyyy-MM-dd") + "'");
        }
    }
}
