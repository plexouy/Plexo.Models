using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class TransactionCallback : Transaction, IClientCallback
    {
        [DataMember]
        public string Client { get; set; }
    }
}