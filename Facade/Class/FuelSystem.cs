using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Class
{
    class FuelSystem
    {
        private int PercentFuelRemaining { get; set; }

        public FuelSystem()
        {
            Random rnd = new Random();
            PercentFuelRemaining = rnd.Next(0,100);
        }

        public string GetFuelPercentOnStartup()
        {
            return "The Fuel system is working, getting fuel quantity.";
        }
    }
}
