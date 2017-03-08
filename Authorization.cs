using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class Authorization 
    {
        [DataMember]
        public AuthorizationType Type { get; set; }
        [DataMember]
        public string MetaReference { get; set; }
        [DataMember]
        public ActionType Action { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
        [DataMember]
        public string CallbackUrl { get; set; }
        [DataMember]
        public Dictionary<string, object> ClientInformation { get; set; }
        [DataMember]
        public List<string> LimitIssuers { get; set; }
        [DataMember]
        public Dictionary<string,string> PromotionInfoIssuers { get; set; }
    }
}