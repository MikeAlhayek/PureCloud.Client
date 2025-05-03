using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuGenerateScheduleRequest
/// </summary>

public partial class BuGenerateScheduleRequest : IEquatable<BuGenerateScheduleRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuGenerateScheduleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuGenerateScheduleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuGenerateScheduleRequest" /> class.
    /// </summary>
    /// <param name="Description">The description for the schedule (required).</param>
    /// <param name="ShortTermForecast">The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count.</param>
    /// <param name="WeekCount">The number of weeks in the schedule. One extra day is added at the end (required).</param>
    /// <param name="Options">Additional scheduling options.</param>
    public BuGenerateScheduleRequest(string Description = null, BuShortTermForecastReference ShortTermForecast = null, int? WeekCount = null, SchedulingOptionsRequest Options = null)
    {
        this.Description = Description;
        this.ShortTermForecast = ShortTermForecast;
        this.WeekCount = WeekCount;
        this.Options = Options;

    }



    /// <summary>
    /// The description for the schedule
    /// </summary>
    /// <value>The description for the schedule</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count
    /// </summary>
    /// <value>The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count</value>
    [JsonPropertyName("shortTermForecast")]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// The number of weeks in the schedule. One extra day is added at the end
    /// </summary>
    /// <value>The number of weeks in the schedule. One extra day is added at the end</value>
    [JsonPropertyName("weekCount")]
    public int? WeekCount { get; set; }



    /// <summary>
    /// Additional scheduling options
    /// </summary>
    /// <value>Additional scheduling options</value>
    [JsonPropertyName("options")]
    public SchedulingOptionsRequest Options { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuGenerateScheduleRequest {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
        sb.Append("  Options: ").Append(Options).Append("\n");
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
        return Equals(obj as BuGenerateScheduleRequest);
    }

    /// <summary>
    /// Returns true if BuGenerateScheduleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuGenerateScheduleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuGenerateScheduleRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                ShortTermForecast == other.ShortTermForecast ||
                ShortTermForecast != null &&
                ShortTermForecast.Equals(other.ShortTermForecast)
            ) &&
            (
                WeekCount == other.WeekCount ||
                WeekCount != null &&
                WeekCount.Equals(other.WeekCount)
            ) &&
            (
                Options == other.Options ||
                Options != null &&
                Options.Equals(other.Options)
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
            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            if (WeekCount != null)
            {
                hash = hash * 59 + WeekCount.GetHashCode();
            }

            if (Options != null)
            {
                hash = hash * 59 + Options.GetHashCode();
            }

            return hash;
        }
    }
}
