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
    public partial class Sag : Form
    {
        public static int sagNummer = 1;
        string sagNavn = "";
        SQLHandler handler = new SQLHandler();
        public Sag()
        {
            InitializeComponent();
        }

        private void Sager_Load(object sender, EventArgs e)
        {

            sag_oversigt.DataSource = handler.FyldDataGridView("dbo.Sag");
        }

        private void opr_sag_Click(object sender, EventArgs e)
        {
            Form f = new Opret_sag();
            f.Show();
        }

        private void sag_oversigt_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in sag_oversigt.SelectedRows)
            {
                sagNummer = (int)row.Cells["SagID"].Value;
                sagNavn = (string)row.Cells["SagNavn"].Value;
            }
        }

        private void vis_sag_Click(object sender, EventArgs e)
        {
            Form f = new Sag_oversigt();
            f.Show();
        }

        private void red_sag_Click(object sender, EventArgs e)
        {
            Form f = new Rediger_sag();
            f.Show();
        }

        private void slet_sag_Click(object sender, EventArgs e)
        {
            {
                //Viser en ja / nej boks inden medarbejder bliver oprettet
                DialogResult dialogResult = MessageBox.Show("Er du sikker på at du vil slette " + sagNavn + "?", "Opret " + sagNavn + "?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    handler.SletMedarbejder(sagNummer);
                    MessageBox.Show(sagNavn + " er blevet slettet");
                }
            }
        }
    }
}
