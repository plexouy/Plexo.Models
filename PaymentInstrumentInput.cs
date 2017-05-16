using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class PaymentInstrumentInput
    {
        [DataMember]
        public string InstrumentToken { get; set; }
        [DataMember]
        public Dictionary<FieldType,string> NonStorableItems { get; set; }
        [DataMember]
        public bool UseExtendedClientCreditIfAvailable { get; set; }
    }

}