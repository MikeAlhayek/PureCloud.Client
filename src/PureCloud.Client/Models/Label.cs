using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Label
/// </summary>

public partial class Label : IEquatable<Label>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Label" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Label() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Label" /> class.
    /// </summary>
    /// <param name="Name">Name of the label (required).</param>
    /// <param name="Value">Value of the label (required).</param>
    public Label(string Name = null, string Value = null)
    {
        this.Name = Name;
        this.Value = Value;

    }



    /// <summary>
    /// Name of the label
    /// </summary>
    /// <value>Name of the label</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Value of the label
    /// </summary>
    /// <value>Value of the label</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// Whether the label is encoded or not
    /// </summary>
    /// <value>Whether the label is encoded or not</value>
    [JsonPropertyName("encoded")]
    public bool? Encoded { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Label {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Encoded: ").Append(Encoded).Append("\n");
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
        return Equals(obj as Label);
    }

    /// <summary>
    /// Returns true if Label instances are equal
    /// </summary>
    /// <param name="other">Instance of Label to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Label other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Encoded == other.Encoded ||
                Encoded != null &&
                Encoded.Equals(other.Encoded)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Encoded != null)
            {
                hash = hash * 59 + Encoded.GetHashCode();
            }

            return hash;
        }
    }
}
