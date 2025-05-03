using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information about a CX infrastructure as code job
/// </summary>

public partial class InfrastructureascodeJob : IEquatable<InfrastructureascodeJob>
{
    /// <summary>
    /// Job status
    /// </summary>
    /// <value>Job status</value>
    
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
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Internalerror for "InternalError"
        /// </summary>
        [EnumMember(Value = "InternalError")]
        Internalerror,

        /// <summary>
        /// Enum Incomplete for "Incomplete"
        /// </summary>
        [EnumMember(Value = "Incomplete")]
        Incomplete,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Rollbackfailed for "RollbackFailed"
        /// </summary>
        [EnumMember(Value = "RollbackFailed")]
        Rollbackfailed,

        /// <summary>
        /// Enum Rollbackcomplete for "RollbackComplete"
        /// </summary>
        [EnumMember(Value = "RollbackComplete")]
        Rollbackcomplete
    }
    /// <summary>
    /// Job status
    /// </summary>
    /// <value>Job status</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="InfrastructureascodeJob" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InfrastructureascodeJob() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InfrastructureascodeJob" /> class.
    /// </summary>
    /// <param name="DryRun">Whether or not the job was a dry run (required).</param>
    public InfrastructureascodeJob(bool? DryRun = null)
    {
        this.DryRun = DryRun;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Whether or not the job was a dry run
    /// </summary>
    /// <value>Whether or not the job was a dry run</value>
    [JsonPropertyName("dryRun")]
    public bool? DryRun { get; set; }



    /// <summary>
    /// Accelerator associated with the job
    /// </summary>
    /// <value>Accelerator associated with the job</value>
    [JsonPropertyName("acceleratorId")]
    public string AcceleratorId { get; private set; }



    /// <summary>
    /// Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date and time on which job was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateSubmitted")]
    public DateTime? DateSubmitted { get; private set; }



    /// <summary>
    /// User who submitted the job
    /// </summary>
    /// <value>User who submitted the job</value>
    [JsonPropertyName("submittedBy")]
    public UserReference SubmittedBy { get; private set; }





    /// <summary>
    /// Information about errors, if any
    /// </summary>
    /// <value>Information about errors, if any</value>
    [JsonPropertyName("errorInfo")]
    public ErrorInfo ErrorInfo { get; private set; }



    /// <summary>
    /// The output results of the terraform job
    /// </summary>
    /// <value>The output results of the terraform job</value>
    [JsonPropertyName("results")]
    public string Results { get; private set; }



    /// <summary>
    /// The results of rolling back the job if there were errors.  Not returned if job was successful.
    /// </summary>
    /// <value>The results of rolling back the job if there were errors.  Not returned if job was successful.</value>
    [JsonPropertyName("rollbackResults")]
    public string RollbackResults { get; private set; }



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
        sb.Append("class InfrastructureascodeJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DryRun: ").Append(DryRun).Append("\n");
        sb.Append("  AcceleratorId: ").Append(AcceleratorId).Append("\n");
        sb.Append("  DateSubmitted: ").Append(DateSubmitted).Append("\n");
        sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  RollbackResults: ").Append(RollbackResults).Append("\n");
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
        return Equals(obj as InfrastructureascodeJob);
    }

    /// <summary>
    /// Returns true if InfrastructureascodeJob instances are equal
    /// </summary>
    /// <param name="other">Instance of InfrastructureascodeJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InfrastructureascodeJob other)
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
                DryRun == other.DryRun ||
                DryRun != null &&
                DryRun.Equals(other.DryRun)
            ) &&
            (
                AcceleratorId == other.AcceleratorId ||
                AcceleratorId != null &&
                AcceleratorId.Equals(other.AcceleratorId)
            ) &&
            (
                DateSubmitted == other.DateSubmitted ||
                DateSubmitted != null &&
                DateSubmitted.Equals(other.DateSubmitted)
            ) &&
            (
                SubmittedBy == other.SubmittedBy ||
                SubmittedBy != null &&
                SubmittedBy.Equals(other.SubmittedBy)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                Results == other.Results ||
                Results != null &&
                Results.Equals(other.Results)
            ) &&
            (
                RollbackResults == other.RollbackResults ||
                RollbackResults != null &&
                RollbackResults.Equals(other.RollbackResults)
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

            if (DryRun != null)
            {
                hash = hash * 59 + DryRun.GetHashCode();
            }

            if (AcceleratorId != null)
            {
                hash = hash * 59 + AcceleratorId.GetHashCode();
            }

            if (DateSubmitted != null)
            {
                hash = hash * 59 + DateSubmitted.GetHashCode();
            }

            if (SubmittedBy != null)
            {
                hash = hash * 59 + SubmittedBy.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (RollbackResults != null)
            {
                hash = hash * 59 + RollbackResults.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
