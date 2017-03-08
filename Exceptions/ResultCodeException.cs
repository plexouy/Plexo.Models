using System;

namespace Goova.Plexo.Exceptions
{
    public class ResultCodeException : Exception
    {
        public ResultCodes Code { get; }

        public ResultCodeException(string message, ResultCodes code) : base(message)
        {
            Code = code;
        }
    }
}
