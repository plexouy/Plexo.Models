using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class ThreeDSSession
    {
        [DataMember]
        public string SessionId { get; set; }

        [DataMember]
        public string RedirectUrl { get; set; }

        [DataMember]
        public bool IsRequired { get; set; }
    }
}
