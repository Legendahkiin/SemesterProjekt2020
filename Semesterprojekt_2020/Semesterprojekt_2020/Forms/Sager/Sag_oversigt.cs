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
    public partial class Sag_oversigt : Form
    {
        SQLHandler handler = new SQLHandler();
        public Sag_oversigt()
        {
            InitializeComponent();
        }

        private void Sag_oversigt_Load(object sender, EventArgs e)
        {
            string[] startDatoArray = handler.FyldSagOversigt(Sag.sagNummer, "StartDato").Split(' ');
            string[] slutDatoArray = handler.FyldSagOversigt(Sag.sagNummer, "SlutDato").Split(' ');

            sag_sagnavn.Text = handler.FyldSagOversigt(Sag.sagNummer, "SagNavn");
            sag_knavn.Text = handler.FyldSagOversigt(Sag.sagNummer, "KundeNavn");
            sag_tlf.Text = handler.FyldSagOversigt(Sag.sagNummer, "Tlfnr");
            sag_email.Text = handler.FyldSagOversigt(Sag.sagNummer, "Email");
            label9.Text = handler.FyldSagOversigt(Sag.sagNummer, "Postnr");
            sag_bynavn.Text = handler.FyldSagOversigt(Sag.sagNummer, "Bynavn");
            sag_adresse.Text = handler.FyldSagOversigt(Sag.sagNummer, "Adresse");
            sag_esttimer.Text = handler.FyldSagOversigt(Sag.sagNummer, "EstTimer");
            sag_startdato.Text = startDatoArray[0];
            sag_slutdato.Text = slutDatoArray[0];

            sag_timeoversigt.DataSource = handler.FyldSagTimeOversigt(Sag.sagNummer);

        }

        private void tilfoj_timereg_Click(object sender, EventArgs e)
        {
            Form f = new Tilfoj_time();
            f.Show();
        }
    }
}
