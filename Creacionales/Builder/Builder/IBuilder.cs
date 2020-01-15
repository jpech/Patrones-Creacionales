using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        void Reset();

        void setSeats(int number);

        void setEngine(Engine engine);

        void setTripComputer();

        void setGPS();
    }
}
