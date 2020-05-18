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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DatabaseKnap_Click(object sender, EventArgs e)
        {
            string databaseConnection = @"Data Source=DESKTOP-UPIGRQQ; Initial Catalog=semesterprojekt12020; Integrated Security = SSPI";
           
            SQLHandler handler = new SQLHandler();

            handler.ConnectToDatabase(databaseConnection);
        }

        private void Medarbejdere_Click(object sender, EventArgs e)
        {

        }

        private void Kunder_Click(object sender, EventArgs e)
        {
            string databaseConnection = @"Data Source=DESKTOP-UPIGRQQ; Initial Catalog=semesterprojekt12020; Integrated Security = SSPI";

            SQLHandler handler = new SQLHandler();

            handler.ReadDatabase("kunde", databaseConnection);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string databaseConnection = @"Data Source=DESKTOP-UPIGRQQ; Initial Catalog=semesterprojekt12020; Integrated Security = SSPI";


            SQLHandler.SetDataGridColumns(dataGridView1, SQLHandler.CreateColumnArray("kunde", databaseConnection));

            //SQLHandler.GetColumnsInTable("kunde", databaseConnection);
        }
    }
}
