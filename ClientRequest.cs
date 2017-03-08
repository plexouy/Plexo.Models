using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class ClientRequest<T> : ClientRequest
    {
        [DataMember]
        public T Request { get; set; }
    }
    [DataContract]
    public class ClientRequest
    {
        [DataMember]
        public string Client { get; set; }
    }
}