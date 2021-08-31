using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class TokenizationSettingsDto
    {
        [DataMember]
        public DisplayOptionsDto Display { get; set; }
    }
}
