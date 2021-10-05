using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CommerceField
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public FieldType Type { get; set; }
    }
}