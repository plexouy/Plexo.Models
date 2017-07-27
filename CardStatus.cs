using System.Runtime.Serialization;

namespace Plexo
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
        Disabled,
        [EnumMember]
        WaitingForConfirmation
    }
}