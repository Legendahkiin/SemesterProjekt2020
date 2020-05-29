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
    public partial class Uddannelse : Form
    {
        SQLHandler handler = new SQLHandler();
        public Uddannelse()
        {
            InitializeComponent();
        }

        public void OpdaterLister()
        {
            handler.FyldUddListbox(nu_udd, 1, Medarbejdere.medarbejderNummer); //Fyld fra combobox?
            handler.FyldUddListbox(tilg_udd, 0, Medarbejdere.medarbejderNummer);
            handler.FyldUddCombobox(combobox_fjern_udd, 1, Medarbejdere.medarbejderNummer);
            handler.FyldUddCombobox(combobox_tilfoj_udd, 0, Medarbejdere.medarbejderNummer);
        }

        private void Uddannelse_Load(object sender, EventArgs e)
        {
            OpdaterLister();
            navn.Text = handler.FyldRedMedarbejder(Medarbejdere.medarbejderNummer, "Navn");
        }


        private void combobox_tilfoj_udd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            handler.GorInaktiv(Convert.ToInt32(combobox_tilfoj_udd.SelectedValue), Medarbejdere.medarbejderNummer, 1);
            OpdaterLister();

        }

        private void combobox_fjern_udd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            handler.GorInaktiv(Convert.ToInt32(combobox_fjern_udd.SelectedValue), Medarbejdere.medarbejderNummer, 0);
            OpdaterLister();

        }
    }
}
