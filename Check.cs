using System.Runtime.Serialization;

namespace Plexo
{
        [DataContract]
        public class Check
        {
            [DataMember]
            public string Id { get; set; }

            [DataMember]
            public string Uri { get; set; }

            [DataMember]
            public string EnrollmentStatus { get; set; }
        }
}


    