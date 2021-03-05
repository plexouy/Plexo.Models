using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class RefundRequest : Reference
    {
        [DataMember]
        public string ClientReferenceId { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public int? OptionalClientId { get; set; }
    }
}