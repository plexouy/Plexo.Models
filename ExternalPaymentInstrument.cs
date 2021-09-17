using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class ExternalPaymentInstrument
    {
        [DataMember]
        public PaymentInstrument PaymentInstrument { get; set; }

        [DataMember]
        public string URL3DS { get; set; }
    }
}
