using System.Runtime.Serialization;
using Newtonsoft.Json;

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
        //Mercury Id is for internal use, no serialization required
        [JsonIgnore]
        public int MercuryId { get; set; }
    }
}