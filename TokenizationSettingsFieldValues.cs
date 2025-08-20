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
        public TokenizationFieldVisibility Visible { get; set; } = TokenizationFieldVisibility.OnlyIfRequired;
        [DataMember]
        public bool ReadOnly { get; set; } = false;
    }
}
