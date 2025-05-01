using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuIntradayResponse
/// </summary>
[DataContract]
public partial class BuIntradayResponse : IEquatable<BuIntradayResponse>
{
    /// <summary>
    /// If not null, the reason there was no data for the request
    /// </summary>
    /// <value>If not null, the reason there was no data for the request</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum NoDataReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nopublishedschedule for "NoPublishedSchedule"
        /// </summary>
        [EnumMember(Value = "NoPublishedSchedule")]
        Nopublishedschedule,

        /// <summary>
        /// Enum Nosourceforecast for "NoSourceForecast"
        /// </summary>
        [EnumMember(Value = "NoSourceForecast")]
        Nosourceforecast
    }
    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// If not null, the reason there was no data for the request
    /// </summary>
    /// <value>If not null, the reason there was no data for the request</value>
    [DataMember(Name = "noDataReason", EmitDefaultValue = false)]
    public NoDataReasonEnum? NoDataReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuIntradayResponse" /> class.
    /// </summary>
    /// <param name="StartDate">The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDate">The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="IntervalLengthMinutes">The aggregation period in minutes, which determines the interval duration of the returned data.</param>
    /// <param name="NoDataReason">If not null, the reason there was no data for the request.</param>
    /// <param name="Categories">The categories to which this data corresponds.</param>
    /// <param name="ShortTermForecast">Short term forecast reference.</param>
    /// <param name="Schedule">Schedule reference.</param>
    /// <param name="IntradayDataGroupings">Intraday data grouped by a single media type and set of planning group IDs.</param>
    public BuIntradayResponse(DateTime? StartDate = null, DateTime? EndDate = null, int? IntervalLengthMinutes = null, NoDataReasonEnum? NoDataReason = null, List<CategoriesEnum> Categories = null, BuShortTermForecastReference ShortTermForecast = null, BuScheduleReference Schedule = null, List<BuIntradayDataGroup> IntradayDataGroupings = null)
    {
        this.StartDate = StartDate;
        this.EndDate = EndDate;
        this.IntervalLengthMinutes = IntervalLengthMinutes;
        this.NoDataReason = NoDataReason;
        this.Categories = Categories;
        this.ShortTermForecast = ShortTermForecast;
        this.Schedule = Schedule;
        this.IntradayDataGroupings = IntradayDataGroupings;

    }



    /// <summary>
    /// The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start of the date range for which this data applies.  This is also the start reference point for the intervals represented in the various arrays. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startDate", EmitDefaultValue = false)]
    public DateTime? StartDate { get; set; }



    /// <summary>
    /// The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end of the date range for which this data applies. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "endDate", EmitDefaultValue = false)]
    public DateTime? EndDate { get; set; }



    /// <summary>
    /// The aggregation period in minutes, which determines the interval duration of the returned data
    /// </summary>
    /// <value>The aggregation period in minutes, which determines the interval duration of the returned data</value>
    [DataMember(Name = "intervalLengthMinutes", EmitDefaultValue = false)]
    public int? IntervalLengthMinutes { get; set; }





    /// <summary>
    /// The categories to which this data corresponds
    /// </summary>
    /// <value>The categories to which this data corresponds</value>
    [DataMember(Name = "categories", EmitDefaultValue = false)]
    public List<CategoriesEnum> Categories { get; set; }



    /// <summary>
    /// Short term forecast reference
    /// </summary>
    /// <value>Short term forecast reference</value>
    [DataMember(Name = "shortTermForecast", EmitDefaultValue = false)]
    public BuShortTermForecastReference ShortTermForecast { get; set; }



    /// <summary>
    /// Schedule reference
    /// </summary>
    /// <value>Schedule reference</value>
    [DataMember(Name = "schedule", EmitDefaultValue = false)]
    public BuScheduleReference Schedule { get; set; }



    /// <summary>
    /// Intraday data grouped by a single media type and set of planning group IDs
    /// </summary>
    /// <value>Intraday data grouped by a single media type and set of planning group IDs</value>
    [DataMember(Name = "intradayDataGroupings", EmitDefaultValue = false)]
    public List<BuIntradayDataGroup> IntradayDataGroupings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuIntradayResponse {\n");

        sb.Append("  StartDate: ").Append(StartDate).Append("\n");
        sb.Append("  EndDate: ").Append(EndDate).Append("\n");
        sb.Append("  IntervalLengthMinutes: ").Append(IntervalLengthMinutes).Append("\n");
        sb.Append("  NoDataReason: ").Append(NoDataReason).Append("\n");
        sb.Append("  Categories: ").Append(Categories).Append("\n");
        sb.Append("  ShortTermForecast: ").Append(ShortTermForecast).Append("\n");
        sb.Append("  Schedule: ").Append(Schedule).Append("\n");
        sb.Append("  IntradayDataGroupings: ").Append(IntradayDataGroupings).Append("\n");
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
        return Equals(obj as BuIntradayResponse);
    }

    /// <summary>
    /// Returns true if BuIntradayResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuIntradayResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuIntradayResponse other)
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
                NoDataReason == other.NoDataReason ||
                NoDataReason != null &&
                NoDataReason.Equals(other.NoDataReason)
            ) &&
            (
                Categories == other.Categories ||
                Categories != null &&
                Categories.SequenceEqual(other.Categories)
            ) &&
            (
                ShortTermForecast == other.ShortTermForecast ||
                ShortTermForecast != null &&
                ShortTermForecast.Equals(other.ShortTermForecast)
            ) &&
            (
                Schedule == other.Schedule ||
                Schedule != null &&
                Schedule.Equals(other.Schedule)
            ) &&
            (
                IntradayDataGroupings == other.IntradayDataGroupings ||
                IntradayDataGroupings != null &&
                IntradayDataGroupings.SequenceEqual(other.IntradayDataGroupings)
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

            if (NoDataReason != null)
            {
                hash = hash * 59 + NoDataReason.GetHashCode();
            }

            if (Categories != null)
            {
                hash = hash * 59 + Categories.GetHashCode();
            }

            if (ShortTermForecast != null)
            {
                hash = hash * 59 + ShortTermForecast.GetHashCode();
            }

            if (Schedule != null)
            {
                hash = hash * 59 + Schedule.GetHashCode();
            }

            if (IntradayDataGroupings != null)
            {
                hash = hash * 59 + IntradayDataGroupings.GetHashCode();
            }

            return hash;
        }
    }
}
