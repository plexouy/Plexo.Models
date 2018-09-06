using System.Runtime.Serialization;

namespace Plexo
{
        [DataContract]
        public class Check
        {
            [DataMember]
            public string Uri { get; set; }

            [DataMember]
            public EnrollmentInfo EnrollmentInfo { get; set; }
        }
}


    