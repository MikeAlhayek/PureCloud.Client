using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationSessionLastEvent
/// </summary>

public partial class JourneySessionEventsNotificationSessionLastEvent : IEquatable<JourneySessionEventsNotificationSessionLastEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationSessionLastEvent" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="EventName">EventName.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    public JourneySessionEventsNotificationSessionLastEvent(string Id = null, string EventName = null, DateTime? CreatedDate = null)
    {
        this.Id = Id;
        this.EventName = EventName;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationSessionLastEvent {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as JourneySessionEventsNotificationSessionLastEvent);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationSessionLastEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationSessionLastEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationSessionLastEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
