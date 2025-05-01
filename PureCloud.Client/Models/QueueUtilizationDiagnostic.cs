using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueUtilizationDiagnostic
/// </summary>
[DataContract]
public partial class QueueUtilizationDiagnostic : IEquatable<QueueUtilizationDiagnostic>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueUtilizationDiagnostic" /> class.
    /// </summary>
    public QueueUtilizationDiagnostic()
    {

    }



    /// <summary>
    /// Identifier of the queue
    /// </summary>
    /// <value>Identifier of the queue</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public DomainEntityRef Queue { get; private set; }



    /// <summary>
    /// The number of users joined to the queue
    /// </summary>
    /// <value>The number of users joined to the queue</value>
    [DataMember(Name = "usersInQueue", EmitDefaultValue = false)]
    public int? UsersInQueue { get; private set; }



    /// <summary>
    /// The number of users active on the queue
    /// </summary>
    /// <value>The number of users active on the queue</value>
    [DataMember(Name = "activeUsersInQueue", EmitDefaultValue = false)]
    public int? ActiveUsersInQueue { get; private set; }



    /// <summary>
    /// The number of users with a status of on-queue
    /// </summary>
    /// <value>The number of users with a status of on-queue</value>
    [DataMember(Name = "usersOnQueue", EmitDefaultValue = false)]
    public int? UsersOnQueue { get; private set; }



    /// <summary>
    /// The number of users in the queue currently not engaged
    /// </summary>
    /// <value>The number of users in the queue currently not engaged</value>
    [DataMember(Name = "usersNotUtilized", EmitDefaultValue = false)]
    public int? UsersNotUtilized { get; private set; }



    /// <summary>
    /// The number of users in the queue with a station
    /// </summary>
    /// <value>The number of users in the queue with a station</value>
    [DataMember(Name = "usersOnQueueWithStation", EmitDefaultValue = false)]
    public int? UsersOnQueueWithStation { get; private set; }



    /// <summary>
    /// The number of users currently engaged in a campaign call
    /// </summary>
    /// <value>The number of users currently engaged in a campaign call</value>
    [DataMember(Name = "usersOnACampaignCall", EmitDefaultValue = false)]
    public int? UsersOnACampaignCall { get; private set; }



    /// <summary>
    /// The number of users whose station is homed to an edge different from the campaign
    /// </summary>
    /// <value>The number of users whose station is homed to an edge different from the campaign</value>
    [DataMember(Name = "usersOnDifferentEdgeGroup", EmitDefaultValue = false)]
    public int? UsersOnDifferentEdgeGroup { get; private set; }



    /// <summary>
    /// The number of users currently engaged in a communication that is not part of the campaign
    /// </summary>
    /// <value>The number of users currently engaged in a communication that is not part of the campaign</value>
    [DataMember(Name = "usersOnANonCampaignCall", EmitDefaultValue = false)]
    public int? UsersOnANonCampaignCall { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueUtilizationDiagnostic {\n");

        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  UsersInQueue: ").Append(UsersInQueue).Append("\n");
        sb.Append("  ActiveUsersInQueue: ").Append(ActiveUsersInQueue).Append("\n");
        sb.Append("  UsersOnQueue: ").Append(UsersOnQueue).Append("\n");
        sb.Append("  UsersNotUtilized: ").Append(UsersNotUtilized).Append("\n");
        sb.Append("  UsersOnQueueWithStation: ").Append(UsersOnQueueWithStation).Append("\n");
        sb.Append("  UsersOnACampaignCall: ").Append(UsersOnACampaignCall).Append("\n");
        sb.Append("  UsersOnDifferentEdgeGroup: ").Append(UsersOnDifferentEdgeGroup).Append("\n");
        sb.Append("  UsersOnANonCampaignCall: ").Append(UsersOnANonCampaignCall).Append("\n");
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
        return Equals(obj as QueueUtilizationDiagnostic);
    }

    /// <summary>
    /// Returns true if QueueUtilizationDiagnostic instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueUtilizationDiagnostic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueUtilizationDiagnostic other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                UsersInQueue == other.UsersInQueue ||
                UsersInQueue != null &&
                UsersInQueue.Equals(other.UsersInQueue)
            ) &&
            (
                ActiveUsersInQueue == other.ActiveUsersInQueue ||
                ActiveUsersInQueue != null &&
                ActiveUsersInQueue.Equals(other.ActiveUsersInQueue)
            ) &&
            (
                UsersOnQueue == other.UsersOnQueue ||
                UsersOnQueue != null &&
                UsersOnQueue.Equals(other.UsersOnQueue)
            ) &&
            (
                UsersNotUtilized == other.UsersNotUtilized ||
                UsersNotUtilized != null &&
                UsersNotUtilized.Equals(other.UsersNotUtilized)
            ) &&
            (
                UsersOnQueueWithStation == other.UsersOnQueueWithStation ||
                UsersOnQueueWithStation != null &&
                UsersOnQueueWithStation.Equals(other.UsersOnQueueWithStation)
            ) &&
            (
                UsersOnACampaignCall == other.UsersOnACampaignCall ||
                UsersOnACampaignCall != null &&
                UsersOnACampaignCall.Equals(other.UsersOnACampaignCall)
            ) &&
            (
                UsersOnDifferentEdgeGroup == other.UsersOnDifferentEdgeGroup ||
                UsersOnDifferentEdgeGroup != null &&
                UsersOnDifferentEdgeGroup.Equals(other.UsersOnDifferentEdgeGroup)
            ) &&
            (
                UsersOnANonCampaignCall == other.UsersOnANonCampaignCall ||
                UsersOnANonCampaignCall != null &&
                UsersOnANonCampaignCall.Equals(other.UsersOnANonCampaignCall)
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
            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (UsersInQueue != null)
            {
                hash = hash * 59 + UsersInQueue.GetHashCode();
            }

            if (ActiveUsersInQueue != null)
            {
                hash = hash * 59 + ActiveUsersInQueue.GetHashCode();
            }

            if (UsersOnQueue != null)
            {
                hash = hash * 59 + UsersOnQueue.GetHashCode();
            }

            if (UsersNotUtilized != null)
            {
                hash = hash * 59 + UsersNotUtilized.GetHashCode();
            }

            if (UsersOnQueueWithStation != null)
            {
                hash = hash * 59 + UsersOnQueueWithStation.GetHashCode();
            }

            if (UsersOnACampaignCall != null)
            {
                hash = hash * 59 + UsersOnACampaignCall.GetHashCode();
            }

            if (UsersOnDifferentEdgeGroup != null)
            {
                hash = hash * 59 + UsersOnDifferentEdgeGroup.GetHashCode();
            }

            if (UsersOnANonCampaignCall != null)
            {
                hash = hash * 59 + UsersOnANonCampaignCall.GetHashCode();
            }

            return hash;
        }
    }
}
