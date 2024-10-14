using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class ThreeDSValidation
    {
        [DataMember]
        public string ClientReferenceId { get; set; }
        [DataMember]
        public string InstrumentToken { get; set; }
        [DataMember]
        public int CommerceId { get; set; }
        [DataMember]
        public string Indicator { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public string RedirectUrl { get; set; }
        [DataMember]
        public string CallbackUrl { get; set; }
    }
}
