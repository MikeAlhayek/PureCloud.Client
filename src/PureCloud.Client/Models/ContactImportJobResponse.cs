using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactImportJobResponse
/// </summary>

public partial class ContactImportJobResponse : IEquatable<ContactImportJobResponse>
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
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Cancelled for "Cancelled"
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled
    }
    /// <summary>
    /// Detailed description for the Job execution state
    /// </summary>
    /// <value>Detailed description for the Job execution state</value>
    
    public enum ExecutionStepEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Validating for "Validating"
        /// </summary>
        [EnumMember(Value = "Validating")]
        Validating,

        /// <summary>
        /// Enum Validated for "Validated"
        /// </summary>
        [EnumMember(Value = "Validated")]
        Validated,

        /// <summary>
        /// Enum Importing for "Importing"
        /// </summary>
        [EnumMember(Value = "Importing")]
        Importing
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Detailed description for the Job execution state
    /// </summary>
    /// <value>Detailed description for the Job execution state</value>
    [JsonPropertyName("executionStep")]
    public ExecutionStepEnum? ExecutionStep { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContactImportJobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactImportJobResponse" /> class.
    /// </summary>
    /// <param name="Status">Status.</param>
    /// <param name="StatusDetails">Detailed description for JobStatus..</param>
    /// <param name="ExecutionStep">Detailed description for the Job execution state.</param>
    /// <param name="Metadata">Metadata for the job.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Settings">Settings (required).</param>
    public ContactImportJobResponse(StatusEnum? Status = null, string StatusDetails = null, ExecutionStepEnum? ExecutionStep = null, ContactImportJobMetadata Metadata = null, DateTime? DateCreated = null, AddressableEntityRef Settings = null)
    {
        this.Status = Status;
        this.StatusDetails = StatusDetails;
        this.ExecutionStep = ExecutionStep;
        this.Metadata = Metadata;
        this.DateCreated = DateCreated;
        this.Settings = Settings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Detailed description for JobStatus.
    /// </summary>
    /// <value>Detailed description for JobStatus.</value>
    [JsonPropertyName("statusDetails")]
    public string StatusDetails { get; set; }





    /// <summary>
    /// Metadata for the job
    /// </summary>
    /// <value>Metadata for the job</value>
    [JsonPropertyName("metadata")]
    public ContactImportJobMetadata Metadata { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// Settings
    /// </summary>
    /// <value>Settings</value>
    [JsonPropertyName("settings")]
    public AddressableEntityRef Settings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactImportJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StatusDetails: ").Append(StatusDetails).Append("\n");
        sb.Append("  ExecutionStep: ").Append(ExecutionStep).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
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
        return Equals(obj as ContactImportJobResponse);
    }

    /// <summary>
    /// Returns true if ContactImportJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactImportJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactImportJobResponse other)
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
                StatusDetails == other.StatusDetails ||
                StatusDetails != null &&
                StatusDetails.Equals(other.StatusDetails)
            ) &&
            (
                ExecutionStep == other.ExecutionStep ||
                ExecutionStep != null &&
                ExecutionStep.Equals(other.ExecutionStep)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.Equals(other.Metadata)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
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

            if (StatusDetails != null)
            {
                hash = hash * 59 + StatusDetails.GetHashCode();
            }

            if (ExecutionStep != null)
            {
                hash = hash * 59 + ExecutionStep.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            return hash;
        }
    }
}
