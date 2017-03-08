using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class ServerSignedRequest<T> : SignedObject<T>
    {
    }
}