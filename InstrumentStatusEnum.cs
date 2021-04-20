using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public enum InstrumentStatusEnum
    {
        [EnumMember]
        Created,
        [EnumMember]
        WarningExpirationInLessThanOneMonth,
        [EnumMember]
        Expired,
        [EnumMember]
        Disabled,
        [EnumMember]
        WaitingForConfirmation,
        [EnumMember]
        Deleted
    }
}