using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public enum CardTypes
    {
        [EnumMember]
        UruguayDebit=1,
        [EnumMember]
        UruguayCredit=2,
        [EnumMember]
        UruguayPrepaid=5,
        [EnumMember]
        Debit=3,
        [EnumMember]
        Credit=4,
        [EnumMember]
        Prepaid=6,
        [EnumMember]
        Unknown=0
    }
}
