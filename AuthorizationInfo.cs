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
        [DataMember]
        public bool? ExtendedBINInformation { get; set; }
        [DataMember]
        public bool? UniqueIDInformation { get; set; }
    }
}