using System;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
                /// Anlegen von Instanzen der Klassen
                var termine = new Termin[] { };
                var consultants = new Consultant[] { };
                var clients = new Client[] { };

                /// Abfrage, ob Daten aus einem File geladen werden sollen, oder Standarddaten
                Console.WriteLine("Programmstart. Wollen Sie Standarddaten laden. (y/n) ");
                var select = Console.ReadLine();
                if (select == "y" || select == "Y")
                {
                    termine = new Termin[]
                        {
                        new Termin(12, 10, 2016, "Salzburg","Projekt Zentaurus",1001),
                        new Termin(14, 10, 2016, "Wien", "Projekt Alpha",1002),
                        new Termin(15, 10, 2016, "Linz", "Projekt Sunshine",1002),
                        new Termin(18, 10, 2016, "Salzburg", "Projekt Zentaurus",1001),
                        new Termin(03, 11, 2016, "Wien", "Projekt Alpha",1002),
                        new Termin(04, 11, 2016, "Wels", "Projekt Mozart",1003),
                        new Termin(08, 11, 2016, "Innsbruck", "Projekt Epsilon",1003),
                        new Termin(12, 12, 2016, "Salzburg", "Projekt Zentaurus",1001),
                        };
                    consultants = new Consultant[]
                        {
                        new Consultant("Horst", "Maier", new DateTime(1980, 04, 15), "horst.maier@conpro.at", "+43 664 2380032", "Horsti", "Initial01", 1000),
                        new Consultant("Max", "Hendel", new DateTime(1975, 10, 14), "max.hendel@conmain.at", "+43 664 4376542", "Maxi", "Initial01", 1001),
                        new Consultant("Verena", "Schmid", new DateTime(1983, 09, 11), "verena.schmid@experteer.at", "+43 664 5435341", "Verena.S", "Initial01", 1002),
                        };
                    clients = new Client[]
                        {
                        new Client("Karl", "Mueller", new DateTime(1981, 03, 15), "karl.m@gmx.at", "+43 664 2345032", "Karl81", "Initial01",81000),
                        new Client("Iris", "Becker", new DateTime(1974, 12, 14), "i.becker@chello.at", "+43 664 4323252", "Iris74", "Initial01", 81001),
                        };

                }


                string input; // variable für Switch
                int a = 0;

                while (a != 7)
                {

                    Console.Clear();
                    Console.WriteLine(
                        "Please select:" + Environment.NewLine + 
                        "1 - show all appointments" + Environment.NewLine + 
                        "2 - show all consultants" + Environment.NewLine +
                        "3 - show all clients" + Environment.NewLine +
                        "4 - serialize+save" + Environment.NewLine + 
                        "5 - load+deserialize" + Environment.NewLine +
                        "6 - Qualification zu Consultant hinzufuegen" + Environment.NewLine +
                        "7 - exit program ");
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
                            foreach (var x in clients)
                            {
                                x.PrintAllData();
                            }
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 4:
                            Serialize.RunT(termine);
                            Console.ReadKey();
                            Serialize.RunCo(consultants);
                            Console.ReadKey();
                            Serialize.RunCl(clients);
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 5:
                            termine = Deserialize.DeserialisierungT();
                            Console.ReadKey();
                            consultants = Deserialize.DeserialisierungCo();
                            Console.ReadKey();
                            clients = Deserialize.DeserialisierungCl();
                            Console.WriteLine("Press enter to continue!");
                            Console.ReadKey();
                            break;
                        case 6:
                            foreach (var x in consultants)
                            {
                                x.PrintAllData();
                            }
                            Console.WriteLine("Beraternummer eingeben: ");
                            select = Console.ReadLine();
                            a = Int32.Parse(select);
                            foreach (var x in consultants)
                            {
                                if (x.Beraternummer == a)
                                {
                                    Console.WriteLine("Welche Qualifikation?: ");
                                    var quali = Console.ReadLine();
                                    x.AddQualification(quali);
                                }
                            }
                            break;
                        case 7:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("No valid selection!");
                            break;
                    }
                }

            }
			catch (Exception e)
			{
				Console.WriteLine("Es ist ein Fehler passiert: " + e.Message);
			}
		}
	}
}
