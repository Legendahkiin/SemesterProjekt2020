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
    public partial class Rediger_medarbejder : Form
    {
        SQLHandler handler = new SQLHandler();
        public Rediger_medarbejder()
        {
            InitializeComponent();
        }

        private void Rediger_medarbejder_Load(object sender, EventArgs e)
        {
            handler.FyldStillingComoBox(red_StillingComboBox);
            nu_med_navn.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Navn");
            nu_med_adr.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Adresse");
            nu_med_postnr.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Postnr");
            nu_med_bynavn.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Bynavn");
            nu_med_email.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Email");
            nu_med_tlf.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Tlfnr");
            nu_med_stilling.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "StillingNavn");
            red_med_navn.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Navn");
            red_med_adr.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Adresse");
            red_med_postnr.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Postnr");
            red_med_bynavn.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Bynavn");
            red_med_email.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Email");
            red_med_tlf.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Tlfnr");
            red_StillingComboBox.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "StillingNavn");

        }

        private void red_medarbejder_Click(object sender, EventArgs e)
        {
            //Viser en ja/nej boks inden kunde bliver slettet
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil redigere " + nu_med_navn.Text + "?", "Rediger?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.OpdaterMedarbejder(Medarbejdere.medarbejderNummer, red_med_navn.Text, red_med_adr.Text, red_med_postnr.Text, red_med_bynavn.Text, red_med_email.Text, red_med_tlf.Text, Convert.ToInt32(red_StillingComboBox.SelectedValue));
                Close();
            }
        }

        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
