using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class PaymentRequest 
    {
        [DataMember]
        public string ClientReferenceId { get; set; }
        [DataMember]
        public PaymentInstrumentInput PaymentInstrumentInput { get; set; }
        [DataMember]
        public List<Item> Items { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public int Installments { get; set; }
        [DataMember]
        public FinancialInclusion FinancialInclusion { get; set; }
        [DataMember]
        public decimal? TipAmount { get; set; }
        [DataMember]
        public int? OptionalCommerceId { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
        [DataMember]
        public string OptionalProvidedCode { get; set; }
        [DataMember]
        public string OptionalExternalPaymentInfo { get; set; }
        [DataMember]
        public bool? IsExpressCheckout { get; set; }
        [DataMember]
        public decimal? LoyaltyProgramAmount { get; set; }
        [DataMember]
        public string ThreeDSReferenceId { get; set; }
    }
}