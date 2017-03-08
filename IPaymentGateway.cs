using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Goova.Plexo
{
    [ServiceContract]
    public interface IPaymentGateway
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Auth", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<string>> Authorize(Authorization authorization);
        [OperationContract]
        [WebGet(UriTemplate = "Issuer", ResponseFormat = WebMessageFormat.Json)]
        Task<ServerResponse<List<IssuerInfo>>> GetSupportedIssuers();
        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Purchase", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> Purchase(PaymentRequest payment);
        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Cancel", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> Cancel(CancelRequest payment);
    }
}
