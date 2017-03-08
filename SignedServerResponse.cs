using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class SignedServerResponse<T> : SignedObject<ServerResponse<T>> { }

    [DataContract]
    public class SignedServerResponse : SignedObject<ServerResponse> { }
}