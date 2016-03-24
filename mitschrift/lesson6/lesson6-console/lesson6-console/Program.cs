
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace ConsoleApplication1
{
    static class Program

    {

        /* static IEnumerable<int> N()
        {
            int i = 1;
            while (i<10000) yield return i++;
        }

        //static List<R> Map<T,R>(this IEnumerable<T> xs, Func<T, R> f)
        /*static IEnumerable<R> Map<T,R> (this IEnumerable<T> xs, Func<T, R> f)
        {

            // var rs = new List<R>();
            foreach (var x in xs)
            {
                yield return f(x); // yield return gibt einen Wert aus Sequenz zurück
                //  rs.Add(f(x));
            }
            //return rs;
            
        }*/

        static void Main(string[] args)
        {

            /*
            var w = new Form() { Text = "Lesson6", Width = 800, Height = 600 };

            w.MouseMove += (sender,eventArgs) => Console.WriteLine($"[MounseMove event] ({ eventArgs.X},{eventArgs.Y})");

            Application.Run(w);
            */

            {
                byte[] data = null;
                WebClient client = new WebClient();
                client.DownloadDataCompleted +=
                    delegate (object sender, DownloadDataCompletedEventArgs e)
                    {
                        data = e.Result;
                    };
                Console.WriteLine("starting...");
                client.DownloadDataAsync(new Uri("http://stackoverflow.com/questions/"));
                while (client.IsBusy)
                {
                    Console.WriteLine("\twaiting...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("done. {0} bytes received;", data.Length);
            }

            /*var w = new Form() { Text = "Lesson 7", Width = 800, Height = 600 };
            w.MouseMove += (sender, e) => Console.WriteLine(e.Location);

            //var moves = Observable.FromEventPattern<MouseEventArgs>(w, "MouseMove");

            var values= moves
                .select(x => x.EventArgs.Location)
                .Where(x => x.X > 400)
                .Subscribe(x => Console.WriteLine(x))
                ;
                */

            // Application.Run(w);

            /*
            var xs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            //var ys = xs.Map(x => "Hallo " + x);

            var ys = N()                 // Das entspricht einer Pipeline!
                .AsParallel()           // Schalter für die Parallelisierung aller folgenden Operationen
                // .Where(x => x >5)      // Befehle sind in System.Linq abgebildet/gesammelt!
                .Select(x => "Hallo " + x);
                // .Take(2);
                
            foreach (var y in ys) Console.WriteLine(y);

            /*
            foreach(var x in xs)
            {
                Console.WriteLine(x);
            }
            */
            // diese beiden Dinge sind ident!
            /*
            var e = xs.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            */
        }
    }
}
