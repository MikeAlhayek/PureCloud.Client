using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SegmentAssignmentEvent
/// </summary>

public partial class SegmentAssignmentEvent : IEquatable<SegmentAssignmentEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="SegmentAssignmentEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected SegmentAssignmentEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="SegmentAssignmentEvent" /> class.
    /// </summary>
    /// <param name="Segment">The segment which was assigned. (required).</param>
    public SegmentAssignmentEvent(AddressableEntityRef Segment = null)
    {
        this.Segment = Segment;

    }



    /// <summary>
    /// The segment which was assigned.
    /// </summary>
    /// <value>The segment which was assigned.</value>
    [JsonPropertyName("segment")]
    public AddressableEntityRef Segment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SegmentAssignmentEvent {\n");

        sb.Append("  Segment: ").Append(Segment).Append("\n");
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
        return Equals(obj as SegmentAssignmentEvent);
    }

    /// <summary>
    /// Returns true if SegmentAssignmentEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of SegmentAssignmentEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SegmentAssignmentEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Segment == other.Segment ||
                Segment != null &&
                Segment.Equals(other.Segment)
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
            if (Segment != null)
            {
                hash = hash * 59 + Segment.GetHashCode();
            }

            return hash;
        }
    }
}
