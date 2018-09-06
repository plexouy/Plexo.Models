using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Plexo
{
   [DataContract]
   public class CheckRequest 
   {
        [DataMember]
        public string Client { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string CardType { get; set; }
        [DataMember]
        public string ExpirationMonth { get; set; }
        [DataMember]
        public string ExpirationYear { get; set; }
        [DataMember]
        public string CvNumber { get; set; }
        [DataMember]
        public string MerchantID { get; set; }
        [DataMember]
        public string MerchantReferenceCode { get; set; }
        [DataMember]
        public string CurrencyId { get; set; }
        [DataMember]
        public double Amount { get; set; }
        [DataMember]
        public string AcsURL { get; set; }
        [DataMember]
        public string PaReq { get; set; }
        [DataMember]
        public string PaRes { get; set; }
	    [DataMember]
        public string TermUrl { get; set; }
	    [DataMember]
        public string Xid { get; set; }
	    [DataMember]
        public string CommerceIndicator { get; set; }
	    [DataMember]
        public string EciRaw { get; set; }
        [DataMember]
        public string Cavv { get; set; }
	    [DataMember]
        public string CavvAlgorithm { get; set; }
	    [DataMember]
        public string AuthenticationData { get; set; }
	    [DataMember]
        public string CollectionIndicator { get; set; }
	    [DataMember]
        public string Instrument { get; set; }
	    //[DataMember]
     //   public string ExternalId { get; set; }
        [DataMember]
        public string Decision { get; set; }
	    [DataMember]
        public int ReasonCode { get; set; }    
    }
}
