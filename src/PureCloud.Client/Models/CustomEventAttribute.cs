using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CustomEventAttribute
/// </summary>

public partial class CustomEventAttribute : IEquatable<CustomEventAttribute>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomEventAttribute" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CustomEventAttribute() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CustomEventAttribute" /> class.
    /// </summary>
    /// <param name="DataType">The data type of the custom attribute. (required).</param>
    /// <param name="Value">The value of the custom attribute. (required).</param>
    public CustomEventAttribute(string DataType = null, string Value = null)
    {
        this.DataType = DataType;
        this.Value = Value;

    }



    /// <summary>
    /// The data type of the custom attribute.
    /// </summary>
    /// <value>The data type of the custom attribute.</value>
    [JsonPropertyName("dataType")]
    public string DataType { get; set; }



    /// <summary>
    /// The value of the custom attribute.
    /// </summary>
    /// <value>The value of the custom attribute.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CustomEventAttribute {\n");

        sb.Append("  DataType: ").Append(DataType).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as CustomEventAttribute);
    }

    /// <summary>
    /// Returns true if CustomEventAttribute instances are equal
    /// </summary>
    /// <param name="other">Instance of CustomEventAttribute to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CustomEventAttribute other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DataType == other.DataType ||
                DataType != null &&
                DataType.Equals(other.DataType)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (DataType != null)
            {
                hash = hash * 59 + DataType.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
