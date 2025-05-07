using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingJob
/// </summary>

public partial class RecordingJob : IEquatable<RecordingJob>
{
    /// <summary>
    /// The current state of the job.
    /// </summary>
    /// <value>The current state of the job.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Fulfilled for "FULFILLED"
        /// </summary>
        [EnumMember(Value = "FULFILLED")]
        Fulfilled,

        /// <summary>
        /// Enum Pending for "PENDING"
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Enum Ready for "READY"
        /// </summary>
        [EnumMember(Value = "READY")]
        Ready,

        /// <summary>
        /// Enum Processing for "PROCESSING"
        /// </summary>
        [EnumMember(Value = "PROCESSING")]
        Processing,

        /// <summary>
        /// Enum Cancelled for "CANCELLED"
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// The current state of the job.
    /// </summary>
    /// <value>The current state of the job.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingJob" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected RecordingJob() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingJob" /> class.
    /// </summary>
    /// <param name="State">The current state of the job. (required).</param>
    public RecordingJob(StateEnum? State = null)
    {
        this.State = State;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Original query of the job.
    /// </summary>
    /// <value>Original query of the job.</value>
    [JsonPropertyName("recordingJobsQuery")]
    public RecordingJobsQuery RecordingJobsQuery { get; set; }



    /// <summary>
    /// Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the job was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Total number of conversations affected.
    /// </summary>
    /// <value>Total number of conversations affected.</value>
    [JsonPropertyName("totalConversations")]
    public int? TotalConversations { get; set; }



    /// <summary>
    /// Total number of recordings affected.
    /// </summary>
    /// <value>Total number of recordings affected.</value>
    [JsonPropertyName("totalRecordings")]
    public int? TotalRecordings { get; set; }



    /// <summary>
    /// Total number of recordings that have been skipped.
    /// </summary>
    /// <value>Total number of recordings that have been skipped.</value>
    [JsonPropertyName("totalSkippedRecordings")]
    public int? TotalSkippedRecordings { get; set; }



    /// <summary>
    /// Total number of recordings that the bulk job failed to process.
    /// </summary>
    /// <value>Total number of recordings that the bulk job failed to process.</value>
    [JsonPropertyName("totalFailedRecordings")]
    public int? TotalFailedRecordings { get; set; }



    /// <summary>
    /// Total number of recordings have been processed.
    /// </summary>
    /// <value>Total number of recordings have been processed.</value>
    [JsonPropertyName("totalProcessedRecordings")]
    public int? TotalProcessedRecordings { get; set; }



    /// <summary>
    /// Progress in percentage based on the number of recordings
    /// </summary>
    /// <value>Progress in percentage based on the number of recordings</value>
    [JsonPropertyName("percentProgress")]
    public int? PercentProgress { get; set; }



    /// <summary>
    /// Error occurred during the job execution
    /// </summary>
    /// <value>Error occurred during the job execution</value>
    [JsonPropertyName("errorMessage")]
    public string ErrorMessage { get; set; }



    /// <summary>
    /// Get IDs of recordings that the bulk job failed for
    /// </summary>
    /// <value>Get IDs of recordings that the bulk job failed for</value>
    [JsonPropertyName("failedRecordings")]
    public string FailedRecordings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Details of the user created the job
    /// </summary>
    /// <value>Details of the user created the job</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  RecordingJobsQuery: ").Append(RecordingJobsQuery).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  TotalConversations: ").Append(TotalConversations).Append("\n");
        sb.Append("  TotalRecordings: ").Append(TotalRecordings).Append("\n");
        sb.Append("  TotalSkippedRecordings: ").Append(TotalSkippedRecordings).Append("\n");
        sb.Append("  TotalFailedRecordings: ").Append(TotalFailedRecordings).Append("\n");
        sb.Append("  TotalProcessedRecordings: ").Append(TotalProcessedRecordings).Append("\n");
        sb.Append("  PercentProgress: ").Append(PercentProgress).Append("\n");
        sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
        sb.Append("  FailedRecordings: ").Append(FailedRecordings).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as RecordingJob);
    }

    /// <summary>
    /// Returns true if RecordingJob instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingJob other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                RecordingJobsQuery == other.RecordingJobsQuery ||
                RecordingJobsQuery != null &&
                RecordingJobsQuery.Equals(other.RecordingJobsQuery)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                TotalConversations == other.TotalConversations ||
                TotalConversations != null &&
                TotalConversations.Equals(other.TotalConversations)
            ) &&
            (
                TotalRecordings == other.TotalRecordings ||
                TotalRecordings != null &&
                TotalRecordings.Equals(other.TotalRecordings)
            ) &&
            (
                TotalSkippedRecordings == other.TotalSkippedRecordings ||
                TotalSkippedRecordings != null &&
                TotalSkippedRecordings.Equals(other.TotalSkippedRecordings)
            ) &&
            (
                TotalFailedRecordings == other.TotalFailedRecordings ||
                TotalFailedRecordings != null &&
                TotalFailedRecordings.Equals(other.TotalFailedRecordings)
            ) &&
            (
                TotalProcessedRecordings == other.TotalProcessedRecordings ||
                TotalProcessedRecordings != null &&
                TotalProcessedRecordings.Equals(other.TotalProcessedRecordings)
            ) &&
            (
                PercentProgress == other.PercentProgress ||
                PercentProgress != null &&
                PercentProgress.Equals(other.PercentProgress)
            ) &&
            (
                ErrorMessage == other.ErrorMessage ||
                ErrorMessage != null &&
                ErrorMessage.Equals(other.ErrorMessage)
            ) &&
            (
                FailedRecordings == other.FailedRecordings ||
                FailedRecordings != null &&
                FailedRecordings.Equals(other.FailedRecordings)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (RecordingJobsQuery != null)
            {
                hash = hash * 59 + RecordingJobsQuery.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (TotalConversations != null)
            {
                hash = hash * 59 + TotalConversations.GetHashCode();
            }

            if (TotalRecordings != null)
            {
                hash = hash * 59 + TotalRecordings.GetHashCode();
            }

            if (TotalSkippedRecordings != null)
            {
                hash = hash * 59 + TotalSkippedRecordings.GetHashCode();
            }

            if (TotalFailedRecordings != null)
            {
                hash = hash * 59 + TotalFailedRecordings.GetHashCode();
            }

            if (TotalProcessedRecordings != null)
            {
                hash = hash * 59 + TotalProcessedRecordings.GetHashCode();
            }

            if (PercentProgress != null)
            {
                hash = hash * 59 + PercentProgress.GetHashCode();
            }

            if (ErrorMessage != null)
            {
                hash = hash * 59 + ErrorMessage.GetHashCode();
            }

            if (FailedRecordings != null)
            {
                hash = hash * 59 + FailedRecordings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            return hash;
        }
    }
}
