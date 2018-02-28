using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Transaction
    {
        [DataMember]
        public string TransactionId { get; set; }
        [DataMember]
        public Commerce Commerce { get; set; }
        [DataMember]
        public string InstrumentToken { get; set; }
        [DataMember]
        public string InstrumentName { get; set; }
        [DataMember]
        public IssuerInfo Issuer { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public int Installments { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public bool IsAnonymous { get; set; }
        [DataMember]
        public TransactionType CurrentState { get; set; }
        [DataMember]
        public string InvoiceNumber { get; set; }
        [DataMember]
        public FinancialInclusionResult FinancialInclusion { get; set; }
        [DataMember]
        public Dictionary<TransactionType, TransactionInfo> Transactions { get; set; }
        [DataMember]
        public Dictionary<FieldType, string> FieldInformation { get; set; }
        [DataMember]
        public bool IsAsyncPayment { get; set; }
        [DataMember]
        public PaymentCode PaymentCode { get; set; }
        [DataMember]
        public long UTCUnixTimeExpiration { get; set; }
    }
}
