using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
    class Serialize
    {
        public static void Run(Termin[] items)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

            // Abfrage ob gespeichert werden soll.
            Console.WriteLine("Serialisierung durchgeführt. Wollen Sie speichern? (y/n) ");
            var select = Console.ReadLine();
            if (select=="y"|| select=="Y")
            {
                var text = JsonConvert.SerializeObject(items, settings);
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Console.WriteLine("Bitte Filename eingeben: ");
                var fn = Console.ReadLine();
                var filename = Path.Combine(desktop, fn);
                File.WriteAllText(filename, text);
            }
            

        }
    }
}
