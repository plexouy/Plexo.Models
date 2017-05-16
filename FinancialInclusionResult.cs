using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class FinancialInclusionResult
    {
        [DataMember]
        public bool IsApplied { get; set; }
        [DataMember]
        public decimal ReturnAmount { get; set; }
        [DataMember]
        public InclusionType LawNumber { get; set; }
    }
}