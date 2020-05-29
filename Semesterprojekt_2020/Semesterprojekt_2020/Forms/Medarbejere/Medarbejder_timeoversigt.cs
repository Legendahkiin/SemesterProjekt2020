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
    public partial class Timeregistrereing : Form
    {
        SQLHandler handler = new SQLHandler();
        public Timeregistrereing()
        {
            InitializeComponent();
        }

        private void Timeregistrereing_Load(object sender, EventArgs e)
        {
            var nuAr = DateTime.Now.Year;
            var nuManed = DateTime.Now.Month;
            int forsteDagManed = 1;
            int sidsteDagManed = DateTime.DaysInMonth(nuAr, nuManed);

            med_time_navn.Text = Medarbejdere.medarbejderNavn;
            fraDatoValg.Value = new DateTime(nuAr, nuManed, forsteDagManed);
            tilDatoValg.Value = new DateTime(nuAr, nuManed, sidsteDagManed);
            LoadData();
        }

        private void fraDatoValg_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tilDatoValg_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private string SumAntalKilometer()
        {
            int sum = 0;
            foreach (DataGridViewRow r in med_timeoversigt.Rows)
            {
                {
                    sum += Convert.ToInt32(r.Cells["AntalKM"].Value);
                }
            }
            return sum.ToString();
        }
        private string SumAntalTimer()
        {
            int sum = 0;
            foreach (DataGridViewRow r in med_timeoversigt.Rows)
            {
                {
                    sum += Convert.ToInt32(r.Cells["AntalTimer"].Value);
                }
            }
            return sum.ToString();
        }

        private void LoadData()
        {
            med_timeoversigt.DataSource = handler.FyldMedTimeoversigt(Medarbejdere.medarbejderNummer, "'" + fraDatoValg.Value.ToString("yyyy-MM-dd") + "'", "'" + tilDatoValg.Value.ToString("yyyy-MM-dd") + "'");
            antaltimer.Text = SumAntalTimer();
            antalKM.Text = SumAntalKilometer();
        }
    }
}
