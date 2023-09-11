using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class PaymentProcessor
    {
        [DataMember]
        public string Acquirer { get; set; }
    
        [DataMember]
        public List<PaymentProcessorField> Fields { get; set; }
    }
}