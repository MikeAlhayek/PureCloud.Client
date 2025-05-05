using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AgentDirectRoutingBackupSettings
/// </summary>

public partial class AgentDirectRoutingBackupSettings : IEquatable<AgentDirectRoutingBackupSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentDirectRoutingBackupSettings" /> class.
    /// </summary>
    /// <param name="QueueId">ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup..</param>
    /// <param name="UserId">ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup..</param>
    /// <param name="WaitForAgent">Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup..</param>
    /// <param name="AgentWaitSeconds">Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]..</param>
    public AgentDirectRoutingBackupSettings(string QueueId = null, string UserId = null, bool? WaitForAgent = null, int? AgentWaitSeconds = null)
    {
        this.QueueId = QueueId;
        this.UserId = UserId;
        this.WaitForAgent = WaitForAgent;
        this.AgentWaitSeconds = AgentWaitSeconds;

    }



    /// <summary>
    /// ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.
    /// </summary>
    /// <value>ID of queue to be used as backup. If queueId and userId are both specified, queue behaves as secondary backup.</value>
    [JsonPropertyName("queueId")]
    public string QueueId { get; set; }



    /// <summary>
    /// ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.
    /// </summary>
    /// <value>ID of user to be used as backup. If queueId and userId are both specified, user behaves as primary backup.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.
    /// </summary>
    /// <value>Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.</value>
    [JsonPropertyName("waitForAgent")]
    public bool? WaitForAgent { get; set; }



    /// <summary>
    /// Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].
    /// </summary>
    /// <value>Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].</value>
    [JsonPropertyName("agentWaitSeconds")]
    public int? AgentWaitSeconds { get; set; }



    /// <summary>
    /// Set of users that this user is a backup for.
    /// </summary>
    /// <value>Set of users that this user is a backup for.</value>
    [JsonPropertyName("backedUpUsers")]
    public List<string> BackedUpUsers { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentDirectRoutingBackupSettings {\n");

        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  WaitForAgent: ").Append(WaitForAgent).Append("\n");
        sb.Append("  AgentWaitSeconds: ").Append(AgentWaitSeconds).Append("\n");
        sb.Append("  BackedUpUsers: ").Append(BackedUpUsers).Append("\n");
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
        return Equals(obj as AgentDirectRoutingBackupSettings);
    }

    /// <summary>
    /// Returns true if AgentDirectRoutingBackupSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentDirectRoutingBackupSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentDirectRoutingBackupSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                WaitForAgent == other.WaitForAgent ||
                WaitForAgent != null &&
                WaitForAgent.Equals(other.WaitForAgent)
            ) &&
            (
                AgentWaitSeconds == other.AgentWaitSeconds ||
                AgentWaitSeconds != null &&
                AgentWaitSeconds.Equals(other.AgentWaitSeconds)
            ) &&
            (
                BackedUpUsers == other.BackedUpUsers ||
                BackedUpUsers != null &&
                BackedUpUsers.SequenceEqual(other.BackedUpUsers)
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
            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (WaitForAgent != null)
            {
                hash = hash * 59 + WaitForAgent.GetHashCode();
            }

            if (AgentWaitSeconds != null)
            {
                hash = hash * 59 + AgentWaitSeconds.GetHashCode();
            }

            if (BackedUpUsers != null)
            {
                hash = hash * 59 + BackedUpUsers.GetHashCode();
            }

            return hash;
        }
    }
}
