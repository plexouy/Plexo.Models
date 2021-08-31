using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class UIOptionsDto
    {
        [DataMember]
        public Dictionary<string, string> Colors { get; set; } // primary color, seconday color, background color
        [DataMember]
        public string Theme { get; set; } // default, dark
        [DataMember]
        public bool AutoDarkTheme { get; set; } // Cambiar de tema automaticamente segun preferencias del usuario en su explorador
    }
}
