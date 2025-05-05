using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserState
/// </summary>

public partial class UserState : IEquatable<UserState>
{
    /// <summary>
    /// User's current state.
    /// </summary>
    /// <value>User's current state.</value>
    
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
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Reason for a change in the user's state.
    /// </summary>
    /// <value>Reason for a change in the user's state.</value>
    
    public enum StateChangeReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voluntary for "Voluntary"
        /// </summary>
        [EnumMember(Value = "Voluntary")]
        Voluntary,

        /// <summary>
        /// Enum Seasonal for "Seasonal"
        /// </summary>
        [EnumMember(Value = "Seasonal")]
        Seasonal,

        /// <summary>
        /// Enum Leave for "Leave"
        /// </summary>
        [EnumMember(Value = "Leave")]
        Leave,

        /// <summary>
        /// Enum Performance for "Performance"
        /// </summary>
        [EnumMember(Value = "Performance")]
        Performance,

        /// <summary>
        /// Enum Conduct for "Conduct"
        /// </summary>
        [EnumMember(Value = "Conduct")]
        Conduct,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// User's current state.
    /// </summary>
    /// <value>User's current state.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Reason for a change in the user's state.
    /// </summary>
    /// <value>Reason for a change in the user's state.</value>
    [JsonPropertyName("stateChangeReason")]
    public StateChangeReasonEnum? StateChangeReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserState" /> class.
    /// </summary>
    /// <param name="State">User&#39;s current state..</param>
    /// <param name="Version">Version of this user..</param>
    /// <param name="StateChangeReason">Reason for a change in the user&#39;s state..</param>
    public UserState(StateEnum? State = null, int? Version = null, StateChangeReasonEnum? StateChangeReason = null)
    {
        this.State = State;
        this.Version = Version;
        this.StateChangeReason = StateChangeReason;

    }





    /// <summary>
    /// Version of this user.
    /// </summary>
    /// <value>Version of this user.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }





    /// <summary>
    /// Date that the state was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date that the state was last changed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("stateChangeDate")]
    public DateTime? StateChangeDate { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserState {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  StateChangeReason: ").Append(StateChangeReason).Append("\n");
        sb.Append("  StateChangeDate: ").Append(StateChangeDate).Append("\n");
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
        return Equals(obj as UserState);
    }

    /// <summary>
    /// Returns true if UserState instances are equal
    /// </summary>
    /// <param name="other">Instance of UserState to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserState other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                StateChangeReason == other.StateChangeReason ||
                StateChangeReason != null &&
                StateChangeReason.Equals(other.StateChangeReason)
            ) &&
            (
                StateChangeDate == other.StateChangeDate ||
                StateChangeDate != null &&
                StateChangeDate.Equals(other.StateChangeDate)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (StateChangeReason != null)
            {
                hash = hash * 59 + StateChangeReason.GetHashCode();
            }

            if (StateChangeDate != null)
            {
                hash = hash * 59 + StateChangeDate.GetHashCode();
            }

            return hash;
        }
    }
}
