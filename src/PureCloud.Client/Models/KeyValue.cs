using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KeyValue
/// </summary>

public partial class KeyValue : IEquatable<KeyValue>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KeyValue" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KeyValue() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KeyValue" /> class.
    /// </summary>
    /// <param name="Key">Key for free-form data. (required).</param>
    /// <param name="Value">Value for free-form data. (required).</param>
    public KeyValue(string Key = null, string Value = null)
    {
        this.Key = Key;
        this.Value = Value;

    }



    /// <summary>
    /// Key for free-form data.
    /// </summary>
    /// <value>Key for free-form data.</value>
    [JsonPropertyName("key")]
    public string Key { get; set; }



    /// <summary>
    /// Value for free-form data.
    /// </summary>
    /// <value>Value for free-form data.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KeyValue {\n");

        sb.Append("  Key: ").Append(Key).Append("\n");
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
        return Equals(obj as KeyValue);
    }

    /// <summary>
    /// Returns true if KeyValue instances are equal
    /// </summary>
    /// <param name="other">Instance of KeyValue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KeyValue other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Key == other.Key ||
                Key != null &&
                Key.Equals(other.Key)
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
            if (Key != null)
            {
                hash = hash * 59 + Key.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
