using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public enum TokenizationFieldVisibility
    {
        [EnumMember]
        OnlyIfRequired = 0,
        [EnumMember]
        Always = 1,
        [EnumMember]
        Never = 2
    }
}
