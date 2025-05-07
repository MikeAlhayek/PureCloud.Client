using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectExportJobStateResponse
/// </summary>

public partial class ArchitectExportJobStateResponse : IEquatable<ArchitectExportJobStateResponse>
{
    /// <summary>
    /// Status of the Architect Export Job
    /// </summary>
    /// <value>Status of the Architect Export Job</value>
    
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
        /// Enum Registered for "Registered"
        /// </summary>
        [EnumMember(Value = "Registered")]
        Registered,

        /// <summary>
        /// Enum Started for "Started"
        /// </summary>
        [EnumMember(Value = "Started")]
        Started,

        /// <summary>
        /// Enum Success for "Success"
        /// </summary>
        [EnumMember(Value = "Success")]
        Success,

        /// <summary>
        /// Enum Failure for "Failure"
        /// </summary>
        [EnumMember(Value = "Failure")]
        Failure
    }
    /// <summary>
    /// The command executed by the Architect Job
    /// </summary>
    /// <value>The command executed by the Architect Job</value>
    
    public enum CommandEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Publish for "Publish"
        /// </summary>
        [EnumMember(Value = "Publish")]
        Publish,

        /// <summary>
        /// Enum Create for "Create"
        /// </summary>
        [EnumMember(Value = "Create")]
        Create,

        /// <summary>
        /// Enum Update for "Update"
        /// </summary>
        [EnumMember(Value = "Update")]
        Update,

        /// <summary>
        /// Enum Export for "Export"
        /// </summary>
        [EnumMember(Value = "Export")]
        Export
    }
    /// <summary>
    /// Status of the Architect Export Job
    /// </summary>
    /// <value>Status of the Architect Export Job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The command executed by the Architect Job
    /// </summary>
    /// <value>The command executed by the Architect Job</value>
    [JsonPropertyName("command")]
    public CommandEnum? Command { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectExportJobStateResponse" /> class.
    /// </summary>
    /// <param name="Status">Status of the Architect Export Job.</param>
    /// <param name="Command">The command executed by the Architect Job.</param>
    /// <param name="DownloadUrl">The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows..</param>
    /// <param name="Messages">Warnings and Errors messages of the Architect Job.</param>
    public ArchitectExportJobStateResponse(StatusEnum? Status = null, CommandEnum? Command = null, string DownloadUrl = null, List<ArchitectJobMessage> Messages = null)
    {
        this.Status = Status;
        this.Command = Command;
        this.DownloadUrl = DownloadUrl;
        this.Messages = Messages;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }







    /// <summary>
    /// The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows.
    /// </summary>
    /// <value>The signed URL for downloading exported Architect data. If more than one flow was exported as part of the job, the URL provides a zipped folder containing all flows.</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



    /// <summary>
    /// Warnings and Errors messages of the Architect Job
    /// </summary>
    /// <value>Warnings and Errors messages of the Architect Job</value>
    [JsonPropertyName("messages")]
    public List<ArchitectJobMessage> Messages { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectExportJobStateResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
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
        return Equals(obj as ArchitectExportJobStateResponse);
    }

    /// <summary>
    /// Returns true if ArchitectExportJobStateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectExportJobStateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectExportJobStateResponse other)
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
                Command == other.Command ||
                Command != null &&
                Command.Equals(other.Command)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Command != null)
            {
                hash = hash * 59 + Command.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
