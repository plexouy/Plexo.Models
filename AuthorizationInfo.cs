using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class AuthorizationInfo
    {
        [DataMember]
        public AuthorizationType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
    }
}