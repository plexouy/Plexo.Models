using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class ExpressCheckoutSettingsDto
    {
        [DataMember]
        public DisplayOptionsDto Display { get; set; }
        [DataMember]
        public BuiltInPagesOptionsDto BuiltInPages { get; set; }
    }
}
