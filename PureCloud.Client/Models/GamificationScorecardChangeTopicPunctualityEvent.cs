using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GamificationScorecardChangeTopicPunctualityEvent
/// </summary>

public partial class GamificationScorecardChangeTopicPunctualityEvent : IEquatable<GamificationScorecardChangeTopicPunctualityEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicPunctualityEvent" /> class.
    /// </summary>
    /// <param name="DateStart">DateStart.</param>
    /// <param name="DateScheduleStart">DateScheduleStart.</param>
    /// <param name="ActivityCode">ActivityCode.</param>
    /// <param name="Points">Points.</param>
    public GamificationScorecardChangeTopicPunctualityEvent(string DateStart = null, string DateScheduleStart = null, string ActivityCode = null, long? Points = null)
    {
        this.DateStart = DateStart;
        this.DateScheduleStart = DateScheduleStart;
        this.ActivityCode = ActivityCode;
        this.Points = Points;

    }



    /// <summary>
    /// Gets or Sets DateStart
    /// </summary>
    [JsonPropertyName("dateStart")]
    public string DateStart { get; set; }



    /// <summary>
    /// Gets or Sets DateScheduleStart
    /// </summary>
    [JsonPropertyName("dateScheduleStart")]
    public string DateScheduleStart { get; set; }



    /// <summary>
    /// Gets or Sets ActivityCode
    /// </summary>
    [JsonPropertyName("activityCode")]
    public string ActivityCode { get; set; }



    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    [JsonPropertyName("points")]
    public long? Points { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GamificationScorecardChangeTopicPunctualityEvent {\n");

        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateScheduleStart: ").Append(DateScheduleStart).Append("\n");
        sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
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
        return Equals(obj as GamificationScorecardChangeTopicPunctualityEvent);
    }

    /// <summary>
    /// Returns true if GamificationScorecardChangeTopicPunctualityEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of GamificationScorecardChangeTopicPunctualityEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GamificationScorecardChangeTopicPunctualityEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateScheduleStart == other.DateScheduleStart ||
                DateScheduleStart != null &&
                DateScheduleStart.Equals(other.DateScheduleStart)
            ) &&
            (
                ActivityCode == other.ActivityCode ||
                ActivityCode != null &&
                ActivityCode.Equals(other.ActivityCode)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
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
            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateScheduleStart != null)
            {
                hash = hash * 59 + DateScheduleStart.GetHashCode();
            }

            if (ActivityCode != null)
            {
                hash = hash * 59 + ActivityCode.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            return hash;
        }
    }
}
