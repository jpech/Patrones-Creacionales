using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class HTMLButton : IButton
    {
        public string onClick()
        {
            return "{Result of HTMLButton}";
        }

        public string Render()
        {
            return "{Result of HTMLButton}";
        }
    }
}
