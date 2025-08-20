using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class TokenizationSettingsFields
    {
        [DataMember]
        public TokenizationSettingsFieldValues Cardholder { get; set; } = new TokenizationSettingsFieldValues();
        [DataMember]
        public TokenizationSettingsFieldValues Identification { get; set; } = new TokenizationSettingsFieldValues();
        [DataMember]
        public TokenizationSettingsFieldValues BillingAddress { get; set; } = new TokenizationSettingsFieldValues();
    }

}
