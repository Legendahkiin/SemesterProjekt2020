using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms.Medarbejere
{
    public partial class Opret_medarbejder : Form
    {
        SQLHandler handler = new SQLHandler();
        public Opret_medarbejder()
        {
            InitializeComponent();
        }

        private void opr_med_Click(object sender, EventArgs e)
        {
            string fejl = "";
            if (opr_med_navn.Text == "")
            {
                fejl += "Du skal indtaste et navn. \r\n";
            }

            if (opr_med_postnr.Text == "")
            {
                fejl += "Du skal indtaste et postnummer. \r\n";
            }

            if (opr_med_postnr.Text.Length > 4)
            {
                fejl += "Ugyldigt postnummer. \r\n";
            }

            if (opr_med_bynavn.Text == "")
            {
                fejl += "Du skal indtaste et bynavn. \r\n";
            }

            if (opr_med_adr.Text == "")
            {
                fejl += "Du skal indtaste et bynavn. \r\n";
            }

            if (opr_med_email.Text == "")
            {
                fejl += "Du skal indtaste en email. \r\n";
            }

            if (opr_med_tlf.Text == "")
            {
                fejl += "Du skal indtaste et telefonnummer. \r\n";
            }

            if (fejl == "")
            {
                //Viser en ja / nej boks inden medarbejder bliver oprettet
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil oprette " + opr_med_navn.Text + "?", "Opret " + opr_med_navn.Text + "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.OpretMedarbejder(opr_med_navn.Text, opr_med_adr.Text, opr_med_postnr.Text, opr_med_bynavn.Text, opr_med_email.Text, opr_med_tlf.Text, Convert.ToInt32(stillingComboBox.SelectedValue));
                    handler.TilfojUddannelse("'" + opr_med_navn.Text + "'", "'" + opr_med_tlf.Text + "'");

                }
            }
            else
            {
                MessageBox.Show(fejl);
            }

        }

        private void Opret_medarbejder_Load(object sender, EventArgs e)
        {
            handler.FyldStillingComoBox(stillingComboBox);
        }

        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
