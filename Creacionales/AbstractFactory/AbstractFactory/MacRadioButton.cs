using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MacRadioButton : IRadioButton
    {
        public string UsefulFunctionRadioButton()
        {
            return "The result of the MacRadioButton.";
        }
    }
}
