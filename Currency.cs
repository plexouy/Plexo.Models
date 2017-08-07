using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Currency
    {
        [DataMember]
        public int CurrencyId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Plural { get; set; }
        [DataMember]
        public string Symbol { get; set; }
    }
}