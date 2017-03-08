using System.Runtime.Serialization;

namespace Goova.Plexo
{
    [DataContract]
    public class PublicKeyInfo
    {
        [DataMember]
        public string Fingerprint { get; set; }
        [DataMember]
        public string Key { get; set; }
    }
}
