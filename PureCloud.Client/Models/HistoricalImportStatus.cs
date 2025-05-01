using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalImportStatus
/// </summary>
[DataContract]
public partial class HistoricalImportStatus : IEquatable<HistoricalImportStatus>
{
    /// <summary>
    /// Status of the historical import in the organization.
    /// </summary>
    /// <value>Status of the historical import in the organization.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Whether this historical import is of type csv or json
    /// </summary>
    /// <value>Whether this historical import is of type csv or json</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Status of the historical import in the organization.
    /// </summary>
    /// <value>Status of the historical import in the organization.</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; private set; }
    /// <summary>
    /// Whether this historical import is of type csv or json
    /// </summary>
    /// <value>Whether this historical import is of type csv or json</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalImportStatus" /> class.
    /// </summary>
    public HistoricalImportStatus()
    {

    }



    /// <summary>
    /// Request id of the historical import in the organization
    /// </summary>
    /// <value>Request id of the historical import in the organization</value>
    [DataMember(Name = "requestId", EmitDefaultValue = false)]
    public string RequestId { get; private set; }



    /// <summary>
    /// The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateImportEnded", EmitDefaultValue = false)]
    public DateTime? DateImportEnded { get; private set; }



    /// <summary>
    /// The first day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The first day of the data you are importing. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateImportStarted", EmitDefaultValue = false)]
    public DateTime? DateImportStarted { get; private set; }





    /// <summary>
    /// Error occured if the status of the import is failed
    /// </summary>
    /// <value>Error occured if the status of the import is failed</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public string Error { get; private set; }



    /// <summary>
    /// Date in which the historical import is initiated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date in which the historical import is initiated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Date in which the historical import is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date in which the historical import is modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Whether this historical import is active or not
    /// </summary>
    /// <value>Whether this historical import is active or not</value>
    [DataMember(Name = "active", EmitDefaultValue = false)]
    public bool? Active { get; private set; }





    /// <summary>
    /// Name of the file that you are importing.
    /// </summary>
    /// <value>Name of the file that you are importing.</value>
    [DataMember(Name = "fileName", EmitDefaultValue = false)]
    public string FileName { get; private set; }



    /// <summary>
    /// Size of the file that you are importing.
    /// </summary>
    /// <value>Size of the file that you are importing.</value>
    [DataMember(Name = "fileSize", EmitDefaultValue = false)]
    public long? FileSize { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalImportStatus {\n");

        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  DateImportEnded: ").Append(DateImportEnded).Append("\n");
        sb.Append("  DateImportStarted: ").Append(DateImportStarted).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as HistoricalImportStatus);
    }

    /// <summary>
    /// Returns true if HistoricalImportStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalImportStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalImportStatus other)
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
                DateImportEnded == other.DateImportEnded ||
                DateImportEnded != null &&
                DateImportEnded.Equals(other.DateImportEnded)
            ) &&
            (
                DateImportStarted == other.DateImportStarted ||
                DateImportStarted != null &&
                DateImportStarted.Equals(other.DateImportStarted)
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

            if (DateImportEnded != null)
            {
                hash = hash * 59 + DateImportEnded.GetHashCode();
            }

            if (DateImportStarted != null)
            {
                hash = hash * 59 + DateImportStarted.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
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
