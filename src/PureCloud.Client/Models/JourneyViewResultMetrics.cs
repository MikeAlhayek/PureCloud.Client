using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The metrics of an element or a link in journey 
/// </summary>

public partial class JourneyViewResultMetrics : IEquatable<JourneyViewResultMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewResultMetrics" /> class.
    /// </summary>
    public JourneyViewResultMetrics()
    {

    }



    /// <summary>
    /// number of external contacts who participated at the element
    /// </summary>
    /// <value>number of external contacts who participated at the element</value>
    [JsonPropertyName("participantCount")]
    public int? ParticipantCount { get; set; }



    /// <summary>
    /// number of external contacts who could still complete the journey
    /// </summary>
    /// <value>number of external contacts who could still complete the journey</value>
    [JsonPropertyName("activeCount")]
    public int? ActiveCount { get; set; }



    /// <summary>
    /// number of external contacts who completed the journey forward
    /// </summary>
    /// <value>number of external contacts who completed the journey forward</value>
    [JsonPropertyName("completedCount")]
    public int? CompletedCount { get; set; }



    /// <summary>
    /// number of external contacts who did not make it to the next element
    /// </summary>
    /// <value>number of external contacts who did not make it to the next element</value>
    [JsonPropertyName("dropoutCount")]
    public int? DropoutCount { get; set; }



    /// <summary>
    /// number of external contacts who moved from one element to next element but did not complete the journey
    /// </summary>
    /// <value>number of external contacts who moved from one element to next element but did not complete the journey</value>
    [JsonPropertyName("flowCount")]
    public int? FlowCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewResultMetrics {\n");

        sb.Append("  ParticipantCount: ").Append(ParticipantCount).Append("\n");
        sb.Append("  ActiveCount: ").Append(ActiveCount).Append("\n");
        sb.Append("  CompletedCount: ").Append(CompletedCount).Append("\n");
        sb.Append("  DropoutCount: ").Append(DropoutCount).Append("\n");
        sb.Append("  FlowCount: ").Append(FlowCount).Append("\n");
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
        return Equals(obj as JourneyViewResultMetrics);
    }

    /// <summary>
    /// Returns true if JourneyViewResultMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewResultMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewResultMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ParticipantCount == other.ParticipantCount ||
                ParticipantCount != null &&
                ParticipantCount.Equals(other.ParticipantCount)
            ) &&
            (
                ActiveCount == other.ActiveCount ||
                ActiveCount != null &&
                ActiveCount.Equals(other.ActiveCount)
            ) &&
            (
                CompletedCount == other.CompletedCount ||
                CompletedCount != null &&
                CompletedCount.Equals(other.CompletedCount)
            ) &&
            (
                DropoutCount == other.DropoutCount ||
                DropoutCount != null &&
                DropoutCount.Equals(other.DropoutCount)
            ) &&
            (
                FlowCount == other.FlowCount ||
                FlowCount != null &&
                FlowCount.Equals(other.FlowCount)
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
            if (ParticipantCount != null)
            {
                hash = hash * 59 + ParticipantCount.GetHashCode();
            }

            if (ActiveCount != null)
            {
                hash = hash * 59 + ActiveCount.GetHashCode();
            }

            if (CompletedCount != null)
            {
                hash = hash * 59 + CompletedCount.GetHashCode();
            }

            if (DropoutCount != null)
            {
                hash = hash * 59 + DropoutCount.GetHashCode();
            }

            if (FlowCount != null)
            {
                hash = hash * 59 + FlowCount.GetHashCode();
            }

            return hash;
        }
    }
}
