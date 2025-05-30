using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TimeSlot
/// </summary>

public partial class TimeSlot : IEquatable<TimeSlot>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeSlot" /> class.
    /// </summary>
    /// <param name="StartTime">start time in xx:xx:xx.xxx format.</param>
    /// <param name="StopTime">stop time in xx:xx:xx.xxx format.</param>
    /// <param name="Day">Day for this time slot, Monday &#x3D; 1 ... Sunday &#x3D; 7.</param>
    public TimeSlot(string StartTime = null, string StopTime = null, int? Day = null)
    {
        this.StartTime = StartTime;
        this.StopTime = StopTime;
        this.Day = Day;

    }



    /// <summary>
    /// start time in xx:xx:xx.xxx format
    /// </summary>
    /// <value>start time in xx:xx:xx.xxx format</value>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }



    /// <summary>
    /// stop time in xx:xx:xx.xxx format
    /// </summary>
    /// <value>stop time in xx:xx:xx.xxx format</value>
    [JsonPropertyName("stopTime")]
    public string StopTime { get; set; }



    /// <summary>
    /// Day for this time slot, Monday &#x3D; 1 ... Sunday &#x3D; 7
    /// </summary>
    /// <value>Day for this time slot, Monday &#x3D; 1 ... Sunday &#x3D; 7</value>
    [JsonPropertyName("day")]
    public int? Day { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TimeSlot {\n");

        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  StopTime: ").Append(StopTime).Append("\n");
        sb.Append("  Day: ").Append(Day).Append("\n");
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
        return Equals(obj as TimeSlot);
    }

    /// <summary>
    /// Returns true if TimeSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of TimeSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TimeSlot other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                StopTime == other.StopTime ||
                StopTime != null &&
                StopTime.Equals(other.StopTime)
            ) &&
            (
                Day == other.Day ||
                Day != null &&
                Day.Equals(other.Day)
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
            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (StopTime != null)
            {
                hash = hash * 59 + StopTime.GetHashCode();
            }

            if (Day != null)
            {
                hash = hash * 59 + Day.GetHashCode();
            }

            return hash;
        }
    }
}
