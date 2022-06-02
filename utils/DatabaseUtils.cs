using InterviewApp.instances;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewApp.utils
{
    internal class DatabaseUtils
    {

        private static SqlConnection conn;

        public static bool setupDatabase()
        {

            string credentials = $"Data Source=localhost;Initial Catalog=form;Integrated Security=True";
            conn = new SqlConnection(credentials);

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't connect to the database. Please report error below to support:\n" + ex.Message);
                return false;
            }

        }

        public static void addPatient(PatientInstance patient)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Patient(Fullname, IdentifyNumber, Birthdate, Sex, Email, Nationality, GDPRAgree) VALUES(@Fullname, @IdentifyNumber, @Birthdate, @Sex, @Email, @Nationality, @GDPRAgree)", conn);
            command.Parameters.AddWithValue("@Fullname", patient.Fullname);
            command.Parameters.AddWithValue("@IdentifyNumber", patient.IdentificationNumber);
            command.Parameters.AddWithValue("@Birthdate", patient.BirthDate);
            command.Parameters.AddWithValue("@Sex", patient.Sex);
            command.Parameters.AddWithValue("@Email", patient.Email);
            command.Parameters.AddWithValue("@Nationality", patient.Nationality);
            command.Parameters.AddWithValue("@GDPRAgree", patient.GDPR);

            try
            {
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't add patient into database. Please report error below to support:\n" + ex.Message);
                Application.Exit();
            }

        }

    }
}
