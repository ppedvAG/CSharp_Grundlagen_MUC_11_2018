using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_Konverter_Auf_DB_Basis
{

    public partial class Form1 : Form
    {
        public BindingList<PatientNeu> Patientenliste { get; set; }

        public Form1()
        {
            InitializeComponent();
            Patientenliste = new BindingList<PatientNeu>();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = Patientenliste;
        }

        private void button_neuer_datensatz(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Geben Sie einen Namen an!");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxOrt.Text))
            {
                MessageBox.Show("Geben Sie einen Namen an!");
                return;
            }

            PatientNeu patientNeu = new PatientNeu();
            patientNeu.Name = textBoxName.Text;
            patientNeu.Geburststag = dateTimePickerGeburt.Value;
            patientNeu.Aufenthaltsort = textBoxOrt.Text;
            Patientenliste.Add(patientNeu);
        }

        private void button_altes_xml_format_speichern(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Patientenliste_AltesFormat.oldxml";
            dialog.Filter = "Altes XML-Format|*.oldxml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Patientenliste in altes Format umwandeln
                List<PatientAlt> patientenListeAltesFormat = new List<PatientAlt>();
                foreach (var item in Patientenliste)
                {
                    PatientAlt patientAlt = new PatientAlt();
                    patientAlt.Name = item.Name;
                    patientAlt.Geburststag = item.Geburststag;
                    patientenListeAltesFormat.Add(patientAlt);
                }

                FileStream stream = null;
                try
                {
                    //Serialisiere und speichere Daten im alten XML-Format
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PatientAlt>));
                    stream = new FileStream(dialog.FileName, FileMode.Create);
                    serializer.Serialize(stream, patientenListeAltesFormat);
                    stream.Close();
                    //zeige XML-Datei an
                    Process.Start(dialog.FileName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }
                finally
                {
                    stream?.Close();
                }
            }
        }

        private void button_altes_xml_importieren(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.FileName = "Patientenliste_AltesFormat.oldxml";
            dialog.Filter = "Altes XML-Format|*.oldxml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = null;
                List<PatientAlt> listeAlt = null;
                try
                {
                    stream = new FileStream(dialog.FileName, FileMode.Open);
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PatientAlt>));
                    listeAlt = (List<PatientAlt>)serializer.Deserialize(stream);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }
                finally
                {
                    stream?.Close();
                }
                //Liste in neues Format kovertieren
                Patientenliste.Clear();
                foreach (var item in listeAlt)
                {
                    PatientNeu patientNeu = new PatientNeu();
                    patientNeu.Name = item.Name;
                    patientNeu.Geburststag = item.Geburststag;
                    Patientenliste.Add(patientNeu);
                }
            }
        }

        private void button_in_DB_speichern(object sender, EventArgs e)
        {
            DBManager.SpeicherePatientenInDB(Patientenliste.ToList());
        }

        private void button_aufenthaltsort_aus_DB(object sender, EventArgs e)
        {
            var listeAusDB = DBManager.LadePatientenAusDB();
            if (listeAusDB == null)
                return;

            //Aufenthaltsort mit aktueller Liste abgleichen
            foreach (var item in Patientenliste)
            {
                //finde den ersten Eintrag eines Patienten in der DB mit selben Namen und Geburtstag
                var patientAusDB = listeAusDB.FirstOrDefault(p => p.Name == item.Name);
                //wenn ein Patient in der DB gefunden werde, übernehme dessen Aufenthaltsort
                if (patientAusDB != null)
                {
                    item.Aufenthaltsort = patientAusDB.Aufenthaltsort;
                }
            }
            dataGridView1.Invalidate();
        }

        private void button_datagrid_leeren(object sender, EventArgs e)
        {
            Patientenliste.Clear();
        }

        private void button_neues_xml_export(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = "Patientenliste_NeuesFormat.oldxml";
            dialog.Filter = "Neues XML-Format|*.newxml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = null;
                try
                {
                    //Serialisiere und speichere Daten im alten XML-Format
                    XmlSerializer serializer = new XmlSerializer(typeof(List<PatientNeu>));
                    stream = new FileStream(dialog.FileName, FileMode.Create);
                    serializer.Serialize(stream, Patientenliste.ToList());
                    stream.Close();
                    //zeige XML-Datei an
                    Process.Start(dialog.FileName);
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }
                finally
                {
                    stream?.Close();
                }
            }
        }
    }
}