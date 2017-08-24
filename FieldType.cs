using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace Plexo
{
    [DataContract]
    public enum FieldType
    {
	//User Generic Information
     
        [EnumMember] Expiration=0x0101,
        [EnumMember] Name,
        [EnumMember] Address,
        [EnumMember] ZipCode,
        [EnumMember] Email,
        [EnumMember] Phone,
        [EnumMember] Cellphone,
        [EnumMember] AmountLimitExtension,
        [EnumMember] Birthdate,
        [EnumMember] InstrumentName,
        [EnumMember] Identification,
        [EnumMember] IdentificationType, // 0 - CI , 1 - Pasaport, 3 Otros
        [EnumMember] IdentificationTypeExtended,// 0 - CI , 1 - Pasaport, 3 Otros, 4 RUT
        [EnumMember] AccountNumber, //Bank Account Number

	    //Provider Related Information starts at 0x400

	    [EnumMember] Provider=0x401, //Example Visa

        //User/Provider Related Information starts at 0x500 // User Flag + Provider Flag

        [EnumMember] SistarBancPaymentMethod = 0x501,
        [EnumMember] RedPagosProductNumber = 0x502,
        [EnumMember] RedPagosUserEnabled = 0x503,



        //Commerce Related Information starts at 0x800

        [EnumMember] ProviderCommerceNumber=0x801, //This Could be the commerce id (Master/Oca/Visa/Etc)
        [EnumMember] OcaTaxiCode=0x802,
	    [EnumMember] TerminalNumber=0x803,
        [EnumMember] PosNumber=0x804,


        //Secure Information Starts at 0x8100  //Private Flag + User Flag
	
	    //Secure User Generic Information
	    [EnumMember] Pan = 0x8101,
	    [EnumMember] Token = 0x8102,

        //Non Storable Secure Information 0x80;
        [EnumMember] Pin = 0x8181,
        [EnumMember] CVC = 0x8182,


    }

}
