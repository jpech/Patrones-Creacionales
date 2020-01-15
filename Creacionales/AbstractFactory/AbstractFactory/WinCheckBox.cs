using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WinCheckBox : ICheckBox
    {
        public string UsefulFunctionCheckBox()
        {
            return "The result of the WinCheckBox.";
        }
    }
}
