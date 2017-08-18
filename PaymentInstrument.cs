using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class PaymentInstrument
    {
        [DataMember]
        public string InstrumentToken { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IssuerInfo Issuer { get; set; }
        [DataMember]
        public List<Currency> SupportedCurrencies { get; set; }
        [DataMember]
        public CardStatus Status { get; set; }
        [DataMember]
        public long InstrumentExpirationUTC { get; set; }
        [DataMember]
        public int? AnonInstrumentUsageTimeLimit { get; set; }
        [DataMember]
        public List<AmountLimit> CreditLimits { get; set; }
        [DataMember]
        public List<TimeLimit> AdditionalRequirements { get; set; }
        [DataMember]
        public Dictionary<FieldType,string> InstrumentInformation { get; set; }
        [DataMember]
        public string SessionCreationId { get; set; }
    }


}