using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CommerceRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}