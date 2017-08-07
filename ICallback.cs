using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Plexo
{
    [ServiceContract]
    public interface ICallback
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Instrument", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ClientResponse> Instrument(IntrumentCallback instrument);

        [OperationContract]
        [WebInvoke(UriTemplate = "Payment", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ClientResponse> Payment(TransactionCallback transaction);
    }
}
