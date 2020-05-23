using Semesterprojekt_2020.Forms;
using Semesterprojekt_2020.Forms.Kunder;
using Semesterprojekt_2020.Forms.Sager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semesterprojekt_2020
{
    public partial class Menu : Form
    {



        public Menu()
        {
            InitializeComponent();
        }

        private void Medarbejdere_Click(object sender, EventArgs e)
        {
            Form f = new Medarbejdere();
            f.Show();
        }

        private void Kunder_Click(object sender, EventArgs e)
        {
            Form f = new Kunder();
            f.Show();
        }

        private void Sager_Click(object sender, EventArgs e)
        {
            Form f = new Sager();
            f.Show();
        }
    }
}
