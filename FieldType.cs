using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace Plexo
{
    [DataContract]
    public enum FieldType
    {
	//User Generic Information
        [EnumMember] Pan,
        [EnumMember] Expiration,
        [EnumMember] Pin,
        [EnumMember] CVC,
        [EnumMember] Name,
        [EnumMember] Address,
        [EnumMember] ZipCode,
        [EnumMember] Email,
        [EnumMember] Phone,
        [EnumMember] Cellphone,
        [EnumMember] AmountLimitExtension,
        [EnumMember] Birthdate,
        [EnumMember] InstrumentName,
        [EnumMember] IdentificationType, // 0 - CI , 1 - Pasaport, 3 Otros
        [EnumMember] Identification,
        [EnumMember] IdentificationTypeExtended,// 0 - CI , 1 - Pasaport, 3 Otros, 4 RUT
	    //Provider Related Information starts at 1000
	    [EnumMember] Provider=1000,
	    //Commerce Related Information starts at 2000
	    [EnumMember] ProviderCommerceNumber=2000,
	    [EnumMember] OcaTaxiCode,
	    //User/Provider Related Information starts at 3000
        [EnumMember] SistarBankPaymentMethod=3000,
	    [EnumMember] RedPagosProductNumber,
    }
}
