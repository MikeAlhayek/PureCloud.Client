using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyWebEventsNotificationSegmentAssignmentMessage
/// </summary>
[DataContract]
public partial class JourneyWebEventsNotificationSegmentAssignmentMessage : IEquatable<JourneyWebEventsNotificationSegmentAssignmentMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationSegmentAssignmentMessage" /> class.
    /// </summary>
    /// <param name="Segment">Segment.</param>
    public JourneyWebEventsNotificationSegmentAssignmentMessage(JourneyWebEventsNotificationSegment Segment = null)
    {
        this.Segment = Segment;

    }



    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    [DataMember(Name = "segment", EmitDefaultValue = false)]
    public JourneyWebEventsNotificationSegment Segment { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationSegmentAssignmentMessage {\n");

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
        return Equals(obj as JourneyWebEventsNotificationSegmentAssignmentMessage);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationSegmentAssignmentMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationSegmentAssignmentMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationSegmentAssignmentMessage other)
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
