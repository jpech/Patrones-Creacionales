using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarManualBuilder : IBuilder
    {
        public Manual manual { get; set; }

        public CarManualBuilder()
        {
            manual = new Manual();
        }

        public void Reset()
        {
            manual.ListaPasos.Add("Reset...");
        }

        public void setEngine(Engine engine)
        {
            engine.TipoMotor = "V-6";
        }

        public void setGPS()
        {
            manual.ListaPasos.Add("Set GPS...");
        }

        public void setSeats(int number)
        {
            manual.ListaPasos.Add(string.Format("{0}{1}{2}", "Set ", number, " Seats "));
        }

        public void setTripComputer()
        {
            manual.ListaPasos.Add("Set Trip Computer...");
        }

        public Manual getResults()
        {
            return manual;
        }
    }
}
