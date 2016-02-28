using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
	class Person
	// abstract class Person   --> abstrakte Classen und Funktionen. Wenn nur noch das, dann auch Codewort interface möglich. Damit muss abstract bei den Funktionen nicht mehr dabei stehen!
	// IN C# beginnen Interfaces immer mit I z.B. IInterfacename
	{
		public string Name { get; }
		public string EMail { get; }
	
		// public abstract void DoSomethingCool()


		public virtual void DoSomethingCool()
		{
			Console.WriteLine ("doing cool stuff .....");
		}
	}

	class Kunde : Person // Vererbung!
	{
		public int BonusPunkte { get; }
	
		public override void DoSomethingCool()
		{
			Console.WriteLine ("doing something else .....");
		}
	}

	class Angestellter : Person
	{
		public int SVN { get; }
	}



	class Program
	{
		
		//public string Name => "Maierhofer";  // Read only Property
		//{
		//	get {return "Maierhofer";}
		//}


		//static int Sqr(int x)
		//		{
		//	return x * x;
		//}

		//static int PlusOne(int x)
		//{
		//			return x + 1;
		//		}



		//		static R[] Map<T,R>(T[] data, Func<T,R> f)   // T ist Platzhalter für Inputdatentyp, R Paltzhalter für Rückgabewer
		//{

		//	var result = new R[data.Length];
		//	for (var i=0; i<data.Length; i++)
		//	{
		//		result [i] = f (data [i]);
		//	}
		//	return result;
		}
		public static void Main (string[] args)
		{
			var k = new  
			
		//	var xs = new[] { 1.0, 2, 3, 4, 5, 6, 7, 8, 9 };

		//	var ys = Map (xs, Sqr);
		//	var ms = Map (xs, x => x * x);	// Lambda Expression

		//	var vs = Map (xs, x => x + 1);  // Lambda Expression
		//	var zs = Map (xs, PlusOne);

		//	var ns = Map (xs, x => "Hallo" + x);


			//	var x = Math.Sin (Math.PI / 2);

			//	Action<string> log=Console.WriteLine; // erhält nur einen Wert und führt eine Aktion aus
			//	Func<double,double> f = Math.Sin; //Funktion wir eine variable f zugewiesen
	
			//	Console.WriteLine(5)
			//	log ("Hallo");
		}


	}
}
