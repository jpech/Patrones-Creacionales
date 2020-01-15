using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder : IBuilder
    {
        public Car car { get; set; }

        public CarBuilder()
        {
            car = new Car();
        }

        public void Reset()
        {
            car.ListaPasos.Add("Reset...");
        }

        public void setEngine(Engine engine)
        {
            engine.TipoMotor = "V-6";
        }

        public void setGPS()
        {
            car.ListaPasos.Add("Set GPS...");
        }

        public void setSeats(int number)
        {
            car.ListaPasos.Add(string.Format("{0}{1}{2}", "Set ", number, " Seats "));
        }

        public void setTripComputer()
        {
            car.ListaPasos.Add("Set Trip Computer...");
        }

        public Car getResults()
        {
            return car;
        }
    }
}
