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
        /// All persons autoproperties
        /// </summary>
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtstag { get; set; }
        public string Mailadresse { get; set; }
        public string Telefonnummer { get; set; }
        public string Username { get; set; }
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
        public Person(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon, string Username, string Password) {}

        /// <summary>
        /// Virtual Method implementation for class Person using the Interface
        /// </summary>
        public virtual void PrintAllData() { }

        /// <summary>
        /// Method to change password
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
