using InterviewApp.instances;
using InterviewApp.utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewApp
{
    public partial class Form1 : Form
    {

        private bool isCzech;

        public Form1()
        {
            InitializeComponent();
            isCzech = true;
            updateLanguage("cs");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (isCzech)
            {
                pbLanguage.Image = Properties.Resources.czech_republic;
                updateLanguage("en");
            }
            else 
            {
                pbLanguage.Image = Properties.Resources.united_kingdom;
                updateLanguage("cs");
            }
            isCzech = !isCzech;
        }

        private void updateLanguage(string language)
        {
            lFullname.Text = Program.getLanguageSet()[language]["label_fullname"].ToString();
            lIdentifyNumber.Text = Program.getLanguageSet()[language]["label_identify_number"].ToString();
            chbHaventIdNumber.Text = Program.getLanguageSet()[language]["checkbox_have_id_number"].ToString();
            lBirth.Text = Program.getLanguageSet()[language]["label_birth"].ToString();
            lSex.Text = Program.getLanguageSet()[language]["label_sex"].ToString();
            lNationality.Text = Program.getLanguageSet()[language]["label_nationality"].ToString();
            chbGDPR.Text = Program.getLanguageSet()[language]["checkbox_agree_with_GDPR"].ToString();
            bSend.Text = Program.getLanguageSet()[language]["button_send"].ToString();
            cbSex.Items.Clear();
            cbSex.Items.AddRange((string[])Program.getLanguageSet()[language]["combobox_sex_list"]);
            cbNationality.Items.Clear();
            cbNationality.Items.AddRange((string[])Program.getLanguageSet()[language]["combobox_nationality_list"]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tbIdentifyNumber_Leave(object sender, EventArgs e)
        {
            if (tbIdentifyNumber.Text.Equals(""))
                return;
            if (!tbIdentifyNumber.Text.Contains("/"))
                return;
            if (tbIdentifyNumber.Text.Length != 11)
                return;

            string bdate = tbIdentifyNumber.Text.Split('/')[0];
            int year = Convert.ToInt32(bdate.Substring(0, 2));
            int month = Convert.ToInt32(bdate.Substring(2, 2));
            int day = Convert.ToInt32(bdate.Substring(4, 2));

            year = year <= DateTime.Now.Year ? year + 2000 : year + 1900;

            DateTime dt = new DateTime(year, month, day);

            dtpBirth.Value = dt;

        }

        private void tbIdentifyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '/')
                return;
            e.Handled = true;
            
        }

        private void bSend_Click(object sender, EventArgs e)
        {

            if((!tbEmail.Text.Contains(".")) || (!tbEmail.Text.Contains("@")))
            {
                MessageBox.Show(Program.getLanguageSet()[isCzech ? "cs" : "en"]["message_email_bad_format"].ToString());
                return;
            }

            if(tbFullname.Text.Equals("") ||
                (chbHaventIdNumber.Checked ? false : tbIdentifyNumber.Text.Equals("")) ||
                cbSex.SelectedIndex == -1 ||
                tbEmail.Text.Equals("") ||
                cbNationality.SelectedIndex == -1)
            {
                MessageBox.Show(Program.getLanguageSet()[isCzech ? "cs" : "en"]["message_all_parameters"].ToString());
                return;
            }

            sendForm();

        }

        private void sendForm()
        {

            string fullname = tbFullname.Text;
            string identifyNumber = tbIdentifyNumber.Text;
            DateTime bdate = dtpBirth.Value;
            string sex = cbSex.SelectedItem.ToString();
            string email = tbEmail.Text;
            int nationality = cbNationality.SelectedIndex;
            bool gdprAgree = chbGDPR.Checked;

            PatientInstance patient = new PatientInstance(fullname, identifyNumber, bdate, sex, email, nationality, gdprAgree);

            string json = JsonConvert.SerializeObject(patient, Formatting.Indented);
            StreamWriter writer = new StreamWriter(fullname.Replace(' ', '-') + ".json");
            writer.Write(json);
            writer.Flush();
            writer.Close();

            DatabaseUtils.addPatient(patient);

        }

        private void lGDPR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"hw.pdf"); // Zmente cestu, je-li treba
        }
    }
}
