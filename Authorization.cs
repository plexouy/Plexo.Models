using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Authorization 
    {
        [DataMember]
        public ActionType Action { get; set; }
        [DataMember]
        public AuthorizationType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
        [DataMember]
        public string RedirectUri { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
        [DataMember]
        public Dictionary<string, object> ClientInformation { get; set; }
        [DataMember]
        public List<string> LimitIssuers { get; set; }
        [DataMember]
        public Dictionary<string,string> PromotionInfoIssuers { get; set; }
        [DataMember]
        public string ExtendableInstrumentToken { get; set; }
    }
}