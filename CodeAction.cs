using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public enum CodeAction
    {
        [EnumMember]
        Query,
        [EnumMember]
        Pay,
        [EnumMember]
        Deny,
        [EnumMember]
        EndCancelation,
        [EnumMember]
        Void
    }

    [DataContract]
    public class PaymentCode
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Url { get; set; }

    }
}
