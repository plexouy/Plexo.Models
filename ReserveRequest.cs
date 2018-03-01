using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ReserveRequest : PaymentRequest
    {
        [DataMember]
        public long ExpirationUTC { get; set; } //Must be included
    }
}