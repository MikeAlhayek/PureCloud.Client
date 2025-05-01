using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserExpands
/// </summary>
[DataContract]
public partial class UserExpands : IEquatable<UserExpands>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserExpands" /> class.
    /// </summary>
    public UserExpands()
    {

    }



    /// <summary>
    /// ACD routing status
    /// </summary>
    /// <value>ACD routing status</value>
    [DataMember(Name = "routingStatus", EmitDefaultValue = false)]
    public RoutingStatus RoutingStatus { get; private set; }



    /// <summary>
    /// Active presence
    /// </summary>
    /// <value>Active presence</value>
    [DataMember(Name = "presence", EmitDefaultValue = false)]
    public UserPresence Presence { get; private set; }



    /// <summary>
    /// Active 3rd party presence
    /// </summary>
    /// <value>Active 3rd party presence</value>
    [DataMember(Name = "integrationPresence", EmitDefaultValue = false)]
    public UserPresence IntegrationPresence { get; private set; }



    /// <summary>
    /// Summary of conversion statistics for conversation types.
    /// </summary>
    /// <value>Summary of conversion statistics for conversation types.</value>
    [DataMember(Name = "conversationSummary", EmitDefaultValue = false)]
    public UserConversationSummary ConversationSummary { get; private set; }



    /// <summary>
    /// Determine if out of office is enabled
    /// </summary>
    /// <value>Determine if out of office is enabled</value>
    [DataMember(Name = "outOfOffice", EmitDefaultValue = false)]
    public OutOfOffice OutOfOffice { get; private set; }



    /// <summary>
    /// Current geolocation position
    /// </summary>
    /// <value>Current geolocation position</value>
    [DataMember(Name = "geolocation", EmitDefaultValue = false)]
    public Geolocation Geolocation { get; private set; }



    /// <summary>
    /// Effective, default, and last station information
    /// </summary>
    /// <value>Effective, default, and last station information</value>
    [DataMember(Name = "station", EmitDefaultValue = false)]
    public UserStations Station { get; private set; }



    /// <summary>
    /// Roles and permissions assigned to the user
    /// </summary>
    /// <value>Roles and permissions assigned to the user</value>
    [DataMember(Name = "authorization", EmitDefaultValue = false)]
    public UserAuthorization Authorization { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserExpands {\n");

        sb.Append("  RoutingStatus: ").Append(RoutingStatus).Append("\n");
        sb.Append("  Presence: ").Append(Presence).Append("\n");
        sb.Append("  IntegrationPresence: ").Append(IntegrationPresence).Append("\n");
        sb.Append("  ConversationSummary: ").Append(ConversationSummary).Append("\n");
        sb.Append("  OutOfOffice: ").Append(OutOfOffice).Append("\n");
        sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
        sb.Append("  Station: ").Append(Station).Append("\n");
        sb.Append("  Authorization: ").Append(Authorization).Append("\n");
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
        return Equals(obj as UserExpands);
    }

    /// <summary>
    /// Returns true if UserExpands instances are equal
    /// </summary>
    /// <param name="other">Instance of UserExpands to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserExpands other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RoutingStatus == other.RoutingStatus ||
                RoutingStatus != null &&
                RoutingStatus.Equals(other.RoutingStatus)
            ) &&
            (
                Presence == other.Presence ||
                Presence != null &&
                Presence.Equals(other.Presence)
            ) &&
            (
                IntegrationPresence == other.IntegrationPresence ||
                IntegrationPresence != null &&
                IntegrationPresence.Equals(other.IntegrationPresence)
            ) &&
            (
                ConversationSummary == other.ConversationSummary ||
                ConversationSummary != null &&
                ConversationSummary.Equals(other.ConversationSummary)
            ) &&
            (
                OutOfOffice == other.OutOfOffice ||
                OutOfOffice != null &&
                OutOfOffice.Equals(other.OutOfOffice)
            ) &&
            (
                Geolocation == other.Geolocation ||
                Geolocation != null &&
                Geolocation.Equals(other.Geolocation)
            ) &&
            (
                Station == other.Station ||
                Station != null &&
                Station.Equals(other.Station)
            ) &&
            (
                Authorization == other.Authorization ||
                Authorization != null &&
                Authorization.Equals(other.Authorization)
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
            if (RoutingStatus != null)
            {
                hash = hash * 59 + RoutingStatus.GetHashCode();
            }

            if (Presence != null)
            {
                hash = hash * 59 + Presence.GetHashCode();
            }

            if (IntegrationPresence != null)
            {
                hash = hash * 59 + IntegrationPresence.GetHashCode();
            }

            if (ConversationSummary != null)
            {
                hash = hash * 59 + ConversationSummary.GetHashCode();
            }

            if (OutOfOffice != null)
            {
                hash = hash * 59 + OutOfOffice.GetHashCode();
            }

            if (Geolocation != null)
            {
                hash = hash * 59 + Geolocation.GetHashCode();
            }

            if (Station != null)
            {
                hash = hash * 59 + Station.GetHashCode();
            }

            if (Authorization != null)
            {
                hash = hash * 59 + Authorization.GetHashCode();
            }

            return hash;
        }
    }
}
