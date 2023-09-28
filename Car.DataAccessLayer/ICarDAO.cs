using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.Entities;
using Car.Utilities;

namespace Car.DataAccessLayer
{
   public interface ICarDAO
    {


       List<Entities.Car> RetrieveAllCars();
       List<Car.Entities.Car> RetrieveAllCarsDetails(int CarId);
       bool AddACar(Car.Entities.Car car);

     
    }
}
