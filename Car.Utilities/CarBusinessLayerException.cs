using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car.Utilities
{
   public class CarBusinessLayerException:ApplicationException
    {


       public CarBusinessLayerException()
       {
           ErrorLogger.WriteToLog("Some error occured", null);
       }


       public CarBusinessLayerException(string errorMessage):base(errorMessage)
       {
           ErrorLogger.WriteToLog(errorMessage, null);
       }

       public CarBusinessLayerException(string errorMessage, Exception innerException)
           : base(errorMessage,innerException)
       {
           ErrorLogger.WriteToLog(errorMessage, innerException);
       }


    }
}
