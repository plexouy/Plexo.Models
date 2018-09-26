using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class BlacklistRequest
    {
        [DataMember]
        public string InstrumentToken { get; set; }

        [DataMember]
        public string Reason { get; set; }

        [DataMember]
        public string OptionalUserName { get; set; }
    }
}
