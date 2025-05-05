using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerDnclistConfigChangeImportStatus
/// </summary>

public partial class DialerDnclistConfigChangeImportStatus : IEquatable<DialerDnclistConfigChangeImportStatus>
{
    /// <summary>
    /// current status of the import
    /// </summary>
    /// <value>current status of the import</value>
    
    public enum ImportStateEnum
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
    [JsonPropertyName("importState")]
    public ImportStateEnum? ImportState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerDnclistConfigChangeImportStatus" /> class.
    /// </summary>
    /// <param name="ImportState">current status of the import.</param>
    /// <param name="TotalRecords">total number of records to be imported.</param>
    /// <param name="CompletedRecords">number of records finished importing.</param>
    /// <param name="PercentageComplete">percentage of records finished importing.</param>
    /// <param name="FailureReason">if the import has failed, the reason for the failure.</param>
    /// <param name="TargetContactListIds">The ids for target contact lists.</param>
    /// <param name="ListNamePrefix">The prefix used for target contact list names.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerDnclistConfigChangeImportStatus(ImportStateEnum? ImportState = null, long? TotalRecords = null, long? CompletedRecords = null, long? PercentageComplete = null, string FailureReason = null, List<string> TargetContactListIds = null, string ListNamePrefix = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.ImportState = ImportState;
        this.TotalRecords = TotalRecords;
        this.CompletedRecords = CompletedRecords;
        this.PercentageComplete = PercentageComplete;
        this.FailureReason = FailureReason;
        this.TargetContactListIds = TargetContactListIds;
        this.ListNamePrefix = ListNamePrefix;
        this.AdditionalProperties = AdditionalProperties;

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
    [JsonPropertyName("percentageComplete")]
    public long? PercentageComplete { get; set; }



    /// <summary>
    /// if the import has failed, the reason for the failure
    /// </summary>
    /// <value>if the import has failed, the reason for the failure</value>
    [JsonPropertyName("failureReason")]
    public string FailureReason { get; set; }



    /// <summary>
    /// The ids for target contact lists
    /// </summary>
    /// <value>The ids for target contact lists</value>
    [JsonPropertyName("targetContactListIds")]
    public List<string> TargetContactListIds { get; set; }



    /// <summary>
    /// The prefix used for target contact list names
    /// </summary>
    /// <value>The prefix used for target contact list names</value>
    [JsonPropertyName("listNamePrefix")]
    public string ListNamePrefix { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerDnclistConfigChangeImportStatus {\n");

        sb.Append("  ImportState: ").Append(ImportState).Append("\n");
        sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
        sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
        sb.Append("  PercentageComplete: ").Append(PercentageComplete).Append("\n");
        sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
        sb.Append("  TargetContactListIds: ").Append(TargetContactListIds).Append("\n");
        sb.Append("  ListNamePrefix: ").Append(ListNamePrefix).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return Equals(obj as DialerDnclistConfigChangeImportStatus);
    }

    /// <summary>
    /// Returns true if DialerDnclistConfigChangeImportStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerDnclistConfigChangeImportStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerDnclistConfigChangeImportStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ImportState == other.ImportState ||
                ImportState != null &&
                ImportState.Equals(other.ImportState)
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
                PercentageComplete == other.PercentageComplete ||
                PercentageComplete != null &&
                PercentageComplete.Equals(other.PercentageComplete)
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
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (ImportState != null)
            {
                hash = hash * 59 + ImportState.GetHashCode();
            }

            if (TotalRecords != null)
            {
                hash = hash * 59 + TotalRecords.GetHashCode();
            }

            if (CompletedRecords != null)
            {
                hash = hash * 59 + CompletedRecords.GetHashCode();
            }

            if (PercentageComplete != null)
            {
                hash = hash * 59 + PercentageComplete.GetHashCode();
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

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
