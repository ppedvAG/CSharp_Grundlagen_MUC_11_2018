using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datensatz = listBox1.SelectedItem.ToString();
            MeineFormulare.DetailformularSelf.label1.Text = datensatz;

            MeineFormulare.DetailformularSelf.ShowDialog();
        }
    }
}
