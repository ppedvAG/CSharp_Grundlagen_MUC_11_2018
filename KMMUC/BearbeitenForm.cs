using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eigene_Klassen;
using KlinikBibliothek;

namespace KMMUC
{
    public partial class BearbeitenForm : Form
    {

        public enum Bearbeitungsmodi { Neu, Editieren }
        public enum PersonenArt { Patient, Arzt, Schwester }

        public Bearbeitungsmodi Modus { get; set; }

        public Person ZuBearbeitendePerson { get; set; }

        Patient _aktuellerPatient = null;

        public string Vorauswahl
        {
            //Strg+K+D
            set
            {
                listBoxPersonenArt.SelectedItem = value;
            }
        }

        //Begin Konstruktoren-----------------------------------------
        public BearbeitenForm()
        {
            BereiteFormularVor();
            Modus = Bearbeitungsmodi.Neu;
            
        }

        public BearbeitenForm(Person person)
        {
            BereiteFormularVor();
            ZuBearbeitendePerson = person;
            Modus = Bearbeitungsmodi.Editieren;

            //Werte vorbelegen
            listBoxPersonenArt.Enabled = false;
            //Personendaten---------------------------
            textBoxVorname.Text = person.Vorname;
            textBoxNachname.Text = person.Nachname;
            dateTimePickerGeburt.Value = person.Geburtsdatum;
            comboBoxGeschlechter.SelectedItem = person.Geschlecht;
            //Patienten spezifische Daten
            if(person is Patient)
            {
                listBoxPersonenArt.SelectedItem = PersonenArt.Patient;
                _aktuellerPatient = (Patient)person;
                BetreuerAnzeigeAktualisieren();
                textBoxICDCode.Text = _aktuellerPatient.ICDCode;
            }
            else if(person is Mitarbeiter)
            {
                //Ändere den Blickwinkel auf das Personenobjekt im Speicher
                Mitarbeiter mitarbeiter = (Mitarbeiter)person;
                textBoxGehalt.Text = mitarbeiter.Gehalt.ToString();

                //Arzt spezifisches
                if(person is Arzt arzt) //Prüfung des Datentyps und Cast zusammengefasst
                {
                    listBoxPersonenArt.SelectedItem = PersonenArt.Arzt;
                    textBoxTitel.Text = arzt.Titel;
                    comboBoxDisziplin.SelectedItem = arzt.Disziplin;
                }
                //Schwester spezifisches
                else if(person is Schwester schwester)
                {
                    listBoxPersonenArt.SelectedItem = PersonenArt.Schwester;
                    checkBoxOberschwester.Checked = schwester.IstOberschwester;
                }
            }
        }
        //END Konstruktoren-------------------------------------------

        public void BereiteFormularVor()
        {
            InitializeComponent();
            //ComboBox Geschlechter
            comboBoxGeschlechter.Items.Add(Person.Geschlechter.Männlich);
            comboBoxGeschlechter.Items.Add(Person.Geschlechter.Weiblich);
            comboBoxGeschlechter.Items.Add(Person.Geschlechter.Sonstiges);
            comboBoxGeschlechter.SelectedIndex = 0;
            //ListBox PersonenArt
            listBoxPersonenArt.Items.Add(PersonenArt.Patient);
            listBoxPersonenArt.Items.Add(PersonenArt.Arzt);
            listBoxPersonenArt.Items.Add(PersonenArt.Schwester);
            //ComboBox Arztdisziplin: Automatische Befüllung der Enum-Werte
            foreach (var item in Enum.GetValues(typeof(Arzt.Disziplinen)))
            {
                comboBoxDisziplin.Items.Add(item);
            }
            dateTimePickerAufnahme.Value = DateTime.Today;
        }

        private void button_ok_click(object sender, EventArgs e)
        {

            if(listBoxPersonenArt.SelectedItem == null)
            {
                MessageBox.Show("Es wurde keine Personenart ausgewählt!");
                return;
            }

           

            string vorname = textBoxVorname.Text;
            string nachname = textBoxNachname.Text;
            DateTime geburtsdatum = dateTimePickerGeburt.Value;
            //Casting von object zu Person.Geschlechter (enum)
            Person.Geschlechter geschlecht = (Person.Geschlechter)comboBoxGeschlechter.SelectedItem;


            DateTime aufnahmedatum = DateTime.Now;
            string icdcode = string.Empty;
            int gehalt = 0;
            string arztTitle = string.Empty;
            bool istOberschwester = false;
            Arzt.Disziplinen arztDisziplin = Arzt.Disziplinen.Chirurgie;

            PersonenArt art = (PersonenArt)listBoxPersonenArt.SelectedItem;

            switch (art)
            {
                case PersonenArt.Patient:
                    aufnahmedatum = dateTimePickerAufnahme.Value;
                    icdcode = textBoxICDCode.Text;
                    break;
                case PersonenArt.Arzt:
                    arztTitle = textBoxTitel.Text;
                    arztDisziplin = (Arzt.Disziplinen)comboBoxDisziplin.SelectedItem;
                    break;
                case PersonenArt.Schwester:
                    istOberschwester = checkBoxOberschwester.Checked;
                    break;
                default:
                    throw new Exception("Unbekannte Personenart");
            }

            if (art == PersonenArt.Arzt || art == PersonenArt.Schwester)
            {
                try
                {
                    gehalt = int.Parse(textBoxGehalt.Text);
                }
                catch (FormatException exp)
                {
                    MessageBox.Show("Das Gehalt ist ungültig!");
                    textBoxGehalt.Focus();
                    return;
                }
                catch (OverflowException exp)
                {
                    MessageBox.Show("Das Gehalt ist zu groß!");
                    textBoxGehalt.Focus();
                    return;
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }     
            }

            try
            {
                switch (art)
                {
                    case PersonenArt.Arzt:
                        Arzt arzt = new Arzt(vorname, nachname, geschlecht, geburtsdatum);
                        arzt.Gehalt = gehalt;
                        arzt.Disziplin = arztDisziplin;
                        arzt.Titel = arztTitle;
                        if (Modus == Bearbeitungsmodi.Neu)
                            PersonenManager.Ärzte.Add(arzt);
                        else
                            ZuBearbeitendePerson = arzt;
                        break;
                    case PersonenArt.Patient:
                        Patient patient = new Patient(vorname, nachname, geschlecht, geburtsdatum);
                        patient.Aufnahmedatum = aufnahmedatum;
                        patient.ICDCode = icdcode;
                        if(_aktuellerPatient != null)
                        {
                            patient.Betreuer = _aktuellerPatient.Betreuer;
                        }
                        if (Modus == Bearbeitungsmodi.Neu)
                            PersonenManager.Patienten.Add(patient);
                        else
                            ZuBearbeitendePerson = patient;
                        break;
                    case PersonenArt.Schwester:
                        Schwester schwester = new Schwester(vorname, nachname, geschlecht, geburtsdatum);
                        schwester.Gehalt = gehalt;
                        schwester.IstOberschwester = istOberschwester;
                        if (Modus == Bearbeitungsmodi.Neu)
                            PersonenManager.Schwestern.Add(schwester);
                        else
                            ZuBearbeitendePerson = schwester;
                        break;
                    default:
                        throw new Exception("Wähle eine Personenart!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return;
            }
            //Schließt Formular
            DialogResult = DialogResult.OK;
        }

        private void listBoxPersonenArt_SelectedIndexChanged(object sender, EventArgs e)
        {
            //erst mal alles ausblenden 
            panelSchwester.Visible = false;
            panelArzt.Visible = false;
            panelMitarbeiter.Visible = false;
            panelPatient.Visible = false;

            //und dann je nach Auswahl wieder einblenden
            switch ((PersonenArt)listBoxPersonenArt.SelectedItem)
            {
                case PersonenArt.Arzt:
                    panelMitarbeiter.Visible = true;
                    panelArzt.Visible = true;
                    break;
                case PersonenArt.Schwester:
                    panelMitarbeiter.Visible = true;
                    panelSchwester.Visible = true;
                    break;
                case PersonenArt.Patient:
                    panelPatient.Visible = true;
                    break;
                default:
                    throw new Exception("Unbekannte Personenart!");
            }
        }

        private void button_betreuer_hinzufügen(object sender, EventArgs e)
        {
            //Wurde schon ein Patient erstellt oder ausgewählt??
            if (_aktuellerPatient == null)
            {
                MessageBox.Show("Bitte erst Patienten erstellen!");
                return;
            }
            BetreuerForm form = new BetreuerForm(_aktuellerPatient);
            form.BetreuerGeändert += Betreuer_Geändert;
            form.ShowDialog();
        }

        private void Betreuer_Geändert(object sender, EventArgs e)
        {
            BetreuerAnzeigeAktualisieren();
        }

        private void BetreuerAnzeigeAktualisieren()
        {
            string anzeige = "Betreuer: ";

            foreach (var item in _aktuellerPatient.Betreuer)
            {
                anzeige += item.ToString() + "\n";
            }

            labelBetreuer.Text = anzeige;
        }

        private void button_abbrechen_click(object sender, EventArgs e)
        {
            //Schließt Formular
            DialogResult = DialogResult.Cancel;
        }
    }
}