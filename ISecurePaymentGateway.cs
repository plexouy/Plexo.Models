using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Plexo
{
    [ServiceContract]
    public interface ISecurePaymentGateway
    {

        #region Operations

        [OperationContract]
        [WebInvoke(UriTemplate = "Auth", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<string>> Authorize(ClientSignedRequest<Authorization> authorization);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Purchase", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Purchase(ClientSignedRequest<PaymentRequest> payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Cancel", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Cancel(ClientSignedRequest<Reference> payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/StartReserve", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> StartReserve(ClientSignedRequest<ReserveRequest> payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/EndReserve", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> EndReserve(ClientSignedRequest<Reserve> reserve);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Status", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Status(ClientSignedRequest<Reference> payment);

        #endregion

        #region Instruments

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<InstrumentWithMetadata>>> GetInstruments(ClientSignedRequest<AuthorizationInfo> info);

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> DeleteInstruments(ClientSignedRequest<DeleteInstrumentRequest> info);

        #endregion

        #region Issuers
        [OperationContract]
        [WebInvoke(UriTemplate = "Issuer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<IssuerInfo>>> GetSupportedIssuers(ClientSignedRequest creq);

        #endregion

        #region Commerces

        [OperationContract]
        [WebGet(UriTemplate = "Commerce")]
        Task<ServerSignedResponse<List<Commerce>>> GetCommerces(ClientSignedRequest creq);


        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Commerce>> AddCommerce(ClientSignedRequest<CommerceRequest> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Modify", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Commerce>> ModifyCommerce(ClientSignedRequest<CommerceModifyRequest> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> DeleteCommerce(ClientSignedRequest<CommerceIdRequest> commerce);
        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/SetDefault", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> SetDefaultCommerce(ClientSignedRequest<CommerceIdRequest> commerce);


        [OperationContract]
        [WebGet(UriTemplate = "Commerce/Issuer")]
        Task<ServerSignedResponse<List<IssuerData>>> GetCommerceIssuers(ClientSignedRequest<CommerceIdRequest> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<IssuerData>> AddIssuerCommerce(ClientSignedRequest<IssuerData> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> DeleteIssuerCommerce(ClientSignedRequest<CommerceIssuerIdRequest> commerce);


        #endregion

        #region Public Key

        [OperationContract]
        [WebGet(UriTemplate = "Key/{fingerprint}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Task<ServerSignedResponse<PublicKeyInfo>> GetServerPublicKey(string fingerprint);

        #endregion
    }
}