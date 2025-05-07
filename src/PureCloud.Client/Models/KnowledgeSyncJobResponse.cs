using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeSyncJobResponse
/// </summary>

public partial class KnowledgeSyncJobResponse : IEquatable<KnowledgeSyncJobResponse>
{
    /// <summary>
    /// The status of the export job.
    /// </summary>
    /// <value>The status of the export job.</value>
    
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
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Validationinprogress for "ValidationInProgress"
        /// </summary>
        [EnumMember(Value = "ValidationInProgress")]
        Validationinprogress,

        /// <summary>
        /// Enum Validationcompleted for "ValidationCompleted"
        /// </summary>
        [EnumMember(Value = "ValidationCompleted")]
        Validationcompleted,

        /// <summary>
        /// Enum Validationfailed for "ValidationFailed"
        /// </summary>
        [EnumMember(Value = "ValidationFailed")]
        Validationfailed,

        /// <summary>
        /// Enum Started for "Started"
        /// </summary>
        [EnumMember(Value = "Started")]
        Started,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Partialcompleted for "PartialCompleted"
        /// </summary>
        [EnumMember(Value = "PartialCompleted")]
        Partialcompleted,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Abortrequested for "AbortRequested"
        /// </summary>
        [EnumMember(Value = "AbortRequested")]
        Abortrequested,

        /// <summary>
        /// Enum Aborted for "Aborted"
        /// </summary>
        [EnumMember(Value = "Aborted")]
        Aborted
    }
    /// <summary>
    /// The status of the export job.
    /// </summary>
    /// <value>The status of the export job.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeSyncJobResponse" /> class.
    /// </summary>
    /// <param name="Id">Id of the sync job..</param>
    /// <param name="UploadKey">UploadKey.</param>
    /// <param name="Status">The status of the export job..</param>
    /// <param name="Report">Report of the sync job.</param>
    /// <param name="KnowledgeBase">Knowledge base which document export belongs to..</param>
    /// <param name="DateCreated">The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">The user who created the operation.</param>
    /// <param name="DownloadURL">The URL of the location at which the caller can download the sync file, when available..</param>
    /// <param name="FailedEntitiesURL">The URL of the location at which the caller can download the entities in json format that failed during the sync..</param>
    /// <param name="Source">Source of the sync job..</param>
    public KnowledgeSyncJobResponse(string Id = null, string UploadKey = null, StatusEnum? Status = null, KnowledgeSyncJobReport Report = null, KnowledgeBaseReference KnowledgeBase = null, DateTime? DateCreated = null, DateTime? DateModified = null, UserReference CreatedBy = null, string DownloadURL = null, string FailedEntitiesURL = null, KnowledgeOperationSource Source = null)
    {
        this.Id = Id;
        this.UploadKey = UploadKey;
        this.Status = Status;
        this.Report = Report;
        this.KnowledgeBase = KnowledgeBase;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.DownloadURL = DownloadURL;
        this.FailedEntitiesURL = FailedEntitiesURL;
        this.Source = Source;

    }



    /// <summary>
    /// Id of the sync job.
    /// </summary>
    /// <value>Id of the sync job.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets UploadKey
    /// </summary>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }





    /// <summary>
    /// Report of the sync job
    /// </summary>
    /// <value>Report of the sync job</value>
    [JsonPropertyName("report")]
    public KnowledgeSyncJobReport Report { get; set; }



    /// <summary>
    /// Knowledge base which document export belongs to.
    /// </summary>
    /// <value>Knowledge base which document export belongs to.</value>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBaseReference KnowledgeBase { get; set; }



    /// <summary>
    /// The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export stopped. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The user who created the operation
    /// </summary>
    /// <value>The user who created the operation</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; set; }



    /// <summary>
    /// The URL of the location at which the caller can download the sync file, when available.
    /// </summary>
    /// <value>The URL of the location at which the caller can download the sync file, when available.</value>
    [JsonPropertyName("downloadURL")]
    public string DownloadURL { get; set; }



    /// <summary>
    /// The URL of the location at which the caller can download the entities in json format that failed during the sync.
    /// </summary>
    /// <value>The URL of the location at which the caller can download the entities in json format that failed during the sync.</value>
    [JsonPropertyName("failedEntitiesURL")]
    public string FailedEntitiesURL { get; set; }



    /// <summary>
    /// Source of the sync job.
    /// </summary>
    /// <value>Source of the sync job.</value>
    [JsonPropertyName("source")]
    public KnowledgeOperationSource Source { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeSyncJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Report: ").Append(Report).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
        sb.Append("  FailedEntitiesURL: ").Append(FailedEntitiesURL).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as KnowledgeSyncJobResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeSyncJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeSyncJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeSyncJobResponse other)
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
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Report == other.Report ||
                Report != null &&
                Report.Equals(other.Report)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DownloadURL == other.DownloadURL ||
                DownloadURL != null &&
                DownloadURL.Equals(other.DownloadURL)
            ) &&
            (
                FailedEntitiesURL == other.FailedEntitiesURL ||
                FailedEntitiesURL != null &&
                FailedEntitiesURL.Equals(other.FailedEntitiesURL)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Report != null)
            {
                hash = hash * 59 + Report.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DownloadURL != null)
            {
                hash = hash * 59 + DownloadURL.GetHashCode();
            }

            if (FailedEntitiesURL != null)
            {
                hash = hash * 59 + FailedEntitiesURL.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
