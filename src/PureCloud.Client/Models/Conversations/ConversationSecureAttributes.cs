using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSecureAttributes
/// </summary>

public partial class ConversationSecureAttributes : IEquatable<ConversationSecureAttributes>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSecureAttributes" /> class.
    /// </summary>
    /// <param name="Attributes">The map of attribute keys to values..</param>
    /// <param name="Version">The version used to detect conflicting updates when using PUT. Not used for PATCH..</param>
    public ConversationSecureAttributes(Dictionary<string, string> Attributes = null, int? Version = null)
    {
        this.Attributes = Attributes;
        this.Version = Version;

    }



    /// <summary>
    /// The map of attribute keys to values.
    /// </summary>
    /// <value>The map of attribute keys to values.</value>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// The version used to detect conflicting updates when using PUT. Not used for PATCH.
    /// </summary>
    /// <value>The version used to detect conflicting updates when using PUT. Not used for PATCH.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSecureAttributes {\n");

        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as ConversationSecureAttributes);
    }

    /// <summary>
    /// Returns true if ConversationSecureAttributes instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSecureAttributes to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSecureAttributes other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
