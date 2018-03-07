using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace Plexo
{
    [DataContract]
    public enum FieldType
    {
        //User Generic Information
        Expiration = 0x0101,
        Name,
        Address,
        ZipCode,
        Email,
        Phone,
        Cellphone,
        AmountLimitExtension,
        Birthdate,
        InstrumentName,
        Identification,
        IdentificationType,                           // 0 - CI , 1 - Pasaport, 3 Otros
        IdentificationTypeExtended,                   // 0 - CI , 1 - Pasaport, 3 Otros, 4 RUT
        AccountNumber,                                //Bank Account Number
        FirstName,
        LastName,
        City,
        //Provider Related Information starts at 0x400
        Provider = 0x0401, //Example Visa

        //User/Provider Related Information starts at 0x500 // User Flag + Provider Flag
        SistarBancPaymentMethod = 0x501,
        RedPagosProductNumber = 0x502,
        RedPagosUserEnabled = 0x503,
        VisaNetUserId = 0x504,
        CardType = 0x505,
        CardIssuer = 0x506,
        CybersourceDeviceFingerprint=0x507,
        ClientIP=0x508,
        IntegerId=0x509,

        //Commerce Related Information starts at 0x800
        ProviderCommerceNumber = 0x801, //This Could be the commerce id (Master/Oca/Visa/Etc)
        OcaTaxiCode = 0x802,
        TerminalNumber = 0x803,
        PosNumber = 0x804,
        ProviderMerchantId = 0x805,
        ProviderBranchNumber = 0x806,
        CommerceReserveExpirationInSeconds=0x807,

        //Secure Information Starts at 0x8100  //Private Flag + User Flag
        //Secure User Generic Information
        Pan = 0x8101,
        Token = 0x8102,
        UniqueId = 0x8103,

        //Non Storable Secure Information 0x80;
        Pin = 0x8181,
        CVC = 0x8182,
    }
}
