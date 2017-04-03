using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public enum ResultCodes
    {
        [EnumMember]
        Ok=0,
        [EnumMember]
        ArgumentError,
        [EnumMember]
        InvalidSession,
        [EnumMember]
        SessionExpired,
        [EnumMember]
        TokenExpired,
        [EnumMember]
        MissingPaymentInstrument,
        [EnumMember]
        DuplicateTransaction,
        [EnumMember]
        SystemError,
        [EnumMember]
        ClientServerError,
        [EnumMember]
        DisabledCard,
        [EnumMember]
        ExpiredCard,
        [EnumMember]
        NotFound,
        [EnumMember]
        InvalidFingerprint,
        [EnumMember]
        InvalidSignature,
        [EnumMember]
        MessageExpired,
        [EnumMember]
        InvalidPaymentInstrument,
        [EnumMember]
        CurrencyNotSupportedByInstrument,
        [EnumMember]
        IssuerNotAssociatedWithClientOrIssuerInactive,
        [EnumMember]
        InvalidCurrency,
        [EnumMember]
        InvalidCard,
        [EnumMember]
        ExternalLimitedCard,
        [EnumMember]
        Forbidden,
        [EnumMember]
        InvalidVerification,
        //To Be Completed
    }
}