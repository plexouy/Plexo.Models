using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ReserveRequest : PaymentRequest
    {
        public long ExpirationUTC { get; set; } //Must be included
    }
}