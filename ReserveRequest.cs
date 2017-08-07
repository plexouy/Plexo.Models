using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ReserveRequest : PaymentInstrument
    {
        public long ExpirationUTC { get; set; } //Must be included
    }
}