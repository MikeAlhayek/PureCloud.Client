using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeAggregateQueryPredicate
/// </summary>
[DataContract]
public partial class KnowledgeAggregateQueryPredicate : IEquatable<KnowledgeAggregateQueryPredicate>
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Dimension for "dimension"
        /// </summary>
        [EnumMember(Value = "dimension")]
        Dimension,

        /// <summary>
        /// Enum Property for "property"
        /// </summary>
        [EnumMember(Value = "property")]
        Property,

        /// <summary>
        /// Enum Metric for "metric"
        /// </summary>
        [EnumMember(Value = "metric")]
        Metric
    }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agentassistantid for "agentAssistantId"
        /// </summary>
        [EnumMember(Value = "agentAssistantId")]
        Agentassistantid,

        /// <summary>
        /// Enum Appdeploymentid for "appDeploymentId"
        /// </summary>
        [EnumMember(Value = "appDeploymentId")]
        Appdeploymentid,

        /// <summary>
        /// Enum Apptype for "appType"
        /// </summary>
        [EnumMember(Value = "appType")]
        Apptype,

        /// <summary>
        /// Enum Botflowid for "botFlowId"
        /// </summary>
        [EnumMember(Value = "botFlowId")]
        Botflowid,

        /// <summary>
        /// Enum Conversationchanneltype for "conversationChannelType"
        /// </summary>
        [EnumMember(Value = "conversationChannelType")]
        Conversationchanneltype,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Documentengagementtype for "documentEngagementType"
        /// </summary>
        [EnumMember(Value = "documentEngagementType")]
        Documentengagementtype,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Feedbackcategory for "feedbackCategory"
        /// </summary>
        [EnumMember(Value = "feedbackCategory")]
        Feedbackcategory,

        /// <summary>
        /// Enum Feedbackid for "feedbackId"
        /// </summary>
        [EnumMember(Value = "feedbackId")]
        Feedbackid,

        /// <summary>
        /// Enum Feedbackrating for "feedbackRating"
        /// </summary>
        [EnumMember(Value = "feedbackRating")]
        Feedbackrating,

        /// <summary>
        /// Enum Feedbackratingtype for "feedbackRatingType"
        /// </summary>
        [EnumMember(Value = "feedbackRatingType")]
        Feedbackratingtype,

        /// <summary>
        /// Enum Feedbackratingvalue for "feedbackRatingValue"
        /// </summary>
        [EnumMember(Value = "feedbackRatingValue")]
        Feedbackratingvalue,

        /// <summary>
        /// Enum Feedbackreason for "feedbackReason"
        /// </summary>
        [EnumMember(Value = "feedbackReason")]
        Feedbackreason,

        /// <summary>
        /// Enum Feedbacktype for "feedbackType"
        /// </summary>
        [EnumMember(Value = "feedbackType")]
        Feedbacktype,

        /// <summary>
        /// Enum Hascomment for "hasComment"
        /// </summary>
        [EnumMember(Value = "hasComment")]
        Hascomment,

        /// <summary>
        /// Enum Hassearch for "hasSearch"
        /// </summary>
        [EnumMember(Value = "hasSearch")]
        Hassearch,

        /// <summary>
        /// Enum Knowledgebasedocumentid for "knowledgeBaseDocumentId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentId")]
        Knowledgebasedocumentid,

        /// <summary>
        /// Enum Knowledgebasedocumentvariationid for "knowledgeBaseDocumentVariationId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentVariationId")]
        Knowledgebasedocumentvariationid,

        /// <summary>
        /// Enum Knowledgebasedocumentversionid for "knowledgeBaseDocumentVersionId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseDocumentVersionId")]
        Knowledgebasedocumentversionid,

        /// <summary>
        /// Enum Knowledgebaseid for "knowledgeBaseId"
        /// </summary>
        [EnumMember(Value = "knowledgeBaseId")]
        Knowledgebaseid,

        /// <summary>
        /// Enum Languagecode for "languageCode"
        /// </summary>
        [EnumMember(Value = "languageCode")]
        Languagecode,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Presenteddocumentscount for "presentedDocumentsCount"
        /// </summary>
        [EnumMember(Value = "presentedDocumentsCount")]
        Presenteddocumentscount,

        /// <summary>
        /// Enum Querytype for "queryType"
        /// </summary>
        [EnumMember(Value = "queryType")]
        Querytype,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Searchid for "searchId"
        /// </summary>
        [EnumMember(Value = "searchId")]
        Searchid,

        /// <summary>
        /// Enum Searchquery for "searchQuery"
        /// </summary>
        [EnumMember(Value = "searchQuery")]
        Searchquery,

        /// <summary>
        /// Enum Selfserved for "selfServed"
        /// </summary>
        [EnumMember(Value = "selfServed")]
        Selfserved,

        /// <summary>
        /// Enum Sessionid for "sessionId"
        /// </summary>
        [EnumMember(Value = "sessionId")]
        Sessionid,

        /// <summary>
        /// Enum Surfacingmethod for "surfacingMethod"
        /// </summary>
        [EnumMember(Value = "surfacingMethod")]
        Surfacingmethod,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid
    }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Matches for "matches"
        /// </summary>
        [EnumMember(Value = "matches")]
        Matches,

        /// <summary>
        /// Enum Exists for "exists"
        /// </summary>
        [EnumMember(Value = "exists")]
        Exists,

        /// <summary>
        /// Enum Notexists for "notExists"
        /// </summary>
        [EnumMember(Value = "notExists")]
        Notexists
    }
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [DataMember(Name = "dimension", EmitDefaultValue = false)]
    public DimensionEnum? Dimension { get; set; }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeAggregateQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">Left hand side for dimension predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for dimension predicates.</param>
    /// <param name="Range">Right hand side for dimension predicates.</param>
    public KnowledgeAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
    {
        this.Type = Type;
        this.Dimension = Dimension;
        this.Operator = Operator;
        this.Value = Value;
        this.Range = Range;

    }









    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public NumericRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeAggregateQueryPredicate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as KnowledgeAggregateQueryPredicate);
    }

    /// <summary>
    /// Returns true if KnowledgeAggregateQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeAggregateQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeAggregateQueryPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Range == other.Range ||
                Range != null &&
                Range.Equals(other.Range)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Range != null)
            {
                hash = hash * 59 + Range.GetHashCode();
            }

            return hash;
        }
    }
}
