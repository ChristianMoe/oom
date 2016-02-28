using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{

                var termine = new Termin[]
                {
                    new Termin(12, 10, 2016, "Salzburg","Projekt Zentaurus"),
                    new Termin(14, 10, 2016, "Wien", "Projekt Alpha"),
                    new Termin(15, 10, 2016, "Linz", "Projekt Sunshine"),
                    new Termin(18, 10, 2016, "Salzburg", "Projekt Zentaurus"),
                    new Termin(03, 11, 2016, "Wien", "Projekt Alpha"),
                    new Termin(04, 11, 2016, "Wels", "Projekt Mozart"),
                    new Termin(08, 11, 2016, "Innsbruck", "Projekt Epsilon"),
                    new Termin(12, 12, 2016, "Salzburg", "Projekt Zentaurus"),
                };

                var consultants = new Consultant[]
                {
                    new Consultant("Horst","Maier",new DateTime(1980,04,15),"horst.maier@conpro.at","+43 664 2380032", 0001),
                    new Consultant("Max","Hendel",new DateTime(1975,10,14),"max.hendel@conmain.at","+43 664 4376542", 0002),
                    new Consultant("Verena","Schmid",new DateTime(1983,09,11),"verena.schmid@experteer.at","+43 664 5435341", 0003),
                };

                string input; // variable für Switch
                int a = 0;

                while (a != 4)
                {

                    Console.Clear();
                    Console.WriteLine("Please select:" + Environment.NewLine + "1 - show all appointments" + Environment.NewLine + "2 - show all consultants" + Environment.NewLine + "3 - add consultant to appointment" + Environment.NewLine + "4 - exit program ");
                    input = Console.ReadLine();
                    a = Int32.Parse(input);
                    Console.WriteLine(Environment.NewLine);

                    switch (a)
                    {
                        case 1:
                            foreach (var x in termine)
                            {
                                x.PrintAllData();
                            }
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 2:
                            foreach (var x in consultants)
                            {
                                x.PrintAllData();
                            }
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("function not yet implemented");
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No valid selection!");
                            break;
                    }
                }

              

              


                /*
                mytermin.Ort = "Salzburg";
                mytermin.Thema = "Projekt Zentaurus";
                Console.WriteLine ("Am {0}.{1}.{2} findet in {3} der Termin {4} statt.", mytermin.GetTag(),mytermin.GetMonat(),mytermin.GetJahr(), mytermin.Ort,mytermin.Thema);

				mytermin.UpdateTag(14);
				mytermin.UpdateMonat(11);
				mytermin.UpdateJahr(2016);
			
				Console.WriteLine ("Aktualisiert: Am {0}.{1}.{2} findet in {3} der Termin {4} statt.", mytermin.GetTag(),mytermin.GetMonat(),mytermin.GetJahr(), mytermin.Ort,mytermin.Thema);
			    */
            }
			catch (Exception e)
			{
				Console.WriteLine("Es ist ein Fehler passiert: " + e.Message);
			}
		}
	}
}
