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
    public partial class Opret_sag : Form
    {
        SQLHandler handler = new SQLHandler();
        public Opret_sag()
        {
            InitializeComponent();
        }

        private void opr_sag_Click(object sender, EventArgs e)
        {
            string fejl = "";

            if(sag_navn_txt.Text == "")
            {
                fejl += "Du skal indtaste et sagnavn.";

            }
            if(sag_esttimer_txt.Text == "")
            {
                fejl += "Du skal indtaste et estimeret antal timer.";
            }
            if(sag_kundeid.Text == "")
            {
                fejl += "Du skal vælge en kunde";
            }
            if(sag_medid.Text == "")
            {
                fejl += "Du skal vælge en advokat";
            }

            if (fejl == "")
            {
                //Viser en ja / nej boks inden medarbejder bliver oprettet
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil oprette " + sag_navn_txt.Text + "?", "Opret " + sag_navn_txt.Text + "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.OpretSag(sag_navn_txt.Text, Valg_kunde.valgKundeID, Valg_advokat.valgMedID, "'" + sag_startdato.Value.ToString("yyyy-MM-dd") + "'", sag_esttimer_txt.Text);
                }
            }
            else
            {
                MessageBox.Show(fejl);
            }
            
        }

        private void valg_kunde_Click(object sender, EventArgs e)
        {
            Form valgKunde = new Valg_kunde();
            valgKunde.FormClosed += valgKunde_FormClosed;
            valgKunde.Show();
        }

        private void valg_advokat_Click(object sender, EventArgs e)
        {
            Form valgAdvokat = new Valg_advokat();
            valgAdvokat.FormClosed += valgAdvokat_FormClosed;
            valgAdvokat.Show();
        }
        private void valgKunde_FormClosed(object sender, FormClosedEventArgs e)
        {
            sag_kunde_navn.Text = Valg_kunde.valgKundeNavn;
            sag_kundeid.Text = Valg_kunde.valgKundeID.ToString();
        }
        private void valgAdvokat_FormClosed(object sender, FormClosedEventArgs e)
        {
            sag_advokat_navn.Text = Valg_advokat.valgMedNavn;
            sag_medid.Text = Valg_advokat.valgMedID.ToString();
        }

        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
