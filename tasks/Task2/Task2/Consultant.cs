using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2
{
    class Consultant:Person
    {

        private List<string> Qualifications = new List<string>();

        /// <summary>
        /// Auto Properties for Consultant
        /// </summary>
        public int Beraternummer { get; set; } 
        public decimal Stundensatz { get; set; }

        /// <summary>
        /// Methods for Qualification
        /// </summary>
        /// <param name="x"></param>
        public void AddQualification(string x) { Qualifications.Add(x); }
        public bool HasQualification(string x) { return Qualifications.Contains(x); }
        public void RemoveQualification(string x) { Qualifications.Remove(x); }

        public void PrintListValues ()
        { 
            foreach (string quali in Qualifications)
	        Console.Write(", {0}",quali);
	    }


    /// <summary>
    /// Constructor for Consultant
    /// </summary>
    /// <param name="Vorname"></param>
    /// <param name="Nachname"></param>
    /// <param name="Geburtsdatum"></param>
    /// <param name="Mail"></param>
    /// <param name="Telefon"></param>
    /// <param name="Username"></param>
    /// <param name="Password"></param>
    /// <param name="Beraternummer"></param>
    [JsonConstructor]
        public Consultant(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon, string Username, string Password, int Beraternummer)
            : base(Vorname, Nachname, Geburtsdatum, Mail, Telefon, Username, Password)
        {
            this.Vorname = Vorname;
            this.Nachname = Nachname;
            this.Geburtstag = Geburtsdatum;
            this.Mailadresse = Mail;
            this.Telefonnummer = Telefon;
            this.Username = Username;
            this.Beraternummer = Beraternummer;
        }

        /// <summary>
        /// Implementation of Interface Function Print all Data
        /// </summary>
        public override void PrintAllData()
        {
            Console.Write("{0}: {1} {2}, {3}, {4}, {5}, {6}, {7}", Beraternummer, Vorname, Nachname, Geburtstag, Mailadresse, Telefonnummer, Username, Stundensatz);
            PrintListValues();
            Console.WriteLine(Environment.NewLine);
        }

    }
}
