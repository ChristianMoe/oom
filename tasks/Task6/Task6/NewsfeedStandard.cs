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
    public static class NewsfeedStandard
    {

        public static async void Run()
        {
           
            var headline = new Subject <string>();

            var subscription = headline
            //.Where(x => x.Contains("Anschlag"))
            .Subscribe(x => Console.WriteLine("{0}:  {1}",DateTime.Now, x));

            Console.WriteLine("Standard Newscatcher gestartet!");
            while (true)
            {
                var url = string.Format(@"http://derStandard.at/?page=rss&ressort=Seite1");
                //var data = new WebClient().DownloadString(url);
                var data = await new WebClient().DownloadStringTaskAsync(url);

                var output = ToUTF8(data);

                string[] start = { "<title>" };
                List<string> headlines = SubStringCut2(output,start,"</title>");
              
                foreach (var x in headlines)
                {
                    headline.OnNext(x.ToString());
                    System.Threading.Thread.Sleep(3000);
                }

            }
        }
        
        public static List<string> SubStringCut2(string text, string[] startWord, string endWord)
        {
            var newslist = new List<string>();
            string[] parts = text.Split(startWord, StringSplitOptions.RemoveEmptyEntries);
            var j = 0;

            foreach (var x in parts)
            {
                var end = x.IndexOf(endWord);
                if (end > 0)
                {
                    newslist.Add(x.Substring(0, end));
                    j++;
                }
            }
            return newslist;
        }

        public static string ToUTF8(string text)
        {

            byte[] dataoriginal = Encoding.Default.GetBytes(text);
            string output = Encoding.UTF8.GetString(dataoriginal);

            return output;
        }

    }
}

