using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class PaymentInstrumentExtended
    {
        [DataMember]
        public string BinInformation { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string UniqueIDInformation { get; set; }
    }


}