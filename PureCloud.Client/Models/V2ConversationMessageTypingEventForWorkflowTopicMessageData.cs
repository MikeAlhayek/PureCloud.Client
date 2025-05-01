using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// V2ConversationMessageTypingEventForWorkflowTopicMessageData
/// </summary>
[DataContract]
public partial class V2ConversationMessageTypingEventForWorkflowTopicMessageData : IEquatable<V2ConversationMessageTypingEventForWorkflowTopicMessageData>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2ConversationMessageTypingEventForWorkflowTopicMessageData" /> class.
    /// </summary>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="NormalizedMessage">NormalizedMessage.</param>
    public V2ConversationMessageTypingEventForWorkflowTopicMessageData(string ConversationId = null, V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage NormalizedMessage = null)
    {
        this.ConversationId = ConversationId;
        this.NormalizedMessage = NormalizedMessage;

    }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets NormalizedMessage
    /// </summary>
    [DataMember(Name = "normalizedMessage", EmitDefaultValue = false)]
    public V2ConversationMessageTypingEventForWorkflowTopicConversationNormalizedMessage NormalizedMessage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2ConversationMessageTypingEventForWorkflowTopicMessageData {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  NormalizedMessage: ").Append(NormalizedMessage).Append("\n");
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
        return Equals(obj as V2ConversationMessageTypingEventForWorkflowTopicMessageData);
    }

    /// <summary>
    /// Returns true if V2ConversationMessageTypingEventForWorkflowTopicMessageData instances are equal
    /// </summary>
    /// <param name="other">Instance of V2ConversationMessageTypingEventForWorkflowTopicMessageData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2ConversationMessageTypingEventForWorkflowTopicMessageData other)
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
                NormalizedMessage == other.NormalizedMessage ||
                NormalizedMessage != null &&
                NormalizedMessage.Equals(other.NormalizedMessage)
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

            if (NormalizedMessage != null)
            {
                hash = hash * 59 + NormalizedMessage.GetHashCode();
            }

            return hash;
        }
    }
}
