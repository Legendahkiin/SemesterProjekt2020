using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms.Kunder
{
    public partial class Opret_kunde : Form
    {

        string fejl = "";
        public Opret_kunde()
        {
            InitializeComponent();
        }

        private void opr_kunde_Click(object sender, EventArgs e)
        {

            if (kunde_navn_txt.Text != "")
            {

            }
            else
            {
                fejl += "Du skal indtaste et navn.\r\n";
            }
            if (kunde_postnr_txt.Text != "")
            {
            }
            else
            {
                fejl += "Du skal indtaste en postnummer.\r\n";
            }
            if (kunde_bynavn_txt.Text != "")
            {
            }
            else
            {
                fejl += "Du skal indtaste et bynavn.\r\n";
            }
            if (kunde_adr_txt.Text != "")
            {
            }
            else
            {
                fejl += "Du skal indtaste et adresse.\r\n";
            }
            if (kunde_email_txt.Text != "")
            {
            }
            else
            {
                fejl += "Du skal indtaste en e-mail. \r\n";
            }
            if (kunde_tlf_txt.Text != "")
            {
            }
            else
            {
                fejl += "Du skal indtaste et telefonnummer. \r\n";
            }

            if(fejl == "")
            {
                //Viser en ja / nej boks inden medarbejder bliver oprettet
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil oprette " + kunde_navn_txt.Text + "?", "Opret " + kunde_navn_txt.Text + "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SQLHandler handler = new SQLHandler();
                    handler.OpretKunde(kunde_navn_txt.Text, kunde_postnr_txt.Text, kunde_bynavn_txt.Text, kunde_adr_txt.Text, kunde_email_txt.Text, kunde_tlf_txt.Text); 
                }
               
            }
            else
            {
                MessageBox.Show(fejl);
            }
        }

        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
