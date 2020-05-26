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
        public static int KundeNummer = 1;
        public Kunde()
        {
            InitializeComponent();
        }

        private void Kunder_Load(object sender, EventArgs e)
        {
            SQLHandler handler = new SQLHandler();
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
            SQLHandler handler = new SQLHandler();
            kunde_oversigt.DataSource = handler.FyldDataGridView("dbo.Kunde");
        }
        private void kunde_oversigt_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in kunde_oversigt.SelectedRows)
            {
                KundeNummer = (int)row.Cells["KundeID"].Value;
            }
        }
    }
}
