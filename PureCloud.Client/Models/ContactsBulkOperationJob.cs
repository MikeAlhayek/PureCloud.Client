using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsBulkOperationJob
/// </summary>

public partial class ContactsBulkOperationJob : IEquatable<ContactsBulkOperationJob>
{
    /// <summary>
    /// The job state.
    /// </summary>
    /// <value>The job state.</value>
    
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
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// The job type.
    /// </summary>
    /// <value>The job type.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bulkdelete for "BulkDelete"
        /// </summary>
        [EnumMember(Value = "BulkDelete")]
        Bulkdelete,

        /// <summary>
        /// Enum Bulkedit for "BulkEdit"
        /// </summary>
        [EnumMember(Value = "BulkEdit")]
        Bulkedit
    }
    /// <summary>
    /// The job state.
    /// </summary>
    /// <value>The job state.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// The job type.
    /// </summary>
    /// <value>The job type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsBulkOperationJob" /> class.
    /// </summary>
    public ContactsBulkOperationJob()
    {

    }



    /// <summary>
    /// The globally unique job identifier.
    /// </summary>
    /// <value>The globally unique job identifier.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }







    /// <summary>
    /// Total records that will be impacted by the bulk operation.
    /// </summary>
    /// <value>Total records that will be impacted by the bulk operation.</value>
    [JsonPropertyName("totalRecords")]
    public long? TotalRecords { get; private set; }



    /// <summary>
    /// Amount of records that have been impacted by the bulk operation.
    /// </summary>
    /// <value>Amount of records that have been impacted by the bulk operation.</value>
    [JsonPropertyName("completedRecords")]
    public long? CompletedRecords { get; private set; }



    /// <summary>
    /// Percentage of records that have been impacted by the bulk operation.
    /// </summary>
    /// <value>Percentage of records that have been impacted by the bulk operation.</value>
    [JsonPropertyName("percentComplete")]
    public int? PercentComplete { get; private set; }



    /// <summary>
    /// Information on failure reason.
    /// </summary>
    /// <value>Information on failure reason.</value>
    [JsonPropertyName("failureReason")]
    public ErrorInfo FailureReason { get; private set; }



    /// <summary>
    /// URI to download the original backup contacts.
    /// </summary>
    /// <value>URI to download the original backup contacts.</value>
    [JsonPropertyName("downloadURI")]
    public string DownloadURI { get; private set; }



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
        sb.Append("class ContactsBulkOperationJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
        sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
        sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
        sb.Append("  DownloadURI: ").Append(DownloadURI).Append("\n");
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
        return Equals(obj as ContactsBulkOperationJob);
    }

    /// <summary>
    /// Returns true if ContactsBulkOperationJob instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsBulkOperationJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsBulkOperationJob other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                TotalRecords == other.TotalRecords ||
                TotalRecords != null &&
                TotalRecords.Equals(other.TotalRecords)
            ) &&
            (
                CompletedRecords == other.CompletedRecords ||
                CompletedRecords != null &&
                CompletedRecords.Equals(other.CompletedRecords)
            ) &&
            (
                PercentComplete == other.PercentComplete ||
                PercentComplete != null &&
                PercentComplete.Equals(other.PercentComplete)
            ) &&
            (
                FailureReason == other.FailureReason ||
                FailureReason != null &&
                FailureReason.Equals(other.FailureReason)
            ) &&
            (
                DownloadURI == other.DownloadURI ||
                DownloadURI != null &&
                DownloadURI.Equals(other.DownloadURI)
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

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (TotalRecords != null)
            {
                hash = hash * 59 + TotalRecords.GetHashCode();
            }

            if (CompletedRecords != null)
            {
                hash = hash * 59 + CompletedRecords.GetHashCode();
            }

            if (PercentComplete != null)
            {
                hash = hash * 59 + PercentComplete.GetHashCode();
            }

            if (FailureReason != null)
            {
                hash = hash * 59 + FailureReason.GetHashCode();
            }

            if (DownloadURI != null)
            {
                hash = hash * 59 + DownloadURI.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
