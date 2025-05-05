using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalEstablishedEvent
/// </summary>

public partial class ExternalEstablishedEvent : IEquatable<ExternalEstablishedEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalEstablishedEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalEstablishedEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalEstablishedEvent" /> class.
    /// </summary>
    /// <param name="EventId">A unique (V4 UUID) eventId for this event (required).</param>
    /// <param name="EventDateTime">A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="ConversationId">A unique Id (V4 UUID) identifying this conversation (required).</param>
    /// <param name="CommunicationId">A unique Id (V4 UUID) identifying this communication (required).</param>
    /// <param name="Ani">The automatic number identification if it is available for this conversation..</param>
    /// <param name="AniName">The automatic number identification name if it is available for this conversation..</param>
    /// <param name="Dnis">The dialed number identification if it is available for this conversation..</param>
    /// <param name="DnisName">The dialed number identification name if it is available for this conversation..</param>
    /// <param name="InitialConfiguration">Metadata about this communication. (required).</param>
    /// <param name="SourceConfiguration">Metadata about the source of this communication&#39;s interaction. (required).</param>
    public ExternalEstablishedEvent(string EventId = null, DateTime? EventDateTime = null, string ConversationId = null, string CommunicationId = null, string Ani = null, string AniName = null, string Dnis = null, string DnisName = null, InitialConfiguration InitialConfiguration = null, SourceConfiguration SourceConfiguration = null)
    {
        this.EventId = EventId;
        this.EventDateTime = EventDateTime;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.Ani = Ani;
        this.AniName = AniName;
        this.Dnis = Dnis;
        this.DnisName = DnisName;
        this.InitialConfiguration = InitialConfiguration;
        this.SourceConfiguration = SourceConfiguration;

    }



    /// <summary>
    /// A unique (V4 UUID) eventId for this event
    /// </summary>
    /// <value>A unique (V4 UUID) eventId for this event</value>
    [JsonPropertyName("eventId")]
    public string EventId { get; set; }



    /// <summary>
    /// A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>A Date Time representing the time this event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("eventDateTime")]
    public DateTime? EventDateTime { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this conversation
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// A unique Id (V4 UUID) identifying this communication
    /// </summary>
    /// <value>A unique Id (V4 UUID) identifying this communication</value>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// The automatic number identification if it is available for this conversation.
    /// </summary>
    /// <value>The automatic number identification if it is available for this conversation.</value>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// The automatic number identification name if it is available for this conversation.
    /// </summary>
    /// <value>The automatic number identification name if it is available for this conversation.</value>
    [JsonPropertyName("aniName")]
    public string AniName { get; set; }



    /// <summary>
    /// The dialed number identification if it is available for this conversation.
    /// </summary>
    /// <value>The dialed number identification if it is available for this conversation.</value>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// The dialed number identification name if it is available for this conversation.
    /// </summary>
    /// <value>The dialed number identification name if it is available for this conversation.</value>
    [JsonPropertyName("dnisName")]
    public string DnisName { get; set; }



    /// <summary>
    /// Metadata about this communication.
    /// </summary>
    /// <value>Metadata about this communication.</value>
    [JsonPropertyName("initialConfiguration")]
    public InitialConfiguration InitialConfiguration { get; set; }



    /// <summary>
    /// Metadata about the source of this communication&#39;s interaction.
    /// </summary>
    /// <value>Metadata about the source of this communication&#39;s interaction.</value>
    [JsonPropertyName("sourceConfiguration")]
    public SourceConfiguration SourceConfiguration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalEstablishedEvent {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  EventDateTime: ").Append(EventDateTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  AniName: ").Append(AniName).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  DnisName: ").Append(DnisName).Append("\n");
        sb.Append("  InitialConfiguration: ").Append(InitialConfiguration).Append("\n");
        sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
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
        return Equals(obj as ExternalEstablishedEvent);
    }

    /// <summary>
    /// Returns true if ExternalEstablishedEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalEstablishedEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalEstablishedEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventId == other.EventId ||
                EventId != null &&
                EventId.Equals(other.EventId)
            ) &&
            (
                EventDateTime == other.EventDateTime ||
                EventDateTime != null &&
                EventDateTime.Equals(other.EventDateTime)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                AniName == other.AniName ||
                AniName != null &&
                AniName.Equals(other.AniName)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                DnisName == other.DnisName ||
                DnisName != null &&
                DnisName.Equals(other.DnisName)
            ) &&
            (
                InitialConfiguration == other.InitialConfiguration ||
                InitialConfiguration != null &&
                InitialConfiguration.Equals(other.InitialConfiguration)
            ) &&
            (
                SourceConfiguration == other.SourceConfiguration ||
                SourceConfiguration != null &&
                SourceConfiguration.Equals(other.SourceConfiguration)
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
            if (EventId != null)
            {
                hash = hash * 59 + EventId.GetHashCode();
            }

            if (EventDateTime != null)
            {
                hash = hash * 59 + EventDateTime.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (AniName != null)
            {
                hash = hash * 59 + AniName.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (DnisName != null)
            {
                hash = hash * 59 + DnisName.GetHashCode();
            }

            if (InitialConfiguration != null)
            {
                hash = hash * 59 + InitialConfiguration.GetHashCode();
            }

            if (SourceConfiguration != null)
            {
                hash = hash * 59 + SourceConfiguration.GetHashCode();
            }

            return hash;
        }
    }
}
