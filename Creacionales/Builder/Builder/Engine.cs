using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Engine : IEngine
    {
        private string tipoMotor;
        public string TipoMotor { get { return tipoMotor; } set { tipoMotor = value; } }
    }
}
