using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace Goova.Plexo
{
    [DataContract]
    public enum FieldType
    {
        [EnumMember] Pan,
        [EnumMember] Expiration,
        [EnumMember] Pin,
        [EnumMember] CVC,
        [EnumMember] Name,
        [EnumMember] Address,
        [EnumMember] ZipCode,
        [EnumMember] Email,
        [EnumMember] AmountLimitExtension
    }
}
