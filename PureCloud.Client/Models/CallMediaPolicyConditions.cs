using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallMediaPolicyConditions
/// </summary>
[DataContract]
public partial class CallMediaPolicyConditions : IEquatable<CallMediaPolicyConditions>
{
    /// <summary>
    /// Gets or Sets Directions
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DirectionsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "INBOUND"
        /// </summary>
        [EnumMember(Value = "INBOUND")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "OUTBOUND"
        /// </summary>
        [EnumMember(Value = "OUTBOUND")]
        Outbound
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallMediaPolicyConditions" /> class.
    /// </summary>
    /// <param name="ForUsers">ForUsers.</param>
    /// <param name="DateRanges">DateRanges.</param>
    /// <param name="ForQueues">ForQueues.</param>
    /// <param name="WrapupCodes">WrapupCodes.</param>
    /// <param name="Languages">Languages.</param>
    /// <param name="TimeAllowed">TimeAllowed.</param>
    /// <param name="Teams">Teams to match conversations against.</param>
    /// <param name="Directions">Directions.</param>
    /// <param name="Duration">Duration.</param>
    public CallMediaPolicyConditions(List<User> ForUsers = null, List<string> DateRanges = null, List<Queue> ForQueues = null, List<WrapupCode> WrapupCodes = null, List<Language> Languages = null, TimeAllowed TimeAllowed = null, List<Team> Teams = null, List<DirectionsEnum> Directions = null, DurationCondition Duration = null)
    {
        this.ForUsers = ForUsers;
        this.DateRanges = DateRanges;
        this.ForQueues = ForQueues;
        this.WrapupCodes = WrapupCodes;
        this.Languages = Languages;
        this.TimeAllowed = TimeAllowed;
        this.Teams = Teams;
        this.Directions = Directions;
        this.Duration = Duration;

    }



    /// <summary>
    /// Gets or Sets ForUsers
    /// </summary>
    [DataMember(Name = "forUsers", EmitDefaultValue = false)]
    public List<User> ForUsers { get; set; }



    /// <summary>
    /// Gets or Sets DateRanges
    /// </summary>
    [DataMember(Name = "dateRanges", EmitDefaultValue = false)]
    public List<string> DateRanges { get; set; }



    /// <summary>
    /// Gets or Sets ForQueues
    /// </summary>
    [DataMember(Name = "forQueues", EmitDefaultValue = false)]
    public List<Queue> ForQueues { get; set; }



    /// <summary>
    /// Gets or Sets WrapupCodes
    /// </summary>
    [DataMember(Name = "wrapupCodes", EmitDefaultValue = false)]
    public List<WrapupCode> WrapupCodes { get; set; }



    /// <summary>
    /// Gets or Sets Languages
    /// </summary>
    [DataMember(Name = "languages", EmitDefaultValue = false)]
    public List<Language> Languages { get; set; }



    /// <summary>
    /// Gets or Sets TimeAllowed
    /// </summary>
    [DataMember(Name = "timeAllowed", EmitDefaultValue = false)]
    public TimeAllowed TimeAllowed { get; set; }



    /// <summary>
    /// Teams to match conversations against
    /// </summary>
    /// <value>Teams to match conversations against</value>
    [DataMember(Name = "teams", EmitDefaultValue = false)]
    public List<Team> Teams { get; set; }



    /// <summary>
    /// Gets or Sets Directions
    /// </summary>
    [DataMember(Name = "directions", EmitDefaultValue = false)]
    public List<DirectionsEnum> Directions { get; set; }



    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name = "duration", EmitDefaultValue = false)]
    public DurationCondition Duration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallMediaPolicyConditions {\n");

        sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
        sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
        sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
        sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
        sb.Append("  Teams: ").Append(Teams).Append("\n");
        sb.Append("  Directions: ").Append(Directions).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
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
        return Equals(obj as CallMediaPolicyConditions);
    }

    /// <summary>
    /// Returns true if CallMediaPolicyConditions instances are equal
    /// </summary>
    /// <param name="other">Instance of CallMediaPolicyConditions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallMediaPolicyConditions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ForUsers == other.ForUsers ||
                ForUsers != null &&
                ForUsers.SequenceEqual(other.ForUsers)
            ) &&
            (
                DateRanges == other.DateRanges ||
                DateRanges != null &&
                DateRanges.SequenceEqual(other.DateRanges)
            ) &&
            (
                ForQueues == other.ForQueues ||
                ForQueues != null &&
                ForQueues.SequenceEqual(other.ForQueues)
            ) &&
            (
                WrapupCodes == other.WrapupCodes ||
                WrapupCodes != null &&
                WrapupCodes.SequenceEqual(other.WrapupCodes)
            ) &&
            (
                Languages == other.Languages ||
                Languages != null &&
                Languages.SequenceEqual(other.Languages)
            ) &&
            (
                TimeAllowed == other.TimeAllowed ||
                TimeAllowed != null &&
                TimeAllowed.Equals(other.TimeAllowed)
            ) &&
            (
                Teams == other.Teams ||
                Teams != null &&
                Teams.SequenceEqual(other.Teams)
            ) &&
            (
                Directions == other.Directions ||
                Directions != null &&
                Directions.SequenceEqual(other.Directions)
            ) &&
            (
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
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
            if (ForUsers != null)
            {
                hash = hash * 59 + ForUsers.GetHashCode();
            }

            if (DateRanges != null)
            {
                hash = hash * 59 + DateRanges.GetHashCode();
            }

            if (ForQueues != null)
            {
                hash = hash * 59 + ForQueues.GetHashCode();
            }

            if (WrapupCodes != null)
            {
                hash = hash * 59 + WrapupCodes.GetHashCode();
            }

            if (Languages != null)
            {
                hash = hash * 59 + Languages.GetHashCode();
            }

            if (TimeAllowed != null)
            {
                hash = hash * 59 + TimeAllowed.GetHashCode();
            }

            if (Teams != null)
            {
                hash = hash * 59 + Teams.GetHashCode();
            }

            if (Directions != null)
            {
                hash = hash * 59 + Directions.GetHashCode();
            }

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            return hash;
        }
    }
}
