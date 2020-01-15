using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WindowsButton : IButton
    {
        public string onClick()
        {
            return "{Result of WindowsButton}";
        }

        public string Render()
        {
            return "{Result of WindowsButton}";
        }
    }
}
