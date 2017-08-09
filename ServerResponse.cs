using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
    [DataContract]
    public class ServerResponse<T> : ServerResponse
    {
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public T Response { get; set; }
    }
    [DataContract]
    public class ServerResponse 
    {
        [DataMember]
        public ResultCodes ResultCode { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string ErrorMessage { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public Dictionary<string,string> I18NErrorMessages { get; set; }
    }

}