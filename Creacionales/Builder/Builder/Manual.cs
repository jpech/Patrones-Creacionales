using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Manual
    {
        public Manual()
        {
            ListaPasos = new List<string>();
        }

        public List<string> ListaPasos { get; set; }
    }
}
