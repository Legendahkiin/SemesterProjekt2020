﻿using System;
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
    public partial class Rediger_sag : Form
    {
        public Rediger_sag()
        {
            InitializeComponent();
        }

        private void red_valg_kunde_Click(object sender, EventArgs e)
        {
            Form valgKunde = new Valg_kunde();
            valgKunde.FormClosed += valgKunde_FormClosed;
            valgKunde.Show();
        }

        private void red_valg_advokat_Click(object sender, EventArgs e)
        {
            Form valgAdvokat = new Valg_advokat();
            valgAdvokat.FormClosed += valgAdvokat_FormClosed;
            valgAdvokat.Show();
        }

        private void valgKunde_FormClosed(object sender, FormClosedEventArgs e)
        {
            red_sag_kunde_navn.Text = Valg_kunde.valgKundeNavn;
            red_sag_kundeid.Text = Valg_kunde.valgKundeID.ToString();
        }
        private void valgAdvokat_FormClosed(object sender, FormClosedEventArgs e)
        {
            red_sag_advokat_navn.Text = Valg_advokat.valgMedNavn;
            red_sag_medid.Text = Valg_advokat.valgMedID.ToString();
        }
    }
}
