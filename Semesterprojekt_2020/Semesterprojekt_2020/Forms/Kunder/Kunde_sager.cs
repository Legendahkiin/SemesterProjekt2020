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
    public partial class Kunde_sager : Form
    {
        string sagStatus = "";
        public Kunde_sager()
        {
            InitializeComponent();
            Dictionary<string, int> dictStatus = new Dictionary<string, int>();
            dictStatus.Add("Åben", 1);
            dictStatus.Add("Lukket", 2);

            sag_status.DataSource = new BindingSource(dictStatus, null);
            sag_status.DisplayMember = "Key";
            sag_status.ValueMember = "Value";
        }
        
        SQLHandler handler = new SQLHandler();


        private void Kunde_sager_Load(object sender, EventArgs e)
        {
            kunde_sager_navn.Text = handler.FyldRedKunde(Kunde.kundeNummer, "Navn");
        }

        private void sag_status_SelectedValueChanged(object sender, EventArgs e)
        {

            if (sag_status.SelectedValue.ToString() == "1")
            {
                sagStatus = "IS NOT NULL";
            }
            else
            {
                sagStatus = "IS NULL";
            }
            kunde_sag_oversigt.DataSource = handler.FyldKundeSagOversigt(Kunde.kundeNummer, sagStatus);
        }
    }
}
