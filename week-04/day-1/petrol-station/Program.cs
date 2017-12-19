using System;

namespace petrol_station
{
    class Program
    {
        static void Main(string[] args)
        {
            var station = new Station(1000);
            var dacia = new Car();

            station.Refill(dacia);

            Console.WriteLine(station.GasAmount);
            Console.Read();
        }
    }
}
