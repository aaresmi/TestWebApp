using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using Car.BusinessLayer;
using Car.BusinessFactory;
using Car.Utilities;

namespace Car.ServiceLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class CarService : ICarService
    {

        private ICarManager carManagerObj = null;

        public CarService()
        {

            try
            {
                CarBusinessFactory carBusinessFactoryObj=CarBusinessFactory.CreateBLFactory();
                carManagerObj=carBusinessFactoryObj.CreateCarBusinessManager();
            }
            catch (CarBusinessLayerException ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };
                

                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }

        }


        public List<Entities.Car> RetrieveAllCars()
        {
            List<Car.Entities.Car> listOfCars;
            try
            {
              listOfCars= carManagerObj.RetrieveAllCars();

            }
           
            catch (CarBusinessLayerException ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }


            catch (Exception ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }

            return listOfCars;

        }

        public List<Entities.Car> RetrieveAllCarsDetails(int CarId)

        {
            try
            {
                return carManagerObj.RetrieveAllCarsDetails(CarId);
            }

            catch (CarBusinessLayerException ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }


            catch (Exception ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }
        }

        public bool AddACar(Entities.Car car)
        {
            try
            {
               return carManagerObj.AddACar(car);
            }

            catch (CarBusinessLayerException ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }


            catch (Exception ex)
            {
                CarServiceError serviceError = new CarServiceError() { errorMessage = ex.ToString() };


                FaultException<CarServiceError> faulEx = new FaultException<CarServiceError>(serviceError, new FaultReason(ex.Message));
                throw faulEx;
            }
        }
    }
}
