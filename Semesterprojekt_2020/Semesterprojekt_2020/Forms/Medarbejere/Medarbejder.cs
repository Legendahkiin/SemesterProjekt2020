using Semesterprojekt_2020.Forms.Medarbejere;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020.Forms
{
    public partial class Medarbejdere : Form
    {
        public static int medarbejderNummer = 1;
        public static string medarbejderNavn = "";
        SQLHandler handler = new SQLHandler();
        public Medarbejdere()
        {
            InitializeComponent();
        }

        private void Medarbejdere_Load(object sender, EventArgs e)
        {
            medarbejder_oversigt.DataSource = handler.FyldDataGridView("dbo.Medarbejder");
        }

        private void opr_medarbejder_Click(object sender, EventArgs e)
        {
            Form f = new Opret_medarbejder();
            f.Show();
        }

        private void red_medarbejder_Click(object sender, EventArgs e)
        {
            Form f = new Rediger_medarbejder();
            f.Show();
        }

        private void slet_medarbejder_Click(object sender, EventArgs e)
        {
            //Viser en ja/nej boks inden kunde bliver slettet
            DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette " + medarbejderNavn + "?", "Slet?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                handler.SletMedarbejder(medarbejderNummer);
                MessageBox.Show("Medarbejder er slettet");
            }
            medarbejder_oversigt.DataSource = handler.FyldDataGridView("dbo.Medarbejder");
        }

        private void vis_timereg_Click(object sender, EventArgs e)
        {
            Form f = new Timeregistrereing();
            f.Show();
        }

        private void vis_uddannelse_Click(object sender, EventArgs e)
        {
            Form f = new Uddannelse();
            f.Show();
        }

        private void medarbejder_oversigt_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in medarbejder_oversigt.SelectedRows)
            {
                medarbejderNummer = (int)row.Cells["MedID"].Value;
                medarbejderNavn = (string)row.Cells["Navn"].Value;
            }

        }
    }
}
