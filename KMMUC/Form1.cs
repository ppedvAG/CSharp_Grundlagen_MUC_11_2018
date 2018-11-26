using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eigene_Klassen;
using KlinikBibliothek;
using Newtonsoft.Json;

namespace KMMUC
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            dataGridPatienten.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridÄrzte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSchwester.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridPatienten.DataSource = PersonenManager.Patienten;
            dataGridÄrzte.DataSource = PersonenManager.Ärzte;
            dataGridSchwester.DataSource = PersonenManager.Schwestern;
        }

        private void buttonNeu_Click(object sender, EventArgs e)
        {
            BearbeitenForm neuesFormular = new BearbeitenForm();
            neuesFormular.Text = "Bearbeitung";

            string ausgewählteTabelle = tabControl1.SelectedTab.Text;

            switch (ausgewählteTabelle)
            {
                case "Ärzte":
                    neuesFormular.Vorauswahl = "Arzt";
                    break;
                case "Schwestern":
                    neuesFormular.Vorauswahl = "Schwester";
                    break;
                case "Patienten":
                    neuesFormular.Vorauswahl = "Patient";
                    break;
                default:
                    break;
            }

            neuesFormular.ShowDialog();
        }

        private void speichernToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Person> personenListe = new List<Person>();

            personenListe.AddRange(PersonenManager.Ärzte);
            personenListe.AddRange(PersonenManager.Schwestern);
            personenListe.AddRange(PersonenManager.Patienten);

            StreamWriter writer = null;
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Auto;

                string json = JsonConvert.SerializeObject(personenListe, settings);

                writer = new StreamWriter("Personen.txt", false);
                writer.Write(json);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
                return;
            }
            finally
            {
                writer?.Close();
            }
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Person> ergebnisListe;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader("Personen.txt");
                string json = reader.ReadToEnd();

                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.Auto;

                ergebnisListe = JsonConvert.DeserializeObject<List<Person>>(json, settings);
                reader.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            //Wird immer ausgeführt, auch wenn es vorher ein return gab
            finally
            {
                reader?.Close();
            }


            //Die große Personenliste durchlaufen und die einzelnen Objekte in die
            //richtigen Unterlisten (Ärzte/Patienten/Schwestern) einsortieren

            foreach (var personAusListe in ergebnisListe)
            {
                if (personAusListe is Arzt)
                {
                    PersonenManager.Ärzte.Clear();
                    PersonenManager.Ärzte.Add((Arzt)personAusListe);
                }
                else if (personAusListe is Schwester)
                {
                    PersonenManager.Schwestern.Clear();
                    PersonenManager.Schwestern.Add((Schwester)personAusListe);
                }
                else if (personAusListe is Patient)
                {
                    PersonenManager.Patienten.Clear();
                    PersonenManager.Patienten.Add((Patient)personAusListe);
                }
            }
        }

        private void buttonBearbeite_Click(object sender, EventArgs e)
        {
            //Zu bearbeitende Person ermitteln
            string ausgewählteTabelle = tabControl1.SelectedTab.Text;
            Person zuBearbeitendePerson = null;

            switch (ausgewählteTabelle)
            {
                case "Ärzte":
                    zuBearbeitendePerson = (Arzt)dataGridÄrzte.SelectedRows[0].DataBoundItem;
                    break;
                case "Schwestern":
                    zuBearbeitendePerson = (Schwester)dataGridSchwester.SelectedRows[0].DataBoundItem;
                    break;
                case "Patienten":
                    zuBearbeitendePerson = (Patient)dataGridPatienten.SelectedRows[0].DataBoundItem;
                    break;
                default:
                    break;
            }

            BearbeitenForm neuesFormular = new BearbeitenForm(zuBearbeitendePerson);
            neuesFormular.Text = "Bearbeitung";

            if(neuesFormular.ShowDialog() == DialogResult.OK)
            {
                if(neuesFormular.ZuBearbeitendePerson is Arzt)
                {
                    int index = PersonenManager.Ärzte.IndexOf(zuBearbeitendePerson as Arzt);
                    PersonenManager.Ärzte[index] = neuesFormular.ZuBearbeitendePerson as Arzt;
                }
                else if(neuesFormular.ZuBearbeitendePerson is Schwester)
                {
                    int index = PersonenManager.Schwestern.IndexOf(zuBearbeitendePerson as Schwester);
                    PersonenManager.Schwestern[index] = neuesFormular.ZuBearbeitendePerson as Schwester;
                }
                else if(neuesFormular.ZuBearbeitendePerson is Patient)
                {
                    int index = PersonenManager.Patienten.IndexOf(zuBearbeitendePerson as Patient);
                    PersonenManager.Patienten[index] = neuesFormular.ZuBearbeitendePerson as Patient;
                }

            }
        }

        private void button_löschen_click(object sender, EventArgs e)
        {
            string ausgewählteTabelle = tabControl1.SelectedTab.Text;

            switch (ausgewählteTabelle)
            {
                case "Ärzte":
                    if (dataGridÄrzte.SelectedRows.Count > 0)
                    {
                        Arzt zuLöschenderArzt = (Arzt)dataGridÄrzte.SelectedRows[0].DataBoundItem;
                        PersonenManager.Ärzte.Remove(zuLöschenderArzt);
                    }
                    break;
                case "Schwestern":
                    if (dataGridSchwester.SelectedRows.Count > 0)
                    {
                        Schwester zuLöschendeSchwester = (Schwester)dataGridSchwester.SelectedRows[0].DataBoundItem;
                        PersonenManager.Schwestern.Remove(zuLöschendeSchwester);
                    }
                    break;
                case "Patienten":
                    if (dataGridPatienten.SelectedRows.Count > 0)
                    {
                        Patient zuLöschenderPatient = (Patient)dataGridPatienten.SelectedRows[0].DataBoundItem;
                        PersonenManager.Patienten.Remove(zuLöschenderPatient);
                    }
                    break;
                default:
                    throw new Exception("Unbekannte Personenart");
            }
        }
    }
}