using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.Entities;
using Car.Utilities;
using Car.DAOFactories;
using Car.DataAccessLayer;


namespace Car.BusinessLayer
{
    public class CarManager:ICarManager
    {

        private ICarDAO carDAOObj;
        public CarManager()
        {
            try
            {
                CarDAOFactory carDAOFactoryObj = CarDAOFactory.CreateFactory();
                carDAOObj = carDAOFactoryObj.CreateCardDAO();
                
               
            }

            catch (CarDALException ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            catch (Exception ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

        }
        public List<Entities.Car> RetrieveAllCars()
        {
             List<Entities.Car>  listOfCarNames;
            try
            {
               listOfCarNames= carDAOObj.RetrieveAllCars();
            }
            catch (CarBusinessLayerException ex)
            {
                
                throw ex;
            }

            catch (CarDALException ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            catch (Exception ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

           return listOfCarNames;
        }

        public List<Entities.Car> RetrieveAllCarsDetails(int CarId)
        {
            List<Entities.Car> listOfCars;
            try
            {
                listOfCars = carDAOObj.RetrieveAllCarsDetails(CarId);
            }
            catch (CarBusinessLayerException ex)
            {

                throw ex;
            }

            catch (CarDALException ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            catch (Exception ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            return listOfCars;
            
        }

        public bool AddACar(Entities.Car car)
        {
            bool status = false;
            try
            {
                carDAOObj.AddACar(car);
            }
            catch (CarBusinessLayerException ex)
            {

                throw ex;
            }

            catch (CarDALException ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            catch (Exception ex)
            {

                CarBusinessLayerException balEx = new CarBusinessLayerException(ex.Message, ex.InnerException);
                throw balEx;
            }

            return status;
           
        }
    }
}
