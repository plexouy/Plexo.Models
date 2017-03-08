using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class TimeLimit
    {
        [DataMember]
        public int SecondsLeft;
        [DataMember]
        public FieldType RequirementAfterTimeLimit { get; set; }
    }
}