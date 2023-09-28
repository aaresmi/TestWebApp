using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Car.Utilities
{
   internal static class ErrorLogger
   {

      private static StreamWriter writer;

       public static void WriteToLog(string errorMessage, Exception innerException)
       {
        

         using(writer=new StreamWriter(@"c:\users\m1023130\documents\visual studio 2010\Projects\CarSolution\ErrorLogFile.txt",true))
         {

             if (writer!=null)
	{
		 if (errorMessage!=null)
	{
             writer.WriteLine(errorMessage);
		 
	}

    else
	{
                writer.WriteLine("No error message found");
	}

                 if (innerException!=null)
	{
                     writer.WriteLine(innerException.ToString());
		 
	}

                 else
	{
                     writer.WriteLine("No inner exception found");
	}

	}

             //writer.Flush();
             //writer.Close();


         }



       }

       
    
   }
}
