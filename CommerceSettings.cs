using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CommerceSettings
    {
        [DataMember]
        public IEnumerable<CommerceField> Fields { get; set; }
    }
}