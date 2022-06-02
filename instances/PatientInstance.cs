using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.instances
{
    internal class PatientInstance
    {

        public string Fullname { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public int Nationality { get; set; }
        public bool GDPR { get; set; }

        public PatientInstance(string fullname, string identificationNumber, DateTime birthDate, string sex, string email, int nationality, bool gdpr)
        {
            this.Fullname = fullname;
            this.IdentificationNumber = identificationNumber;
            this.BirthDate = birthDate;
            this.Sex = sex;
            this.Email = email;
            this.Nationality = nationality;
            this.GDPR = gdpr;
        }

    }
}
