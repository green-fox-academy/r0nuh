using System;

namespace petrol_station
{
    class Station
    {
        public int GasAmount { get; set; }

        public Station(int gasAmount)
        {
            GasAmount = gasAmount;
        }

        public void Refill(Car car)
        {
            GasAmount = GasAmount - car.Capacity;
            car.GasAmount = car.Capacity;
        }
    }
}
