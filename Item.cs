using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Item
    {
        [DataMember]
        public string ClientItemReferenceId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int? Quantity { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public List<InfoLine> InfoLines { get; set; }
        [DataMember]
        public string MetaData { get; set; }
        [DataMember]
        public List<string> Tags { get; set; }
    }
}
