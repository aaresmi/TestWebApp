using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Car.Entities
{
    [DataContract]
    public class Car
    {

        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public string CarName { get; set; }

        [DataMember]
        public int ModelNumber { get; set; }

        [DataMember]
        public string Features { get; set; }

        [DataMember]
        public string Comments { get; set; }

    }
}
