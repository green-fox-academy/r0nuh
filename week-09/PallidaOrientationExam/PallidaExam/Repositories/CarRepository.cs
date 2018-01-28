using PallidaExam.Entities;
using PallidaExam.Models;
using System.Collections.Generic;
using System.Linq;

namespace PallidaExam.Repositories
{
    public class CarRepository
    {
        private CarContext carContext;

        public CarRepository(CarContext carContext)
        {
            this.carContext = carContext;
        }

        public List<Car> GetCar()
        {
            return carContext.Cars.ToList();
        }

        public List<Car> FilterPlates(string platenumber)
        {
            return carContext.Cars.Where(car => car.LicencePlate.Contains(platenumber)).ToList();
        }
    }
}
