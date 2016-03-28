using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Net;

namespace Task6
{

    public static class Messwerte
    {

        public static async void Run()
        {
            var parts = new string[] { };
            string URLGesamt="";

            var messwert = new Subject<int> ();

            var subscription = messwert
                .Subscribe(x => Console.WriteLine("{0}:  {1}: {2}", DateTime.Now, parts[3], parts[13]));

            Console.WriteLine("Wettercatcher gestartet!");

            for (var i=1; i < 120; i++)
            {

                if ((0 < i) && (i < 10))
                {
                    const string URLPart1 = "http://weather.tuxnet24.de/?id=AUXX000";
                    var Number = (i+1).ToString();
                    URLGesamt = URLPart1 + Number;
                }
                if ((10 <= i) && (i < 100))
                {
                    const string URLPart1 = "http://weather.tuxnet24.de/?id=AUXX00";
                    var Number = (i + 1).ToString();
                    URLGesamt = URLPart1 + Number;
                }
                if ((100 <= i))
                {
                    const string URLPart1 = "http://weather.tuxnet24.de/?id=AUXX0";
                    var Number = (i + 1).ToString();
                    URLGesamt = URLPart1 + Number;
                }

                var url = string.Format(@URLGesamt);
                var data = await new WebClient().DownloadStringTaskAsync(url);
                //parts = data.Split('\n');

                var datatemp = NewsfeedCNN.ToUTF8(data);
                string[] start = { "= " };
                parts = SubStringCut2(datatemp, start, "\n").ToArray();

                System.Threading.Thread.Sleep(1000);
                

                messwert.OnNext(i);
            }
        }

        public static List<string> SubStringCut2(string text, string[] startWord, string endWord)
        {
            var templist = new List<string>();
            string[] parts = text.Split(startWord, StringSplitOptions.RemoveEmptyEntries);
            var j = 0;

            foreach (var x in parts)
            {
                var end = x.IndexOf(endWord);
                if (end > 0)
                {
                    templist.Add(x.Substring(0, end));
                    j++;
                }
            }
            return templist;
        }

    }
}
