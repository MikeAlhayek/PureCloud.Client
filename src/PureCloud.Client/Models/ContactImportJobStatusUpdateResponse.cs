using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactImportJobStatusUpdateResponse
/// </summary>

public partial class ContactImportJobStatusUpdateResponse : IEquatable<ContactImportJobStatusUpdateResponse>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
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
        /// Enum Continue for "Continue"
        /// </summary>
        [EnumMember(Value = "Continue")]
        Continue,

        /// <summary>
        /// Enum Cancel for "Cancel"
        /// </summary>
        [EnumMember(Value = "Cancel")]
        Cancel,

        /// <summary>
        /// Enum Retry for "Retry"
        /// </summary>
        [EnumMember(Value = "Retry")]
        Retry
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobStatusUpdateResponse" /> class.
    /// </summary>
    /// <param name="JobId">JobId.</param>
    /// <param name="Status">Status.</param>
    public ContactImportJobStatusUpdateResponse(string JobId = null, StatusEnum? Status = null)
    {
        this.JobId = JobId;
        this.Status = Status;

    }



    /// <summary>
    /// Gets or Sets JobId
    /// </summary>
    [JsonPropertyName("jobId")]
    public string JobId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactImportJobStatusUpdateResponse {\n");

        sb.Append("  JobId: ").Append(JobId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
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
        return Equals(obj as ContactImportJobStatusUpdateResponse);
    }

    /// <summary>
    /// Returns true if ContactImportJobStatusUpdateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactImportJobStatusUpdateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactImportJobStatusUpdateResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JobId == other.JobId ||
                JobId != null &&
                JobId.Equals(other.JobId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
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
            if (JobId != null)
            {
                hash = hash * 59 + JobId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            return hash;
        }
    }
}
