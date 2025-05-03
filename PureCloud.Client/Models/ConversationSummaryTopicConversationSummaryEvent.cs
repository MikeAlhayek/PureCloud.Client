using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSummaryTopicConversationSummaryEvent
/// </summary>

public partial class ConversationSummaryTopicConversationSummaryEvent : IEquatable<ConversationSummaryTopicConversationSummaryEvent>
{
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms,

        /// <summary>
        /// Enum Twitter for "TWITTER"
        /// </summary>
        [EnumMember(Value = "TWITTER")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "FACEBOOK"
        /// </summary>
        [EnumMember(Value = "FACEBOOK")]
        Facebook,

        /// <summary>
        /// Enum Instagram for "INSTAGRAM"
        /// </summary>
        [EnumMember(Value = "INSTAGRAM")]
        Instagram,

        /// <summary>
        /// Enum Line for "LINE"
        /// </summary>
        [EnumMember(Value = "LINE")]
        Line,

        /// <summary>
        /// Enum Whatsapp for "WHATSAPP"
        /// </summary>
        [EnumMember(Value = "WHATSAPP")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "WEBMESSAGING"
        /// </summary>
        [EnumMember(Value = "WEBMESSAGING")]
        Webmessaging,

        /// <summary>
        /// Enum Open for "OPEN"
        /// </summary>
        [EnumMember(Value = "OPEN")]
        Open,

        /// <summary>
        /// Enum Apple for "APPLE"
        /// </summary>
        [EnumMember(Value = "APPLE")]
        Apple
    }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message,

        /// <summary>
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email
    }
    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    
    public enum ErrorTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum ConversationTooLong for "CONVERSATION_TOO_LONG"
        /// </summary>
        [EnumMember(Value = "CONVERSATION_TOO_LONG")]
        ConversationTooLong,

        /// <summary>
        /// Enum ConversationTooShort for "CONVERSATION_TOO_SHORT"
        /// </summary>
        [EnumMember(Value = "CONVERSATION_TOO_SHORT")]
        ConversationTooShort,

        /// <summary>
        /// Enum RateLimited for "RATE_LIMITED"
        /// </summary>
        [EnumMember(Value = "RATE_LIMITED")]
        RateLimited
    }
    /// <summary>
    /// Gets or Sets MessageType
    /// </summary>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Gets or Sets ErrorType
    /// </summary>
    [JsonPropertyName("errorType")]
    public ErrorTypeEnum? ErrorType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSummaryTopicConversationSummaryEvent" /> class.
    /// </summary>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="QueueId">QueueId.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="CommunicationIds">CommunicationIds.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="MessageType">MessageType.</param>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="SummaryId">SummaryId.</param>
    /// <param name="Language">Language.</param>
    /// <param name="Summary">Summary.</param>
    /// <param name="Headline">Headline.</param>
    /// <param name="Reason">Reason.</param>
    /// <param name="Resolution">Resolution.</param>
    /// <param name="WrapUpCodes">WrapUpCodes.</param>
    /// <param name="TriggerSource">TriggerSource.</param>
    /// <param name="LastEditedBy">LastEditedBy.</param>
    /// <param name="ErrorType">ErrorType.</param>
    /// <param name="DurationMs">DurationMs.</param>
    public ConversationSummaryTopicConversationSummaryEvent(Guid? ConversationId = null, Guid? QueueId = null, List<ConversationSummaryTopicConversationSummaryParticipant> Participants = null, List<string> CommunicationIds = null, DateTime? CreatedDate = null, MessageTypeEnum? MessageType = null, MediaTypeEnum? MediaType = null, Guid? SummaryId = null, string Language = null, ConversationSummaryTopicConversationSummary Summary = null, ConversationSummaryTopicConversationHeadline Headline = null, ConversationSummaryTopicConversationReason Reason = null, ConversationSummaryTopicConversationResolution Resolution = null, List<ConversationSummaryTopicConversationWrapUpCode> WrapUpCodes = null, ConversationSummaryTopicTriggerSource TriggerSource = null, ConversationSummaryTopicConversationSummaryParticipant LastEditedBy = null, ErrorTypeEnum? ErrorType = null, long? DurationMs = null)
    {
        this.ConversationId = ConversationId;
        this.QueueId = QueueId;
        this.Participants = Participants;
        this.CommunicationIds = CommunicationIds;
        this.CreatedDate = CreatedDate;
        this.MessageType = MessageType;
        this.MediaType = MediaType;
        this.SummaryId = SummaryId;
        this.Language = Language;
        this.Summary = Summary;
        this.Headline = Headline;
        this.Reason = Reason;
        this.Resolution = Resolution;
        this.WrapUpCodes = WrapUpCodes;
        this.TriggerSource = TriggerSource;
        this.LastEditedBy = LastEditedBy;
        this.ErrorType = ErrorType;
        this.DurationMs = DurationMs;

    }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public Guid? ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets QueueId
    /// </summary>
    [JsonPropertyName("queueId")]
    public Guid? QueueId { get; set; }



    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonPropertyName("participants")]
    public List<ConversationSummaryTopicConversationSummaryParticipant> Participants { get; set; }



    /// <summary>
    /// Gets or Sets CommunicationIds
    /// </summary>
    [JsonPropertyName("communicationIds")]
    public List<string> CommunicationIds { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }







    /// <summary>
    /// Gets or Sets SummaryId
    /// </summary>
    [JsonPropertyName("summaryId")]
    public Guid? SummaryId { get; set; }



    /// <summary>
    /// Gets or Sets Language
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [JsonPropertyName("summary")]
    public ConversationSummaryTopicConversationSummary Summary { get; set; }



    /// <summary>
    /// Gets or Sets Headline
    /// </summary>
    [JsonPropertyName("headline")]
    public ConversationSummaryTopicConversationHeadline Headline { get; set; }



    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [JsonPropertyName("reason")]
    public ConversationSummaryTopicConversationReason Reason { get; set; }



    /// <summary>
    /// Gets or Sets Resolution
    /// </summary>
    [JsonPropertyName("resolution")]
    public ConversationSummaryTopicConversationResolution Resolution { get; set; }



    /// <summary>
    /// Gets or Sets WrapUpCodes
    /// </summary>
    [JsonPropertyName("wrapUpCodes")]
    public List<ConversationSummaryTopicConversationWrapUpCode> WrapUpCodes { get; set; }



    /// <summary>
    /// Gets or Sets TriggerSource
    /// </summary>
    [JsonPropertyName("triggerSource")]
    public ConversationSummaryTopicTriggerSource TriggerSource { get; set; }



    /// <summary>
    /// Gets or Sets LastEditedBy
    /// </summary>
    [JsonPropertyName("lastEditedBy")]
    public ConversationSummaryTopicConversationSummaryParticipant LastEditedBy { get; set; }





    /// <summary>
    /// Gets or Sets DurationMs
    /// </summary>
    [JsonPropertyName("durationMs")]
    public long? DurationMs { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSummaryTopicConversationSummaryEvent {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  CommunicationIds: ").Append(CommunicationIds).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  SummaryId: ").Append(SummaryId).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Summary: ").Append(Summary).Append("\n");
        sb.Append("  Headline: ").Append(Headline).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Resolution: ").Append(Resolution).Append("\n");
        sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
        sb.Append("  TriggerSource: ").Append(TriggerSource).Append("\n");
        sb.Append("  LastEditedBy: ").Append(LastEditedBy).Append("\n");
        sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
        sb.Append("  DurationMs: ").Append(DurationMs).Append("\n");
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
        return Equals(obj as ConversationSummaryTopicConversationSummaryEvent);
    }

    /// <summary>
    /// Returns true if ConversationSummaryTopicConversationSummaryEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSummaryTopicConversationSummaryEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSummaryTopicConversationSummaryEvent other)
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
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                CommunicationIds == other.CommunicationIds ||
                CommunicationIds != null &&
                CommunicationIds.SequenceEqual(other.CommunicationIds)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                SummaryId == other.SummaryId ||
                SummaryId != null &&
                SummaryId.Equals(other.SummaryId)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Summary == other.Summary ||
                Summary != null &&
                Summary.Equals(other.Summary)
            ) &&
            (
                Headline == other.Headline ||
                Headline != null &&
                Headline.Equals(other.Headline)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Resolution == other.Resolution ||
                Resolution != null &&
                Resolution.Equals(other.Resolution)
            ) &&
            (
                WrapUpCodes == other.WrapUpCodes ||
                WrapUpCodes != null &&
                WrapUpCodes.SequenceEqual(other.WrapUpCodes)
            ) &&
            (
                TriggerSource == other.TriggerSource ||
                TriggerSource != null &&
                TriggerSource.Equals(other.TriggerSource)
            ) &&
            (
                LastEditedBy == other.LastEditedBy ||
                LastEditedBy != null &&
                LastEditedBy.Equals(other.LastEditedBy)
            ) &&
            (
                ErrorType == other.ErrorType ||
                ErrorType != null &&
                ErrorType.Equals(other.ErrorType)
            ) &&
            (
                DurationMs == other.DurationMs ||
                DurationMs != null &&
                DurationMs.Equals(other.DurationMs)
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

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (CommunicationIds != null)
            {
                hash = hash * 59 + CommunicationIds.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (SummaryId != null)
            {
                hash = hash * 59 + SummaryId.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Summary != null)
            {
                hash = hash * 59 + Summary.GetHashCode();
            }

            if (Headline != null)
            {
                hash = hash * 59 + Headline.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Resolution != null)
            {
                hash = hash * 59 + Resolution.GetHashCode();
            }

            if (WrapUpCodes != null)
            {
                hash = hash * 59 + WrapUpCodes.GetHashCode();
            }

            if (TriggerSource != null)
            {
                hash = hash * 59 + TriggerSource.GetHashCode();
            }

            if (LastEditedBy != null)
            {
                hash = hash * 59 + LastEditedBy.GetHashCode();
            }

            if (ErrorType != null)
            {
                hash = hash * 59 + ErrorType.GetHashCode();
            }

            if (DurationMs != null)
            {
                hash = hash * 59 + DurationMs.GetHashCode();
            }

            return hash;
        }
    }
}
