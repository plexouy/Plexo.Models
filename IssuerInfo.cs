using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class IssuerInfo
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string Issuer { get; set; }
        [DataMember]
        public string Bank { get; set; }
        [DataMember]
        public string Variation { get; set; }
        [DataMember]
        public string ImageUrl { get; set; }
    }
}