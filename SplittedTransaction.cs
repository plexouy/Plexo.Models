using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class SplittedTransaction
    {
        [DataMember]
        public Transaction PurchaseTransaction { get; set; }
        [DataMember]
        public Transaction SplitTransaction { get; set; }
        [DataMember]
        public TransactionResult Status { get; set; }
    }
}
