using System;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Goova.Plexo.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Goova.Plexo.Helpers
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

        public PublicKeyInfo GetPublicKey()
        {
            PublicKeyInfo info=new PublicKeyInfo();
            info.Fingerprint = _cert.Thumbprint;
            info.Key=Convert.ToBase64String(_cert.Export(X509ContentType.Cert));
            return info;
        }
        public TS Verify<T, TS>(T obj) where T : SignedObject<TS>
        {
            string so = JsonConvert.SerializeObject(obj.Object, Formatting.None); //Canonicalize
            var parsedObject = JObject.Parse(so);//Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject);//Canonicalize
            byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(normal, Formatting.None));
            if (!_rsa.VerifyData(body, Convert.FromBase64String(obj.Signature), HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1))
                throw new SignatureException("Signature do not match");
            if ((long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds > obj.Object.UTCUnixTimeExpiration)
                throw new SignatureException("Object has expired");
            return obj.Object.Object;
        }
        public void Verify<T>(T obj) where T : SignedObject
        {
            string so = JsonConvert.SerializeObject(obj.Object, Formatting.None); //Canonicalize
            var parsedObject = JObject.Parse(so);//Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject);//Canonicalize
            byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(normal, Formatting.None));
            if (!_rsa.VerifyData(body, Convert.FromBase64String(obj.Signature), HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1))
                throw new SignatureException("Signature do not match");
            if ((long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds > obj.Object.UTCUnixTimeExpiration)
                throw new SignatureException("Object has expired");

        }
        public T Sign<T,TS>(TS obj) where T: SignedObject<TS>, new()
        {
            T t = new T();
            t.Object=new StateObject<TS>();
            t.Object.UTCUnixTimeExpiration = (long)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds + DefaultExpirationTimeInSeconds;
            t.Object.Fingerprint = _cert.Thumbprint;
            t.Object.Object = obj;
            string so = JsonConvert.SerializeObject(t.Object, Formatting.None); //Canonicalize
            var parsedObject = JObject.Parse(so);//Canonicalize
            var normal = SortPropertiesAlphabetically(parsedObject);//Canonicalize
            byte[] body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(normal, Formatting.None));
            t.Signature= Convert.ToBase64String(_rsa.SignData(body, HashAlgorithmName.SHA512, RSASignaturePadding.Pkcs1));
            return t;
        }
        private static JObject SortPropertiesAlphabetically(JObject original)
        {
            var result = new JObject();

            foreach (var property in original.Properties().ToList().OrderBy(p => p.Name))
            {
                var value = property.Value as JObject;

                if (value != null)
                {
                    value = SortPropertiesAlphabetically(value);
                    result.Add(property.Name, value);
                }
                else
                {
                    result.Add(property.Name, property.Value);
                }
            }

            return result;
        }
    }
}