using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QualityEvaluationScoreItem
/// </summary>

public partial class QualityEvaluationScoreItem : IEquatable<QualityEvaluationScoreItem>
{
    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    
    public enum MediaTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "cobrowse"
        /// </summary>
        [EnumMember(Value = "cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Internalmessage for "internalmessage"
        /// </summary>
        [EnumMember(Value = "internalmessage")]
        Internalmessage,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message,

        /// <summary>
        /// Enum Screenshare for "screenshare"
        /// </summary>
        [EnumMember(Value = "screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Video for "video"
        /// </summary>
        [EnumMember(Value = "video")]
        Video,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="QualityEvaluationScoreItem" /> class.
    /// </summary>
    /// <param name="MediaTypes">A list of media types for the metric.</param>
    public QualityEvaluationScoreItem(List<MediaTypesEnum> MediaTypes = null)
    {
        this.MediaTypes = MediaTypes;

    }



    /// <summary>
    /// The id of evaluation
    /// </summary>
    /// <value>The id of evaluation</value>
    [JsonPropertyName("evaluationId")]
    public string EvaluationId { get; set; }



    /// <summary>
    /// The id of conversation
    /// </summary>
    /// <value>The id of conversation</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationDate")]
    public DateTime? ConversationDate { get; set; }



    /// <summary>
    /// The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("conversationEndDate")]
    public DateTime? ConversationEndDate { get; set; }



    /// <summary>
    /// The name of form
    /// </summary>
    /// <value>The name of form</value>
    [JsonPropertyName("formName")]
    public string FormName { get; set; }



    /// <summary>
    /// Gamification points earned for this metric
    /// </summary>
    /// <value>Gamification points earned for this metric</value>
    [JsonPropertyName("points")]
    public int? Points { get; set; }



    /// <summary>
    /// The quality score of evaluation as a percentage
    /// </summary>
    /// <value>The quality score of evaluation as a percentage</value>
    [JsonPropertyName("evaluationScore")]
    public double? EvaluationScore { get; set; }



    /// <summary>
    /// The maximum Gamification points a user may earn for this metric
    /// </summary>
    /// <value>The maximum Gamification points a user may earn for this metric</value>
    [JsonPropertyName("maxPoints")]
    public int? MaxPoints { get; set; }



    /// <summary>
    /// A list of media types for the metric
    /// </summary>
    /// <value>A list of media types for the metric</value>
    [JsonPropertyName("mediaTypes")]
    public List<MediaTypesEnum> MediaTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QualityEvaluationScoreItem {\n");

        sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
        sb.Append("  ConversationEndDate: ").Append(ConversationEndDate).Append("\n");
        sb.Append("  FormName: ").Append(FormName).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
        return Equals(obj as QualityEvaluationScoreItem);
    }

    /// <summary>
    /// Returns true if QualityEvaluationScoreItem instances are equal
    /// </summary>
    /// <param name="other">Instance of QualityEvaluationScoreItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QualityEvaluationScoreItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationId == other.EvaluationId ||
                EvaluationId != null &&
                EvaluationId.Equals(other.EvaluationId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConversationDate == other.ConversationDate ||
                ConversationDate != null &&
                ConversationDate.Equals(other.ConversationDate)
            ) &&
            (
                ConversationEndDate == other.ConversationEndDate ||
                ConversationEndDate != null &&
                ConversationEndDate.Equals(other.ConversationEndDate)
            ) &&
            (
                FormName == other.FormName ||
                FormName != null &&
                FormName.Equals(other.FormName)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
            ) &&
            (
                EvaluationScore == other.EvaluationScore ||
                EvaluationScore != null &&
                EvaluationScore.Equals(other.EvaluationScore)
            ) &&
            (
                MaxPoints == other.MaxPoints ||
                MaxPoints != null &&
                MaxPoints.Equals(other.MaxPoints)
            ) &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
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
            if (EvaluationId != null)
            {
                hash = hash * 59 + EvaluationId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConversationDate != null)
            {
                hash = hash * 59 + ConversationDate.GetHashCode();
            }

            if (ConversationEndDate != null)
            {
                hash = hash * 59 + ConversationEndDate.GetHashCode();
            }

            if (FormName != null)
            {
                hash = hash * 59 + FormName.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (EvaluationScore != null)
            {
                hash = hash * 59 + EvaluationScore.GetHashCode();
            }

            if (MaxPoints != null)
            {
                hash = hash * 59 + MaxPoints.GetHashCode();
            }

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            return hash;
        }
    }
}
