﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WinButton : IButton
    {
        public string UsefulFunctioButton()
        {
            return "The result of the WinButton";
        }
    }
}
