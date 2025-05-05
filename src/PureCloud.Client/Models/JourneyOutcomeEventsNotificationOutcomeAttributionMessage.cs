using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationOutcomeAttributionMessage
/// </summary>

public partial class JourneyOutcomeEventsNotificationOutcomeAttributionMessage : IEquatable<JourneyOutcomeEventsNotificationOutcomeAttributionMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationOutcomeAttributionMessage" /> class.
    /// </summary>
    /// <param name="Outcome">Outcome.</param>
    /// <param name="OutcomeTouchpoints">OutcomeTouchpoints.</param>
    /// <param name="SegmentAssignments">SegmentAssignments.</param>
    /// <param name="AssociatedValue">AssociatedValue.</param>
    public JourneyOutcomeEventsNotificationOutcomeAttributionMessage(JourneyOutcomeEventsNotificationOutcome Outcome = null, List<JourneyOutcomeEventsNotificationOutcomeTouchpoint> OutcomeTouchpoints = null, List<JourneyOutcomeEventsNotificationSegment> SegmentAssignments = null, JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue = null)
    {
        this.Outcome = Outcome;
        this.OutcomeTouchpoints = OutcomeTouchpoints;
        this.SegmentAssignments = SegmentAssignments;
        this.AssociatedValue = AssociatedValue;

    }



    /// <summary>
    /// Gets or Sets Outcome
    /// </summary>
    [JsonPropertyName("outcome")]
    public JourneyOutcomeEventsNotificationOutcome Outcome { get; set; }



    /// <summary>
    /// Gets or Sets OutcomeTouchpoints
    /// </summary>
    [JsonPropertyName("outcomeTouchpoints")]
    public List<JourneyOutcomeEventsNotificationOutcomeTouchpoint> OutcomeTouchpoints { get; set; }



    /// <summary>
    /// Gets or Sets SegmentAssignments
    /// </summary>
    [JsonPropertyName("segmentAssignments")]
    public List<JourneyOutcomeEventsNotificationSegment> SegmentAssignments { get; set; }



    /// <summary>
    /// Gets or Sets AssociatedValue
    /// </summary>
    [JsonPropertyName("associatedValue")]
    public JourneyOutcomeEventsNotificationAssociatedValue AssociatedValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationOutcomeAttributionMessage {\n");

        sb.Append("  Outcome: ").Append(Outcome).Append("\n");
        sb.Append("  OutcomeTouchpoints: ").Append(OutcomeTouchpoints).Append("\n");
        sb.Append("  SegmentAssignments: ").Append(SegmentAssignments).Append("\n");
        sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
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
        return Equals(obj as JourneyOutcomeEventsNotificationOutcomeAttributionMessage);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationOutcomeAttributionMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationOutcomeAttributionMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationOutcomeAttributionMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Outcome == other.Outcome ||
                Outcome != null &&
                Outcome.Equals(other.Outcome)
            ) &&
            (
                OutcomeTouchpoints == other.OutcomeTouchpoints ||
                OutcomeTouchpoints != null &&
                OutcomeTouchpoints.SequenceEqual(other.OutcomeTouchpoints)
            ) &&
            (
                SegmentAssignments == other.SegmentAssignments ||
                SegmentAssignments != null &&
                SegmentAssignments.SequenceEqual(other.SegmentAssignments)
            ) &&
            (
                AssociatedValue == other.AssociatedValue ||
                AssociatedValue != null &&
                AssociatedValue.Equals(other.AssociatedValue)
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
            if (Outcome != null)
            {
                hash = hash * 59 + Outcome.GetHashCode();
            }

            if (OutcomeTouchpoints != null)
            {
                hash = hash * 59 + OutcomeTouchpoints.GetHashCode();
            }

            if (SegmentAssignments != null)
            {
                hash = hash * 59 + SegmentAssignments.GetHashCode();
            }

            if (AssociatedValue != null)
            {
                hash = hash * 59 + AssociatedValue.GetHashCode();
            }

            return hash;
        }
    }
}
