namespace Plexo.Exceptions
{
    public class FingerprintException : ResultCodeException
    {
        public FingerprintException(string message) : base(message, ResultCodes.InvalidFingerprint)
        {
        }
    }
}