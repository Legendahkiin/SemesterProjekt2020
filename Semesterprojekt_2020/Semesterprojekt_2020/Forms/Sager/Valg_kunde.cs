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
    public partial class Valg_kunde : Form
    {
        public static int valgKundeID;
        public static string valgKundeNavn = "";
        SQLHandler handler = new SQLHandler();
        public Valg_kunde()
        {
            InitializeComponent();
        }

        private void Valg_kunde_Load(object sender, EventArgs e)
        {
            valg_kunde_oversigt.DataSource = handler.FyldValgKunde();
        }

        private void valg_kunde_oversigt_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in valg_kunde_oversigt.SelectedRows)
            {
                valgKundeID = (int)row.Cells["KundeID"].Value;
                valgKundeNavn = (string)row.Cells["Navn"].Value;
            }
        }

        private void kunde_valgt_Click(object sender, EventArgs e)
        {
            //Du har valgt dialog?
            Close();
        }
    }
}
