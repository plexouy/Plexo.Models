using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Commerce
    {
        [DataMember]
        public int CommerceId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}