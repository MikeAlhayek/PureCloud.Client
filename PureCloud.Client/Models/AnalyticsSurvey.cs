using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsSurvey
/// </summary>
[DataContract]
public partial class AnalyticsSurvey : IEquatable<AnalyticsSurvey>
{
    /// <summary>
    /// The type of the survey
    /// </summary>
    /// <value>The type of the survey</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SurveyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Web for "Web"
        /// </summary>
        [EnumMember(Value = "Web")]
        Web,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// The type of the survey
    /// </summary>
    /// <value>The type of the survey</value>
    [DataMember(Name = "surveyType", EmitDefaultValue = false)]
    public SurveyTypeEnum? SurveyType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsSurvey" /> class.
    /// </summary>
    /// <param name="EventTime">Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="QueueId">The ID of the associated queue.</param>
    /// <param name="SurveyCompletedDate">Completion datetime of the survey in ISO 8601 format.</param>
    /// <param name="SurveyFormContextId">Unique identifier for the survey form, regardless of version.</param>
    /// <param name="SurveyFormId">ID of the survey form used.</param>
    /// <param name="SurveyFormName">Name of the survey form used.</param>
    /// <param name="SurveyId">ID of the survey.</param>
    /// <param name="SurveyPartialResponse">Whether the survey was completed with any required questions unanswered..</param>
    /// <param name="SurveyPromoterScore">Score of the survey used with NPS.</param>
    /// <param name="SurveyStatus">The status of the survey.</param>
    /// <param name="SurveyType">The type of the survey.</param>
    /// <param name="UserId">ID of the agent the survey was performed against.</param>
    /// <param name="OSurveyTotalScore">OSurveyTotalScore.</param>
    public AnalyticsSurvey(DateTime? EventTime = null, string QueueId = null, DateTime? SurveyCompletedDate = null, string SurveyFormContextId = null, string SurveyFormId = null, string SurveyFormName = null, string SurveyId = null, bool? SurveyPartialResponse = null, int? SurveyPromoterScore = null, string SurveyStatus = null, SurveyTypeEnum? SurveyType = null, string UserId = null, long? OSurveyTotalScore = null)
    {
        this.EventTime = EventTime;
        this.QueueId = QueueId;
        this.SurveyCompletedDate = SurveyCompletedDate;
        this.SurveyFormContextId = SurveyFormContextId;
        this.SurveyFormId = SurveyFormId;
        this.SurveyFormName = SurveyFormName;
        this.SurveyId = SurveyId;
        this.SurveyPartialResponse = SurveyPartialResponse;
        this.SurveyPromoterScore = SurveyPromoterScore;
        this.SurveyStatus = SurveyStatus;
        this.SurveyType = SurveyType;
        this.UserId = UserId;
        this.OSurveyTotalScore = OSurveyTotalScore;

    }



    /// <summary>
    /// Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Specifies when an event occurred. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "eventTime", EmitDefaultValue = false)]
    public DateTime? EventTime { get; set; }



    /// <summary>
    /// The ID of the associated queue
    /// </summary>
    /// <value>The ID of the associated queue</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Completion datetime of the survey in ISO 8601 format
    /// </summary>
    /// <value>Completion datetime of the survey in ISO 8601 format</value>
    [DataMember(Name = "surveyCompletedDate", EmitDefaultValue = false)]
    public DateTime? SurveyCompletedDate { get; set; }



    /// <summary>
    /// Unique identifier for the survey form, regardless of version
    /// </summary>
    /// <value>Unique identifier for the survey form, regardless of version</value>
    [DataMember(Name = "surveyFormContextId", EmitDefaultValue = false)]
    public string SurveyFormContextId { get; set; }



    /// <summary>
    /// ID of the survey form used
    /// </summary>
    /// <value>ID of the survey form used</value>
    [DataMember(Name = "surveyFormId", EmitDefaultValue = false)]
    public string SurveyFormId { get; set; }



    /// <summary>
    /// Name of the survey form used
    /// </summary>
    /// <value>Name of the survey form used</value>
    [DataMember(Name = "surveyFormName", EmitDefaultValue = false)]
    public string SurveyFormName { get; set; }



    /// <summary>
    /// ID of the survey
    /// </summary>
    /// <value>ID of the survey</value>
    [DataMember(Name = "surveyId", EmitDefaultValue = false)]
    public string SurveyId { get; set; }



    /// <summary>
    /// Whether the survey was completed with any required questions unanswered.
    /// </summary>
    /// <value>Whether the survey was completed with any required questions unanswered.</value>
    [DataMember(Name = "surveyPartialResponse", EmitDefaultValue = false)]
    public bool? SurveyPartialResponse { get; set; }



    /// <summary>
    /// Score of the survey used with NPS
    /// </summary>
    /// <value>Score of the survey used with NPS</value>
    [DataMember(Name = "surveyPromoterScore", EmitDefaultValue = false)]
    public int? SurveyPromoterScore { get; set; }



    /// <summary>
    /// The status of the survey
    /// </summary>
    /// <value>The status of the survey</value>
    [DataMember(Name = "surveyStatus", EmitDefaultValue = false)]
    public string SurveyStatus { get; set; }





    /// <summary>
    /// ID of the agent the survey was performed against
    /// </summary>
    /// <value>ID of the agent the survey was performed against</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets OSurveyTotalScore
    /// </summary>
    [DataMember(Name = "oSurveyTotalScore", EmitDefaultValue = false)]
    public long? OSurveyTotalScore { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsSurvey {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  SurveyCompletedDate: ").Append(SurveyCompletedDate).Append("\n");
        sb.Append("  SurveyFormContextId: ").Append(SurveyFormContextId).Append("\n");
        sb.Append("  SurveyFormId: ").Append(SurveyFormId).Append("\n");
        sb.Append("  SurveyFormName: ").Append(SurveyFormName).Append("\n");
        sb.Append("  SurveyId: ").Append(SurveyId).Append("\n");
        sb.Append("  SurveyPartialResponse: ").Append(SurveyPartialResponse).Append("\n");
        sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
        sb.Append("  SurveyStatus: ").Append(SurveyStatus).Append("\n");
        sb.Append("  SurveyType: ").Append(SurveyType).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  OSurveyTotalScore: ").Append(OSurveyTotalScore).Append("\n");
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
        return Equals(obj as AnalyticsSurvey);
    }

    /// <summary>
    /// Returns true if AnalyticsSurvey instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsSurvey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsSurvey other)
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
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                SurveyCompletedDate == other.SurveyCompletedDate ||
                SurveyCompletedDate != null &&
                SurveyCompletedDate.Equals(other.SurveyCompletedDate)
            ) &&
            (
                SurveyFormContextId == other.SurveyFormContextId ||
                SurveyFormContextId != null &&
                SurveyFormContextId.Equals(other.SurveyFormContextId)
            ) &&
            (
                SurveyFormId == other.SurveyFormId ||
                SurveyFormId != null &&
                SurveyFormId.Equals(other.SurveyFormId)
            ) &&
            (
                SurveyFormName == other.SurveyFormName ||
                SurveyFormName != null &&
                SurveyFormName.Equals(other.SurveyFormName)
            ) &&
            (
                SurveyId == other.SurveyId ||
                SurveyId != null &&
                SurveyId.Equals(other.SurveyId)
            ) &&
            (
                SurveyPartialResponse == other.SurveyPartialResponse ||
                SurveyPartialResponse != null &&
                SurveyPartialResponse.Equals(other.SurveyPartialResponse)
            ) &&
            (
                SurveyPromoterScore == other.SurveyPromoterScore ||
                SurveyPromoterScore != null &&
                SurveyPromoterScore.Equals(other.SurveyPromoterScore)
            ) &&
            (
                SurveyStatus == other.SurveyStatus ||
                SurveyStatus != null &&
                SurveyStatus.Equals(other.SurveyStatus)
            ) &&
            (
                SurveyType == other.SurveyType ||
                SurveyType != null &&
                SurveyType.Equals(other.SurveyType)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                OSurveyTotalScore == other.OSurveyTotalScore ||
                OSurveyTotalScore != null &&
                OSurveyTotalScore.Equals(other.OSurveyTotalScore)
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

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (SurveyCompletedDate != null)
            {
                hash = hash * 59 + SurveyCompletedDate.GetHashCode();
            }

            if (SurveyFormContextId != null)
            {
                hash = hash * 59 + SurveyFormContextId.GetHashCode();
            }

            if (SurveyFormId != null)
            {
                hash = hash * 59 + SurveyFormId.GetHashCode();
            }

            if (SurveyFormName != null)
            {
                hash = hash * 59 + SurveyFormName.GetHashCode();
            }

            if (SurveyId != null)
            {
                hash = hash * 59 + SurveyId.GetHashCode();
            }

            if (SurveyPartialResponse != null)
            {
                hash = hash * 59 + SurveyPartialResponse.GetHashCode();
            }

            if (SurveyPromoterScore != null)
            {
                hash = hash * 59 + SurveyPromoterScore.GetHashCode();
            }

            if (SurveyStatus != null)
            {
                hash = hash * 59 + SurveyStatus.GetHashCode();
            }

            if (SurveyType != null)
            {
                hash = hash * 59 + SurveyType.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (OSurveyTotalScore != null)
            {
                hash = hash * 59 + OSurveyTotalScore.GetHashCode();
            }

            return hash;
        }
    }
}
