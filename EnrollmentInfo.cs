using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class EnrollmentInfo
    {        
        [DataMember]
        public bool EnrollmentStatus { get; set; }
    }
}
