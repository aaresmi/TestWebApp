using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.BusinessLayer
{
    public interface ICarManager
    {
        List<Entities.Car> RetrieveAllCars();
        List<Car.Entities.Car> RetrieveAllCarsDetails(int CarId);
        bool AddACar(Car.Entities.Car car);

    }
}
