using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsConversationWithoutAttributesMultiGetResponse
/// </summary>

public partial class AnalyticsConversationWithoutAttributesMultiGetResponse : IEquatable<AnalyticsConversationWithoutAttributesMultiGetResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsConversationWithoutAttributesMultiGetResponse" /> class.
    /// </summary>
    /// <param name="Conversations">Conversations.</param>
    public AnalyticsConversationWithoutAttributesMultiGetResponse(List<AnalyticsConversationWithoutAttributes> Conversations = null)
    {
        this.Conversations = Conversations;

    }



    /// <summary>
    /// Gets or Sets Conversations
    /// </summary>
    [JsonPropertyName("conversations")]
    public List<AnalyticsConversationWithoutAttributes> Conversations { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsConversationWithoutAttributesMultiGetResponse {\n");

        sb.Append("  Conversations: ").Append(Conversations).Append("\n");
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
        return Equals(obj as AnalyticsConversationWithoutAttributesMultiGetResponse);
    }

    /// <summary>
    /// Returns true if AnalyticsConversationWithoutAttributesMultiGetResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsConversationWithoutAttributesMultiGetResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsConversationWithoutAttributesMultiGetResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Conversations == other.Conversations ||
                Conversations != null &&
                Conversations.SequenceEqual(other.Conversations)
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
            if (Conversations != null)
            {
                hash = hash * 59 + Conversations.GetHashCode();
            }

            return hash;
        }
    }
}
