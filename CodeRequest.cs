using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class CodeRequest
    {
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public CodeAction Action { get; set; }
    }
}