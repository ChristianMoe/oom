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
        public static Termin[] DeserialisierungT()
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var desktop = Environment.CurrentDirectory;
            //var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fn = "termine.json";
            var filename = Path.Combine(desktop, fn);
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Termin[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) x.PrintAllData();
            Console.WriteLine("Daten von {0} eingelesen!",filename);
            return itemsFromFile;
        }
        public static Client[] DeserialisierungCl()
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var desktop = Environment.CurrentDirectory;
            //var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fn = "clients.json";
            var filename = Path.Combine(desktop, fn);
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Client[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) x.PrintAllData();
            Console.WriteLine("Daten von {0} eingelesen!", filename);
            return itemsFromFile;
        }
        public static Consultant[] DeserialisierungCo()
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            var desktop = Environment.CurrentDirectory;
            //var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fn = "consultants.json";
            var filename = Path.Combine(desktop, fn);
            var textFromFile = File.ReadAllText(filename);
            var itemsFromFile = JsonConvert.DeserializeObject<Consultant[]>(textFromFile, settings);
            foreach (var x in itemsFromFile) x.PrintAllData();
            Console.WriteLine("Daten von {0} eingelesen!", filename);
            return itemsFromFile;
        }
    }
}