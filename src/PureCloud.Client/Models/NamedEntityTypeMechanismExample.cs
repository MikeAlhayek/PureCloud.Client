using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityTypeMechanismExample
/// </summary>

public partial class NamedEntityTypeMechanismExample : IEquatable<NamedEntityTypeMechanismExample>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeMechanismExample" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityTypeMechanismExample() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityTypeMechanismExample" /> class.
    /// </summary>
    /// <param name="Text">Example input text (required).</param>
    /// <param name="ResolvedValue">Resolved entity value (required).</param>
    public NamedEntityTypeMechanismExample(string Text = null, string ResolvedValue = null)
    {
        this.Text = Text;
        this.ResolvedValue = ResolvedValue;

    }



    /// <summary>
    /// Example input text
    /// </summary>
    /// <value>Example input text</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Resolved entity value
    /// </summary>
    /// <value>Resolved entity value</value>
    [JsonPropertyName("resolvedValue")]
    public string ResolvedValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityTypeMechanismExample {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  ResolvedValue: ").Append(ResolvedValue).Append("\n");
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
        return Equals(obj as NamedEntityTypeMechanismExample);
    }

    /// <summary>
    /// Returns true if NamedEntityTypeMechanismExample instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityTypeMechanismExample to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityTypeMechanismExample other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                ResolvedValue == other.ResolvedValue ||
                ResolvedValue != null &&
                ResolvedValue.Equals(other.ResolvedValue)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (ResolvedValue != null)
            {
                hash = hash * 59 + ResolvedValue.GetHashCode();
            }

            return hash;
        }
    }
}
