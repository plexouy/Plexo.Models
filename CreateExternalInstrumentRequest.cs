using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class CreateExternalInstrumentRequest
    {
        [DataMember]
        public int IssuerId { get; set; }
        [DataMember]
        public Authorization AuthorizationData { get; set; }
        [DataMember]
        public Dictionary<FieldType, string> InstrumentData { get; set; }
    }
}