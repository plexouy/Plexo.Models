using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum ReferenceType
    {
        [EnumMember]
        PlexoTransactionId,
        [EnumMember]
        ClientReferenceId
    }
}