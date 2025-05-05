using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PatchCallbackRequest
/// </summary>

public partial class PatchCallbackRequest : IEquatable<PatchCallbackRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCallbackRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PatchCallbackRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PatchCallbackRequest" /> class.
    /// </summary>
    /// <param name="ConversationId">The conversationId. (required).</param>
    /// <param name="QueueId">The identifier of the queue to be used for the callback..</param>
    /// <param name="AgentId">The agentId. (required).</param>
    /// <param name="CallbackScheduledTime">The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public PatchCallbackRequest(string ConversationId = null, string QueueId = null, string AgentId = null, DateTime? CallbackScheduledTime = null)
    {
        this.ConversationId = ConversationId;
        this.QueueId = QueueId;
        this.AgentId = AgentId;
        this.CallbackScheduledTime = CallbackScheduledTime;

    }



    /// <summary>
    /// The conversationId.
    /// </summary>
    /// <value>The conversationId.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The identifier of the queue to be used for the callback.
    /// </summary>
    /// <value>The identifier of the queue to be used for the callback.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// The agentId.
    /// </summary>
    /// <value>The agentId.</value>
    [JsonPropertyName("agentId")]
    public string AgentId { get; set; }



    /// <summary>
    /// The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The scheduled date-time for the callback. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("callbackScheduledTime")]
    public DateTime? CallbackScheduledTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PatchCallbackRequest {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
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
        return Equals(obj as PatchCallbackRequest);
    }

    /// <summary>
    /// Returns true if PatchCallbackRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PatchCallbackRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PatchCallbackRequest other)
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
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                CallbackScheduledTime == other.CallbackScheduledTime ||
                CallbackScheduledTime != null &&
                CallbackScheduledTime.Equals(other.CallbackScheduledTime)
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

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (CallbackScheduledTime != null)
            {
                hash = hash * 59 + CallbackScheduledTime.GetHashCode();
            }

            return hash;
        }
    }
}
