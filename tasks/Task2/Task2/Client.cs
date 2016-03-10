using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2
{
    class Client:Person
    {
        /// <summary>
        /// Auto-Property Klientennummer
        /// </summary>
        public int m_clientnumber { get; set; }

        /// <summary>
        /// Constructor for Class Client
        /// </summary>
        /// <param name="Vorname"></param>
        /// <param name="Nachname"></param>
        /// <param name="Geburtsdatum"></param>
        /// <param name="Mail"></param>
        /// <param name="Telefon"></param>
        /// <param name="Username"></param>
        /// <param name="Password"></param>
        /// <param name="ClientNr"></param>

        [JsonConstructor]
        public Client(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon,string Username, string Password, int ClientNr)
            : base(Vorname, Nachname, Geburtsdatum, Mail, Telefon, Username, Password)
        {
            m_clientnumber = ClientNr;
        }


        /// <summary>
        /// Implementation of Interface Function Print all Data
        /// </summary>
        public override void PrintAllData()
        {
            Console.WriteLine("{0}: {1} {2}, {3}, {4}, {5}, {6}", m_clientnumber, GetVorname(), GetNachname(), GetGeburtsdatum(), GetMail(), GetTelefon(),GetUsername());
        }
    }
}
