using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// ResolutionDetailQueryPredicate
/// </summary>
[DataContract]
public partial class ResolutionDetailQueryPredicate : IEquatable<ResolutionDetailQueryPredicate>
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
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nnextcontactavoided for "nNextContactAvoided"
        /// </summary>
        [EnumMember(Value = "nNextContactAvoided")]
        Nnextcontactavoided
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
    /// Left hand side for metric predicates
    /// </summary>
    /// <value>Left hand side for metric predicates</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Optional operator, default is matches
    /// </summary>
    /// <value>Optional operator, default is matches</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResolutionDetailQueryPredicate" /> class.
    /// </summary>
    /// <param name="Type">Optional type, can usually be inferred.</param>
    /// <param name="Metric">Left hand side for metric predicates.</param>
    /// <param name="Operator">Optional operator, default is matches.</param>
    /// <param name="Value">Right hand side for metric predicates.</param>
    /// <param name="Range">Right hand side for metric predicates.</param>
    public ResolutionDetailQueryPredicate(TypeEnum? Type = null, MetricEnum? Metric = null, OperatorEnum? Operator = null, string Value = null, NumericRange Range = null)
    {
        this.Type = Type;
        this.Metric = Metric;
        this.Operator = Operator;
        this.Value = Value;
        this.Range = Range;

    }









    /// <summary>
    /// Right hand side for metric predicates
    /// </summary>
    /// <value>Right hand side for metric predicates</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// Right hand side for metric predicates
    /// </summary>
    /// <value>Right hand side for metric predicates</value>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public NumericRange Range { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResolutionDetailQueryPredicate {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
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
        return this.Equals(obj as ResolutionDetailQueryPredicate);
    }

    /// <summary>
    /// Returns true if ResolutionDetailQueryPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of ResolutionDetailQueryPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResolutionDetailQueryPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Metric == other.Metric ||
                this.Metric != null &&
                this.Metric.Equals(other.Metric)
            ) &&
            (
                this.Operator == other.Operator ||
                this.Operator != null &&
                this.Operator.Equals(other.Operator)
            ) &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
            ) &&
            (
                this.Range == other.Range ||
                this.Range != null &&
                this.Range.Equals(other.Range)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Metric != null)
            {
                hash = hash * 59 + this.Metric.GetHashCode();
            }

            if (this.Operator != null)
            {
                hash = hash * 59 + this.Operator.GetHashCode();
            }

            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            if (this.Range != null)
            {
                hash = hash * 59 + this.Range.GetHashCode();
            }

            return hash;
        }
    }
}
