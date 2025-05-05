using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactColumnConditionSettings
/// </summary>

public partial class ContactColumnConditionSettings : IEquatable<ContactColumnConditionSettings>
{
    /// <summary>
    /// The operator to use when comparing values.
    /// </summary>
    /// <value>The operator to use when comparing values.</value>
    
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
        /// Enum Equals for "Equals"
        /// </summary>
        [EnumMember(Value = "Equals")]
        Equals,

        /// <summary>
        /// Enum Lessthan for "LessThan"
        /// </summary>
        [EnumMember(Value = "LessThan")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanequals for "LessThanEquals"
        /// </summary>
        [EnumMember(Value = "LessThanEquals")]
        Lessthanequals,

        /// <summary>
        /// Enum Greaterthan for "GreaterThan"
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanequals for "GreaterThanEquals"
        /// </summary>
        [EnumMember(Value = "GreaterThanEquals")]
        Greaterthanequals,

        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,

        /// <summary>
        /// Enum Beginswith for "BeginsWith"
        /// </summary>
        [EnumMember(Value = "BeginsWith")]
        Beginswith,

        /// <summary>
        /// Enum Endswith for "EndsWith"
        /// </summary>
        [EnumMember(Value = "EndsWith")]
        Endswith,

        /// <summary>
        /// Enum Before for "Before"
        /// </summary>
        [EnumMember(Value = "Before")]
        Before,

        /// <summary>
        /// Enum After for "After"
        /// </summary>
        [EnumMember(Value = "After")]
        After
    }
    /// <summary>
    /// The data type the value should be treated as.
    /// </summary>
    /// <value>The data type the value should be treated as.</value>
    
    public enum ValueTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Datetime for "DateTime"
        /// </summary>
        [EnumMember(Value = "DateTime")]
        Datetime,

        /// <summary>
        /// Enum Numeric for "Numeric"
        /// </summary>
        [EnumMember(Value = "Numeric")]
        Numeric,

        /// <summary>
        /// Enum Period for "Period"
        /// </summary>
        [EnumMember(Value = "Period")]
        Period,

        /// <summary>
        /// Enum String for "String"
        /// </summary>
        [EnumMember(Value = "String")]
        String
    }
    /// <summary>
    /// The operator to use when comparing values.
    /// </summary>
    /// <value>The operator to use when comparing values.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// The data type the value should be treated as.
    /// </summary>
    /// <value>The data type the value should be treated as.</value>
    [JsonPropertyName("valueType")]
    public ValueTypeEnum? ValueType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactColumnConditionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactColumnConditionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactColumnConditionSettings" /> class.
    /// </summary>
    /// <param name="ColumnName">The name of the contact list column to evaluate. (required).</param>
    /// <param name="Operator">The operator to use when comparing values. (required).</param>
    /// <param name="Value">The value to compare against the contact&#39;s data. (required).</param>
    /// <param name="ValueType">The data type the value should be treated as. (required).</param>
    public ContactColumnConditionSettings(string ColumnName = null, OperatorEnum? Operator = null, string Value = null, ValueTypeEnum? ValueType = null)
    {
        this.ColumnName = ColumnName;
        this.Operator = Operator;
        this.Value = Value;
        this.ValueType = ValueType;

    }



    /// <summary>
    /// The name of the contact list column to evaluate.
    /// </summary>
    /// <value>The name of the contact list column to evaluate.</value>
    [JsonPropertyName("columnName")]
    public string ColumnName { get; set; }





    /// <summary>
    /// The value to compare against the contact&#39;s data.
    /// </summary>
    /// <value>The value to compare against the contact&#39;s data.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactColumnConditionSettings {\n");

        sb.Append("  ColumnName: ").Append(ColumnName).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
        return Equals(obj as ContactColumnConditionSettings);
    }

    /// <summary>
    /// Returns true if ContactColumnConditionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactColumnConditionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactColumnConditionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ColumnName == other.ColumnName ||
                ColumnName != null &&
                ColumnName.Equals(other.ColumnName)
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
                ValueType == other.ValueType ||
                ValueType != null &&
                ValueType.Equals(other.ValueType)
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
            if (ColumnName != null)
            {
                hash = hash * 59 + ColumnName.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (ValueType != null)
            {
                hash = hash * 59 + ValueType.GetHashCode();
            }

            return hash;
        }
    }
}
