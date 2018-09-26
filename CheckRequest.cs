using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
   [DataContract]
   public class CheckRequest 
   {
        [DataMember]
        public string InstrumentToken { get; set; }
        [DataMember]
        public string CardType { get; set; }
        [DataMember]
        public string CvNumber { get; set; }
        [DataMember]
        public int? OptionalCommerceId { get; set; }
        [DataMember]
        public string ClientReferenceId { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string RedirectUri { get; set; }
    }
}
