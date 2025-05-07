using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ImportStatus
/// </summary>

public partial class ImportStatus : IEquatable<ImportStatus>
{
    /// <summary>
    /// current status of the import
    /// </summary>
    /// <value>current status of the import</value>
    
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
        /// Enum InProgress for "IN_PROGRESS"
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        InProgress,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// current status of the import
    /// </summary>
    /// <value>current status of the import</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ImportStatus" /> class.
    /// </summary>
    public ImportStatus()
    {

    }





    /// <summary>
    /// total number of records to be imported
    /// </summary>
    /// <value>total number of records to be imported</value>
    [JsonPropertyName("totalRecords")]
    public long? TotalRecords { get; set; }



    /// <summary>
    /// number of records finished importing
    /// </summary>
    /// <value>number of records finished importing</value>
    [JsonPropertyName("completedRecords")]
    public long? CompletedRecords { get; set; }



    /// <summary>
    /// percentage of records finished importing
    /// </summary>
    /// <value>percentage of records finished importing</value>
    [JsonPropertyName("percentComplete")]
    public int? PercentComplete { get; set; }



    /// <summary>
    /// if the import has failed, the reason for the failure
    /// </summary>
    /// <value>if the import has failed, the reason for the failure</value>
    [JsonPropertyName("failureReason")]
    public string FailureReason { get; set; }



    /// <summary>
    /// The contact list Ids for target contact lists.
    /// </summary>
    /// <value>The contact list Ids for target contact lists.</value>
    [JsonPropertyName("targetContactListIds")]
    public List<string> TargetContactListIds { get; set; }



    /// <summary>
    /// The prefix for the contact list name
    /// </summary>
    /// <value>The prefix for the contact list name</value>
    [JsonPropertyName("listNamePrefix")]
    public string ListNamePrefix { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ImportStatus {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
        sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
        sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
        sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
        sb.Append("  TargetContactListIds: ").Append(TargetContactListIds).Append("\n");
        sb.Append("  ListNamePrefix: ").Append(ListNamePrefix).Append("\n");
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
        return Equals(obj as ImportStatus);
    }

    /// <summary>
    /// Returns true if ImportStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of ImportStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ImportStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
                TargetContactListIds == other.TargetContactListIds ||
                TargetContactListIds != null &&
                TargetContactListIds.SequenceEqual(other.TargetContactListIds)
            ) &&
            (
                ListNamePrefix == other.ListNamePrefix ||
                ListNamePrefix != null &&
                ListNamePrefix.Equals(other.ListNamePrefix)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
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

            if (TargetContactListIds != null)
            {
                hash = hash * 59 + TargetContactListIds.GetHashCode();
            }

            if (ListNamePrefix != null)
            {
                hash = hash * 59 + ListNamePrefix.GetHashCode();
            }

            return hash;
        }
    }
}
