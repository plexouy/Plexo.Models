using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum ReferenceType
    {
        [EnumMember]
        PlexoTransactionId,
        [EnumMember]
        ClientPurchaseReferenceId,
        [EnumMember]
        ClientCancelReferenceId,
        [EnumMember]
        ClientReserveReferenceId,
        [EnumMember]
        ClientRefundReferenceId,
    }
}