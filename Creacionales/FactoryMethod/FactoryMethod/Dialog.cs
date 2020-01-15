using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Dialog : IButton
    {

        public abstract IButton CreateButton();

        public string onClick()
        {
            return "OnClick";
        }

        public string Render()
        {
            return "Render";
        }
    }
}
