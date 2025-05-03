using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate
/// </summary>

public partial class WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate : IEquatable<WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate>
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
        /// Enum Initiated for "Initiated"
        /// </summary>
        [EnumMember(Value = "Initiated")]
        Initiated,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

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
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled,

        /// <summary>
        /// Enum Purged for "Purged"
        /// </summary>
        [EnumMember(Value = "Purged")]
        Purged,

        /// <summary>
        /// Enum Purgepending for "PurgePending"
        /// </summary>
        [EnumMember(Value = "PurgePending")]
        Purgepending
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
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
        /// Enum Csv for "Csv"
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv,

        /// <summary>
        /// Enum Json for "Json"
        /// </summary>
        [EnumMember(Value = "Json")]
        Json
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate" /> class.
    /// </summary>
    /// <param name="RequestId">RequestId.</param>
    /// <param name="DateImportStarted">DateImportStarted.</param>
    /// <param name="DateImportEnded">DateImportEnded.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="DateModified">DateModified.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Error">Error.</param>
    /// <param name="Active">Active.</param>
    /// <param name="Type">Type.</param>
    /// <param name="FileName">FileName.</param>
    /// <param name="FileSize">FileSize.</param>
    public WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate(string RequestId = null, DateTime? DateImportStarted = null, DateTime? DateImportEnded = null, DateTime? DateCreated = null, DateTime? DateModified = null, StatusEnum? Status = null, string Error = null, bool? Active = null, TypeEnum? Type = null, string FileName = null, long? FileSize = null)
    {
        this.RequestId = RequestId;
        this.DateImportStarted = DateImportStarted;
        this.DateImportEnded = DateImportEnded;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Status = Status;
        this.Error = Error;
        this.Active = Active;
        this.Type = Type;
        this.FileName = FileName;
        this.FileSize = FileSize;

    }



    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    [JsonPropertyName("requestId")]
    public string RequestId { get; set; }



    /// <summary>
    /// Gets or Sets DateImportStarted
    /// </summary>
    [JsonPropertyName("dateImportStarted")]
    public DateTime? DateImportStarted { get; set; }



    /// <summary>
    /// Gets or Sets DateImportEnded
    /// </summary>
    [JsonPropertyName("dateImportEnded")]
    public DateTime? DateImportEnded { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets DateModified
    /// </summary>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }





    /// <summary>
    /// Gets or Sets Error
    /// </summary>
    [JsonPropertyName("error")]
    public string Error { get; set; }



    /// <summary>
    /// Gets or Sets Active
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }





    /// <summary>
    /// Gets or Sets FileName
    /// </summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }



    /// <summary>
    /// Gets or Sets FileSize
    /// </summary>
    [JsonPropertyName("fileSize")]
    public long? FileSize { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate {\n");

        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  DateImportStarted: ").Append(DateImportStarted).Append("\n");
        sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  FileSize: ").Append(FileSize).Append("\n");
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
        return Equals(obj as WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate);
    }

    /// <summary>
    /// Returns true if WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalDataUploadRequestStatusTopicHistoricalDataUploadRequestUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RequestId == other.RequestId ||
                RequestId != null &&
                RequestId.Equals(other.RequestId)
            ) &&
            (
                DateImportStarted == other.DateImportStarted ||
                DateImportStarted != null &&
                DateImportStarted.Equals(other.DateImportStarted)
            ) &&
            (
                DateImportEnded == other.DateImportEnded ||
                DateImportEnded != null &&
                DateImportEnded.Equals(other.DateImportEnded)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                FileSize == other.FileSize ||
                FileSize != null &&
                FileSize.Equals(other.FileSize)
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
            if (RequestId != null)
            {
                hash = hash * 59 + RequestId.GetHashCode();
            }

            if (DateImportStarted != null)
            {
                hash = hash * 59 + DateImportStarted.GetHashCode();
            }

            if (DateImportEnded != null)
            {
                hash = hash * 59 + DateImportEnded.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (FileSize != null)
            {
                hash = hash * 59 + FileSize.GetHashCode();
            }

            return hash;
        }
    }
}
