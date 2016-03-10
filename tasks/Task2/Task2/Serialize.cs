using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Task2
{
    class Serialize
    {
        public static void RunT(Termin[] items)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));


                var text = JsonConvert.SerializeObject(items, settings);
                var desktop = Environment.CurrentDirectory;
                var fn = "termine.json";
                var filename = Path.Combine(desktop, fn);
                File.WriteAllText(filename, text);
                Console.WriteLine("Consultants in {0} gespeichert!", filename);
            
        }
        public static void RunCl(Client[] items)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));


                var text = JsonConvert.SerializeObject(items, settings);
                var desktop = Environment.CurrentDirectory;
                var fn = "clients.json";
                var filename = Path.Combine(desktop, fn);
                File.WriteAllText(filename, text);
                Console.WriteLine("Consultants in {0} gespeichert!", filename);
            
        }
        public static void RunCo(Consultant[] items)
        {
            var settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };
            Console.WriteLine(JsonConvert.SerializeObject(items, settings));

   
                var text = JsonConvert.SerializeObject(items, settings);
                var desktop = Environment.CurrentDirectory;
                var fn = "consultants.json";
                var filename = Path.Combine(desktop, fn);
                File.WriteAllText(filename, text);
                Console.WriteLine("Consultants in {0} gespeichert!", filename);
            
        }
    }
}
