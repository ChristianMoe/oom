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
    class Program
    {
        static void Main(string[] args)
        {
            Messwerte.Run();
            NewsfeedStandard.Run();
            NewsfeedCNN.Run();

            Console.Read();
        }
    }
}
