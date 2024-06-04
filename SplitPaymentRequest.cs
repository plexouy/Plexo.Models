using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class SplitPaymentRequest
    {
        [DataMember]
        public PaymentRequest MainPaymentRequest { get; set; }
        [DataMember]
        public PaymentRequest SecondaryPaymentRequest { get; set; }
    }
}
