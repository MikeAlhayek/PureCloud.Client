using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentFilterItem
/// </summary>

public partial class ContentFilterItem : IEquatable<ContentFilterItem>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum Number for "NUMBER"
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        Number,

        /// <summary>
        /// Enum String for "STRING"
        /// </summary>
        [EnumMember(Value = "STRING")]
        String,

        /// <summary>
        /// Enum Date for "DATE"
        /// </summary>
        [EnumMember(Value = "DATE")]
        Date,

        /// <summary>
        /// Enum Boolean for "BOOLEAN"
        /// </summary>
        [EnumMember(Value = "BOOLEAN")]
        Boolean,

        /// <summary>
        /// Enum List for "LIST"
        /// </summary>
        [EnumMember(Value = "LIST")]
        List
    }
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    
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
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In,

        /// <summary>
        /// Enum Range for "RANGE"
        /// </summary>
        [EnumMember(Value = "RANGE")]
        Range,

        /// <summary>
        /// Enum Equals for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        Equals,

        /// <summary>
        /// Enum Notequals for "NOTEQUALS"
        /// </summary>
        [EnumMember(Value = "NOTEQUALS")]
        Notequals,

        /// <summary>
        /// Enum Lessthan for "LESSTHAN"
        /// </summary>
        [EnumMember(Value = "LESSTHAN")]
        Lessthan,

        /// <summary>
        /// Enum Lessthanequals for "LESSTHANEQUALS"
        /// </summary>
        [EnumMember(Value = "LESSTHANEQUALS")]
        Lessthanequals,

        /// <summary>
        /// Enum Greaterthan for "GREATERTHAN"
        /// </summary>
        [EnumMember(Value = "GREATERTHAN")]
        Greaterthan,

        /// <summary>
        /// Enum Greaterthanequals for "GREATERTHANEQUALS"
        /// </summary>
        [EnumMember(Value = "GREATERTHANEQUALS")]
        Greaterthanequals,

        /// <summary>
        /// Enum Contains for "CONTAINS"
        /// </summary>
        [EnumMember(Value = "CONTAINS")]
        Contains
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentFilterItem" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="Operator">Operator.</param>
    /// <param name="Values">Values.</param>
    public ContentFilterItem(string Name = null, TypeEnum? Type = null, OperatorEnum? Operator = null, List<string> Values = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Operator = Operator;
        this.Values = Values;

    }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }







    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentFilterItem {\n");

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
        return Equals(obj as ContentFilterItem);
    }

    /// <summary>
    /// Returns true if ContentFilterItem instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentFilterItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentFilterItem other)
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
