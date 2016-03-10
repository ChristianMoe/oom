﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task2
{
    class Consultant:Person
    {

        /// <summary>
        /// Auto Properties for Consultant
        /// </summary>
        public int Beraternummer { get; set; } 
        public decimal Stundensatz { get; set; }

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
            this.Beraternummer = Beraternummer;
        }

        /// <summary>
        /// Implementation of Interface Function Print all Data
        /// </summary>
        public override void PrintAllData()
        {
            Console.WriteLine("{0}: {1} {2}, {3}, {4}, {5}, {6}, {7}", Beraternummer, GetVorname(), GetNachname(), GetGeburtsdatum(), GetMail(), GetTelefon(), GetUsername(), Stundensatz);
        }

    }
}
