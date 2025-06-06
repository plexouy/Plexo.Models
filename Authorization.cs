using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Authorization : AuthorizationInfo
    {
        [DataMember]
        public ActionType Action { get; set; }      
        [DataMember]
        public string RedirectUri { get; set; }
        [DataMember]
        public string OptionalMetadata { get; set; }
        [DataMember]
        public Dictionary<FieldType, string> ClientInformation { get; set; }
        [DataMember]
        public List<string> LimitIssuers { get; set; }
        [DataMember]
        public Dictionary<string,string> PromotionInfoIssuers { get; set; }
        [DataMember]
        public string ExtendableInstrumentToken { get; set; }
        [DataMember]
        public bool? DoNotUseCallback { get; set; }
        [DataMember]
        public int? OptionalCommerceId { get; set; }
        [DataMember]
        public List<string> LimitBanks { get; set; }
        [DataMember]
        public WebFormSettingsDto WebFormSettings { get; set; }

    }
}