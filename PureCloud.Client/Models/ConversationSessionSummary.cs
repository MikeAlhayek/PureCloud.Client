using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationSessionSummary
/// </summary>

public partial class ConversationSessionSummary : IEquatable<ConversationSessionSummary>
{
    /// <summary>
    /// The status of the conversation summary.
    /// </summary>
    /// <value>The status of the conversation summary.</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Started for "Started"
        /// </summary>
        [EnumMember(Value = "Started")]
        Started,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing
    }
    /// <summary>
    /// The media type of the conversation.
    /// </summary>
    /// <value>The media type of the conversation.</value>
    
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
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Webmessaging for "Webmessaging"
        /// </summary>
        [EnumMember(Value = "Webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The status of the conversation summary.
    /// </summary>
    /// <value>The status of the conversation summary.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The media type of the conversation.
    /// </summary>
    /// <value>The media type of the conversation.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationSessionSummary" /> class.
    /// </summary>
    /// <param name="Text">The text of the summary..</param>
    /// <param name="Status">The status of the conversation summary..</param>
    /// <param name="MediaType">The media type of the conversation..</param>
    /// <param name="Language">The language of the conversation..</param>
    /// <param name="PredictedWrapupCodes">The wrapup codes of the conversation summary..</param>
    /// <param name="EditedSummary">The edited summary of the conversation..</param>
    /// <param name="Reason">The reason of the conversation summary..</param>
    /// <param name="Followup">The followup of the conversation summary..</param>
    /// <param name="Resolution">The resolution of the conversation summary..</param>
    /// <param name="DateCreated">The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Participants">The list of participants..</param>
    public ConversationSessionSummary(string Text = null, StatusEnum? Status = null, MediaTypeEnum? MediaType = null, string Language = null, List<ConversationSummaryWrapupCode> PredictedWrapupCodes = null, ConversationEditedInput EditedSummary = null, ConversationSummaryReason Reason = null, ConversationSummaryFollowup Followup = null, ConversationSummaryResolution Resolution = null, DateTime? DateCreated = null, List<AddressableEntityRef> Participants = null)
    {
        this.Text = Text;
        this.Status = Status;
        this.MediaType = MediaType;
        this.Language = Language;
        this.PredictedWrapupCodes = PredictedWrapupCodes;
        this.EditedSummary = EditedSummary;
        this.Reason = Reason;
        this.Followup = Followup;
        this.Resolution = Resolution;
        this.DateCreated = DateCreated;
        this.Participants = Participants;

    }



    /// <summary>
    /// The text of the summary.
    /// </summary>
    /// <value>The text of the summary.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }







    /// <summary>
    /// The language of the conversation.
    /// </summary>
    /// <value>The language of the conversation.</value>
    [JsonPropertyName("language")]
    public string Language { get; set; }



    /// <summary>
    /// The wrapup codes of the conversation summary.
    /// </summary>
    /// <value>The wrapup codes of the conversation summary.</value>
    [JsonPropertyName("predictedWrapupCodes")]
    public List<ConversationSummaryWrapupCode> PredictedWrapupCodes { get; set; }



    /// <summary>
    /// The edited summary of the conversation.
    /// </summary>
    /// <value>The edited summary of the conversation.</value>
    [JsonPropertyName("editedSummary")]
    public ConversationEditedInput EditedSummary { get; set; }



    /// <summary>
    /// The reason of the conversation summary.
    /// </summary>
    /// <value>The reason of the conversation summary.</value>
    [JsonPropertyName("reason")]
    public ConversationSummaryReason Reason { get; set; }



    /// <summary>
    /// The followup of the conversation summary.
    /// </summary>
    /// <value>The followup of the conversation summary.</value>
    [JsonPropertyName("followup")]
    public ConversationSummaryFollowup Followup { get; set; }



    /// <summary>
    /// The resolution of the conversation summary.
    /// </summary>
    /// <value>The resolution of the conversation summary.</value>
    [JsonPropertyName("resolution")]
    public ConversationSummaryResolution Resolution { get; set; }



    /// <summary>
    /// The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of the summary. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The id of the summary.
    /// </summary>
    /// <value>The id of the summary.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The AI confidence value.
    /// </summary>
    /// <value>The AI confidence value.</value>
    [JsonPropertyName("confidence")]
    public float? Confidence { get; private set; }



    /// <summary>
    /// The list of participants.
    /// </summary>
    /// <value>The list of participants.</value>
    [JsonPropertyName("participants")]
    public List<AddressableEntityRef> Participants { get; set; }



    /// <summary>
    /// The communication object of the summary.
    /// </summary>
    /// <value>The communication object of the summary.</value>
    [JsonPropertyName("communication")]
    public Entity Communication { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationSessionSummary {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  PredictedWrapupCodes: ").Append(PredictedWrapupCodes).Append("\n");
        sb.Append("  EditedSummary: ").Append(EditedSummary).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Followup: ").Append(Followup).Append("\n");
        sb.Append("  Resolution: ").Append(Resolution).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  Communication: ").Append(Communication).Append("\n");
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
        return Equals(obj as ConversationSessionSummary);
    }

    /// <summary>
    /// Returns true if ConversationSessionSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationSessionSummary to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationSessionSummary other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                PredictedWrapupCodes == other.PredictedWrapupCodes ||
                PredictedWrapupCodes != null &&
                PredictedWrapupCodes.SequenceEqual(other.PredictedWrapupCodes)
            ) &&
            (
                EditedSummary == other.EditedSummary ||
                EditedSummary != null &&
                EditedSummary.Equals(other.EditedSummary)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Followup == other.Followup ||
                Followup != null &&
                Followup.Equals(other.Followup)
            ) &&
            (
                Resolution == other.Resolution ||
                Resolution != null &&
                Resolution.Equals(other.Resolution)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                Communication == other.Communication ||
                Communication != null &&
                Communication.Equals(other.Communication)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (PredictedWrapupCodes != null)
            {
                hash = hash * 59 + PredictedWrapupCodes.GetHashCode();
            }

            if (EditedSummary != null)
            {
                hash = hash * 59 + EditedSummary.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Followup != null)
            {
                hash = hash * 59 + Followup.GetHashCode();
            }

            if (Resolution != null)
            {
                hash = hash * 59 + Resolution.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (Communication != null)
            {
                hash = hash * 59 + Communication.GetHashCode();
            }

            return hash;
        }
    }
}
