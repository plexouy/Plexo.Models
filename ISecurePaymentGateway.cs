﻿using System.Collections.Generic;
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
        Task<ServerSignedResponse<Session>> Authorize(ClientSignedRequest<Authorization> authorization);

        [OperationContract]
        [WebInvoke(UriTemplate = "ExpressCheckout", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Session>> ExpressCheckout(ClientSignedRequest<ExpressCheckoutRequest> expressCheckout);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Purchase", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Purchase(ClientSignedRequest<PaymentRequest> payment);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Cancel", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Cancel(ClientSignedRequest<CancelRequest> payment);

        [OperationContract]
        [WebInvoke(UriTemplate = "Operation/Refund", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> Refund(ClientSignedRequest<RefundRequest> payment);

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

        #region Blacklist

        [OperationContract]
        [WebInvoke(UriTemplate = "Blacklist/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> BlackListAdd(ClientSignedRequest<BlacklistRequest> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "Blacklist/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> BlackListDelete(ClientSignedRequest<BlacklistRequest> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "Blacklist", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<BlacklistRequest>>> GetBlackList(ClientSignedRequest request);

        #endregion

        #region Instruments

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<PaymentInstrument>>> GetInstruments(ClientSignedRequest<AuthorizationInfo> info);

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<PaymentInstrument>> AddInstrument(ClientSignedRequest<CreateBankInstrumentRequest> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/ExternalAdd", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<ExternalPaymentInstrument>> AddExternal(ClientSignedRequest<CreateExternalInstrumentRequest> request);


        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> DeleteInstrument(ClientSignedRequest<DeleteInstrumentRequest> info);

        [OperationContract]
        [WebInvoke(UriTemplate = "Instruments/Bank", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<PaymentInstrument>> CreateBankInstrument(ClientSignedRequest<CreateBankInstrumentRequest> request);

        #endregion

        #region Issuers
        [OperationContract]
        [WebInvoke(UriTemplate = "Issuer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<IssuerInfo>>> GetSupportedIssuers(ClientSignedRequest creq);

        [OperationContract]
        [WebInvoke(UriTemplate = "PaymentProcessors", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<IssuerPaymentProcessor>>> GetSupportedPaymentProcessors(ClientSignedRequest creq);

        #endregion

        #region Commerces

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
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
        [WebInvoke(UriTemplate = "Commerce/Issuer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<IssuerData>>> GetCommerceIssuers(ClientSignedRequest<CommerceIdRequest> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Add", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<IssuerData>> AddIssuerCommerce(ClientSignedRequest<IssuerData> commerce);

        [OperationContract]
        [WebInvoke(UriTemplate = "Commerce/Issuer/Delete", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse> DeleteIssuerCommerce(ClientSignedRequest<CommerceIssuerIdRequest> commerce);  

        #endregion

        #region TransactionInfo

        [OperationContract]
        [WebInvoke(UriTemplate = "Transactions", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<TransactionCursor>> ObtainTransactions(ClientSignedRequest<TransactionQuery> query);

        [OperationContract]
        [WebInvoke(UriTemplate = "Transactions/CSV", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<string>> ObtainCSVTransactions(ClientSignedRequest<TransactionQuery> query);

        #endregion

        #region Public Key

        [OperationContract]
        [WebGet(UriTemplate = "Key/{fingerprint}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Task<ServerSignedResponse<PublicKeyInfo>> GetServerPublicKey(string fingerprint);

        #endregion

        #region VerificationCodes

        [OperationContract]
        [WebInvoke(UriTemplate = "Code", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<Transaction>> CodeAction(IssuerSignedRequest<CodeRequest> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "CodeV2", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ServerSignedResponse<List<Transaction>>> CodeActionV2(IssuerSignedRequest<CodeRequest> request);

        #endregion

    }
}