using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class ExpressCheckoutRequest
    {
        [DataMember]
        public Authorization AuthorizationData { get; set; }

        [DataMember]
        public PaymentRequest PaymentData { get; set; }
    }
}
