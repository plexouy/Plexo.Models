namespace Plexo.Exceptions
{
    public class MessageExpiredException : ResultCodeException
    {
        public MessageExpiredException(params (string language, string message)[] errormessages) : base(ResultCodes.MessageExpired, errormessages)
        {

        }
    }
}