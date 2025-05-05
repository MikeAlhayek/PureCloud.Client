using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OneOnOne
/// </summary>

public partial class OneOnOne : IEquatable<OneOnOne>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OneOnOne" /> class.
    /// </summary>
    /// <param name="PinnedMessages">Room&#39;s pinned messages.</param>
    public OneOnOne(List<AddressableEntityRef> PinnedMessages = null)
    {
        this.PinnedMessages = PinnedMessages;

    }



    /// <summary>
    /// Room&#39;s pinned messages
    /// </summary>
    /// <value>Room&#39;s pinned messages</value>
    [JsonPropertyName("pinnedMessages")]
    public List<AddressableEntityRef> PinnedMessages { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OneOnOne {\n");

        sb.Append("  PinnedMessages: ").Append(PinnedMessages).Append("\n");
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
        return Equals(obj as OneOnOne);
    }

    /// <summary>
    /// Returns true if OneOnOne instances are equal
    /// </summary>
    /// <param name="other">Instance of OneOnOne to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OneOnOne other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PinnedMessages == other.PinnedMessages ||
                PinnedMessages != null &&
                PinnedMessages.SequenceEqual(other.PinnedMessages)
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
            if (PinnedMessages != null)
            {
                hash = hash * 59 + PinnedMessages.GetHashCode();
            }

            return hash;
        }
    }
}
