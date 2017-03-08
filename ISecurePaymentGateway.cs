using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Goova.Plexo
{
    [ServiceContract]
    public interface ISecurePaymentGateway
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Auth", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<SignedServerResponse<string>> Authorize(ClientSignedRequest<Authorization> authorization);
        [OperationContract]
        [WebInvoke(UriTemplate = "Issuer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<SignedServerResponse<List<IssuerInfo>>> GetSupportedIssuers(ClientSignedRequest creq);
        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Purchase", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<SignedServerResponse<Transaction>> Purchase(ClientSignedRequest<PaymentRequest> payment);
        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Cancel", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<SignedServerResponse<Transaction>> Cancel(ClientSignedRequest<CancelRequest> payment);
        [OperationContract]
        [WebGet(UriTemplate = "Key/{fingerprint}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Task<SignedServerResponse<PublicKeyInfo>> GetServerPublicKey(string fingerprint);

    }
}