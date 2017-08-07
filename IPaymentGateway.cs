using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Plexo
{
    [ServiceContract]
    public interface IPaymentGateway
    {

        #region Operations
        
        [OperationContract]
        [WebInvoke(UriTemplate = "Auth", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<string>> Authorize(Authorization authorization);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Purchase", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> Purchase(PaymentRequest payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Cancel", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> Cancel(Reference payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/StartReserve", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> StartReserve(ReserveRequest payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/EndReserve", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> EndReserve(Reserve reserve);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Status", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Transaction>> Status(Reference payment);

        #endregion

        #region Instruments
        
        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<List<InstrumentWithMetadata>>> GetInstruments(AuthorizationInfo info);

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse> DeleteInstruments(DeleteInstrumentRequest info);

        #endregion

        #region Issuers

        [OperationContract]
        [WebGet(UriTemplate = "Issuer", ResponseFormat = WebMessageFormat.Json)]
        Task<ServerResponse<List<IssuerInfo>>> GetSupportedIssuers();

        #endregion

        #region Commerces

        [OperationContract]
        [WebGet(UriTemplate = "Commerce")]
        Task<ServerResponse<List<Commerce>>> GetCommerces();


        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Commerce>> AddCommerce(CommerceRequest commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Modify", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<Commerce>> ModifyCommerce(CommerceModifyRequest commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse> DeleteCommerce(CommerceIdRequest commerce);
        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/SetDefault", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse> SetDefaultCommerce(CommerceIdRequest commerce);

        [OperationContract]
        [WebGet(UriTemplate = "Commerce/Issuer")]
        Task<ServerResponse<List<IssuerData>>> GetCommerceIssuers(CommerceIdRequest commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse<IssuerData>> AddIssuerCommerce(IssuerData commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerResponse> DeleteIssuerCommerce(CommerceIssuerIdRequest commerce);

        #endregion

    }
}
