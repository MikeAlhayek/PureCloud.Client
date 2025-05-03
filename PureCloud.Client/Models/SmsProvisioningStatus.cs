using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SmsProvisioningStatus
/// </summary>

public partial class SmsProvisioningStatus : IEquatable<SmsProvisioningStatus>
{
    /// <summary>
    /// Provisioning action
    /// </summary>
    /// <value>Provisioning action</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

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
        /// Enum Delete for "Delete"
        /// </summary>
        [EnumMember(Value = "Delete")]
        Delete
    }
    /// <summary>
    /// Provisioning state
    /// </summary>
    /// <value>Provisioning state</value>
    
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
        Failed
    }
    /// <summary>
    /// Provisioning action
    /// </summary>
    /// <value>Provisioning action</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Provisioning state
    /// </summary>
    /// <value>Provisioning state</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SmsProvisioningStatus" /> class.
    /// </summary>
    /// <param name="Action">Provisioning action.</param>
    /// <param name="State">Provisioning state.</param>
    /// <param name="Error">Any error associated with a Failed state.</param>
    /// <param name="Version">The phone number version associated with the provisioning action.</param>
    public SmsProvisioningStatus(ActionEnum? Action = null, StateEnum? State = null, ErrorBody Error = null, long? Version = null)
    {
        this.Action = Action;
        this.State = State;
        this.Error = Error;
        this.Version = Version;

    }







    /// <summary>
    /// Any error associated with a Failed state
    /// </summary>
    /// <value>Any error associated with a Failed state</value>
    [JsonPropertyName("error")]
    public ErrorBody Error { get; set; }



    /// <summary>
    /// The phone number version associated with the provisioning action
    /// </summary>
    /// <value>The phone number version associated with the provisioning action</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SmsProvisioningStatus {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as SmsProvisioningStatus);
    }

    /// <summary>
    /// Returns true if SmsProvisioningStatus instances are equal
    /// </summary>
    /// <param name="other">Instance of SmsProvisioningStatus to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SmsProvisioningStatus other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
