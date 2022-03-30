using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class BuiltInPagesOptionsDto
    {
        [DataMember]
        public bool? CheckoutSuccessPage { get; set; }
        [DataMember]
        public bool? CheckoutErrorPage { get; set; }
    }
}
