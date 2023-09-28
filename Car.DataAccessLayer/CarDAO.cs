using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.Utilities;
using Car.Entities;
using System.Data.SqlClient;

namespace Car.DataAccessLayer
{
    public class CarDAO:ICarDAO
    {

        public bool AddACar(Car.Entities.Car car)
        {


            tblCar carTableObj = null;
             try 
	        {
                carTableObj = ConvertCarEntityToCarTable(car, carTableObj);

            
		       using (MCECarEntities carTbl = new MCECarEntities())
                {     
                        
                    if (carTbl!=null)
                    {     
                        carTbl.AddTotblCars(carTableObj);
                       
                        carTbl.SaveChanges();
                    }
                    else
                    {
                        throw new CarDALException(ErrorMessage.CAR_DATA_NOT_FOUND);
                    }
                    


                }

               return true;
	    }
	        catch (CarDALException ex)
	        {

                throw ex;
	        }

            catch(SqlException ex)
             {

                 CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                 throw dalEx;
            }

             catch (Exception ex)
             {

                 CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                 throw dalEx;
             }



        }

        //public List<Entities.Car> RetrieveAllCars()
        //{

        //    Car.Entities.Car carObj;
        //    List<Car.Entities.Car> listOfCars=new List<Entities.Car>();
        //    try
        //    {

        //        using (MCECarEntities carTbl = new MCECarEntities())
        //        {
                    

        //            var carList = carTbl.tblCars.Select(x => x).ToList<tblCar>();
        //            foreach (var item in carList)
        //            {
        //                carObj = new Entities.Car();
        //                Car.Entities.Car car = ConvertCarTableToCarEntity(item, carObj);
        //                listOfCars.Add(car);
        //            }
        //            return listOfCars;
        //        }
                
        //    }
        //    catch (CarDALException ex)
        //    {

        //        throw ex;
        //    }

        //    catch (SqlException ex)
        //    {

        //        CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
        //        throw dalEx;
        //    }

        //    catch (Exception ex)
        //    {

        //        CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
        //        throw dalEx;
        //    }
        //}

      

        /// <summary>
        /// Store procedure implementation to retrieve all cars. This method retrieves all car details from the database. 
        /// </summary>
        /// <returns></returns>

        
        public List<Entities.Car> RetrieveAllCars()
        {

            Car.Entities.Car carObj;
            List<Car.Entities.Car> listOfCars = new List<Entities.Car>();
            try
            {

                using (MCECarEntities carTbl = new MCECarEntities())
                {


                    var carList = carTbl.GetCars();
                    foreach (var item in carList)
                    {
                        carObj = new Entities.Car();
                        Car.Entities.Car car = ConvertCarTableToCarEntity(item, carObj);
                        listOfCars.Add(car);
                    }
                    return listOfCars;
                }

            }
            catch (CarDALException ex)
            {

                throw ex;
            }

            catch (SqlException ex)
            {

                CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                throw dalEx;
            }

            catch (Exception ex)
            {

                CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                throw dalEx;
            }
        }



        public List<Entities.Car> RetrieveAllCarsDetails(int CarId)
        {

            List<Entities.Car> listOfCars=null;
            try
            {
                using (MCECarEntities carTbl = new MCECarEntities())
                {

                    var allCars = carTbl.tblCars.Select(x => x);
                    var carDetails = allCars.Where(x => x.CarId == CarId).FirstOrDefault();
                    Entities.Car carObj = new Entities.Car()
                    {
                      
                        CarId=carDetails.CarId,
                        CarName = carDetails.CarName,
                        ModelNumber = Convert.ToInt32(carDetails.CarModel),
                        Features =  carDetails.Feartures,
                        Comments = carDetails.Comments 
                    };

                    listOfCars = new List<Entities.Car>() { carObj };

                    return listOfCars;
                }
            }
            catch (CarDALException ex)
	        {

                throw ex;
	        }

            catch(SqlException ex)
             {

                 CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                 throw dalEx;
            }

             catch (Exception ex)
             {

                 CarDALException dalEx = new CarDALException(ex.Message, ex.InnerException);
                 throw dalEx;
             }
        }



        //helper class
        #region Helper Methods
        private tblCar ConvertCarEntityToCarTable(Car.Entities.Car car, tblCar carTable)
        {
            carTable = new tblCar()
            {
              
                CarName = car.CarName,
                CarModel = car.ModelNumber,
                Feartures = car.Features.ToString(),
                Comments = car.Comments.ToString()
            };

           return carTable;
        }

        private Car.Entities.Car ConvertCarTableToCarEntity(tblCar carTable, Car.Entities.Car car)
        {
            car = new Car.Entities.Car()
            {
               CarId=carTable.CarId,
               CarName=carTable.CarName,
               ModelNumber=Convert.ToInt32(carTable.CarModel),
               Comments=carTable.Comments,
               Features=carTable.Feartures
            };

            return car;
        }


        #endregion



    }
}
