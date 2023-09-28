using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Car.DataAccessLayer;

namespace Car.DAOFactories
{
    public class CarDAOFactory
    {
        private static CarDAOFactory carFactory = new CarDAOFactory();
        //private static CarDAOFactory carFactory = null;

        private CarDAOFactory()
        {

        }

        public static CarDAOFactory CreateFactory()
        {
            //if (carFactory == null)
            //{
            //    carFactory = new CarDAOFactory();

            //    return carFactory;

            //}

            //else
            //{
            //    return null;
            //}


            return carFactory;
        }


        public ICarDAO CreateCardDAO()
        {
            ICarDAO carDAOObjRef = new CarDAO();
            return carDAOObjRef;
        }

    }
}
