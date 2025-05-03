using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PunctualityEvent
/// </summary>

public partial class PunctualityEvent : IEquatable<PunctualityEvent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PunctualityEvent" /> class.
    /// </summary>
    /// <param name="Bullseye">Bullseye.</param>
    public PunctualityEvent(bool? Bullseye = null)
    {
        this.Bullseye = Bullseye;

    }



    /// <summary>
    /// The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The scheduled activity start time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateScheduleStart")]
    public DateTime? DateScheduleStart { get; private set; }



    /// <summary>
    /// The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the user started the activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; private set; }



    /// <summary>
    /// The length of the activity in minutes
    /// </summary>
    /// <value>The length of the activity in minutes</value>
    [JsonPropertyName("lengthMinutes")]
    public int? LengthMinutes { get; private set; }



    /// <summary>
    /// The description of the activity
    /// </summary>
    /// <value>The description of the activity</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The ID of the activity code associated with this activity
    /// </summary>
    /// <value>The ID of the activity code associated with this activity</value>
    [JsonPropertyName("activityCodeId")]
    public string ActivityCodeId { get; private set; }



    /// <summary>
    /// The activity code
    /// </summary>
    /// <value>The activity code</value>
    [JsonPropertyName("activityCode")]
    public string ActivityCode { get; private set; }



    /// <summary>
    /// The activity name
    /// </summary>
    /// <value>The activity name</value>
    [JsonPropertyName("activityName")]
    public string ActivityName { get; private set; }



    /// <summary>
    /// The category for the activity
    /// </summary>
    /// <value>The category for the activity</value>
    [JsonPropertyName("category")]
    public string Category { get; private set; }



    /// <summary>
    /// The points earned for this activity
    /// </summary>
    /// <value>The points earned for this activity</value>
    [JsonPropertyName("points")]
    public int? Points { get; private set; }



    /// <summary>
    /// Difference between this activity and the last activity in seconds
    /// </summary>
    /// <value>Difference between this activity and the last activity in seconds</value>
    [JsonPropertyName("delta")]
    public double? Delta { get; private set; }



    /// <summary>
    /// Gets or Sets Bullseye
    /// </summary>
    [JsonPropertyName("bullseye")]
    public bool? Bullseye { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PunctualityEvent {\n");

        sb.Append("  DateScheduleStart: ").Append(DateScheduleStart).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  LengthMinutes: ").Append(LengthMinutes).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ActivityCodeId: ").Append(ActivityCodeId).Append("\n");
        sb.Append("  ActivityCode: ").Append(ActivityCode).Append("\n");
        sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  Delta: ").Append(Delta).Append("\n");
        sb.Append("  Bullseye: ").Append(Bullseye).Append("\n");
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
        return Equals(obj as PunctualityEvent);
    }

    /// <summary>
    /// Returns true if PunctualityEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of PunctualityEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PunctualityEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateScheduleStart == other.DateScheduleStart ||
                DateScheduleStart != null &&
                DateScheduleStart.Equals(other.DateScheduleStart)
            ) &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                LengthMinutes == other.LengthMinutes ||
                LengthMinutes != null &&
                LengthMinutes.Equals(other.LengthMinutes)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ActivityCodeId == other.ActivityCodeId ||
                ActivityCodeId != null &&
                ActivityCodeId.Equals(other.ActivityCodeId)
            ) &&
            (
                ActivityCode == other.ActivityCode ||
                ActivityCode != null &&
                ActivityCode.Equals(other.ActivityCode)
            ) &&
            (
                ActivityName == other.ActivityName ||
                ActivityName != null &&
                ActivityName.Equals(other.ActivityName)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
            ) &&
            (
                Delta == other.Delta ||
                Delta != null &&
                Delta.Equals(other.Delta)
            ) &&
            (
                Bullseye == other.Bullseye ||
                Bullseye != null &&
                Bullseye.Equals(other.Bullseye)
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
            if (DateScheduleStart != null)
            {
                hash = hash * 59 + DateScheduleStart.GetHashCode();
            }

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (LengthMinutes != null)
            {
                hash = hash * 59 + LengthMinutes.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ActivityCodeId != null)
            {
                hash = hash * 59 + ActivityCodeId.GetHashCode();
            }

            if (ActivityCode != null)
            {
                hash = hash * 59 + ActivityCode.GetHashCode();
            }

            if (ActivityName != null)
            {
                hash = hash * 59 + ActivityName.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (Delta != null)
            {
                hash = hash * 59 + Delta.GetHashCode();
            }

            if (Bullseye != null)
            {
                hash = hash * 59 + Bullseye.GetHashCode();
            }

            return hash;
        }
    }
}
