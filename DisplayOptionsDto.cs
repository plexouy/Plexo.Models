using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    [DataContract]
    public class DisplayOptionsDto
    {
        [DataMember]
        public bool Titles { get; set; } // Mostrar titulos
        [DataMember]
        public bool Details { get; set; } // Mostrar detalle de compra
    }
}
