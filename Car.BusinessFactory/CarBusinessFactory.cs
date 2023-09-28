using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Car.BusinessLayer;

namespace Car.BusinessFactory
{
    public class CarBusinessFactory
    {
        private static CarBusinessFactory carBusinessFactoryObj = new CarBusinessFactory();  

        //private static CarBusinessFactory carBusinessFactoryObj = null;

        private CarBusinessFactory()
        {

        }

        public static CarBusinessFactory CreateBLFactory()
        {
            //if (carBusinessFactoryObj == null)
            //{

            //    carBusinessFactoryObj = new CarBusinessFactory();
            //    return carBusinessFactoryObj;
            //}
            //else
            //{
            //    return null;
            //}

            return carBusinessFactoryObj;

        }

        public ICarManager CreateCarBusinessManager()
        {
            ICarManager carManager = new CarManager();
            return carManager;

        }

    }
}
