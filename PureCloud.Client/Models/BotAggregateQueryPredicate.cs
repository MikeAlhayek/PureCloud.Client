using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BotAggregateQueryPredicate
/// </summary>
[DataContract]
public partial class BotAggregateQueryPredicate : IEquatable<BotAggregateQueryPredicate>
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
        /// Enum Askactionid for "askActionId"
        /// </summary>
        [EnumMember(Value = "askActionId")]
        Askactionid,

        /// <summary>
        /// Enum Askactionresult for "askActionResult"
        /// </summary>
        [EnumMember(Value = "askActionResult")]
        Askactionresult,

        /// <summary>
        /// Enum Askactiontype for "askActionType"
        /// </summary>
        [EnumMember(Value = "askActionType")]
        Askactiontype,

        /// <summary>
        /// Enum Botfinalintent for "botFinalIntent"
        /// </summary>
        [EnumMember(Value = "botFinalIntent")]
        Botfinalintent,

        /// <summary>
        /// Enum Botflowsubtype for "botFlowSubType"
        /// </summary>
        [EnumMember(Value = "botFlowSubType")]
        Botflowsubtype,

        /// <summary>
        /// Enum Botflowtype for "botFlowType"
        /// </summary>
        [EnumMember(Value = "botFlowType")]
        Botflowtype,

        /// <summary>
        /// Enum Botid for "botId"
        /// </summary>
        [EnumMember(Value = "botId")]
        Botid,

        /// <summary>
        /// Enum Botintent for "botIntent"
        /// </summary>
        [EnumMember(Value = "botIntent")]
        Botintent,

        /// <summary>
        /// Enum Botname for "botName"
        /// </summary>
        [EnumMember(Value = "botName")]
        Botname,

        /// <summary>
        /// Enum Botproduct for "botProduct"
        /// </summary>
        [EnumMember(Value = "botProduct")]
        Botproduct,

        /// <summary>
        /// Enum Botprovider for "botProvider"
        /// </summary>
        [EnumMember(Value = "botProvider")]
        Botprovider,

        /// <summary>
        /// Enum Botrecognitionfailurereason for "botRecognitionFailureReason"
        /// </summary>
        [EnumMember(Value = "botRecognitionFailureReason")]
        Botrecognitionfailurereason,

        /// <summary>
        /// Enum Botresult for "botResult"
        /// </summary>
        [EnumMember(Value = "botResult")]
        Botresult,

        /// <summary>
        /// Enum Botsessionid for "botSessionId"
        /// </summary>
        [EnumMember(Value = "botSessionId")]
        Botsessionid,

        /// <summary>
        /// Enum Botslot for "botSlot"
        /// </summary>
        [EnumMember(Value = "botSlot")]
        Botslot,

        /// <summary>
        /// Enum Botslotmechanism for "botSlotMechanism"
        /// </summary>
        [EnumMember(Value = "botSlotMechanism")]
        Botslotmechanism,

        /// <summary>
        /// Enum Botversion for "botVersion"
        /// </summary>
        [EnumMember(Value = "botVersion")]
        Botversion,

        /// <summary>
        /// Enum Conversationid for "conversationId"
        /// </summary>
        [EnumMember(Value = "conversationId")]
        Conversationid,

        /// <summary>
        /// Enum Externalcontactid for "externalContactId"
        /// </summary>
        [EnumMember(Value = "externalContactId")]
        Externalcontactid,

        /// <summary>
        /// Enum Intermediateintentname for "intermediateIntentName"
        /// </summary>
        [EnumMember(Value = "intermediateIntentName")]
        Intermediateintentname,

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
        /// Enum Lastactionid for "lastActionId"
        /// </summary>
        [EnumMember(Value = "lastActionId")]
        Lastactionid,

        /// <summary>
        /// Enum Lastinputactionid for "lastInputActionId"
        /// </summary>
        [EnumMember(Value = "lastInputActionId")]
        Lastinputactionid,

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
        /// Enum Previewmode for "previewMode"
        /// </summary>
        [EnumMember(Value = "previewMode")]
        Previewmode,

        /// <summary>
        /// Enum Selfserved for "selfServed"
        /// </summary>
        [EnumMember(Value = "selfServed")]
        Selfserved
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
    /// Initializes a new instance of the <see cref="BotAggregateQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Dimension">Left hand side for dimension predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for dimension predicates.</param>
    /// <param name="Range">Right hand side for dimension predicates.</param>
    public BotAggregateQueryPredicate(TypeEnum? Type = null, DimensionEnum? Dimension = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
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
        sb.Append("class BotAggregateQueryPredicate {\n");

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
        return Equals(obj as BotAggregateQueryPredicate);
    }

    /// <summary>
    /// Returns true if BotAggregateQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of BotAggregateQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BotAggregateQueryPredicate other)
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
