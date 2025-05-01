using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// EventError
/// </summary>
[DataContract]
public partial class EventError : IEquatable<EventError>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventError" /> class.
    /// </summary>
    /// <param name="EventId">The eventId (V4 UUID) for the event that encountered an error..</param>
    /// <param name="Message">A message describing the error..</param>
    /// <param name="Retryable">The event for this eventId can be resubmitted if this value is true..</param>
    public EventError(string EventId = null, string Message = null, bool? Retryable = null)
    {
        this.EventId = EventId;
        this.Message = Message;
        this.Retryable = Retryable;

    }



    /// <summary>
    /// The eventId (V4 UUID) for the event that encountered an error.
    /// </summary>
    /// <value>The eventId (V4 UUID) for the event that encountered an error.</value>
    [DataMember(Name = "eventId", EmitDefaultValue = false)]
    public string EventId { get; set; }



    /// <summary>
    /// A message describing the error.
    /// </summary>
    /// <value>A message describing the error.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// The event for this eventId can be resubmitted if this value is true.
    /// </summary>
    /// <value>The event for this eventId can be resubmitted if this value is true.</value>
    [DataMember(Name = "retryable", EmitDefaultValue = false)]
    public bool? Retryable { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventError {\n");

        sb.Append("  EventId: ").Append(EventId).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Retryable: ").Append(Retryable).Append("\n");
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
        return Equals(obj as EventError);
    }

    /// <summary>
    /// Returns true if EventError instances are equal
    /// </summary>
    /// <param name="other">Instance of EventError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventError other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventId == other.EventId ||
                EventId != null &&
                EventId.Equals(other.EventId)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Retryable == other.Retryable ||
                Retryable != null &&
                Retryable.Equals(other.Retryable)
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
            if (EventId != null)
            {
                hash = hash * 59 + EventId.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Retryable != null)
            {
                hash = hash * 59 + Retryable.GetHashCode();
            }

            return hash;
        }
    }
}
