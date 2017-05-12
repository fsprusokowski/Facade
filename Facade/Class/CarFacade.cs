using System;

namespace Facade.Class
{
    class CarFacade
    {
        private WheelSystem Wheel { get; set; }
        private AccelerationSystem Acc { get; set; }
        private FuelSystem Fuel { get; set; }

        public CarFacade()
        {
            Wheel = new WheelSystem();
            Acc = new AccelerationSystem();
            Fuel = new FuelSystem();
        }

        public void Startup()
        {
            Console.WriteLine(Fuel.GetFuelPercentOnStartup());
            Console.WriteLine(Wheel.UnlockSystem());
        }

        public void PressAccPedal()
        {
            Console.WriteLine(Acc.Accelerate());
        }
    }
}
