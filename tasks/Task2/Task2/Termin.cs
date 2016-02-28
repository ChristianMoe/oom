/// <summary>
/// Christian Mödlhammer - Task 3 OOM - Erweiterung von Task2
/// </summary>

using System;

namespace Task2
{	
	public class Termin : IAllData
	{
		private int m_tag; /// private fields
		private int m_monat;
		private int m_jahr;

		private string m_thema;
		private string m_ort;

        private int m_zugeteilterberater;

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

		public Termin (int tag,int monat,int jahr, string ort, string thema) /// constructor
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");

			m_tag = tag;
			m_monat = monat;
			m_jahr = jahr;
            m_ort = ort;
            m_thema = thema;
        }
	
		public int GetTag() /// method
		{
			return m_tag;
		}

		public int GetMonat() /// method
		{
			return m_monat;
		}

		public int GetJahr() /// Methode
		{
			return m_jahr;
		}

        public string GetOrt() /// method
		{
            return m_ort;
        }

        public string GetThema() /// method
		{
            return m_thema;
        }

        public void UpdateTag(int tag) /// method
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			m_tag = tag;
		}

		public void UpdateMonat(int monat) /// method
		{
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			m_monat = monat;
		}

		public void UpdateJahr(int jahr) /// Methode
		{
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");
			m_jahr = jahr;
		}

        public void BeraterZuTerminEintragen(int Beraternummer) /// method
		{
            m_zugeteilterberater = Beraternummer;
        }

    }
}

