/// <summary>
/// Christian Mödlhammer - Task 2 OOM
/// </summary>

using System;

namespace Task2
{	
	public class Termin
	{
		private int m_tag; /// private fields
		private int m_monat;
		private int m_jahr;

		private string m_thema;
		private string m_ort;

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


		public Termin (int tag,int monat,int jahr) /// constructor
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");

			m_tag = tag;
			m_monat = monat;
			m_jahr = jahr;
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

	}
}

