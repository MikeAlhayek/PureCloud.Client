using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignTimeSlot
/// </summary>

public partial class CampaignTimeSlot : IEquatable<CampaignTimeSlot>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignTimeSlot" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignTimeSlot() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignTimeSlot" /> class.
    /// </summary>
    /// <param name="StartTime">The start time of the interval as an ISO-8601 string, i.e. HH:mm:ss (required).</param>
    /// <param name="StopTime">The end time of the interval as an ISO-8601 string, i.e. HH:mm:ss (required).</param>
    /// <param name="Day">The day of the interval. Valid values: [1-7], representing Monday through Sunday (required).</param>
    public CampaignTimeSlot(string StartTime = null, string StopTime = null, int? Day = null)
    {
        this.StartTime = StartTime;
        this.StopTime = StopTime;
        this.Day = Day;

    }



    /// <summary>
    /// The start time of the interval as an ISO-8601 string, i.e. HH:mm:ss
    /// </summary>
    /// <value>The start time of the interval as an ISO-8601 string, i.e. HH:mm:ss</value>
    [JsonPropertyName("startTime")]
    public string StartTime { get; set; }



    /// <summary>
    /// The end time of the interval as an ISO-8601 string, i.e. HH:mm:ss
    /// </summary>
    /// <value>The end time of the interval as an ISO-8601 string, i.e. HH:mm:ss</value>
    [JsonPropertyName("stopTime")]
    public string StopTime { get; set; }



    /// <summary>
    /// The day of the interval. Valid values: [1-7], representing Monday through Sunday
    /// </summary>
    /// <value>The day of the interval. Valid values: [1-7], representing Monday through Sunday</value>
    [JsonPropertyName("day")]
    public int? Day { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignTimeSlot {\n");

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
        return Equals(obj as CampaignTimeSlot);
    }

    /// <summary>
    /// Returns true if CampaignTimeSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignTimeSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignTimeSlot other)
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
