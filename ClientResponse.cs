using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class ClientResponse : ServerResponse
    {
        [DataMember]
        public string Client { get; set; }

    }
}