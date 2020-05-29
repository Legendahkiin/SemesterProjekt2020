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
    public partial class Valg_advokat : Form
    {
        public static int valgMedID;
        public static string valgMedNavn = "";
        SQLHandler handler = new SQLHandler();
        public Valg_advokat()
        {
            InitializeComponent();
        }

        private void Valg_advokat_Load(object sender, EventArgs e)
        {
            valg_advokat_oversigt.DataSource = handler.FyldValgAdvokat();
        }

        private void valg_kunde_oversigt_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in valg_advokat_oversigt.SelectedRows)
            {
                valgMedID = (int)row.Cells["MedID"].Value;
                valgMedNavn = (string)row.Cells["Navn"].Value;
            }
        }

        private void advokat_valgt_Click(object sender, EventArgs e)
        {
            //Du har valgt dialog?
            Close();
        }
    }
}
