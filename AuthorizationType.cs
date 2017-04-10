using System.Runtime.Serialization;

namespace Goova.Plexo
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
