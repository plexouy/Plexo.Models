using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Reference
    {        
        [DataMember]
        public ReferenceType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
    }
}