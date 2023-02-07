using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public enum InternalFieldType
    {
        IgnoreCVV,
        ProviderApiKey,
    }
}
