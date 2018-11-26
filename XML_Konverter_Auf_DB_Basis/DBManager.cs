using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XML_Konverter_Auf_DB_Basis
{
    public class DBManager
    {
        //Einrichtrung einer SQL Server DB in Visual Studio:
        //https://docs.microsoft.com/en-us/visualstudio/data-tools/create-a-simple-data-application-by-using-adonet?view=vs-2017

        public const string Connection_String = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PatientenDB;Integrated Security=True;Pooling=False";

        public static void SpeicherePatientenInDB(List<PatientNeu> patienten)
        {
            using (SqlConnection connection = new SqlConnection(Connection_String))
            {
                try
                {
                    connection.Open();
                    //Bisherige Daten löschen
                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = "DELETE FROM Patient";
                        command.ExecuteNonQuery();
                    }
                    foreach (var item in patienten)
                    {
                        using (SqlCommand command = connection.CreateCommand())
                        {

                            command.CommandText = "INSERT INTO Patient (Name,Geburtstag,Aufenthaltsort) VALUES (@name,@geburtstag, @aufenthaltsort);";
                            command.Parameters.AddWithValue("@name", item.Name);
                            command.Parameters.AddWithValue("@geburtstag", item.Geburststag);
                            command.Parameters.AddWithValue("@aufenthaltsort", item.Aufenthaltsort);
                            command.ExecuteNonQuery();
                        }

                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Fehler bei der DB: {exp.Message}\nWurde die Datenbank schon angelegt?");
                }
            }
        }

        public static List<PatientNeu> LadePatientenAusDB()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection_String))
                {
                    using (SqlCommand command = new SqlCommand("Select * FROM Patient", connection))
                    {
                        connection.Open();
                        var reader = command.ExecuteReader();
                        List<PatientNeu> patientenAusDB = new List<PatientNeu>();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                PatientNeu patientAusDB = new PatientNeu();
                                patientAusDB.Name = reader["Name"].ToString();
                                patientAusDB.Geburststag = DateTime.Parse(reader["Geburtstag"].ToString());
                                patientAusDB.Aufenthaltsort = reader["Aufenthaltsort"].ToString();
                                patientenAusDB.Add(patientAusDB);
                            }
                        }
                        return patientenAusDB;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Fehler bei der DB: {exp.Message}\nWurde die Datenbank schon angelegt?");
                return null;
            }
        }
    }
}