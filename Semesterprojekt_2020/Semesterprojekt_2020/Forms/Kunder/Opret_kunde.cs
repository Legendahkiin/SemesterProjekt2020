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

        string besked = "";
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
                besked += "Du skal indtaste et navn.";
            }
            if (kunde_postnr_txt.Text != "")
            {
            }
            else
            {
                besked += "Du skal indtaste en postnummer.";
            }
            if (kunde_bynavn_txt.Text != "")
            {
            }
            else
            {
                besked += "Du skal indtaste et bynavn";
            }
            if (kunde_adr_txt.Text != "")
            {
            }
            else
            {
                besked += "Du skal indtaste et adresse.";
            }
            if (kunde_email_txt.Text != "")
            {
            }
            else
            {
                besked += "Du skal indtaste en e-mail";
            }
            if (kunde_tlf_txt.Text != "")
            {
            }
            else
            {
                besked += "Du skal indtaste et telefonnummer";
            }

            if(besked == "")
            {
                SQLHandler handler = new SQLHandler();
                handler.OpretKunde(kunde_navn_txt.Text, kunde_postnr_txt.Text, kunde_bynavn_txt.Text, kunde_adr_txt.Text, kunde_email_txt.Text, kunde_tlf_txt.Text);
            }
        }

    }
}
