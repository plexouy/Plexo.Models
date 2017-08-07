using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class Reserve : Reference
    {
        public bool Commit { get; set; }
    }
}