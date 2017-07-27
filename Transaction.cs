using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public string TransactionId { get; set; }
        [DataMember]
        public string ReferenceId { get; set; }
        [DataMember]
        public string Authorization { get; set; }
        [DataMember]
        public string Ticket { get; set; }
        [DataMember]
        public string InstrumentName { get; set; }
        [DataMember]
        public IssuerInfo Issuer { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public FinancialInclusionResult FinancialInclusion { get; set; }
        [DataMember]
        public TransactionResult Status { get; set; }
        [DataMember]
        public int TransactionCode { get; set; }
        [DataMember]
        public string TransactionResultText { get; set; }
    }
}