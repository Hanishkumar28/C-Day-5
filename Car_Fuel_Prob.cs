using System;

namespace Day5
{
    class Car : IVehiculo
    {
        public int fuel { get; set; }
        public Car(int _fuel)
            {
                fuel = _fuel;
            }
        public void Drive()
        {
            if(fuel > 0)
            {
                Console.WriteLine("The Car is Driving");
            }
            else
            {
                Console.WriteLine("FuelTank is empty, Car cannot be driven");
            }
        }
        public bool Refuel(int amtofgas)
        {
            fuel = fuel + amtofgas;
            Console.WriteLine("Total fuel amount after refuel : "+fuel);
            return true;
        }
        static void Main()
        {
            Car car1 = new Car(0);
            Console.WriteLine("Enter the fuel : ");
            int fuel = Convert.ToInt32(Console.ReadLine());
            if (car1.Refuel(fuel))
            {
                car1.Drive();
            }
        }
    }
}