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
    public partial class Rediger_sag : Form
    {
        SQLHandler handler = new SQLHandler();
        public Rediger_sag()
        {
            InitializeComponent();
        }

        private void Rediger_sag_Load(object sender, EventArgs e)
        {
            red_sag_navn_txt.Text = handler.FyldRedSag(Sag.sagNummer, "SagNavn");
            red_sag_esttimer_txt.Text = handler.FyldRedSag(Sag.sagNummer, "EstTimer");
            red_sag_startdato.Text = handler.FyldRedSag(Sag.sagNummer, "StartDato");
            red_sag_kundeid.Text = handler.FyldRedSag(Sag.sagNummer, "KundeID");
            red_sag_kunde_navn.Text = handler.FyldRedSag(Sag.sagNummer, "KundeNavn");
            red_sag_medid.Text = handler.FyldRedSag(Sag.sagNummer, "MedID");
            red_sag_advokat_navn.Text = handler.FyldRedSag(Sag.sagNummer, "MedarbejderNavn");
        }

        private void red_valg_kunde_Click(object sender, EventArgs e)
        {
            Form valgKunde = new Valg_kunde();
            valgKunde.FormClosed += valgKunde_FormClosed;
            valgKunde.Show();
        }

        private void red_valg_advokat_Click(object sender, EventArgs e)
        {
            Form valgAdvokat = new Valg_advokat();
            valgAdvokat.FormClosed += valgAdvokat_FormClosed;
            valgAdvokat.Show();
        }

        private void valgKunde_FormClosed(object sender, FormClosedEventArgs e)
        {
            red_sag_kunde_navn.Text = Valg_kunde.valgKundeNavn;
            red_sag_kundeid.Text = Valg_kunde.valgKundeID.ToString();
        }
        private void valgAdvokat_FormClosed(object sender, FormClosedEventArgs e)
        {
            red_sag_advokat_navn.Text = Valg_advokat.valgMedNavn;
            red_sag_medid.Text = Valg_advokat.valgMedID.ToString();
        }

        private void red_sag_annuller_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void red_sag_Click(object sender, EventArgs e)
        {
            //Viser en ja/nej boks inden kunde bliver slettet
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil redigere " + red_sag_navn_txt.Text + "?", "Rediger?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.OpdaterSag(Sag.sagNummer, red_sag_navn_txt.Text, red_sag_esttimer_txt.Text, "'" + red_sag_startdato.Value.ToString("yyyy-MM-dd") + "'", red_sag_kundeid.Text, red_sag_medid.Text);
                Close();
            }
        }
    }
}

