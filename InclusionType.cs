using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum InclusionType
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Law17934 = 1,
        [EnumMember]
        Law18083 = 2,
        [EnumMember]
        Law18910 = 3,
        [EnumMember]
        Law18999 = 4,
        [EnumMember]
        Law19210 = 6
    }
}