using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallbackDisconnectIdentifier
/// </summary>

public partial class CallbackDisconnectIdentifier : IEquatable<CallbackDisconnectIdentifier>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackDisconnectIdentifier" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CallbackDisconnectIdentifier() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallbackDisconnectIdentifier" /> class.
    /// </summary>
    /// <param name="ConversationId">The Conversation Id. (required).</param>
    /// <param name="CallbackId">The callback id. (required).</param>
    public CallbackDisconnectIdentifier(string ConversationId = null, string CallbackId = null)
    {
        this.ConversationId = ConversationId;
        this.CallbackId = CallbackId;

    }



    /// <summary>
    /// The Conversation Id.
    /// </summary>
    /// <value>The Conversation Id.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The callback id.
    /// </summary>
    /// <value>The callback id.</value>
    [JsonPropertyName("callbackId")]
    public string CallbackId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallbackDisconnectIdentifier {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CallbackId: ").Append(CallbackId).Append("\n");
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
        return Equals(obj as CallbackDisconnectIdentifier);
    }

    /// <summary>
    /// Returns true if CallbackDisconnectIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of CallbackDisconnectIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallbackDisconnectIdentifier other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CallbackId == other.CallbackId ||
                CallbackId != null &&
                CallbackId.Equals(other.CallbackId)
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
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CallbackId != null)
            {
                hash = hash * 59 + CallbackId.GetHashCode();
            }

            return hash;
        }
    }
}
