namespace Plexo.Exceptions
{
    public class SignatureException : ResultCodeException
    {
        public SignatureException(params (string language, string message)[] errormessages) : base(ResultCodes.InvalidSignature, errormessages)
        {

        }
    }
}