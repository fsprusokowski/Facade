using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Class;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarFacade();
            car.Startup();
            car.PressAccPedal();
            Console.ReadKey();
        }
    }
}
