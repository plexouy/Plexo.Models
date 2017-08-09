using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class IssuerInfo
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public int IssuerId { get; set; }
        [DataMember]
        public int VariationId { get; set; }
        [DataMember]
        public string Issuer { get; set; }
        [DataMember]
        public string Bank { get; set; }
        [DataMember]
        public string Variation { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
        [DataMember]
        public bool MayHaveAsyncPayments { get; set; }
        [DataMember]
        public bool SupportsReserve { get; set; }
        [DataMember]
        public bool MayHavePaymentsLimits { get; set; }
        [DataMember]
        public List<FieldInfo> Fields { get; set; }
    }
}