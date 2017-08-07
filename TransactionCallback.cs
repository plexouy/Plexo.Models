using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class TransactionCallback : Transaction
    {
        [DataMember]
        public string Client { get; set; }
    }
}