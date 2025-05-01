using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerRulesetConfigChangeDataActionConditionPredicate
/// </summary>
[DataContract]
public partial class DialerRulesetConfigChangeDataActionConditionPredicate : IEquatable<DialerRulesetConfigChangeDataActionConditionPredicate>
{
    /// <summary>
    /// The operation with which to evaluate this condition
    /// </summary>
    /// <value>The operation with which to evaluate this condition</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OutputOperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Equals for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        Equals,

        /// <summary>
        /// Enum LessThan for "LESS_THAN"
        /// </summary>
        [EnumMember(Value = "LESS_THAN")]
        LessThan,

        /// <summary>
        /// Enum LessThanEquals for "LESS_THAN_EQUALS"
        /// </summary>
        [EnumMember(Value = "LESS_THAN_EQUALS")]
        LessThanEquals,

        /// <summary>
        /// Enum GreaterThan for "GREATER_THAN"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN")]
        GreaterThan,

        /// <summary>
        /// Enum GreaterThanEquals for "GREATER_THAN_EQUALS"
        /// </summary>
        [EnumMember(Value = "GREATER_THAN_EQUALS")]
        GreaterThanEquals,

        /// <summary>
        /// Enum Contains for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        Contains,

        /// <summary>
        /// Enum BeginsWith for "BEGINS_WITH"
        /// </summary>
        [EnumMember(Value = "BEGINS_WITH")]
        BeginsWith,

        /// <summary>
        /// Enum EndsWith for "ENDS_WITH"
        /// </summary>
        [EnumMember(Value = "ENDS_WITH")]
        EndsWith,

        /// <summary>
        /// Enum Before for "BEFORE"
        /// </summary>
        [EnumMember(Value = "BEFORE")]
        Before,

        /// <summary>
        /// Enum After for "AFTER"
        /// </summary>
        [EnumMember(Value = "AFTER")]
        After
    }
    /// <summary>
    /// The operation with which to evaluate this condition
    /// </summary>
    /// <value>The operation with which to evaluate this condition</value>
    [DataMember(Name = "outputOperator", EmitDefaultValue = false)]
    public OutputOperatorEnum? OutputOperator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerRulesetConfigChangeDataActionConditionPredicate" /> class.
    /// </summary>
    /// <param name="OutputField">The name of an output field from the data action&#39;s output to use for this condition.</param>
    /// <param name="OutputOperator">The operation with which to evaluate this condition.</param>
    /// <param name="ComparisonValue">The value to compare against for this condition.</param>
    /// <param name="OutputFieldMissingResolution">The result of this predicate if the requested output field is missing from the data action&#39;s result.</param>
    /// <param name="Inverted">If true, inverts the result of evaluating this Predicate. Default is false..</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerRulesetConfigChangeDataActionConditionPredicate(string OutputField = null, OutputOperatorEnum? OutputOperator = null, string ComparisonValue = null, bool? OutputFieldMissingResolution = null, bool? Inverted = null, Dictionary<string, Object> AdditionalProperties = null)
    {
        this.OutputField = OutputField;
        this.OutputOperator = OutputOperator;
        this.ComparisonValue = ComparisonValue;
        this.OutputFieldMissingResolution = OutputFieldMissingResolution;
        this.Inverted = Inverted;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The name of an output field from the data action&#39;s output to use for this condition
    /// </summary>
    /// <value>The name of an output field from the data action&#39;s output to use for this condition</value>
    [DataMember(Name = "outputField", EmitDefaultValue = false)]
    public string OutputField { get; set; }





    /// <summary>
    /// The value to compare against for this condition
    /// </summary>
    /// <value>The value to compare against for this condition</value>
    [DataMember(Name = "comparisonValue", EmitDefaultValue = false)]
    public string ComparisonValue { get; set; }



    /// <summary>
    /// The result of this predicate if the requested output field is missing from the data action&#39;s result
    /// </summary>
    /// <value>The result of this predicate if the requested output field is missing from the data action&#39;s result</value>
    [DataMember(Name = "outputFieldMissingResolution", EmitDefaultValue = false)]
    public bool? OutputFieldMissingResolution { get; set; }



    /// <summary>
    /// If true, inverts the result of evaluating this Predicate. Default is false.
    /// </summary>
    /// <value>If true, inverts the result of evaluating this Predicate. Default is false.</value>
    [DataMember(Name = "inverted", EmitDefaultValue = false)]
    public bool? Inverted { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, Object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerRulesetConfigChangeDataActionConditionPredicate {\n");

        sb.Append("  OutputField: ").Append(OutputField).Append("\n");
        sb.Append("  OutputOperator: ").Append(OutputOperator).Append("\n");
        sb.Append("  ComparisonValue: ").Append(ComparisonValue).Append("\n");
        sb.Append("  OutputFieldMissingResolution: ").Append(OutputFieldMissingResolution).Append("\n");
        sb.Append("  Inverted: ").Append(Inverted).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return this.Equals(obj as DialerRulesetConfigChangeDataActionConditionPredicate);
    }

    /// <summary>
    /// Returns true if DialerRulesetConfigChangeDataActionConditionPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerRulesetConfigChangeDataActionConditionPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerRulesetConfigChangeDataActionConditionPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.OutputField == other.OutputField ||
                this.OutputField != null &&
                this.OutputField.Equals(other.OutputField)
            ) &&
            (
                this.OutputOperator == other.OutputOperator ||
                this.OutputOperator != null &&
                this.OutputOperator.Equals(other.OutputOperator)
            ) &&
            (
                this.ComparisonValue == other.ComparisonValue ||
                this.ComparisonValue != null &&
                this.ComparisonValue.Equals(other.ComparisonValue)
            ) &&
            (
                this.OutputFieldMissingResolution == other.OutputFieldMissingResolution ||
                this.OutputFieldMissingResolution != null &&
                this.OutputFieldMissingResolution.Equals(other.OutputFieldMissingResolution)
            ) &&
            (
                this.Inverted == other.Inverted ||
                this.Inverted != null &&
                this.Inverted.Equals(other.Inverted)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (this.OutputField != null)
            {
                hash = hash * 59 + this.OutputField.GetHashCode();
            }

            if (this.OutputOperator != null)
            {
                hash = hash * 59 + this.OutputOperator.GetHashCode();
            }

            if (this.ComparisonValue != null)
            {
                hash = hash * 59 + this.ComparisonValue.GetHashCode();
            }

            if (this.OutputFieldMissingResolution != null)
            {
                hash = hash * 59 + this.OutputFieldMissingResolution.GetHashCode();
            }

            if (this.Inverted != null)
            {
                hash = hash * 59 + this.Inverted.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
