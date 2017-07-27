using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember]
        public string Client { get; set; }
    }
}