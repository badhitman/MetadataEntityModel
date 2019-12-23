using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MetadataEntityModel.Models
{
    [DataContract]
    public class BitcoinAverageConvertModel
    {
        [DataMember]
        public bool success { get; set; }

        [DataMember]
        public double price { get; set; }

        [DataMember]
        public string time { get; set; }
    }
}
