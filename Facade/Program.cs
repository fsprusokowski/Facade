using System;
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
