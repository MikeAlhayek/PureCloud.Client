using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlertSummaryEntity
/// </summary>

public partial class AlertSummaryEntity : IEquatable<AlertSummaryEntity>
{
    /// <summary>
    /// Specifies the type of entity being evaluated
    /// </summary>
    /// <value>Specifies the type of entity being evaluated</value>
    
    public enum EntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum Queue for "Queue"
        /// </summary>
        [EnumMember(Value = "Queue")]
        Queue,

        /// <summary>
        /// Enum Team for "Team"
        /// </summary>
        [EnumMember(Value = "Team")]
        Team,

        /// <summary>
        /// Enum Teammembers for "TeamMembers"
        /// </summary>
        [EnumMember(Value = "TeamMembers")]
        Teammembers
    }
    /// <summary>
    /// Specifies the type of entity being evaluated
    /// </summary>
    /// <value>Specifies the type of entity being evaluated</value>
    [JsonPropertyName("entityType")]
    public EntityTypeEnum? EntityType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlertSummaryEntity" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlertSummaryEntity() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlertSummaryEntity" /> class.
    /// </summary>
    /// <param name="EntityType">Specifies the type of entity being evaluated (required).</param>
    /// <param name="User">User id of the entity being monitored.</param>
    /// <param name="Group">Group id of the entity being monitored.</param>
    /// <param name="Queue">Queue id of the entity being monitored.</param>
    /// <param name="Team">Team id of the entity being monitored.</param>
    /// <param name="Alerting">Flag that indicated if the entity is current causing the alert to be triggered (required).</param>
    public AlertSummaryEntity(EntityTypeEnum? EntityType = null, AddressableEntityRef User = null, AddressableEntityRef Group = null, AddressableEntityRef Queue = null, AddressableEntityRef Team = null, bool? Alerting = null)
    {
        this.EntityType = EntityType;
        this.User = User;
        this.Group = Group;
        this.Queue = Queue;
        this.Team = Team;
        this.Alerting = Alerting;

    }





    /// <summary>
    /// User id of the entity being monitored
    /// </summary>
    /// <value>User id of the entity being monitored</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }



    /// <summary>
    /// Group id of the entity being monitored
    /// </summary>
    /// <value>Group id of the entity being monitored</value>
    [JsonPropertyName("group")]
    public AddressableEntityRef Group { get; set; }



    /// <summary>
    /// Queue id of the entity being monitored
    /// </summary>
    /// <value>Queue id of the entity being monitored</value>
    [JsonPropertyName("queue")]
    public AddressableEntityRef Queue { get; set; }



    /// <summary>
    /// Team id of the entity being monitored
    /// </summary>
    /// <value>Team id of the entity being monitored</value>
    [JsonPropertyName("team")]
    public AddressableEntityRef Team { get; set; }



    /// <summary>
    /// Flag that indicated if the entity is current causing the alert to be triggered
    /// </summary>
    /// <value>Flag that indicated if the entity is current causing the alert to be triggered</value>
    [JsonPropertyName("alerting")]
    public bool? Alerting { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlertSummaryEntity {\n");

        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  Alerting: ").Append(Alerting).Append("\n");
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
        return Equals(obj as AlertSummaryEntity);
    }

    /// <summary>
    /// Returns true if AlertSummaryEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of AlertSummaryEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlertSummaryEntity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                Alerting == other.Alerting ||
                Alerting != null &&
                Alerting.Equals(other.Alerting)
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
            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (Alerting != null)
            {
                hash = hash * 59 + Alerting.GetHashCode();
            }

            return hash;
        }
    }
}
