using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum TransactionResult
    {
        [EnumMember]
        Ok = 0,
        [EnumMember]
        Started = 1,
        [EnumMember]
        Pending = 2,
        [EnumMember]
        Denied = 10,
        [EnumMember]
        Expired = 20,
        [EnumMember]
        NotProcessed=21,
        [EnumMember]
        UnableToCancel=22,
        [EnumMember]
        IssuerOperationNotSupported=23,
        [EnumMember]
        ExtendedCreditVerificationRequired=100,
        [EnumMember]
        BadArgument=998,
        [EnumMember]
        SystemError = 999 //To Be Completed
    }
}