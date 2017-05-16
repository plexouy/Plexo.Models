using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ServerSignedRequest<T> : SignedObject<T>
    {
    }
}