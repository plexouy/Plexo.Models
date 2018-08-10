using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum TransactionType
    {
        [EnumMember]
        Reserve,
        [EnumMember]
        Purchase,
        [EnumMember]
        Cancel,
        [EnumMember]
        Refund
    }
}