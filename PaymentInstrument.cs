using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Goova.Plexo
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
        public DateTime InstrumentExpiration { get; set; }
        [DataMember]
        public int? AnonInstrumentUsageTimeLimit { get; set; }
        [DataMember]
        public List<CreditLimit> CreditLimits { get; set; }
        [DataMember]
        public List<TimeLimit> AdditionalRequirements { get; set; }
    }


}