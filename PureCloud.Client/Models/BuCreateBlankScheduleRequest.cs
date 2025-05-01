using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuCreateBlankScheduleRequest
/// </summary>
[DataContract]
public partial class BuCreateBlankScheduleRequest : IEquatable<BuCreateBlankScheduleRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="BuCreateBlankScheduleRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuCreateBlankScheduleRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuCreateBlankScheduleRequest" /> class.
    /// </summary>
    /// <param name="Description">The description for the schedule (required).</param>
    /// <param name="ShortTermForecast">The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count.</param>
    /// <param name="WeekCount">The number of weeks in the schedule. One extra day is added at the end (required).</param>
    public BuCreateBlankScheduleRequest(string Description = null, BuShortTermForecastReference ShortTermForecast = null, int? WeekCount = null)
    {
        this.Description = Description;
        this.ShortTermForecast = ShortTermForecast;
        this.WeekCount = WeekCount;

    }



    /// <summary>
    /// The description for the schedule
    /// </summary>
    /// <value>The description for the schedule</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count
    /// </summary>
    /// <value>The forecast to use when generating the schedule.  Note that the forecast must fully encompass the schedule&#39;s start week + week count</value>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// The number of weeks in the schedule. One extra day is added at the end
    /// </summary>
    /// <value>The number of weeks in the schedule. One extra day is added at the end</value>
    [DataMember(Name = "weekCount", EmitDefaultValue = false)]
    public int? WeekCount { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuCreateBlankScheduleRequest {\n");

        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  WeekCount: ").Append(WeekCount).Append("\n");
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
        return Equals(obj as BuCreateBlankScheduleRequest);
    }

    /// <summary>
    /// Returns true if BuCreateBlankScheduleRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BuCreateBlankScheduleRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuCreateBlankScheduleRequest other)
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

            return hash;
        }
    }
}
