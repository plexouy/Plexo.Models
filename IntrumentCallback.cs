using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class IntrumentCallback
    {
        [DataMember]
        public string SessionId { get; set; }
        [DataMember]
        public string Client { get; set; }
        [DataMember]
        public ActionType Action { get; set; }
        [DataMember]
        public PaymentInstrument PaymentInstrument { get; set; }
	    [DataMember]
	    public string OptionalMetadata { get; set; }
    }
}
