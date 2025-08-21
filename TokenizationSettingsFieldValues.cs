using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class TokenizationSettingsFieldValues
    {
        [DataMember]
        public string Visible { get; set; } = "onlyIfRequired"; //always / never
        [DataMember]
        public bool ReadOnly { get; set; } = false;
    }
}
