using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    public class SplittedTransactionCallback : SplittedTransaction, IClientCallback
    {
        [DataMember]
        public string Client { get; set; }
    }
}
