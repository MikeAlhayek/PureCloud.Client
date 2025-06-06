using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Details about a scroll percentage event trigger
/// </summary>

public partial class ScrollPercentageEventTrigger : IEquatable<ScrollPercentageEventTrigger>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScrollPercentageEventTrigger" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScrollPercentageEventTrigger() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScrollPercentageEventTrigger" /> class.
    /// </summary>
    /// <param name="Percentage">Percentage of a webpage at which an event is triggered. (required).</param>
    /// <param name="EventName">Name of event triggered after scrolling to the specified percentage. (required).</param>
    public ScrollPercentageEventTrigger(int? Percentage = null, string EventName = null)
    {
        this.Percentage = Percentage;
        this.EventName = EventName;

    }



    /// <summary>
    /// Percentage of a webpage at which an event is triggered.
    /// </summary>
    /// <value>Percentage of a webpage at which an event is triggered.</value>
    [JsonPropertyName("percentage")]
    public int? Percentage { get; set; }



    /// <summary>
    /// Name of event triggered after scrolling to the specified percentage.
    /// </summary>
    /// <value>Name of event triggered after scrolling to the specified percentage.</value>
    [JsonPropertyName("eventName")]
    public string EventName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScrollPercentageEventTrigger {\n");

        sb.Append("  Percentage: ").Append(Percentage).Append("\n");
        sb.Append("  EventName: ").Append(EventName).Append("\n");
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
        return Equals(obj as ScrollPercentageEventTrigger);
    }

    /// <summary>
    /// Returns true if ScrollPercentageEventTrigger instances are equal
    /// </summary>
    /// <param name="other">Instance of ScrollPercentageEventTrigger to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScrollPercentageEventTrigger other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Percentage == other.Percentage ||
                Percentage != null &&
                Percentage.Equals(other.Percentage)
            ) &&
            (
                EventName == other.EventName ||
                EventName != null &&
                EventName.Equals(other.EventName)
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
            if (Percentage != null)
            {
                hash = hash * 59 + Percentage.GetHashCode();
            }

            if (EventName != null)
            {
                hash = hash * 59 + EventName.GetHashCode();
            }

            return hash;
        }
    }
}
