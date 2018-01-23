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

        public Exception OriginalException { get; set; }

        public ResultCodeException(ResultCodes code, params (string language, string message)[] errormessages)
        {
            Code = code;
            I18NErrorMessages=new Dictionary<string, string>();
            foreach ((string language, string message) in errormessages)
            {
                I18NErrorMessages[language] = message;
            }
        }
        public ResultCodeException(ServerResponse resp)
        {
            Code = resp.ResultCode;
            if (resp.I18NErrorMessages == null && resp.ErrorMessage != null)
                I18NErrorMessages = new Dictionary<string, string>() { { "es", resp.ErrorMessage }, { "en", resp.ErrorMessage } };
            else
                I18NErrorMessages = resp.I18NErrorMessages;

        }
    }
}
