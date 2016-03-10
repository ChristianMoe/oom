/// <summary>
/// Christian Mödlhammer - Task 3 OOM - Erweiterung von Task2
/// </summary>

using System;
using Newtonsoft.Json;

namespace Task2
{	
	public class Termin : IAllData
	{

        /// <summary>
        /// Fields für Termin
        /// </summary>
        private string m_thema;
		private string m_ort;
        
        /// <summary>
        /// Auto Properties for Class Termin
        /// </summary>
        public int m_zugeteilterberater { get; set;}
        public int m_zugeteilterclient { get; set;}
        public int Tag { get; set; }
        public int Monat { get; set; }
        public int Jahr { get; set; }

        public void PrintAllData()
        {
            Console.WriteLine("{0}.{1}.{2}, {3}, {4}, {4}, {4}", GetTag(), GetMonat(), GetJahr(), GetOrt(), GetThema(), m_zugeteilterberater,m_zugeteilterclient);
        }

        /// <summary>
        /// Property für Ort
        /// </summary>
        public string Ort
        {
			get {return m_ort;}
			set {m_ort=value;}
		}

        /// <summary>
        /// Property für Thema
        /// </summary>
        public string Thema
        {
            get {return m_thema;}
			set {m_thema=value;}
		}
        
        /// <summary>
        /// Constructor for Termin
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="monat"></param>
        /// <param name="jahr"></param>
        /// <param name="ort"></param>
        /// <param name="thema"></param>
        /// <param name="beraternummer"></param>

        [JsonConstructor]
        public Termin (int tag,int monat,int jahr, string ort, string thema, int beraternummer) 
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");

			Tag = tag;
			Monat = monat;
			Jahr = jahr;
            m_ort = ort;
            m_thema = thema;
            m_zugeteilterclient = beraternummer;
        }

        
        /// <summary>
        /// Method returns Tag
        /// </summary>
        /// <returns>int Value of Tag</returns>
        public int GetTag() 
		{
			return Tag;
		}
        /// <summary>
        /// Method returns Monat 
        /// </summary>
        /// <returns>int Value of Monat</returns>
		public int GetMonat() 
		{
			return Monat;
		}
        /// <summary>
        /// Method returns Jahr 
        /// </summary>
        /// <returns>int Value of Jahr</returns>
        public int GetJahr()
		{
			return Jahr;
		}
        /// <summary>
        /// Method returns Ort
        /// </summary>
        /// <returns>string Value of Ort</returns>
        public string GetOrt()
		{
            return Ort;
        }
        /// <summary>
        /// Method returns Thema
        /// </summary>
        /// <returns>string Value of Thema</returns>
        public string GetThema() 
		{
            return Thema;
        }
        /// <summary>
        /// Sets and checks value of Tag
        /// </summary>
        /// <param name="tag"></param>
        public void UpdateTag(int tag) /// method
		{
			if ((tag<1)||(tag>31)) throw new Exception("kein gültiger Tag!");
			Tag = tag;
		}
        /// <summary>
        /// Sets and checks value of Monat
        /// </summary>
        /// <param name="monat"></param>
		public void UpdateMonat(int monat) /// method
		{
			if ((monat<1)||(monat>12)) throw new Exception("kein gültiger Monat!");
			Monat = monat;
		}
        /// <summary>
        /// Sets and chekcs value of Jahr
        /// </summary>
        /// <param name="jahr"></param>
        public void UpdateJahr(int jahr) /// Methode
		{
			if (jahr<2016) throw new Exception("kein Datum nach 2015 eingegeben!");
			Jahr = jahr;
		}
        
    }
}

