using System;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms.Kunder
{
    public partial class Rediger_kunde : Form
    {
        SQLHandler handler = new SQLHandler();
        public Rediger_kunde()
        {
            InitializeComponent();
        }

        //Henter data fra SQL og sætter det ind på labels og textbokse
        private void Rediger_kunde_Load(object sender, EventArgs e)
        {
            nu_kunde_navn.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Navn");
            nu_kunde_postnr.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Postnr");
            nu_kunde_bynavn.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Bynavn");
            nu_kunde_adresse.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Adresse");
            nu_kunde_email.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Email");
            nu_kunde_tlfnr.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Tlfnr");
            red_kunde_navn.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Navn");
            red_kunde_postnr.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Postnr");
            red_kunde_bynavn.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Bynavn");
            red_kunde_adresse.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Adresse");
            red_kunde_email.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Email");
            red_kunde_tlfnr.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Tlfnr");
        }

        //Opdaterer data på kunde
        private void red_kunde_Click(object sender, EventArgs e)
        {
            //Viser en ja / nej boks inden medarbejder bliver oprettet
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil redigere " + nu_kunde_navn.Text + "?", "Rediger " + nu_kunde_navn.Text + "?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.OpdaterKunde(Kunde.kundeNummer, red_kunde_navn.Text, red_kunde_postnr.Text, red_kunde_bynavn.Text, red_kunde_adresse.Text, red_kunde_email.Text, red_kunde_tlfnr.Text);
                Close();
            }
            
            
        }

        //Anullerer og lukker vinduet
        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
