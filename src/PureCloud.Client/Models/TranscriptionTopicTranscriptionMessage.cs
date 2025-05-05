using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TranscriptionTopicTranscriptionMessage
/// </summary>

public partial class TranscriptionTopicTranscriptionMessage : IEquatable<TranscriptionTopicTranscriptionMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranscriptionTopicTranscriptionMessage" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="OrganizationId">OrganizationId.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="CommunicationId">CommunicationId.</param>
    /// <param name="SessionStartTimeMs">SessionStartTimeMs.</param>
    /// <param name="TranscriptionStartTimeMs">TranscriptionStartTimeMs.</param>
    /// <param name="Transcripts">Transcripts.</param>
    /// <param name="Status">Status.</param>
    public TranscriptionTopicTranscriptionMessage(DateTime? EventTime = null, string OrganizationId = null, string ConversationId = null, string CommunicationId = null, long? SessionStartTimeMs = null, long? TranscriptionStartTimeMs = null, List<TranscriptionTopicTranscriptResult> Transcripts = null, TranscriptionTopicTranscriptionRequestStatus Status = null)
    {
        this.EventTime = EventTime;
        this.OrganizationId = OrganizationId;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.SessionStartTimeMs = SessionStartTimeMs;
        this.TranscriptionStartTimeMs = TranscriptionStartTimeMs;
        this.Transcripts = Transcripts;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [JsonPropertyName("eventTime")]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    [JsonPropertyName("organizationId")]
    public string OrganizationId { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets CommunicationId
    /// </summary>
    [JsonPropertyName("communicationId")]
    public string CommunicationId { get; set; }



    /// <summary>
    /// Gets or Sets SessionStartTimeMs
    /// </summary>
    [JsonPropertyName("sessionStartTimeMs")]
    public long? SessionStartTimeMs { get; set; }



    /// <summary>
    /// Gets or Sets TranscriptionStartTimeMs
    /// </summary>
    [JsonPropertyName("transcriptionStartTimeMs")]
    public long? TranscriptionStartTimeMs { get; set; }



    /// <summary>
    /// Gets or Sets Transcripts
    /// </summary>
    [JsonPropertyName("transcripts")]
    public List<TranscriptionTopicTranscriptResult> Transcripts { get; set; }



    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public TranscriptionTopicTranscriptionRequestStatus Status { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TranscriptionTopicTranscriptionMessage {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  SessionStartTimeMs: ").Append(SessionStartTimeMs).Append("\n");
        sb.Append("  TranscriptionStartTimeMs: ").Append(TranscriptionStartTimeMs).Append("\n");
        sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as TranscriptionTopicTranscriptionMessage);
    }

    /// <summary>
    /// Returns true if TranscriptionTopicTranscriptionMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of TranscriptionTopicTranscriptionMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TranscriptionTopicTranscriptionMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                OrganizationId == other.OrganizationId ||
                OrganizationId != null &&
                OrganizationId.Equals(other.OrganizationId)
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
                SessionStartTimeMs == other.SessionStartTimeMs ||
                SessionStartTimeMs != null &&
                SessionStartTimeMs.Equals(other.SessionStartTimeMs)
            ) &&
            (
                TranscriptionStartTimeMs == other.TranscriptionStartTimeMs ||
                TranscriptionStartTimeMs != null &&
                TranscriptionStartTimeMs.Equals(other.TranscriptionStartTimeMs)
            ) &&
            (
                Transcripts == other.Transcripts ||
                Transcripts != null &&
                Transcripts.SequenceEqual(other.Transcripts)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (OrganizationId != null)
            {
                hash = hash * 59 + OrganizationId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (SessionStartTimeMs != null)
            {
                hash = hash * 59 + SessionStartTimeMs.GetHashCode();
            }

            if (TranscriptionStartTimeMs != null)
            {
                hash = hash * 59 + TranscriptionStartTimeMs.GetHashCode();
            }

            if (Transcripts != null)
            {
                hash = hash * 59 + Transcripts.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
