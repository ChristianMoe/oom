using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
    class Deserialize
    {
        public static Termin[] Deserialisierung()
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine("Bitte Filename eingeben: ");
            var fn = Console.ReadLine();
            var filename = Path.Combine(desktop, fn);
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Termin[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) x.PrintAllData();
            return itemsFromFile;
        }
    }
}