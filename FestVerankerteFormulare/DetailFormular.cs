﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FestVerankerteFormulare
{
    public partial class DetailFormular : Form
    {
        public DetailFormular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MeineFormulare.Form1Self.listBox1.SelectedIndex = 0;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeineFormulare.Form1Self.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MeineFormulare.Form1Self.Hide();
        }
    }
}
