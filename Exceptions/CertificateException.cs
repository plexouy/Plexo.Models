namespace Goova.Plexo.Exceptions
{
    public class CertificateException : ResultCodeException
    {
        public CertificateException(string message) : base(message, ResultCodes.SystemError)
        {
            
        }
    }
}