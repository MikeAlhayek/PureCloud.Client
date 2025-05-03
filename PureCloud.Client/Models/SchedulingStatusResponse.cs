using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SchedulingStatusResponse
/// </summary>

public partial class SchedulingStatusResponse : IEquatable<SchedulingStatusResponse>
{
    /// <summary>
    /// The status of the scheduling job.
    /// </summary>
    /// <value>The status of the scheduling job.</value>
    
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
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Ongoing for "Ongoing"
        /// </summary>
        [EnumMember(Value = "Ongoing")]
        Ongoing,

        /// <summary>
        /// Enum Partialfailure for "PartialFailure"
        /// </summary>
        [EnumMember(Value = "PartialFailure")]
        Partialfailure
    }
    /// <summary>
    /// The status of the scheduling job.
    /// </summary>
    /// <value>The status of the scheduling job.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SchedulingStatusResponse" /> class.
    /// </summary>
    public SchedulingStatusResponse()
    {

    }



    /// <summary>
    /// The ID generated for the scheduling job.  Use to GET result when job is completed.
    /// </summary>
    /// <value>The ID generated for the scheduling job.  Use to GET result when job is completed.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }





    /// <summary>
    /// If the request could not be properly processed, error details will be given here.
    /// </summary>
    /// <value>If the request could not be properly processed, error details will be given here.</value>
    [JsonPropertyName("errorDetails")]
    public List<SchedulingProcessingError> ErrorDetails { get; private set; }



    /// <summary>
    /// The uri of the scheduling result. It has a value if the status is &#39;Success&#39;.
    /// </summary>
    /// <value>The uri of the scheduling result. It has a value if the status is &#39;Success&#39;.</value>
    [JsonPropertyName("schedulingResultUri")]
    public string SchedulingResultUri { get; private set; }



    /// <summary>
    /// The percentage of the job that is complete.
    /// </summary>
    /// <value>The percentage of the job that is complete.</value>
    [JsonPropertyName("percentComplete")]
    public int? PercentComplete { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SchedulingStatusResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
        sb.Append("  SchedulingResultUri: ").Append(SchedulingResultUri).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
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
        return Equals(obj as SchedulingStatusResponse);
    }

    /// <summary>
    /// Returns true if SchedulingStatusResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SchedulingStatusResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SchedulingStatusResponse other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ErrorDetails == other.ErrorDetails ||
                ErrorDetails != null &&
                ErrorDetails.SequenceEqual(other.ErrorDetails)
            ) &&
            (
                SchedulingResultUri == other.SchedulingResultUri ||
                SchedulingResultUri != null &&
                SchedulingResultUri.Equals(other.SchedulingResultUri)
            ) &&
            (
                PercentComplete == other.PercentComplete ||
                PercentComplete != null &&
                PercentComplete.Equals(other.PercentComplete)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ErrorDetails != null)
            {
                hash = hash * 59 + ErrorDetails.GetHashCode();
            }

            if (SchedulingResultUri != null)
            {
                hash = hash * 59 + SchedulingResultUri.GetHashCode();
            }

            if (PercentComplete != null)
            {
                hash = hash * 59 + PercentComplete.GetHashCode();
            }

            return hash;
        }
    }
}
