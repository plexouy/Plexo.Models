using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class RefundRequest : Reference
    {
        [DataMember]
        public string ClientReferenceId { get; set; }

        [DataMember]
        public FinancialInclusion FinancialInclusion { get; set; }

    }
}