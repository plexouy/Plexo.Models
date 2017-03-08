using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public enum CardStatus
    {
        [EnumMember]
        Ok,
        [EnumMember]
        WarningExpirationInLessThanOneMonth,
        [EnumMember]
        Expired,
        [EnumMember]
        Disabled
    }
}