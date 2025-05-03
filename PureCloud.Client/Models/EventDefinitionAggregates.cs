using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EventDefinitionAggregates
/// </summary>

public partial class EventDefinitionAggregates : IEquatable<EventDefinitionAggregates>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EventDefinitionAggregates" /> class.
    /// </summary>
    /// <param name="EventDefinition">Event definition..</param>
    /// <param name="EventCount">How many events have occurred..</param>
    public EventDefinitionAggregates(AddressableEntityRef EventDefinition = null, int? EventCount = null)
    {
        this.EventDefinition = EventDefinition;
        this.EventCount = EventCount;

    }



    /// <summary>
    /// Event definition.
    /// </summary>
    /// <value>Event definition.</value>
    [JsonPropertyName("eventDefinition")]
    public AddressableEntityRef EventDefinition { get; set; }



    /// <summary>
    /// How many events have occurred.
    /// </summary>
    /// <value>How many events have occurred.</value>
    [JsonPropertyName("eventCount")]
    public int? EventCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventDefinitionAggregates {\n");

        sb.Append("  EventDefinition: ").Append(EventDefinition).Append("\n");
        sb.Append("  EventCount: ").Append(EventCount).Append("\n");
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
        return Equals(obj as EventDefinitionAggregates);
    }

    /// <summary>
    /// Returns true if EventDefinitionAggregates instances are equal
    /// </summary>
    /// <param name="other">Instance of EventDefinitionAggregates to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventDefinitionAggregates other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventDefinition == other.EventDefinition ||
                EventDefinition != null &&
                EventDefinition.Equals(other.EventDefinition)
            ) &&
            (
                EventCount == other.EventCount ||
                EventCount != null &&
                EventCount.Equals(other.EventCount)
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
            if (EventDefinition != null)
            {
                hash = hash * 59 + EventDefinition.GetHashCode();
            }

            if (EventCount != null)
            {
                hash = hash * 59 + EventCount.GetHashCode();
            }

            return hash;
        }
    }
}
