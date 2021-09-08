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
        public bool? Titles { get; set; } // Mostrar titulos
        [DataMember]
        public bool? Details { get; set; } // Mostrar detalle de compra
        [DataMember]
        public bool? Footer { get; set; } // Mostrar pie de pagina
        [DataMember]
        public bool? Logo { get; set; } // Mostrar logo
        [DataMember]
        public bool? Accessibility { get; set; } // Activar accesibilidad usando equalweb
    }
}
