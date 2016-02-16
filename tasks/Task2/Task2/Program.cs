using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				Termin mytermin = new Termin (12, 10, 2016);
				mytermin.Ort = "Salzburg";
				mytermin.Thema = "Projekt Zentaurus";
				Console.WriteLine ("Am {0}.{1}.{2} findet in {3} der Termin {4} statt.", mytermin.GetTag(),mytermin.GetMonat(),mytermin.GetJahr(), mytermin.Ort,mytermin.Thema);
			
				mytermin.UpdateTag(14);
				mytermin.UpdateMonat(11);
				mytermin.UpdateJahr(2016);
			
				Console.WriteLine ("Aktualisiert: Am {0}.{1}.{2} findet in {3} der Termin {4} statt.", mytermin.GetTag(),mytermin.GetMonat(),mytermin.GetJahr(), mytermin.Ort,mytermin.Thema);
			}
			catch (Exception e)
			{
				Console.WriteLine("Es ist ein Fehler passiert: " + e.Message);
			}
		}
	}
}
