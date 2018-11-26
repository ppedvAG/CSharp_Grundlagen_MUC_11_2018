using KlinikBibliothek;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMMUC
{
    public partial class BetreuerForm : Form
    {
        public Patient  AktuellerPatient { get; set; }

        //Eigenes Event namens BeteuerGeändert anlegen
        public event EventHandler BetreuerGeändert;

        public BetreuerForm(Patient patient)
        {
            InitializeComponent();
            this.dataGridViewÄrzte.DataSource = PersonenManager.Ärzte;
            this.dataGridViewÄrzte.ReadOnly = true;
            this.dataGridViewÄrzte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSchwestern.DataSource = PersonenManager.Schwestern;
            this.dataGridViewSchwestern.ReadOnly = true;
            this.dataGridViewSchwestern.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AktuellerPatient = patient;
        }

        private void dataGridViewÄrzte_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                AktuellerPatient.FügeBetreuerHinzu((Mitarbeiter)dataGridViewÄrzte.SelectedRows[0].DataBoundItem);
                //Event feuern
                //? prüft, ob die Variable ungleich null ist und ruft nur dann die nachstehende Methode auf
                //ansonsten wird die Anweisung ignoriert
                BetreuerGeändert?.Invoke(this, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Wähle einen Arzt aus!");
            }
        }

        private void dataGridViewSchwestern_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                AktuellerPatient.FügeBetreuerHinzu((Mitarbeiter)dataGridViewSchwestern.SelectedRows[0].DataBoundItem);
                //Event feuern
                //? prüft, ob die Variable ungleich null ist und ruft nur dann die nachstehende Methode auf
                //ansonsten wird die Anweisung ignoriert
                BetreuerGeändert?.Invoke(this, null);

            }
            catch (Exception)
            {
                MessageBox.Show("Wähle einen Arzt aus!");
            }
        }
    }
}
