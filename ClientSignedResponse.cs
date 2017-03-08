using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class ClientSignedResponse : SignedObject<ClientResponse>
    {
    }
}