using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about an idle event trigger
/// </summary>

public partial class IdleEventTrigger : IEquatable<IdleEventTrigger>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IdleEventTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IdleEventTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IdleEventTrigger" /> class.
    /// </summary>
    /// <param name="EventName">Name of event triggered after period of inactivity. (required).</param>
    /// <param name="IdleAfterSeconds">Number of seconds of inactivity before an event is triggered..</param>
    public IdleEventTrigger(string EventName = null, long? IdleAfterSeconds = null)
    {
        this.EventName = EventName;
        this.IdleAfterSeconds = IdleAfterSeconds;

    }



    /// <summary>
    /// Name of event triggered after period of inactivity.
    /// </summary>
    /// <value>Name of event triggered after period of inactivity.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// Number of seconds of inactivity before an event is triggered.
    /// </summary>
    /// <value>Number of seconds of inactivity before an event is triggered.</value>
    [JsonPropertyName("idleAfterSeconds")]
    public long? IdleAfterSeconds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IdleEventTrigger {\n");

        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  IdleAfterSeconds: ").Append(IdleAfterSeconds).Append("\n");
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
        return Equals(obj as IdleEventTrigger);
    }

    /// <summary>
    /// Returns true if IdleEventTrigger instances are equal
    /// </summary>
    /// <param name="other">Instance of IdleEventTrigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IdleEventTrigger other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
            ) &&
            (
                IdleAfterSeconds == other.IdleAfterSeconds ||
                IdleAfterSeconds != null &&
                IdleAfterSeconds.Equals(other.IdleAfterSeconds)
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
            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            if (IdleAfterSeconds != null)
            {
                hash = hash * 59 + IdleAfterSeconds.GetHashCode();
            }

            return hash;
        }
    }
}
