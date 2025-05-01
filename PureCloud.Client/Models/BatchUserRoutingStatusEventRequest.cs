using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// A maximum of 100 events are allowed per request
/// </summary>
[DataContract]
public partial class BatchUserRoutingStatusEventRequest : IEquatable<BatchUserRoutingStatusEventRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchUserRoutingStatusEventRequest" /> class.
    /// </summary>
    /// <param name="UserRoutingStatusEvents">UserRoutingStatus events for this batch.</param>
    public BatchUserRoutingStatusEventRequest(List<UserRoutingStatusEvent> UserRoutingStatusEvents = null)
    {
        this.UserRoutingStatusEvents = UserRoutingStatusEvents;

    }



    /// <summary>
    /// UserRoutingStatus events for this batch
    /// </summary>
    /// <value>UserRoutingStatus events for this batch</value>
    [DataMember(Name = "userRoutingStatusEvents", EmitDefaultValue = false)]
    public List<UserRoutingStatusEvent> UserRoutingStatusEvents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BatchUserRoutingStatusEventRequest {\n");

        sb.Append("  UserRoutingStatusEvents: ").Append(UserRoutingStatusEvents).Append("\n");
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
        return Equals(obj as BatchUserRoutingStatusEventRequest);
    }

    /// <summary>
    /// Returns true if BatchUserRoutingStatusEventRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BatchUserRoutingStatusEventRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BatchUserRoutingStatusEventRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UserRoutingStatusEvents == other.UserRoutingStatusEvents ||
                UserRoutingStatusEvents != null &&
                UserRoutingStatusEvents.SequenceEqual(other.UserRoutingStatusEvents)
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
            if (UserRoutingStatusEvents != null)
            {
                hash = hash * 59 + UserRoutingStatusEvents.GetHashCode();
            }

            return hash;
        }
    }
}
