using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public Car()
        {
            ListaPasos = new List<string>();
        }

        public List<string> ListaPasos { get; set; }
    }
}
