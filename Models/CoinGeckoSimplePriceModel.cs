using System;
using System.Runtime.Serialization;

namespace MetadataEntityModel.Models
{
    [DataContract]
    public class CoinGeckoSimplePriceModel
    {
        [DataMember]
        public CoinGeckoSimpleValueModel bitcoin { get; set; }

        public DateTime time { get; set; }
    }

    [DataContract]
    public class CoinGeckoSimpleValueModel
    {
        [DataMember]
        public double rub { get; set; }
    }
}