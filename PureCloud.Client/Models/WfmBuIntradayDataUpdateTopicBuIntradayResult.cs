using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuIntradayDataUpdateTopicBuIntradayResult
/// </summary>

public partial class WfmBuIntradayDataUpdateTopicBuIntradayResult : IEquatable<WfmBuIntradayDataUpdateTopicBuIntradayResult>
{
    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    
    public enum CategoriesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Forecastdata for "ForecastData"
        /// </summary>
        [EnumMember(Value = "ForecastData")]
        Forecastdata,

        /// <summary>
        /// Enum Scheduledata for "ScheduleData"
        /// </summary>
        [EnumMember(Value = "ScheduleData")]
        Scheduledata,

        /// <summary>
        /// Enum Performancepredictiondata for "PerformancePredictionData"
        /// </summary>
        [EnumMember(Value = "PerformancePredictionData")]
        Performancepredictiondata
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuIntradayDataUpdateTopicBuIntradayResult" /> class.
    /// </summary>
    /// <param name="StartDate">StartDate.</param>
    /// <param name="EndDate">EndDate.</param>
    /// <param name="IntervalLengthMinutes">IntervalLengthMinutes.</param>
    /// <param name="IntradayDataGroupings">IntradayDataGroupings.</param>
    /// <param name="Categories">Categories.</param>
    /// <param name="NoDataReason">NoDataReason.</param>
    /// <param name="Schedule">Schedule.</param>
    /// <param name="ShortTermForecast">ShortTermForecast.</param>
    public WfmBuIntradayDataUpdateTopicBuIntradayResult(DateTime? StartDate = null, DateTime? EndDate = null, long? IntervalLengthMinutes = null, List<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup> IntradayDataGroupings = null, List<CategoriesEnum> Categories = null, string NoDataReason = null, WfmBuIntradayDataUpdateTopicBuScheduleReference Schedule = null, WfmBuIntradayDataUpdateTopicBuShortTermForecastReference ShortTermForecast = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.IntervalLengthMinutes = IntervalLengthMinutes;
        this.IntradayDataGroupings = IntradayDataGroupings;
        this.Categories = Categories;
        this.NoDataReason = NoDataReason;
        this.Schedule = Schedule;
        this.ShortTermForecast = ShortTermForecast;

    }



    /// <summary>
    /// Gets or Sets StartDate
    /// </summary>
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// Gets or Sets EndDate
    /// </summary>
    [JsonPropertyName("endDate")]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// Gets or Sets IntervalLengthMinutes
    /// </summary>
    [JsonPropertyName("intervalLengthMinutes")]
    public long? IntervalLengthMinutes { get; set; }



    /// <summary>
    /// Gets or Sets IntradayDataGroupings
    /// </summary>
    [JsonPropertyName("intradayDataGroupings")]
    public List<WfmBuIntradayDataUpdateTopicBuIntradayDataGroup> IntradayDataGroupings { get; set; }



    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [JsonPropertyName("categories")]
    public List<CategoriesEnum> Categories { get; set; }



    /// <summary>
    /// Gets or Sets NoDataReason
    /// </summary>
    [JsonPropertyName("noDataReason")]
    public string NoDataReason { get; set; }



    /// <summary>
    /// Gets or Sets Schedule
    /// </summary>
    [JsonPropertyName("schedule")]
    public WfmBuIntradayDataUpdateTopicBuScheduleReference Schedule { get; set; }



    /// <summary>
    /// Gets or Sets ShortTermForecast
    /// </summary>
    [JsonPropertyName("shortTermForecast")]
    public WfmBuIntradayDataUpdateTopicBuShortTermForecastReference ShortTermForecast { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuIntradayDataUpdateTopicBuIntradayResult {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
        sb.Append("  IntradayDataGroupings: ").Append(IntradayDataGroupings).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  NoDataReason: ").Append(NoDataReason).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
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
        return Equals(obj as WfmBuIntradayDataUpdateTopicBuIntradayResult);
    }

    /// <summary>
    /// Returns true if WfmBuIntradayDataUpdateTopicBuIntradayResult instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuIntradayDataUpdateTopicBuIntradayResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuIntradayDataUpdateTopicBuIntradayResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                StartDate == other.StartDate ||
                StartDate != null &&
                StartDate.Equals(other.StartDate)
            ) &&
            (
                EndDate == other.EndDate ||
                EndDate != null &&
                EndDate.Equals(other.EndDate)
            ) &&
            (
                IntervalLengthMinutes == other.IntervalLengthMinutes ||
                IntervalLengthMinutes != null &&
                IntervalLengthMinutes.Equals(other.IntervalLengthMinutes)
            ) &&
            (
                IntradayDataGroupings == other.IntradayDataGroupings ||
                IntradayDataGroupings != null &&
                IntradayDataGroupings.SequenceEqual(other.IntradayDataGroupings)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.SequenceEqual(other.Categories)
            ) &&
            (
                NoDataReason == other.NoDataReason ||
                NoDataReason != null &&
                NoDataReason.Equals(other.NoDataReason)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                ShortTermForecast == other.ShortTermForecast ||
                ShortTermForecast != null &&
                ShortTermForecast.Equals(other.ShortTermForecast)
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
            if (StartDate != null)
            {
                hash = hash * 59 + StartDate.GetHashCode();
            }

            if (EndDate != null)
            {
                hash = hash * 59 + EndDate.GetHashCode();
            }

            if (IntervalLengthMinutes != null)
            {
                hash = hash * 59 + IntervalLengthMinutes.GetHashCode();
            }

            if (IntradayDataGroupings != null)
            {
                hash = hash * 59 + IntradayDataGroupings.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            if (NoDataReason != null)
            {
                hash = hash * 59 + NoDataReason.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            return hash;
        }
    }
}
