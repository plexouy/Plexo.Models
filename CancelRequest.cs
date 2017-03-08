using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class CancelRequest
    {        
        [DataMember]
        public PaymentInstrumentInput PaymentInstrumentInput { get; set; }
        [DataMember]
        public string TransactionId { get; set; }
        [DataMember]
        public decimal? Amount { get; set; }
    }
}