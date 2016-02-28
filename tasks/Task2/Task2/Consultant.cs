using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Consultant:Person
    {
        private int m_beraternummer;
        /*
        public int Beraternummer
        {
            set
            {
                m_beraternummer = value; 
            }
            get
            {
                return m_beraternummer;
            }

        }
        */
        public Consultant(string Vorname, string Nachname, DateTime Geburtsdatum, string Mail, string Telefon, int Beraternummer)
            : base(Vorname, Nachname, Geburtsdatum, Mail, Telefon)
        {
            m_beraternummer = Beraternummer;
        }

        public override void PrintAllData()
        {
            Console.WriteLine("{0}: {1} {2}, {3}, {4}, {5}", m_beraternummer,GetVorname(), GetNachname(), GetGeburtsdatum(), GetMail(), GetTelefon());

        }

    }
}
