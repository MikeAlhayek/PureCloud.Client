using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerContactlistfilterConfigChangeFilterPredicate
/// </summary>
[DataContract]
public partial class DialerContactlistfilterConfigChangeFilterPredicate : IEquatable<DialerContactlistfilterConfigChangeFilterPredicate>
{
    /// <summary>
    /// Whether a contact column is numeric or alphabetic
    /// </summary>
    /// <value>Whether a contact column is numeric or alphabetic</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ColumnTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Numeric for "numeric"
        /// </summary>
        [EnumMember(Value = "numeric")]
        Numeric,

        /// <summary>
        /// Enum Alphabetic for "alphabetic"
        /// </summary>
        [EnumMember(Value = "alphabetic")]
        Alphabetic
    }
    /// <summary>
    /// The comparison operator
    /// </summary>
    /// <value>The comparison operator</value>
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
        After,

        /// <summary>
        /// Enum Between for "BETWEEN"
        /// </summary>
        [EnumMember(Value = "BETWEEN")]
        Between,

        /// <summary>
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In
    }
    /// <summary>
    /// Whether a contact column is numeric or alphabetic
    /// </summary>
    /// <value>Whether a contact column is numeric or alphabetic</value>
    [DataMember(Name = "columnType", EmitDefaultValue = false)]
    public ColumnTypeEnum? ColumnType { get; set; }
    /// <summary>
    /// The comparison operator
    /// </summary>
    /// <value>The comparison operator</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeFilterPredicate" /> class.
    /// </summary>
    /// <param name="Column">The contact list column.</param>
    /// <param name="ColumnType">Whether a contact column is numeric or alphabetic.</param>
    /// <param name="Operator">The comparison operator.</param>
    /// <param name="Value">The value the predicate applies to.</param>
    /// <param name="Range">Range.</param>
    /// <param name="Inverted">Whether or not to invert to result of evaluating the predicate.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerContactlistfilterConfigChangeFilterPredicate(string Column = null, ColumnTypeEnum? ColumnType = null, OperatorEnum? Operator = null, string Value = null, DialerContactlistfilterConfigChangeRange Range = null, bool? Inverted = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Column = Column;
        this.ColumnType = ColumnType;
        this.Operator = Operator;
        this.Value = Value;
        this.Range = Range;
        this.Inverted = Inverted;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// The contact list column
    /// </summary>
    /// <value>The contact list column</value>
    [DataMember(Name = "column", EmitDefaultValue = false)]
    public string Column { get; set; }







    /// <summary>
    /// The value the predicate applies to
    /// </summary>
    /// <value>The value the predicate applies to</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// Gets or Sets Range
    /// </summary>
    [DataMember(Name = "range", EmitDefaultValue = false)]
    public DialerContactlistfilterConfigChangeRange Range { get; set; }



    /// <summary>
    /// Whether or not to invert to result of evaluating the predicate
    /// </summary>
    /// <value>Whether or not to invert to result of evaluating the predicate</value>
    [DataMember(Name = "inverted", EmitDefaultValue = false)]
    public bool? Inverted { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerContactlistfilterConfigChangeFilterPredicate {\n");

        sb.Append("  Column: ").Append(Column).Append("\n");
        sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Range: ").Append(Range).Append("\n");
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
        return Equals(obj as DialerContactlistfilterConfigChangeFilterPredicate);
    }

    /// <summary>
    /// Returns true if DialerContactlistfilterConfigChangeFilterPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistfilterConfigChangeFilterPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistfilterConfigChangeFilterPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Column == other.Column ||
                Column != null &&
                Column.Equals(other.Column)
            ) &&
            (
                ColumnType == other.ColumnType ||
                ColumnType != null &&
                ColumnType.Equals(other.ColumnType)
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
            ) &&
            (
                Inverted == other.Inverted ||
                Inverted != null &&
                Inverted.Equals(other.Inverted)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (Column != null)
            {
                hash = hash * 59 + Column.GetHashCode();
            }

            if (ColumnType != null)
            {
                hash = hash * 59 + ColumnType.GetHashCode();
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

            if (Inverted != null)
            {
                hash = hash * 59 + Inverted.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
