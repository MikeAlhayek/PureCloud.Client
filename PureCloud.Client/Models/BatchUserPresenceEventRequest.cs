using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A maximum of 100 events are allowed per request
/// </summary>
[DataContract]
public partial class BatchUserPresenceEventRequest : IEquatable<BatchUserPresenceEventRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchUserPresenceEventRequest" /> class.
    /// </summary>
    /// <param name="UserPresenceEvents">UserPresence events for this batch.</param>
    public BatchUserPresenceEventRequest(List<UserPresenceEvent> UserPresenceEvents = null)
    {
        this.UserPresenceEvents = UserPresenceEvents;

    }



    /// <summary>
    /// UserPresence events for this batch
    /// </summary>
    /// <value>UserPresence events for this batch</value>
    [DataMember(Name = "userPresenceEvents", EmitDefaultValue = false)]
    public List<UserPresenceEvent> UserPresenceEvents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchUserPresenceEventRequest {\n");

        sb.Append("  UserPresenceEvents: ").Append(UserPresenceEvents).Append("\n");
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
        return Equals(obj as BatchUserPresenceEventRequest);
    }

    /// <summary>
    /// Returns true if BatchUserPresenceEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchUserPresenceEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchUserPresenceEventRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserPresenceEvents == other.UserPresenceEvents ||
                UserPresenceEvents != null &&
                UserPresenceEvents.SequenceEqual(other.UserPresenceEvents)
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
            if (UserPresenceEvents != null)
            {
                hash = hash * 59 + UserPresenceEvents.GetHashCode();
            }

            return hash;
        }
    }
}
