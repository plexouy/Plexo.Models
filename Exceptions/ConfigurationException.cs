namespace Goova.Plexo.Exceptions
{
    public class ConfigurationException : ResultCodeException
    {
        public ConfigurationException(string message) : base(message, ResultCodes.SystemError)
        {
            
        }
    }
}