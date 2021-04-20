using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public enum InstrumentStatus
    {
        [EnumMember]
        Created,
        [EnumMember]
        Updated,
        [EnumMember]
        Deleted
    }
}
