using System;

namespace lesson2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try 
			{
				var a = new Buch ("DFS",9.90m,Currency.EUR); //m Kürzel für typecast auf dezimal.
				Console.WriteLine (a.GetPreis (Currency.USD));
			} catch (Exception e) 
			{
				Console.WriteLine("Es ist etwas passiert: " + e.Message);
			}
		}
	}
}
