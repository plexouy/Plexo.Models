using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class DeleteInstrumentRequest : AuthorizationInfo
    {
        [DataMember]
        public string InstrumentToken { get; set; }
    }
}