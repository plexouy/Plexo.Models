using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class SignedServerResponse<T> : SignedObject<ServerResponse<T>> { }

    [DataContract]
    public class SignedServerResponse : SignedObject<ServerResponse> { }
}