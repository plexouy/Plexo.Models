using System;
using System.Collections.Generic;
using System.Linq;

namespace Plexo.Exceptions
{
    public class ResultCodeException : Exception
    {
        public ResultCodes Code { get; }
        public string ErrorMessage => I18NErrorMessages.ContainsKey("en") ? I18NErrorMessages["en"] : I18NErrorMessages.Values.FirstOrDefault();
        public Dictionary<string, string> I18NErrorMessages { get; }
        public bool IsErrorLogged { get; set; } = false;


        public ResultCodeException(ResultCodes code, params (string language, string message)[] errormessages)
        {
            Code = code;
            I18NErrorMessages = errormessages.ToDictionary(a => a.language, a => a.message);
        }
        public ResultCodeException(ServerResponse resp)
        {
            Code = resp.ResultCode;
            I18NErrorMessages = resp.I18NErrorMessages;
        }
    }
}
