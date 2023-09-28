using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Car.ServiceLayer
{
    [DataContract]
    public class CarServiceError
    {

    [DataMember]
        public string errorMessage { get; set; }
    }
}