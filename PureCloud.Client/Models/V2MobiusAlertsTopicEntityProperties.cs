using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2MobiusAlertsTopicEntityProperties
/// </summary>
[DataContract]
public partial class V2MobiusAlertsTopicEntityProperties : IEquatable<V2MobiusAlertsTopicEntityProperties>
{
    /// <summary>
    /// Gets or Sets EntityType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Organization for "Organization"
        /// </summary>
        [EnumMember(Value = "Organization")]
        Organization,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Queue for "Queue"
        /// </summary>
        [EnumMember(Value = "Queue")]
        Queue,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum Edge for "Edge"
        /// </summary>
        [EnumMember(Value = "Edge")]
        Edge,

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
    /// Gets or Sets EntityType
    /// </summary>
    [DataMember(Name = "entityType", EmitDefaultValue = false)]
    public EntityTypeEnum? EntityType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2MobiusAlertsTopicEntityProperties" /> class.
    /// </summary>
    /// <param name="EntityType">EntityType.</param>
    /// <param name="User">User.</param>
    /// <param name="Group">Group.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="Team">Team.</param>
    public V2MobiusAlertsTopicEntityProperties(EntityTypeEnum? EntityType = null, V2MobiusAlertsTopicAlertingAddressableEntityRef User = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Group = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Queue = null, V2MobiusAlertsTopicAlertingAddressableEntityRef Team = null)
    {
        this.EntityType = EntityType;
        this.User = User;
        this.Group = Group;
        this.Queue = Queue;
        this.Team = Team;

    }





    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertingAddressableEntityRef User { get; set; }



    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [DataMember(Name = "group", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Group { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Queue { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [DataMember(Name = "team", EmitDefaultValue = false)]
    public V2MobiusAlertsTopicAlertingAddressableEntityRef Team { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2MobiusAlertsTopicEntityProperties {\n");

        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
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
        return Equals(obj as V2MobiusAlertsTopicEntityProperties);
    }

    /// <summary>
    /// Returns true if V2MobiusAlertsTopicEntityProperties instances are equal
    /// </summary>
    /// <param name="other">Instance of V2MobiusAlertsTopicEntityProperties to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2MobiusAlertsTopicEntityProperties other)
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

            return hash;
        }
    }
}
