using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ValueWrapperHrisTimeOffType
/// </summary>

public partial class ValueWrapperHrisTimeOffType : IEquatable<ValueWrapperHrisTimeOffType>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValueWrapperHrisTimeOffType" /> class.
    /// </summary>
    /// <param name="Value">The value for the associated field.</param>
    public ValueWrapperHrisTimeOffType(HrisTimeOffType Value = null)
    {
        this.Value = Value;

    }



    /// <summary>
    /// The value for the associated field
    /// </summary>
    /// <value>The value for the associated field</value>
    [JsonPropertyName("value")]
    public HrisTimeOffType Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ValueWrapperHrisTimeOffType {\n");

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
        return Equals(obj as ValueWrapperHrisTimeOffType);
    }

    /// <summary>
    /// Returns true if ValueWrapperHrisTimeOffType instances are equal
    /// </summary>
    /// <param name="other">Instance of ValueWrapperHrisTimeOffType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ValueWrapperHrisTimeOffType other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
