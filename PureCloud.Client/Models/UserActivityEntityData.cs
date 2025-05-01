using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UserActivityEntityData
/// </summary>
[DataContract]
public partial class UserActivityEntityData : IEquatable<UserActivityEntityData>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserActivityEntityData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserActivityEntityData() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserActivityEntityData" /> class.
    /// </summary>
    /// <param name="ActivityDate">The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="OrganizationPresenceId">Organization presence identifier.</param>
    /// <param name="PresenceDate">Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="QueueId">Queue identifier.</param>
    /// <param name="QueueMembershipStatus">Queue membership status (e.g. active or inactive).</param>
    /// <param name="RoutingStatus">Agent routing status.</param>
    /// <param name="RoutingStatusDate">Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SystemPresence">System presence.</param>
    /// <param name="TeamId">The team ID the user is a member of.</param>
    /// <param name="UserId">Unique identifier for the user.</param>
    public UserActivityEntityData(DateTime? ActivityDate = null, string OrganizationPresenceId = null, DateTime? PresenceDate = null, string QueueId = null, string QueueMembershipStatus = null, string RoutingStatus = null, DateTime? RoutingStatusDate = null, string SystemPresence = null, string TeamId = null, string UserId = null)
    {
        this.ActivityDate = ActivityDate;
        this.OrganizationPresenceId = OrganizationPresenceId;
        this.PresenceDate = PresenceDate;
        this.QueueId = QueueId;
        this.QueueMembershipStatus = QueueMembershipStatus;
        this.RoutingStatus = RoutingStatus;
        this.RoutingStatusDate = RoutingStatusDate;
        this.SystemPresence = SystemPresence;
        this.TeamId = TeamId;
        this.UserId = UserId;

    }



    /// <summary>
    /// The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time at which the activity was observed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "activityDate", EmitDefaultValue = false)]
    public DateTime? ActivityDate { get; set; }



    /// <summary>
    /// Organization presence identifier
    /// </summary>
    /// <value>Organization presence identifier</value>
    [DataMember(Name = "organizationPresenceId", EmitDefaultValue = false)]
    public string OrganizationPresenceId { get; set; }



    /// <summary>
    /// Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of the latest presence change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "presenceDate", EmitDefaultValue = false)]
    public DateTime? PresenceDate { get; set; }



    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// Queue membership status (e.g. active or inactive)
    /// </summary>
    /// <value>Queue membership status (e.g. active or inactive)</value>
    [DataMember(Name = "queueMembershipStatus", EmitDefaultValue = false)]
    public string QueueMembershipStatus { get; set; }



    /// <summary>
    /// Agent routing status
    /// </summary>
    /// <value>Agent routing status</value>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public string RoutingStatus { get; set; }



    /// <summary>
    /// Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date of the latest routing status change. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "routingStatusDate", EmitDefaultValue = false)]
    public DateTime? RoutingStatusDate { get; set; }



    /// <summary>
    /// System presence
    /// </summary>
    /// <value>System presence</value>
    [DataMember(Name = "systemPresence", EmitDefaultValue = false)]
    public string SystemPresence { get; set; }



    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }



    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserActivityEntityData {\n");

        sb.Append("  ActivityDate: ").Append(ActivityDate).Append("\n");
        sb.Append("  OrganizationPresenceId: ").Append(OrganizationPresenceId).Append("\n");
        sb.Append("  PresenceDate: ").Append(PresenceDate).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  QueueMembershipStatus: ").Append(QueueMembershipStatus).Append("\n");
        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
        sb.Append("  RoutingStatusDate: ").Append(RoutingStatusDate).Append("\n");
        sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
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
        return Equals(obj as UserActivityEntityData);
    }

    /// <summary>
    /// Returns true if UserActivityEntityData instances are equal
    /// </summary>
    /// <param name="other">Instance of UserActivityEntityData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserActivityEntityData other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ActivityDate == other.ActivityDate ||
                ActivityDate != null &&
                ActivityDate.Equals(other.ActivityDate)
            ) &&
            (
                OrganizationPresenceId == other.OrganizationPresenceId ||
                OrganizationPresenceId != null &&
                OrganizationPresenceId.Equals(other.OrganizationPresenceId)
            ) &&
            (
                PresenceDate == other.PresenceDate ||
                PresenceDate != null &&
                PresenceDate.Equals(other.PresenceDate)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                QueueMembershipStatus == other.QueueMembershipStatus ||
                QueueMembershipStatus != null &&
                QueueMembershipStatus.Equals(other.QueueMembershipStatus)
            ) &&
            (
                RoutingStatus == other.RoutingStatus ||
                RoutingStatus != null &&
                RoutingStatus.Equals(other.RoutingStatus)
            ) &&
            (
                RoutingStatusDate == other.RoutingStatusDate ||
                RoutingStatusDate != null &&
                RoutingStatusDate.Equals(other.RoutingStatusDate)
            ) &&
            (
                SystemPresence == other.SystemPresence ||
                SystemPresence != null &&
                SystemPresence.Equals(other.SystemPresence)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
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
            if (ActivityDate != null)
            {
                hash = hash * 59 + ActivityDate.GetHashCode();
            }

            if (OrganizationPresenceId != null)
            {
                hash = hash * 59 + OrganizationPresenceId.GetHashCode();
            }

            if (PresenceDate != null)
            {
                hash = hash * 59 + PresenceDate.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (QueueMembershipStatus != null)
            {
                hash = hash * 59 + QueueMembershipStatus.GetHashCode();
            }

            if (RoutingStatus != null)
            {
                hash = hash * 59 + RoutingStatus.GetHashCode();
            }

            if (RoutingStatusDate != null)
            {
                hash = hash * 59 + RoutingStatusDate.GetHashCode();
            }

            if (SystemPresence != null)
            {
                hash = hash * 59 + SystemPresence.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            return hash;
        }
    }
}
