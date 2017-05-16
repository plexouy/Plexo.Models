using System.Runtime.Serialization;
// ReSharper disable InconsistentNaming

namespace Plexo
{
    [DataContract]
    public class StateObject
    {
        [DataMember]
        public string Fingerprint { get; set; }
        [DataMember]
        public long UTCUnixTimeExpiration { get; set; }
    }

    [DataContract]
    public class StateObject<T> : StateObject
    {
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public T Object { get; set; }
    }
}