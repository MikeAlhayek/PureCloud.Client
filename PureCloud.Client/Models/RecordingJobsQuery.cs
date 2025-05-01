using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingJobsQuery
/// </summary>
[DataContract]
public partial class RecordingJobsQuery : IEquatable<RecordingJobsQuery>
{
    /// <summary>
    /// Operation to perform bulk task. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date.
    /// </summary>
    /// <value>Operation to perform bulk task. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Archive for "ARCHIVE"
        /// </summary>
        [EnumMember(Value = "ARCHIVE")]
        Archive,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete,

        /// <summary>
        /// Enum Export for "EXPORT"
        /// </summary>
        [EnumMember(Value = "EXPORT")]
        Export
    }
    /// <summary>
    /// Operation to perform bulk task. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date.
    /// </summary>
    /// <value>Operation to perform bulk task. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date.</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingJobsQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecordingJobsQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingJobsQuery" /> class.
    /// </summary>
    /// <param name="Action">Operation to perform bulk task. If the operation will cause the delete date of a recording to be older than the export date, the export date will be adjusted to the delete date. (required).</param>
    /// <param name="ActionDate">The date when the action will be performed. If screenRecordingActionDate is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ActionAge">The number of days after each recording&#39;s creation date when the action will be performed. If screenRecordingActionAge is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings..</param>
    /// <param name="ScreenRecordingActionDate">The date when the action will be performed for screen recordings. If this is provided then includeScreenRecordings must be true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ScreenRecordingActionAge">The number of days after each screen recording&#39;s creation date when the action will be performed. If this is provided then includeScreenRecordings must be true..</param>
    /// <param name="IntegrationId">IntegrationId to Access AWS S3 bucket for bulk recording exports. This field is required and used only for EXPORT action..</param>
    /// <param name="IncludeRecordingsWithSensitiveData">Whether to include recordings with PCI DSS and/or PII data, default value &#x3D; false .</param>
    /// <param name="IncludeScreenRecordings">Whether to include Screen recordings for the action, default value &#x3D; true .</param>
    /// <param name="ClearExport">For DELETE action, setting this to true will clear any pending exports for recordings. This field is only used for DELETE action. Default value &#x3D; false.</param>
    /// <param name="ConversationQuery">Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.  This result depends on the analytics data lake job completion. See also: https://developer.genesys.cloud/analyticsdatamanagement/analytics/jobs/conversation-details-job#data-availability.This is supported only when querying for conversations up to and including 5 years old..</param>
    /// <param name="AgedConversationInterval">As an alternative to conversationQuery, specify the date and time range of conversations that are older than 5 years to query.Results will include all conversations that had activity during the interval. This is supported only when querying for conversations older than 5 years;conversationQuery must not be provided when this is provided. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.Interval duration must not exceed 6 months. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    public RecordingJobsQuery(ActionEnum? Action = null, DateTime? ActionDate = null, int? ActionAge = null, DateTime? ScreenRecordingActionDate = null, int? ScreenRecordingActionAge = null, string IntegrationId = null, bool? IncludeRecordingsWithSensitiveData = null, bool? IncludeScreenRecordings = null, bool? ClearExport = null, AsyncConversationQuery ConversationQuery = null, string AgedConversationInterval = null)
    {
        this.Action = Action;
        this.ActionDate = ActionDate;
        this.ActionAge = ActionAge;
        this.ScreenRecordingActionDate = ScreenRecordingActionDate;
        this.ScreenRecordingActionAge = ScreenRecordingActionAge;
        this.IntegrationId = IntegrationId;
        this.IncludeRecordingsWithSensitiveData = IncludeRecordingsWithSensitiveData;
        this.IncludeScreenRecordings = IncludeScreenRecordings;
        this.ClearExport = ClearExport;
        this.ConversationQuery = ConversationQuery;
        this.AgedConversationInterval = AgedConversationInterval;

    }





    /// <summary>
    /// The date when the action will be performed. If screenRecordingActionDate is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the action will be performed. If screenRecordingActionDate is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "actionDate", EmitDefaultValue = false)]
    public DateTime? ActionDate { get; set; }



    /// <summary>
    /// The number of days after each recording&#39;s creation date when the action will be performed. If screenRecordingActionAge is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings.
    /// </summary>
    /// <value>The number of days after each recording&#39;s creation date when the action will be performed. If screenRecordingActionAge is also provided, this value is only used for non-screen recordings. Otherwise this value is used for all recordings.</value>
    [DataMember(Name = "actionAge", EmitDefaultValue = false)]
    public int? ActionAge { get; set; }



    /// <summary>
    /// The date when the action will be performed for screen recordings. If this is provided then includeScreenRecordings must be true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the action will be performed for screen recordings. If this is provided then includeScreenRecordings must be true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "screenRecordingActionDate", EmitDefaultValue = false)]
    public DateTime? ScreenRecordingActionDate { get; set; }



    /// <summary>
    /// The number of days after each screen recording&#39;s creation date when the action will be performed. If this is provided then includeScreenRecordings must be true.
    /// </summary>
    /// <value>The number of days after each screen recording&#39;s creation date when the action will be performed. If this is provided then includeScreenRecordings must be true.</value>
    [DataMember(Name = "screenRecordingActionAge", EmitDefaultValue = false)]
    public int? ScreenRecordingActionAge { get; set; }



    /// <summary>
    /// IntegrationId to Access AWS S3 bucket for bulk recording exports. This field is required and used only for EXPORT action.
    /// </summary>
    /// <value>IntegrationId to Access AWS S3 bucket for bulk recording exports. This field is required and used only for EXPORT action.</value>
    [DataMember(Name = "integrationId", EmitDefaultValue = false)]
    public string IntegrationId { get; set; }



    /// <summary>
    /// Whether to include recordings with PCI DSS and/or PII data, default value &#x3D; false 
    /// </summary>
    /// <value>Whether to include recordings with PCI DSS and/or PII data, default value &#x3D; false </value>
    [DataMember(Name = "includeRecordingsWithSensitiveData", EmitDefaultValue = false)]
    public bool? IncludeRecordingsWithSensitiveData { get; set; }



    /// <summary>
    /// Whether to include Screen recordings for the action, default value &#x3D; true 
    /// </summary>
    /// <value>Whether to include Screen recordings for the action, default value &#x3D; true </value>
    [DataMember(Name = "includeScreenRecordings", EmitDefaultValue = false)]
    public bool? IncludeScreenRecordings { get; set; }



    /// <summary>
    /// For DELETE action, setting this to true will clear any pending exports for recordings. This field is only used for DELETE action. Default value &#x3D; false
    /// </summary>
    /// <value>For DELETE action, setting this to true will clear any pending exports for recordings. This field is only used for DELETE action. Default value &#x3D; false</value>
    [DataMember(Name = "clearExport", EmitDefaultValue = false)]
    public bool? ClearExport { get; set; }



    /// <summary>
    /// Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.  This result depends on the analytics data lake job completion. See also: https://developer.genesys.cloud/analyticsdatamanagement/analytics/jobs/conversation-details-job#data-availability.This is supported only when querying for conversations up to and including 5 years old.
    /// </summary>
    /// <value>Conversation Query. Note: After the recording is created, it might take up to 48 hours for the recording to be included in the submitted job query.  This result depends on the analytics data lake job completion. See also: https://developer.genesys.cloud/analyticsdatamanagement/analytics/jobs/conversation-details-job#data-availability.This is supported only when querying for conversations up to and including 5 years old.</value>
    [DataMember(Name = "conversationQuery", EmitDefaultValue = false)]
    public AsyncConversationQuery ConversationQuery { get; set; }



    /// <summary>
    /// As an alternative to conversationQuery, specify the date and time range of conversations that are older than 5 years to query.Results will include all conversations that had activity during the interval. This is supported only when querying for conversations older than 5 years;conversationQuery must not be provided when this is provided. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.Interval duration must not exceed 6 months. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>As an alternative to conversationQuery, specify the date and time range of conversations that are older than 5 years to query.Results will include all conversations that had activity during the interval. This is supported only when querying for conversations older than 5 years;conversationQuery must not be provided when this is provided. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.Interval duration must not exceed 6 months. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [DataMember(Name = "agedConversationInterval", EmitDefaultValue = false)]
    public string AgedConversationInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingJobsQuery {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
        sb.Append("  ActionAge: ").Append(ActionAge).Append("\n");
        sb.Append("  ScreenRecordingActionDate: ").Append(ScreenRecordingActionDate).Append("\n");
        sb.Append("  ScreenRecordingActionAge: ").Append(ScreenRecordingActionAge).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("  IncludeRecordingsWithSensitiveData: ").Append(IncludeRecordingsWithSensitiveData).Append("\n");
        sb.Append("  IncludeScreenRecordings: ").Append(IncludeScreenRecordings).Append("\n");
        sb.Append("  ClearExport: ").Append(ClearExport).Append("\n");
        sb.Append("  ConversationQuery: ").Append(ConversationQuery).Append("\n");
        sb.Append("  AgedConversationInterval: ").Append(AgedConversationInterval).Append("\n");
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
        return Equals(obj as RecordingJobsQuery);
    }

    /// <summary>
    /// Returns true if RecordingJobsQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingJobsQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingJobsQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                ActionDate == other.ActionDate ||
                ActionDate != null &&
                ActionDate.Equals(other.ActionDate)
            ) &&
            (
                ActionAge == other.ActionAge ||
                ActionAge != null &&
                ActionAge.Equals(other.ActionAge)
            ) &&
            (
                ScreenRecordingActionDate == other.ScreenRecordingActionDate ||
                ScreenRecordingActionDate != null &&
                ScreenRecordingActionDate.Equals(other.ScreenRecordingActionDate)
            ) &&
            (
                ScreenRecordingActionAge == other.ScreenRecordingActionAge ||
                ScreenRecordingActionAge != null &&
                ScreenRecordingActionAge.Equals(other.ScreenRecordingActionAge)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            ) &&
            (
                IncludeRecordingsWithSensitiveData == other.IncludeRecordingsWithSensitiveData ||
                IncludeRecordingsWithSensitiveData != null &&
                IncludeRecordingsWithSensitiveData.Equals(other.IncludeRecordingsWithSensitiveData)
            ) &&
            (
                IncludeScreenRecordings == other.IncludeScreenRecordings ||
                IncludeScreenRecordings != null &&
                IncludeScreenRecordings.Equals(other.IncludeScreenRecordings)
            ) &&
            (
                ClearExport == other.ClearExport ||
                ClearExport != null &&
                ClearExport.Equals(other.ClearExport)
            ) &&
            (
                ConversationQuery == other.ConversationQuery ||
                ConversationQuery != null &&
                ConversationQuery.Equals(other.ConversationQuery)
            ) &&
            (
                AgedConversationInterval == other.AgedConversationInterval ||
                AgedConversationInterval != null &&
                AgedConversationInterval.Equals(other.AgedConversationInterval)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (ActionDate != null)
            {
                hash = hash * 59 + ActionDate.GetHashCode();
            }

            if (ActionAge != null)
            {
                hash = hash * 59 + ActionAge.GetHashCode();
            }

            if (ScreenRecordingActionDate != null)
            {
                hash = hash * 59 + ScreenRecordingActionDate.GetHashCode();
            }

            if (ScreenRecordingActionAge != null)
            {
                hash = hash * 59 + ScreenRecordingActionAge.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            if (IncludeRecordingsWithSensitiveData != null)
            {
                hash = hash * 59 + IncludeRecordingsWithSensitiveData.GetHashCode();
            }

            if (IncludeScreenRecordings != null)
            {
                hash = hash * 59 + IncludeScreenRecordings.GetHashCode();
            }

            if (ClearExport != null)
            {
                hash = hash * 59 + ClearExport.GetHashCode();
            }

            if (ConversationQuery != null)
            {
                hash = hash * 59 + ConversationQuery.GetHashCode();
            }

            if (AgedConversationInterval != null)
            {
                hash = hash * 59 + AgedConversationInterval.GetHashCode();
            }

            return hash;
        }
    }
}
