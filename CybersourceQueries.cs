using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    public class CybersourceQueries
    {
        public System.Guid Qid { get; set; }
        public string AcsURL { get; set; }
        public string PaReq { get; set; }
        public string PaRes { get; set; }
        public string TermUrl { get; set; }
        public string Xid { get; set; }
        public string CommerceIndicator { get; set; }
        public string EciRaw { get; set; }
        public string Cavv { get; set; }
        public string CavvAlgorithm { get; set; }
        public string AuthenticationData { get; set; }
        public string CollectionIndicator { get; set; }
        public string Instrument { get; set; }
        public string ExternalId { get; set; }
        public int CurrencyId { get; set; }
        public string Decision { get; set; }
        public int ReasonCode { get; set; }
        public long RequestTime { get; set; }
        public string AccountNumber { get; set; }
        public string CardType { get; set; }
        public string ExpirationMonth { get; set; }
        public string ExpirationYear { get; set; }
        public string CvNumber { get; set; }
        public string Client { get; set; }    
        public string RedirectUrl { get; set; }        
    }
}