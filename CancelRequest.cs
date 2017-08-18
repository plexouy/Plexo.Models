using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CancelRequest : Reference
    {
        [DataMember]
        public string ClientReferenceId { get; set; }
    }
}