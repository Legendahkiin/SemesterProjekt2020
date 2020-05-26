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
    public partial class Rediger_kunde : Form
    {
        int KundeNummer = Kunde.KundeNummer;
        public Rediger_kunde()
        {
            InitializeComponent();
        }

        //Henter data fra SQL og sætter det ind på labels og textbokse
        private void Rediger_kunde_Load(object sender, EventArgs e)
        {
            SQLHandler handler = new SQLHandler();
            nu_kunde_navn.Text = handler.FyldRedKunde(KundeNummer, "Navn");
            nu_kunde_postnr.Text = handler.FyldRedKunde(KundeNummer, "Postnr");
            nu_kunde_bynavn.Text = handler.FyldRedKunde(KundeNummer, "Bynavn");
            nu_kunde_adresse.Text = handler.FyldRedKunde(KundeNummer, "Adresse");
            nu_kunde_email.Text = handler.FyldRedKunde(KundeNummer, "Email");
            nu_kunde_tlfnr.Text = handler.FyldRedKunde(KundeNummer, "Tlfnr");
            red_kunde_navn.Text = handler.FyldRedKunde(KundeNummer, "Navn");
            red_kunde_postnr.Text = handler.FyldRedKunde(KundeNummer, "Postnr");
            red_kunde_bynavn.Text = handler.FyldRedKunde(KundeNummer, "Bynavn");
            red_kunde_adresse.Text = handler.FyldRedKunde(KundeNummer, "Adresse");
            red_kunde_email.Text = handler.FyldRedKunde(KundeNummer, "Email");
            red_kunde_tlfnr.Text = handler.FyldRedKunde(KundeNummer, "Tlfnr");
        }

        //Opdaterer data på kunde
        private void red_kunde_Click(object sender, EventArgs e)
        {
            SQLHandler handler = new SQLHandler();
            handler.OpdaterKunde(KundeNummer, red_kunde_navn.Text, red_kunde_postnr.Text, red_kunde_bynavn.Text, red_kunde_adresse.Text, red_kunde_email.Text, red_kunde_tlfnr.Text);
            
        }

        //Anullerer og lukker vinduet
        private void Annuller_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
