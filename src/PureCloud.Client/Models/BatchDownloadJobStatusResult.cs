using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BatchDownloadJobStatusResult
/// </summary>

public partial class BatchDownloadJobStatusResult : IEquatable<BatchDownloadJobStatusResult>
{
    /// <summary>
    /// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
    /// </summary>
    /// <value>Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.</value>
    
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
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed
    }
    /// <summary>
    /// Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.
    /// </summary>
    /// <value>Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchDownloadJobStatusResult" /> class.
    /// </summary>
    /// <param name="JobId">JobId returned when job was initially submitted..</param>
    /// <param name="ExpectedResultCount">Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed..</param>
    /// <param name="ResultCount">Current number of results available, this includes both success and error results..</param>
    /// <param name="ErrorCount">Current number of error results..</param>
    /// <param name="Status">Current status of the job. A job is considered completed when all the submitted requests have been processed and fulfilled..</param>
    /// <param name="Results">Current set of results for the job..</param>
    public BatchDownloadJobStatusResult(string JobId = null, int? ExpectedResultCount = null, int? ResultCount = null, int? ErrorCount = null, StatusEnum? Status = null, List<BatchDownloadJobResult> Results = null)
    {
        this.JobId = JobId;
        this.ExpectedResultCount = ExpectedResultCount;
        this.ResultCount = ResultCount;
        this.ErrorCount = ErrorCount;
        this.Status = Status;
        this.Results = Results;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// JobId returned when job was initially submitted.
    /// </summary>
    /// <value>JobId returned when job was initially submitted.</value>
    [JsonPropertyName("jobId")]
    public string JobId { get; set; }



    /// <summary>
    /// Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed.
    /// </summary>
    /// <value>Number of results expected when job is completed, this includes both success and error results. This number could change as recordings are being discovered and processed.</value>
    [JsonPropertyName("expectedResultCount")]
    public int? ExpectedResultCount { get; set; }



    /// <summary>
    /// Current number of results available, this includes both success and error results.
    /// </summary>
    /// <value>Current number of results available, this includes both success and error results.</value>
    [JsonPropertyName("resultCount")]
    public int? ResultCount { get; set; }



    /// <summary>
    /// Current number of error results.
    /// </summary>
    /// <value>Current number of error results.</value>
    [JsonPropertyName("errorCount")]
    public int? ErrorCount { get; set; }





    /// <summary>
    /// Current set of results for the job.
    /// </summary>
    /// <value>Current set of results for the job.</value>
    [JsonPropertyName("results")]
    public List<BatchDownloadJobResult> Results { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchDownloadJobStatusResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  JobId: ").Append(JobId).Append("\n");
        sb.Append("  ExpectedResultCount: ").Append(ExpectedResultCount).Append("\n");
        sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
        sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
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
        return Equals(obj as BatchDownloadJobStatusResult);
    }

    /// <summary>
    /// Returns true if BatchDownloadJobStatusResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchDownloadJobStatusResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchDownloadJobStatusResult other)
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
                JobId == other.JobId ||
                JobId != null &&
                JobId.Equals(other.JobId)
            ) &&
            (
                ExpectedResultCount == other.ExpectedResultCount ||
                ExpectedResultCount != null &&
                ExpectedResultCount.Equals(other.ExpectedResultCount)
            ) &&
            (
                ResultCount == other.ResultCount ||
                ResultCount != null &&
                ResultCount.Equals(other.ResultCount)
            ) &&
            (
                ErrorCount == other.ErrorCount ||
                ErrorCount != null &&
                ErrorCount.Equals(other.ErrorCount)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
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

            if (JobId != null)
            {
                hash = hash * 59 + JobId.GetHashCode();
            }

            if (ExpectedResultCount != null)
            {
                hash = hash * 59 + ExpectedResultCount.GetHashCode();
            }

            if (ResultCount != null)
            {
                hash = hash * 59 + ResultCount.GetHashCode();
            }

            if (ErrorCount != null)
            {
                hash = hash * 59 + ErrorCount.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
