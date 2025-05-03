using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemFilter
/// </summary>

public partial class WorkitemFilter : IEquatable<WorkitemFilter>
{
    /// <summary>
    /// Attribute type.
    /// </summary>
    /// <value>Attribute type.</value>
    
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
        /// Enum String for "String"
        /// </summary>
        [EnumMember(Value = "String")]
        String,

        /// <summary>
        /// Enum Int for "Int"
        /// </summary>
        [EnumMember(Value = "Int")]
        Int
    }
    /// <summary>
    /// Filter operator.
    /// </summary>
    /// <value>Filter operator.</value>
    
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
        /// Enum Eq for "EQ"
        /// </summary>
        [EnumMember(Value = "EQ")]
        Eq,

        /// <summary>
        /// Enum Neq for "NEQ"
        /// </summary>
        [EnumMember(Value = "NEQ")]
        Neq,

        /// <summary>
        /// Enum Gt for "GT"
        /// </summary>
        [EnumMember(Value = "GT")]
        Gt,

        /// <summary>
        /// Enum Lt for "LT"
        /// </summary>
        [EnumMember(Value = "LT")]
        Lt,

        /// <summary>
        /// Enum Gte for "GTE"
        /// </summary>
        [EnumMember(Value = "GTE")]
        Gte,

        /// <summary>
        /// Enum Lte for "LTE"
        /// </summary>
        [EnumMember(Value = "LTE")]
        Lte,

        /// <summary>
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In,

        /// <summary>
        /// Enum Contains for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        Contains,

        /// <summary>
        /// Enum Between for "BETWEEN"
        /// </summary>
        [EnumMember(Value = "BETWEEN")]
        Between,

        /// <summary>
        /// Enum BeginsWith for "BEGINS_WITH"
        /// </summary>
        [EnumMember(Value = "BEGINS_WITH")]
        BeginsWith
    }
    /// <summary>
    /// Attribute type.
    /// </summary>
    /// <value>Attribute type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Filter operator.
    /// </summary>
    /// <value>Filter operator.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemFilter" /> class.
    /// </summary>
    /// <param name="Name">Attribute name. (required).</param>
    /// <param name="Type">Attribute type. (required).</param>
    /// <param name="Operator">Filter operator. (required).</param>
    /// <param name="Values">List of values to be used in the filter. (required).</param>
    public WorkitemFilter(string Name = null, TypeEnum? Type = null, OperatorEnum? Operator = null, List<string> Values = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Operator = Operator;
        this.Values = Values;

    }



    /// <summary>
    /// Attribute name.
    /// </summary>
    /// <value>Attribute name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// List of values to be used in the filter.
    /// </summary>
    /// <value>List of values to be used in the filter.</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemFilter {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as WorkitemFilter);
    }

    /// <summary>
    /// Returns true if WorkitemFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
