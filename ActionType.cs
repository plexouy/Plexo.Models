using System;
using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    [Flags]
    public enum ActionType
    {
        [EnumMember]
        SelectInstrument = 1,
        [EnumMember]
        RegisterInstrument = 2,
        [EnumMember]
        DeleteInstrument = 4,
    }
}