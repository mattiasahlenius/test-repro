using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press q to quit... ");

            Task.Factory.StartNew(
                () =>
                {
                    while (true)
                    {
                        Console.WriteLine(DateTime.Now);
                        Task.Delay(1000).Wait();
                    }
                });

            while (!(Console.ReadKey().KeyChar == 'q' || Console.ReadKey().KeyChar == 'w')) ;


        }
    }
}
