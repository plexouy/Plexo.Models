using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class TransactionInfo
    {
        [DataMember]
        public string ClientReferenceId { get; set; }
        [DataMember]
        public string ClientMetadata { get; set; }
        [DataMember]
        public TransactionResult Status { get; set; }
        [DataMember]
        public int TransactionCode { get; set; }
        [DataMember]
        public string TransactionResultText { get; set; }
        [DataMember]
        public long ExecutionDateUTC { get; set; }
        [DataMember]
        public string Authorization { get; set; }
        [DataMember]
        public string Ticket { get; set; }
        [DataMember]
        public long? ExpirationUTC { get; set; } //Case Use, when TransactionResult=Pending, or when Opearation is StartReserve

    }
}