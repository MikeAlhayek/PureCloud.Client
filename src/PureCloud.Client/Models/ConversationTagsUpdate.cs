using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationTagsUpdate
/// </summary>

public partial class ConversationTagsUpdate : IEquatable<ConversationTagsUpdate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationTagsUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationTagsUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationTagsUpdate" /> class.
    /// </summary>
    /// <param name="ExternalTag">The external tag associated with the conversation. (required).</param>
    public ConversationTagsUpdate(string ExternalTag = null)
    {
        this.ExternalTag = ExternalTag;

    }



    /// <summary>
    /// The external tag associated with the conversation.
    /// </summary>
    /// <value>The external tag associated with the conversation.</value>
    [JsonPropertyName("externalTag")]
    public string ExternalTag { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationTagsUpdate {\n");

        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
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
        return Equals(obj as ConversationTagsUpdate);
    }

    /// <summary>
    /// Returns true if ConversationTagsUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationTagsUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationTagsUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
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
            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            return hash;
        }
    }
}
