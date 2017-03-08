using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class CreditLimit
    {
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public decimal ExtendedAmount { get; set; }
        [DataMember]
        public Currency Currency { get; set; }
        [DataMember]
        public bool SupportsExtendedCredit { get; set; }
    }
}