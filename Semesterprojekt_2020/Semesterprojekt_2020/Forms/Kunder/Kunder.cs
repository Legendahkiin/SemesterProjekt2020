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
    public partial class Kunder : Form
    {
        public Kunder()
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
    }
}
