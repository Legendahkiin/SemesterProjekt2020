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
        public Sag()
        {
            InitializeComponent();
        }

        private void Sager_Load(object sender, EventArgs e)
        {

            SQLHandler handler = new SQLHandler();
            sag_oversigt.DataSource = handler.FyldDataGridView("dbo.Sag");
        }
    }
}
