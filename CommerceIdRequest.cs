using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CommerceIdRequest
    {
        [DataMember]
        public int CommerceId { get; set; }
    }
}