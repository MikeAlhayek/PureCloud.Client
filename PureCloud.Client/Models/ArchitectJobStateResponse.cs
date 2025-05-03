using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ArchitectJobStateResponse
/// </summary>

public partial class ArchitectJobStateResponse : IEquatable<ArchitectJobStateResponse>
{
    /// <summary>
    /// Status of the Architect Job
    /// </summary>
    /// <value>Status of the Architect Job</value>
    
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
    /// Status of the Architect Job
    /// </summary>
    /// <value>Status of the Architect Job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The command executed by the Architect Job
    /// </summary>
    /// <value>The command executed by the Architect Job</value>
    [JsonPropertyName("command")]
    public CommandEnum? Command { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ArchitectJobStateResponse" /> class.
    /// </summary>
    /// <param name="Flow">Flow created from the Architect Job.</param>
    /// <param name="Status">Status of the Architect Job.</param>
    /// <param name="Command">The command executed by the Architect Job.</param>
    /// <param name="Messages">Warnings and Errors messages of the Architect Job.</param>
    public ArchitectJobStateResponse(AddressableEntityRef Flow = null, StatusEnum? Status = null, CommandEnum? Command = null, List<ArchitectJobMessage> Messages = null)
    {
        this.Flow = Flow;
        this.Status = Status;
        this.Command = Command;
        this.Messages = Messages;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Flow created from the Architect Job
    /// </summary>
    /// <value>Flow created from the Architect Job</value>
    [JsonPropertyName("flow")]
    public AddressableEntityRef Flow { get; set; }







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
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ArchitectJobStateResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Command: ").Append(Command).Append("\n");
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
        return Equals(obj as ArchitectJobStateResponse);
    }

    /// <summary>
    /// Returns true if ArchitectJobStateResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ArchitectJobStateResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ArchitectJobStateResponse other)
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
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
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

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Command != null)
            {
                hash = hash * 59 + Command.GetHashCode();
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
