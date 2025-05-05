using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordersState
/// </summary>

public partial class RecordersState : IEquatable<RecordersState>
{
    /// <summary>
    /// Indicates the state of the adhoc recorder.
    /// </summary>
    /// <value>Indicates the state of the adhoc recorder.</value>
    
    public enum AdhocStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Paused for "PAUSED"
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        Paused,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None
    }
    /// <summary>
    /// Indicates the state of the customer experience recorder.
    /// </summary>
    /// <value>Indicates the state of the customer experience recorder.</value>
    
    public enum CustomerExperienceStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Paused for "PAUSED"
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        Paused,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None
    }
    /// <summary>
    /// Indicates the state of the agent experience recorder.
    /// </summary>
    /// <value>Indicates the state of the agent experience recorder.</value>
    
    public enum AgentExperienceStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "ACTIVE"
        /// </summary>
        [EnumMember(Value = "ACTIVE")]
        Active,

        /// <summary>
        /// Enum Paused for "PAUSED"
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        Paused,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None
    }
    /// <summary>
    /// Indicates the state of the adhoc recorder.
    /// </summary>
    /// <value>Indicates the state of the adhoc recorder.</value>
    [JsonPropertyName("adhocState")]
    public AdhocStateEnum? AdhocState { get; set; }
    /// <summary>
    /// Indicates the state of the customer experience recorder.
    /// </summary>
    /// <value>Indicates the state of the customer experience recorder.</value>
    [JsonPropertyName("customerExperienceState")]
    public CustomerExperienceStateEnum? CustomerExperienceState { get; set; }
    /// <summary>
    /// Indicates the state of the agent experience recorder.
    /// </summary>
    /// <value>Indicates the state of the agent experience recorder.</value>
    [JsonPropertyName("agentExperienceState")]
    public AgentExperienceStateEnum? AgentExperienceState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordersState" /> class.
    /// </summary>
    /// <param name="AdhocState">Indicates the state of the adhoc recorder..</param>
    /// <param name="CustomerExperienceState">Indicates the state of the customer experience recorder..</param>
    /// <param name="AgentExperienceState">Indicates the state of the agent experience recorder..</param>
    public RecordersState(AdhocStateEnum? AdhocState = null, CustomerExperienceStateEnum? CustomerExperienceState = null, AgentExperienceStateEnum? AgentExperienceState = null)
    {
        this.AdhocState = AdhocState;
        this.CustomerExperienceState = CustomerExperienceState;
        this.AgentExperienceState = AgentExperienceState;

    }








    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordersState {\n");

        sb.Append("  AdhocState: ").Append(AdhocState).Append("\n");
        sb.Append("  CustomerExperienceState: ").Append(CustomerExperienceState).Append("\n");
        sb.Append("  AgentExperienceState: ").Append(AgentExperienceState).Append("\n");
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
        return Equals(obj as RecordersState);
    }

    /// <summary>
    /// Returns true if RecordersState instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordersState to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordersState other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AdhocState == other.AdhocState ||
                AdhocState != null &&
                AdhocState.Equals(other.AdhocState)
            ) &&
            (
                CustomerExperienceState == other.CustomerExperienceState ||
                CustomerExperienceState != null &&
                CustomerExperienceState.Equals(other.CustomerExperienceState)
            ) &&
            (
                AgentExperienceState == other.AgentExperienceState ||
                AgentExperienceState != null &&
                AgentExperienceState.Equals(other.AgentExperienceState)
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
            if (AdhocState != null)
            {
                hash = hash * 59 + AdhocState.GetHashCode();
            }

            if (CustomerExperienceState != null)
            {
                hash = hash * 59 + CustomerExperienceState.GetHashCode();
            }

            if (AgentExperienceState != null)
            {
                hash = hash * 59 + AgentExperienceState.GetHashCode();
            }

            return hash;
        }
    }
}
