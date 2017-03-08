using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class InfoLine
    {
        [DataMember]
        public string Text { get; set; }
        [DataMember]
        public double Amount { get; set; }
    }
}