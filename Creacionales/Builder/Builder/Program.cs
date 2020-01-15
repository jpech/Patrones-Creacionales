using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            CarManualBuilder builder = new CarManualBuilder();

            director.MakeSportsCars(builder);
            Manual manual = builder.getResults();

            foreach (var item in manual.ListaPasos)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
