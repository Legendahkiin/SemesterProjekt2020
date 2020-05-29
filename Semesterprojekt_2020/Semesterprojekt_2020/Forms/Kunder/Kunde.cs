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
    public partial class Kunde : Form
    {
        SQLHandler handler = new SQLHandler();
        public static int kundeNummer = 1;
        string kundeNavn = "";
        public Kunde()
        {
            InitializeComponent();
        }

        private void Kunder_Load(object sender, EventArgs e)
        {
            kunde_oversigt.DataSource = handler.FyldDataGridView("dbo.Kunde");
        }

        private void opr_kunde_Click(object sender, EventArgs e)
        {
            Form f = new Opret_kunde();
            f.Show();
        }

        private void red_kunde_Click(object sender, EventArgs e)
        {
            Form f = new Rediger_kunde();
            f.FormClosed += f_FormClosed;
            f.Show();
        }

        //Opdaterer oversigten når kunden er redigeret 
        private void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            kunde_oversigt.DataSource = handler.FyldDataGridView("dbo.Kunde");
        }
        private void kunde_oversigt_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in kunde_oversigt.SelectedRows)
            {
                kundeNummer = (int)row.Cells["KundeID"].Value;
                kundeNavn = (string)row.Cells["Navn"].Value;
            }
        }

        //Slet kunde ved klik
        private void slet_kunde_Click(object sender, EventArgs e)
        {
            {
                //Viser en ja / nej boks inden medarbejder bliver oprettet
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette " + kundeNavn + "?", "Opret " + kundeNavn + "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.SletMedarbejder(kundeNummer);
                    MessageBox.Show(kundeNavn + " er blevet slettet");
                }
            }
        }

        private void vis_kunde_sager_Click(object sender, EventArgs e)
        {
            Form f = new Kunde_sager();
            f.Show();
        }
    }
}
