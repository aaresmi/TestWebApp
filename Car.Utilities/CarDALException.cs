using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.Utilities
{
   public class CarDALException:ApplicationException
    {

       
       public CarDALException()
       {
           ErrorLogger.WriteToLog("Some error occured", null);
       }


       public CarDALException(string errorMessage):base(errorMessage)
       {
           ErrorLogger.WriteToLog(errorMessage, null);
       }

       public CarDALException(string errorMessage, Exception innerException)
           : base(errorMessage,innerException)
       {
           ErrorLogger.WriteToLog(errorMessage, innerException);
       }

    }
}
