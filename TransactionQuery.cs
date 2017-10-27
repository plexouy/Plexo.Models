using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Plexo
{
    public class TransactionQuery
    {
        [DataMember]
        public List<Query> Queries { get; set; }
        [DataMember]
        public List<TransactionOrder> Order { get; set; }
        [DataMember]
        public int Limit { get; set; }
        [DataMember]
        public int Skip { get; set; }
    }

    [DataContract]
    public class TransactionOrder
    {
        [DataMember]
        public TransactionField Field { get; set; }
        [DataMember]
        public TransactionOrderDirection Direction { get; set; }
    }
    [DataContract]
    public enum TransactionOrderDirection
    {
        [EnumMember]
        Asc,
        [EnumMember]
        Desc
    }

    [DataContract]
    public enum QueryOperation
    {
        [EnumMember]
        And,
        [EnumMember]
        Or,
        [EnumMember]
        None
    }

    [DataContract]
    public class Query
    {
        [DataMember]
        public QueryOperation QueryOperator { get; }
        [DataMember]
        public TransactionField Field { get; set; }
        [DataMember]
        public TransactionOperator Operator { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public List<Query> SubQueries { get; set; }
    }



    [DataContract]
    public enum TransactionOperator
    {
        [EnumMember]
        Equal,
        [EnumMember]
        NotEqual,
        [EnumMember]
        BiggerThan,
        [EnumMember]
        BiggerOrEqualThan,
        [EnumMember]
        SmallerThan,
        [EnumMember]
        SmallerOrEqualThen,
        [EnumMember]
        Contains,
        [EnumMember]
        NotContains
    }
    [DataContract]
    public enum TransactionField
    {
        [EnumMember]
        CreationDate,
        [EnumMember]
        TransactionState,
        [EnumMember]
        PurchaseStatus,
        [EnumMember]
        CancelStatus,
        [EnumMember]
        ReserveStatus,
        [EnumMember]
        TransactionId,
        [EnumMember]
        IssuerId,
        [EnumMember]
        BankId,
        [EnumMember]
        CommerceId,
        [EnumMember]
        PurchaseExternalId,
        [EnumMember]
        CancelExternalId,
        [EnumMember]
        ReserveExternalId,
        [EnumMember]
        PurchaseAuthorization,
        [EnumMember]
        CancelAuthorization,
        [EnumMember]
        ReserveAuthorization,
        [EnumMember]
        PurchaseMetadata,
        [EnumMember]
        CancelMetadata,
        [EnumMember]
        ReserveMetadata,
        [EnumMember]
        Metadata
    }

}
