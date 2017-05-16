namespace Plexo.Exceptions
{
    public class SignatureException : ResultCodeException
    {
        public SignatureException(string message) : base(message, ResultCodes.InvalidSignature)
        {
        }
    }
}