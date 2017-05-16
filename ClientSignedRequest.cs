using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ClientSignedRequest<T> : SignedObject<ClientRequest<T>> { }

    [DataContract]
    public class ClientSignedRequest : SignedObject<ClientRequest> { }


}