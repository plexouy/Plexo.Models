using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum AuthorizationType
    {
        [EnumMember]
        ClientReference,
        [EnumMember]
        OAuth,
        [EnumMember]
        Anonymous
    }
}
