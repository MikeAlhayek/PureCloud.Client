using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatMediaPolicyConditions
/// </summary>

public partial class ChatMediaPolicyConditions : IEquatable<ChatMediaPolicyConditions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatMediaPolicyConditions" /> class.
    /// </summary>
    /// <param name="ForUsers">ForUsers.</param>
    /// <param name="DateRanges">DateRanges.</param>
    /// <param name="ForQueues">ForQueues.</param>
    /// <param name="WrapupCodes">WrapupCodes.</param>
    /// <param name="Languages">Languages.</param>
    /// <param name="TimeAllowed">TimeAllowed.</param>
    /// <param name="Teams">Teams to match conversations against.</param>
    /// <param name="Duration">Duration.</param>
    public ChatMediaPolicyConditions(List<User> ForUsers = null, List<string> DateRanges = null, List<Queue> ForQueues = null, List<WrapupCode> WrapupCodes = null, List<Language> Languages = null, TimeAllowed TimeAllowed = null, List<Team> Teams = null, DurationCondition Duration = null)
    {
        this.ForUsers = ForUsers;
        this.DateRanges = DateRanges;
        this.ForQueues = ForQueues;
        this.WrapupCodes = WrapupCodes;
        this.Languages = Languages;
        this.TimeAllowed = TimeAllowed;
        this.Teams = Teams;
        this.Duration = Duration;

    }



    /// <summary>
    /// Gets or Sets ForUsers
    /// </summary>
    [JsonPropertyName("forUsers")]
    public List<User> ForUsers { get; set; }



    /// <summary>
    /// Gets or Sets DateRanges
    /// </summary>
    [JsonPropertyName("dateRanges")]
    public List<string> DateRanges { get; set; }



    /// <summary>
    /// Gets or Sets ForQueues
    /// </summary>
    [JsonPropertyName("forQueues")]
    public List<Queue> ForQueues { get; set; }



    /// <summary>
    /// Gets or Sets WrapupCodes
    /// </summary>
    [JsonPropertyName("wrapupCodes")]
    public List<WrapupCode> WrapupCodes { get; set; }



    /// <summary>
    /// Gets or Sets Languages
    /// </summary>
    [JsonPropertyName("languages")]
    public List<Language> Languages { get; set; }



    /// <summary>
    /// Gets or Sets TimeAllowed
    /// </summary>
    [JsonPropertyName("timeAllowed")]
    public TimeAllowed TimeAllowed { get; set; }



    /// <summary>
    /// Teams to match conversations against
    /// </summary>
    /// <value>Teams to match conversations against</value>
    [JsonPropertyName("teams")]
    public List<Team> Teams { get; set; }



    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    [JsonPropertyName("duration")]
    public DurationCondition Duration { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ChatMediaPolicyConditions {\n");

        sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
        sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
        sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
        sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
        sb.Append("  Languages: ").Append(Languages).Append("\n");
        sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
        sb.Append("  Teams: ").Append(Teams).Append("\n");
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
        return Equals(obj as ChatMediaPolicyConditions);
    }

    /// <summary>
    /// Returns true if ChatMediaPolicyConditions instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatMediaPolicyConditions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatMediaPolicyConditions other)
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

            if (Duration != null)
            {
                hash = hash * 59 + Duration.GetHashCode();
            }

            return hash;
        }
    }
}
