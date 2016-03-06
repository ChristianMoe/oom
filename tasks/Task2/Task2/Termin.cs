/// <summary>
/// Christian Mödlhammer - Task 3 OOM - Erweiterung von Task2
/// </summary>

using System;
using Newtonsoft.Json;

namespace Task2
{	
	public class Termin : IAllData
	{
        /* ausgeschaltet, da über get,set property gearbeitet werden muss für Json
        private int m_tag; /// private fields
		private int m_monat;
		private int m_jahr;

		private string m_thema;
		private string m_ort;

        private int m_zugeteilterberater;
        */

        public void PrintAllData()
        {
            Console.WriteLine("{0}.{1}.{2}, {3}, {4}", GetTag(), GetMonat(), GetJahr(), GetOrt(), GetThema());
        }
        /*
        public string Ort  /// property
		{
			get 
			{
				return m_ort;
			}
			set 
			{
				m_ort=value;
			}
		}

		public string Thema  /// property
		{
			get 
			{
				return m_thema;
			}
			set 
			{
				m_thema=value;
			}
		}
        */

        [JsonConstructor]
        public Termin (int tag,int monat,int jahr, string ort, string thema) /// constructor
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");

			Tag = tag;
			Monat = monat;
			Jahr = jahr;
            Ort = ort;
            Thema = thema;
        }

        // auto-implemented Properties für Json
        public int Tag { get; set; }
        public int Monat { get; set; }
        public int Jahr { get; set; }
        public string Ort { get; set; }
        public string Thema { get; set; }


        public int GetTag() /// method
		{
			return Tag;
		}

		public int GetMonat() /// method
		{
			return Monat;
		}

		public int GetJahr() /// Methode
		{
			return Jahr;
		}

        public string GetOrt() /// method
		{
            return Ort;
        }

        public string GetThema() /// method
		{
            return Thema;
        }

        public void UpdateTag(int tag) /// method
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			Tag = tag;
		}

		public void UpdateMonat(int monat) /// method
		{
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			Monat = monat;
		}

		public void UpdateJahr(int jahr) /// Methode
		{
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");
			Jahr = jahr;
		}

        /* public void BeraterZuTerminEintragen(int Beraternummer) /// method
		{
            m_zugeteilterberater = Beraternummer;
        }
        */
    }
}

