using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DirectRouting
/// </summary>
[DataContract]
public partial class DirectRouting : IEquatable<DirectRouting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DirectRouting" /> class.
    /// </summary>
    /// <param name="CallMediaSettings">Direct Routing Settings specific to Call media..</param>
    /// <param name="EmailMediaSettings">Direct Routing Settings specific to Email media..</param>
    /// <param name="MessageMediaSettings">Direct Routing Settings specific to Message media..</param>
    /// <param name="BackupQueueId">ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation..</param>
    /// <param name="WaitForAgent">Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup..</param>
    /// <param name="AgentWaitSeconds">Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000]..</param>
    public DirectRouting(DirectRoutingMediaSettings CallMediaSettings = null, DirectRoutingMediaSettings EmailMediaSettings = null, DirectRoutingMediaSettings MessageMediaSettings = null, string BackupQueueId = null, bool? WaitForAgent = null, int? AgentWaitSeconds = null)
    {
        this.CallMediaSettings = CallMediaSettings;
        this.EmailMediaSettings = EmailMediaSettings;
        this.MessageMediaSettings = MessageMediaSettings;
        this.BackupQueueId = BackupQueueId;
        this.WaitForAgent = WaitForAgent;
        this.AgentWaitSeconds = AgentWaitSeconds;

    }



    /// <summary>
    /// Direct Routing Settings specific to Call media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Call media.</value>
    [DataMember(Name = "callMediaSettings", EmitDefaultValue = false)]
    public DirectRoutingMediaSettings CallMediaSettings { get; set; }



    /// <summary>
    /// Direct Routing Settings specific to Email media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Email media.</value>
    [DataMember(Name = "emailMediaSettings", EmitDefaultValue = false)]
    public DirectRoutingMediaSettings EmailMediaSettings { get; set; }



    /// <summary>
    /// Direct Routing Settings specific to Message media.
    /// </summary>
    /// <value>Direct Routing Settings specific to Message media.</value>
    [DataMember(Name = "messageMediaSettings", EmitDefaultValue = false)]
    public DirectRoutingMediaSettings MessageMediaSettings { get; set; }



    /// <summary>
    /// ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation.
    /// </summary>
    /// <value>ID of another queue to be used as the default backup if an agent does not have their Backup Settings configured. If not set, the current queue will be used as backup, but with Direct Routing criteria removed from the conversation.</value>
    [DataMember(Name = "backupQueueId", EmitDefaultValue = false)]
    public string BackupQueueId { get; set; }



    /// <summary>
    /// Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.
    /// </summary>
    /// <value>Flag indicating if Direct Routing interactions should wait for Direct Routing agent or go immediately to selected backup.</value>
    [DataMember(Name = "waitForAgent", EmitDefaultValue = false)]
    public bool? WaitForAgent { get; set; }



    /// <summary>
    /// Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].
    /// </summary>
    /// <value>Time (in seconds) that a Direct Routing interaction will wait for Direct Routing agent before going to selected backup. Valid range [60, 864000].</value>
    [DataMember(Name = "agentWaitSeconds", EmitDefaultValue = false)]
    public int? AgentWaitSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DirectRouting {\n");

        sb.Append("  CallMediaSettings: ").Append(CallMediaSettings).Append("\n");
        sb.Append("  EmailMediaSettings: ").Append(EmailMediaSettings).Append("\n");
        sb.Append("  MessageMediaSettings: ").Append(MessageMediaSettings).Append("\n");
        sb.Append("  BackupQueueId: ").Append(BackupQueueId).Append("\n");
        sb.Append("  WaitForAgent: ").Append(WaitForAgent).Append("\n");
        sb.Append("  AgentWaitSeconds: ").Append(AgentWaitSeconds).Append("\n");
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
        return Equals(obj as DirectRouting);
    }

    /// <summary>
    /// Returns true if DirectRouting instances are equal
    /// </summary>
    /// <param name="other">Instance of DirectRouting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DirectRouting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CallMediaSettings == other.CallMediaSettings ||
                CallMediaSettings != null &&
                CallMediaSettings.Equals(other.CallMediaSettings)
            ) &&
            (
                EmailMediaSettings == other.EmailMediaSettings ||
                EmailMediaSettings != null &&
                EmailMediaSettings.Equals(other.EmailMediaSettings)
            ) &&
            (
                MessageMediaSettings == other.MessageMediaSettings ||
                MessageMediaSettings != null &&
                MessageMediaSettings.Equals(other.MessageMediaSettings)
            ) &&
            (
                BackupQueueId == other.BackupQueueId ||
                BackupQueueId != null &&
                BackupQueueId.Equals(other.BackupQueueId)
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
            if (CallMediaSettings != null)
            {
                hash = hash * 59 + CallMediaSettings.GetHashCode();
            }

            if (EmailMediaSettings != null)
            {
                hash = hash * 59 + EmailMediaSettings.GetHashCode();
            }

            if (MessageMediaSettings != null)
            {
                hash = hash * 59 + MessageMediaSettings.GetHashCode();
            }

            if (BackupQueueId != null)
            {
                hash = hash * 59 + BackupQueueId.GetHashCode();
            }

            if (WaitForAgent != null)
            {
                hash = hash * 59 + WaitForAgent.GetHashCode();
            }

            if (AgentWaitSeconds != null)
            {
                hash = hash * 59 + AgentWaitSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
