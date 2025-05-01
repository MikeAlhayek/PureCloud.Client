using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PolicyConditions
/// </summary>
[DataContract]
public partial class PolicyConditions : IEquatable<PolicyConditions>
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
    /// Gets or Sets MediaTypes
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat
    }
    /// <summary>
    /// This condition is to filter out conversation with and without customer participation.
    /// </summary>
    /// <value>This condition is to filter out conversation with and without customer participation.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CustomerParticipationEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Yes for "YES"
        /// </summary>
        [EnumMember(Value = "YES")]
        Yes,

        /// <summary>
        /// Enum No for "NO"
        /// </summary>
        [EnumMember(Value = "NO")]
        No
    }
    /// <summary>
    /// This condition is to filter out conversation with and without customer participation.
    /// </summary>
    /// <value>This condition is to filter out conversation with and without customer participation.</value>
    [DataMember(Name = "customerParticipation", EmitDefaultValue = false)]
    public CustomerParticipationEnum? CustomerParticipation { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyConditions" /> class.
    /// </summary>
    /// <param name="ForUsers">ForUsers.</param>
    /// <param name="Directions">Directions.</param>
    /// <param name="DateRanges">DateRanges.</param>
    /// <param name="MediaTypes">MediaTypes.</param>
    /// <param name="ForQueues">ForQueues.</param>
    /// <param name="Duration">Duration.</param>
    /// <param name="WrapupCodes">WrapupCodes.</param>
    /// <param name="TimeAllowed">TimeAllowed.</param>
    /// <param name="Teams">Teams to match conversations against.</param>
    /// <param name="CustomerParticipation">This condition is to filter out conversation with and without customer participation..</param>
    public PolicyConditions(List<User> ForUsers = null, List<DirectionsEnum> Directions = null, List<string> DateRanges = null, List<MediaTypesEnum> MediaTypes = null, List<Queue> ForQueues = null, DurationCondition Duration = null, List<WrapupCode> WrapupCodes = null, TimeAllowed TimeAllowed = null, List<Team> Teams = null, CustomerParticipationEnum? CustomerParticipation = null)
    {
        this.ForUsers = ForUsers;
        this.Directions = Directions;
        this.DateRanges = DateRanges;
        this.MediaTypes = MediaTypes;
        this.ForQueues = ForQueues;
        this.Duration = Duration;
        this.WrapupCodes = WrapupCodes;
        this.TimeAllowed = TimeAllowed;
        this.Teams = Teams;
        this.CustomerParticipation = CustomerParticipation;

    }



    /// <summary>
    /// Gets or Sets ForUsers
    /// </summary>
    [DataMember(Name = "forUsers", EmitDefaultValue = false)]
    public List<User> ForUsers { get; set; }



    /// <summary>
    /// Gets or Sets Directions
    /// </summary>
    [DataMember(Name = "directions", EmitDefaultValue = false)]
    public List<DirectionsEnum> Directions { get; set; }



    /// <summary>
    /// Gets or Sets DateRanges
    /// </summary>
    [DataMember(Name = "dateRanges", EmitDefaultValue = false)]
    public List<string> DateRanges { get; set; }



    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    [DataMember(Name = "mediaTypes", EmitDefaultValue = false)]
    public List<MediaTypesEnum> MediaTypes { get; set; }



    /// <summary>
    /// Gets or Sets ForQueues
    /// </summary>
    [DataMember(Name = "forQueues", EmitDefaultValue = false)]
    public List<Queue> ForQueues { get; set; }



    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [DataMember(Name = "duration", EmitDefaultValue = false)]
    public DurationCondition Duration { get; set; }



    /// <summary>
    /// Gets or Sets WrapupCodes
    /// </summary>
    [DataMember(Name = "wrapupCodes", EmitDefaultValue = false)]
    public List<WrapupCode> WrapupCodes { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PolicyConditions {\n");

        sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
        sb.Append("  Directions: ").Append(Directions).Append("\n");
        sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
        sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
        sb.Append("  Duration: ").Append(Duration).Append("\n");
        sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
        sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
        sb.Append("  Teams: ").Append(Teams).Append("\n");
        sb.Append("  CustomerParticipation: ").Append(CustomerParticipation).Append("\n");
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
        return Equals(obj as PolicyConditions);
    }

    /// <summary>
    /// Returns true if PolicyConditions instances are equal
    /// </summary>
    /// <param name="other">Instance of PolicyConditions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PolicyConditions other)
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
                Directions == other.Directions ||
                Directions != null &&
                Directions.SequenceEqual(other.Directions)
            ) &&
            (
                DateRanges == other.DateRanges ||
                DateRanges != null &&
                DateRanges.SequenceEqual(other.DateRanges)
            ) &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
            ) &&
            (
                ForQueues == other.ForQueues ||
                ForQueues != null &&
                ForQueues.SequenceEqual(other.ForQueues)
            ) &&
            (
                Duration == other.Duration ||
                Duration != null &&
                Duration.Equals(other.Duration)
            ) &&
            (
                WrapupCodes == other.WrapupCodes ||
                WrapupCodes != null &&
                WrapupCodes.SequenceEqual(other.WrapupCodes)
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
                CustomerParticipation == other.CustomerParticipation ||
                CustomerParticipation != null &&
                CustomerParticipation.Equals(other.CustomerParticipation)
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

            if (Directions != null)
            {
                hash = hash * 59 + Directions.GetHashCode();
            }

            if (DateRanges != null)
            {
                hash = hash * 59 + DateRanges.GetHashCode();
            }

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            if (ForQueues != null)
            {
                hash = hash * 59 + ForQueues.GetHashCode();
            }

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            if (WrapupCodes != null)
            {
                hash = hash * 59 + WrapupCodes.GetHashCode();
            }

            if (TimeAllowed != null)
            {
                hash = hash * 59 + TimeAllowed.GetHashCode();
            }

            if (Teams != null)
            {
                hash = hash * 59 + Teams.GetHashCode();
            }

            if (CustomerParticipation != null)
            {
                hash = hash * 59 + CustomerParticipation.GetHashCode();
            }

            return hash;
        }
    }
}
