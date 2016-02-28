using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person : IAllData
    {

        /// <summary>
        /// All persons have the following information fields
        /// </summary>

        private string m_vorname;
        private string m_nachname;
        private DateTime m_geburtsdatum;
        private string m_mailadresse;
        private string m_telefonnummer;

        public Person(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon)
        {
            m_vorname = Vorname;
            m_nachname = Nachname;
            m_geburtsdatum = Geburtsdatum;
            m_mailadresse = Mail;
            m_telefonnummer = Telefon;
        }

        public virtual void PrintAllData() { }

        public string GetVorname() { return m_vorname;}
        public string GetNachname() { return m_nachname; }
        public DateTime GetGeburtsdatum() { return m_geburtsdatum; }
        public string GetMail() { return m_mailadresse; }
        public string GetTelefon() { return m_telefonnummer; }
        
    }
}
