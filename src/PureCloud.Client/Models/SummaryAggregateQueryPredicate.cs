using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SummaryAggregateQueryPredicate
/// </summary>

public partial class SummaryAggregateQueryPredicate : IEquatable<SummaryAggregateQueryPredicate>
{
    /// <summary>
    /// Optional type, can usually be inferred
    /// </summary>
    /// <value>Optional type, can usually be inferred</value>
    
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
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Copied for "copied"
        /// </summary>
        [EnumMember(Value = "copied")]
        Copied,

        /// <summary>
        /// Enum Editedfield for "editedField"
        /// </summary>
        [EnumMember(Value = "editedField")]
        Editedfield,

        /// <summary>
        /// Enum Errortype for "errorType"
        /// </summary>
        [EnumMember(Value = "errorType")]
        Errortype,

        /// <summary>
        /// Enum Language for "language"
        /// </summary>
        [EnumMember(Value = "language")]
        Language,

        /// <summary>
        /// Enum Mediatype for "mediaType"
        /// </summary>
        [EnumMember(Value = "mediaType")]
        Mediatype,

        /// <summary>
        /// Enum Messagetype for "messageType"
        /// </summary>
        [EnumMember(Value = "messageType")]
        Messagetype,

        /// <summary>
        /// Enum Presented for "presented"
        /// </summary>
        [EnumMember(Value = "presented")]
        Presented,

        /// <summary>
        /// Enum Queueid for "queueId"
        /// </summary>
        [EnumMember(Value = "queueId")]
        Queueid,

        /// <summary>
        /// Enum Summarygenerated for "summaryGenerated"
        /// </summary>
        [EnumMember(Value = "summaryGenerated")]
        Summarygenerated,

        /// <summary>
        /// Enum Summaryid for "summaryId"
        /// </summary>
        [EnumMember(Value = "summaryId")]
        Summaryid,

        /// <summary>
        /// Enum Summaryrating for "summaryRating"
        /// </summary>
        [EnumMember(Value = "summaryRating")]
        Summaryrating,

        /// <summary>
        /// Enum Triggersourceid for "triggerSourceId"
        /// </summary>
        [EnumMember(Value = "triggerSourceId")]
        Triggersourceid,

        /// <summary>
        /// Enum Triggersourceoutcome for "triggerSourceOutcome"
        /// </summary>
        [EnumMember(Value = "triggerSourceOutcome")]
        Triggersourceoutcome,

        /// <summary>
        /// Enum Triggersourcetype for "triggerSourceType"
        /// </summary>
        [EnumMember(Value = "triggerSourceType")]
        Triggersourcetype,

        /// <summary>
        /// Enum Userid for "userId"
        /// </summary>
        [EnumMember(Value = "userId")]
        Userid,

        /// <summary>
        /// Enum Wrapupcoderating for "wrapUpCodeRating"
        /// </summary>
        [EnumMember(Value = "wrapUpCodeRating")]
        Wrapupcoderating,

        /// <summary>
        /// Enum Wrapupcodesuggestionselected for "wrapUpCodeSuggestionSelected"
        /// </summary>
        [EnumMember(Value = "wrapUpCodeSuggestionSelected")]
        Wrapupcodesuggestionselected,

        /// <summary>
        /// Enum Wrapupcodesgenerated for "wrapupCodesGenerated"
        /// </summary>
        [EnumMember(Value = "wrapupCodesGenerated")]
        Wrapupcodesgenerated
    }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    
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
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Left hand side for dimension predicates
    /// </summary>
    /// <value>Left hand side for dimension predicates</value>
    [JsonPropertyName("dimension")]
    public DimensionEnum? Dimension { get; set; }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SummaryAggregateQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">Left hand side for dimension predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for dimension predicates.</param>
    /// <param name="Range">Right hand side for dimension predicates.</param>
    public SummaryAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
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
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Right hand side for dimension predicates
    /// </summary>
    /// <value>Right hand side for dimension predicates</value>
    [JsonPropertyName("range")]
    public NumericRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SummaryAggregateQueryPredicate {\n");

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
        return Equals(obj as SummaryAggregateQueryPredicate);
    }

    /// <summary>
    /// Returns true if SummaryAggregateQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of SummaryAggregateQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SummaryAggregateQueryPredicate other)
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
