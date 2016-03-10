using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


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
        private string m_username;
        private string m_password;

        /// <summary>
        /// Constructor for Person
        /// </summary>
        /// <param name="Vorname"></param>
        /// <param name="Nachname"></param>
        /// <param name="Geburtsdatum"></param>
        /// <param name="Mail"></param>
        /// <param name="Telefon"></param>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        [JsonConstructor]
        public Person(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon, string Username, string Password)
        {
            m_vorname = Vorname;
            m_nachname = Nachname;
            m_geburtsdatum = Geburtsdatum;
            m_mailadresse = Mail;
            m_telefonnummer = Telefon;
            m_username = Username;
            m_password = Password;

        }

        /// <summary>
        /// Virtual Method implementation for class Person using the Interface
        /// </summary>
        public virtual void PrintAllData() { }

        /// <summary>
        /// Methods for Valuereturn
        /// </summary>
        /// <returns>values of specific fields</returns>
        public string GetVorname() { return m_vorname;}
        public string GetNachname() { return m_nachname; }
        public DateTime GetGeburtsdatum() { return m_geburtsdatum; }
        public string GetMail() { return m_mailadresse; }
        public string GetTelefon() { return m_telefonnummer; }
        public string GetUsername() { return m_username; }

        /// <summary>
        /// Methos to change password
        /// </summary>
        /// <returns>1 on success, 0 on failure</returns>
        public int ChangePassword ()
        {
            Console.WriteLine("Bitte geben Sie das aktuelle Passwort ein:");
            var PasswortTemp = Console.ReadLine();
            if (PasswortTemp == m_password)
            {
                var PasswortTempControl="";
                do
                {
                    Console.WriteLine("Bitte geben Sie das neue Passwort ein:");
                    PasswortTemp = Console.ReadLine();
                    Console.WriteLine("Bitte geben Sie das neue Passwort erneut ein:");
                    PasswortTempControl = Console.ReadLine();
                } while (PasswortTemp != PasswortTempControl);
                m_password = PasswortTemp;
                return 1; // Rückgabewert für erfolgreiche Passwortänderung
            }
            else Console.WriteLine("Sie haben ein falsches Passwort eingegeben!");
            return 0; //Rückgabewert für fehlgeschlagene Passwortänderung
        }

    }
}
