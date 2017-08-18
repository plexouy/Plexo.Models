using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plexo.Exceptions;


namespace Plexo.Helpers
{
    public class SignatureHelper
    {
        private readonly X509Certificate2 _cert;
        private readonly RSA _rsa;

        public const int DefaultExpirationTimeInSeconds = 600;


        public SignatureHelper(X509Certificate2 cert, bool priv)
        {
            _cert = cert;
            _rsa = priv ? cert.GetRSAPrivateKey() : cert.GetRSAPublicKey();
        }

        private readonly JsonSerializerSettings serSettings = new JsonSerializerSettings {Formatting = Formatting.None, DateFormatHandling = DateFormatHandling.IsoDateFormat, DateTimeZoneHandling = DateTimeZoneHandling.Local, NullValueHandling = NullValueHandling.Ignore};

        public PublicKeyInfo GetPublicKey()
        {
            PublicKeyInfo info = new PublicKeyInfo();
            info.Fingerprint = _cert.Thumbprint;
            info.Key = Convert.ToBase64String(_cert.Export(X509ContentType.Cert));
            return info;
        }

        public TS Verify<T, TS>(T obj) where T : SignedObject<TS>
        {
            string so = JsonConvert.SerializeObject(obj.Object, Formatting.None, serSettings); //Canonicalize
            var parsedObject = JObject.Parse(so); //Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject); //Canonicalize
            string so2 = JsonConvert.SerializeObject(normal, Formatting.None, serSettings);
            byte[] body = Encoding.UTF8.GetBytes(so2);
            if (!_rsa.VerifyData(body, Convert.FromBase64String(obj.Signature), HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1))
                throw new SignatureException(("en",$"Signature do not match: Recv by Server: {so} Canonicalized by Server: {so2}"), ("es", $"La firma no concuerda: Recibido por el Servidor: {so} Canonicalizado por el Servidor: {so2}"));
            if ((long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds > obj.Object.UTCUnixTimeExpiration)
                throw new SignatureException(("en", "Object has expired"), ("es", "El objecto ha expirado"));
            return obj.Object.Object;
        }

        public void Verify<T>(T obj) where T : SignedObject
        {
            string so = JsonConvert.SerializeObject(obj.Object, Formatting.None, serSettings); //Canonicalize
            var parsedObject = JObject.Parse(so); //Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject); //Canonicalize
            string so2 = JsonConvert.SerializeObject(normal, Formatting.None, serSettings);
            byte[] body = Encoding.UTF8.GetBytes(so2);
            if (!_rsa.VerifyData(body, Convert.FromBase64String(obj.Signature), HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1))
                throw new SignatureException(("en", $"Signature do not match: Recv by Server: {so} Canonicalized by Server: {so2}"), ("es", $"La firma no concuerda: Recibido por el Servidor: {so} Canonicalizado por el Servidor: {so2}"));
            if ((long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds > obj.Object.UTCUnixTimeExpiration)
                throw new SignatureException(("en", "Object has expired"), ("es", "El objecto ha expirado"));
        }

        public T Sign<T, TS>(TS obj) where T : SignedObject<TS>, new()
        {
            T t = new T();
            t.Object = new StateObject<TS>();
            t.Object.UTCUnixTimeExpiration = (long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds + DefaultExpirationTimeInSeconds;
            t.Object.Fingerprint = _cert.Thumbprint;
            t.Object.Object = obj;
            string so = JsonConvert.SerializeObject(t.Object, Formatting.None, serSettings); //Canonicalize
            var parsedObject = JObject.Parse(so); //Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject); //Canonicalize
            string so2 = JsonConvert.SerializeObject(normal, Formatting.None, serSettings);
            byte[] body = Encoding.UTF8.GetBytes(so2);
            t.Signature = Convert.ToBase64String(_rsa.SignData(body, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1));
            return t;
        }

        private static JToken SortPropertiesAlphabetically(JToken original)
        {
            if (original is JObject)
            {
                var result = new JObject();
                foreach (var property in ((JObject) original).Properties().ToList().OrderBy(p => p.Name))
                {
                    var value = property.Value;
                    if (value != null)
                        value = SortPropertiesAlphabetically(value);
                    result.Add(property.Name, value);
                }
                return result;
            }
            if (original is JArray)
            {
                var array = original as JArray;
                for (int i = 0; i < array.Count; i++)
                    array[i] = SortPropertiesAlphabetically(array[i]);
                return array;
            }
            if (original is JValue)
            {
                JValue n = (JValue) original;
                if (n.Value is DateTime)
                {
                    DateTime dt = (DateTime) n.Value;
                    if (dt.Kind != DateTimeKind.Local)
                    {
                        dt = dt.Kind == DateTimeKind.Unspecified ? DateTime.SpecifyKind(dt, DateTimeKind.Local) : dt.ToLocalTime();
                        n.Value = dt;
                    }
                }
                return n;
            }
            return original;
        }
    }
}