using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public void MakeSUV (IBuilder builder)
        {
            Engine engine = new Engine();
            builder.Reset();
            builder.setSeats(4);
            builder.setEngine(engine);
            builder.setTripComputer();
            builder.setGPS();
        }

        public void MakeSportsCars(IBuilder builder)
        {
            Engine engine = new Engine();
            builder.Reset();
            builder.setSeats(2);
            builder.setEngine(engine);
            builder.setTripComputer();
            builder.setGPS();
        }

    }
}
