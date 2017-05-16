using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ClientSignedResponse : SignedObject<ClientResponse>
    {
    }
}