using System;
using System.Runtime.Serialization;

namespace Plexo
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
        [EnumMember]
        SessionExtendAmount = 8,
        [EnumMember]
        ClientExtendAmount = 16,
        [EnumMember]
        AskForTemporaryItems=32
    }
}