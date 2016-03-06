using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Filename
    {
        /* War nur eine Idee ... läuft noch nicht
        public static string Eingabe()
        {
            //Anzeigen der Filenamen im Directory
            Auflisten();
            var filename = "items.json";
            return filename;
        }

        static void Auflisten()
        {
            try
            {
               var files = from file in Directory.EnumerateFiles (Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*", SearchOption.All)
                           from line in File.ReadLines(file)
                           where line.Contains("*")
                           select new
                           {
                                File = file,

                                Line = line
                           };

                foreach (var f in files)
                {
                    Console.WriteLine("{0}", f.File);
                }
                Console.WriteLine("{0} files found.", files.Count().ToString());
            }
            catch (UnauthorizedAccessException UAEx)
            {
                Console.WriteLine(UAEx.Message);
            }
            catch (PathTooLongException PathEx)
            {
                Console.WriteLine(PathEx.Message);
            }
        }*/
    }
}
