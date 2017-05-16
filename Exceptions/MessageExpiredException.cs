namespace Plexo.Exceptions
{
    public class MessageExpiredException : ResultCodeException
    {
        
        public MessageExpiredException(string message) : base(message, ResultCodes.MessageExpired)
        {
        }
    }
}