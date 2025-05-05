using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody
/// </summary>

public partial class V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody : IEquatable<V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody" /> class.
    /// </summary>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="DeploymentId">DeploymentId.</param>
    /// <param name="ParticipantId">ParticipantId.</param>
    /// <param name="ExternalContactId">ExternalContactId.</param>
    /// <param name="CommunicationId">CommunicationId.</param>
    /// <param name="SessionExpiry">SessionExpiry.</param>
    /// <param name="Messages">Messages.</param>
    /// <param name="EventTimeMs">EventTimeMs.</param>
    public V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody(string ConversationId = null, string DeploymentId = null, string ParticipantId = null, string ExternalContactId = null, string CommunicationId = null, long? SessionExpiry = null, List<V2WebMessagingUndeliveredMessageTopicMessage> Messages = null, long? EventTimeMs = null)
    {
        this.ConversationId = ConversationId;
        this.DeploymentId = DeploymentId;
        this.ParticipantId = ParticipantId;
        this.ExternalContactId = ExternalContactId;
        this.CommunicationId = CommunicationId;
        this.SessionExpiry = SessionExpiry;
        this.Messages = Messages;
        this.EventTimeMs = EventTimeMs;

    }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets DeploymentId
    /// </summary>
    [JsonPropertyName("deploymentId")]
    public string DeploymentId { get; set; }



    /// <summary>
    /// Gets or Sets ParticipantId
    /// </summary>
    [JsonPropertyName("participantId")]
    public string ParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactId
    /// </summary>
    [JsonPropertyName("externalContactId")]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// Gets or Sets SessionExpiry
    /// </summary>
    [JsonPropertyName("sessionExpiry")]
    public long? SessionExpiry { get; set; }



    /// <summary>
    /// Gets or Sets Messages
    /// </summary>
    [JsonPropertyName("messages")]
    public List<V2WebMessagingUndeliveredMessageTopicMessage> Messages { get; set; }



    /// <summary>
    /// Gets or Sets EventTimeMs
    /// </summary>
    [JsonPropertyName("eventTimeMs")]
    public long? EventTimeMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  DeploymentId: ").Append(DeploymentId).Append("\n");
        sb.Append("  ParticipantId: ").Append(ParticipantId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  SessionExpiry: ").Append(SessionExpiry).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  EventTimeMs: ").Append(EventTimeMs).Append("\n");
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
        return Equals(obj as V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody);
    }

    /// <summary>
    /// Returns true if V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody instances are equal
    /// </summary>
    /// <param name="other">Instance of V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2WebMessagingUndeliveredMessageTopicWebMessagingUndeliveredMessageEventBody other)
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
                DeploymentId == other.DeploymentId ||
                DeploymentId != null &&
                DeploymentId.Equals(other.DeploymentId)
            ) &&
            (
                ParticipantId == other.ParticipantId ||
                ParticipantId != null &&
                ParticipantId.Equals(other.ParticipantId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                SessionExpiry == other.SessionExpiry ||
                SessionExpiry != null &&
                SessionExpiry.Equals(other.SessionExpiry)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
            ) &&
            (
                EventTimeMs == other.EventTimeMs ||
                EventTimeMs != null &&
                EventTimeMs.Equals(other.EventTimeMs)
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

            if (DeploymentId != null)
            {
                hash = hash * 59 + DeploymentId.GetHashCode();
            }

            if (ParticipantId != null)
            {
                hash = hash * 59 + ParticipantId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (SessionExpiry != null)
            {
                hash = hash * 59 + SessionExpiry.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            if (EventTimeMs != null)
            {
                hash = hash * 59 + EventTimeMs.GetHashCode();
            }

            return hash;
        }
    }
}
