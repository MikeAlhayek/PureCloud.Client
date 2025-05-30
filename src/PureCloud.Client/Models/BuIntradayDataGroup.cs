using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuIntradayDataGroup
/// </summary>

public partial class BuIntradayDataGroup : IEquatable<BuIntradayDataGroup>
{
    /// <summary>
    /// The media type associated with this intraday group
    /// </summary>
    /// <value>The media type associated with this intraday group</value>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Workitem for "Workitem"
        /// </summary>
        [EnumMember(Value = "Workitem")]
        Workitem
    }
    /// <summary>
    /// The media type associated with this intraday group
    /// </summary>
    /// <value>The media type associated with this intraday group</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuIntradayDataGroup" /> class.
    /// </summary>
    /// <param name="MediaType">The media type associated with this intraday group.</param>
    /// <param name="ForecastDataSummary">Forecast data summary for this date range.</param>
    /// <param name="ForecastDataPerInterval">Forecast data per interval for this date range.</param>
    /// <param name="ScheduleDataSummary">Schedule data summary for this date range.</param>
    /// <param name="ScheduleDataPerInterval">Schedule data per interval for this date range.</param>
    /// <param name="PerformancePredictionDataSummary">Performance prediction data summary for this date range.</param>
    /// <param name="PerformancePredictionDataPerInterval">Performance prediction data per interval for this date range.</param>
    public BuIntradayDataGroup(MediaTypeEnum? MediaType = null, BuIntradayForecastData ForecastDataSummary = null, List<BuIntradayForecastData> ForecastDataPerInterval = null, BuIntradayScheduleData ScheduleDataSummary = null, List<BuIntradayScheduleData> ScheduleDataPerInterval = null, IntradayPerformancePredictionData PerformancePredictionDataSummary = null, List<IntradayPerformancePredictionData> PerformancePredictionDataPerInterval = null)
    {
        this.MediaType = MediaType;
        this.ForecastDataSummary = ForecastDataSummary;
        this.ForecastDataPerInterval = ForecastDataPerInterval;
        this.ScheduleDataSummary = ScheduleDataSummary;
        this.ScheduleDataPerInterval = ScheduleDataPerInterval;
        this.PerformancePredictionDataSummary = PerformancePredictionDataSummary;
        this.PerformancePredictionDataPerInterval = PerformancePredictionDataPerInterval;

    }





    /// <summary>
    /// Forecast data summary for this date range
    /// </summary>
    /// <value>Forecast data summary for this date range</value>
    [JsonPropertyName("forecastDataSummary")]
    public BuIntradayForecastData ForecastDataSummary { get; set; }



    /// <summary>
    /// Forecast data per interval for this date range
    /// </summary>
    /// <value>Forecast data per interval for this date range</value>
    [JsonPropertyName("forecastDataPerInterval")]
    public List<BuIntradayForecastData> ForecastDataPerInterval { get; set; }



    /// <summary>
    /// Schedule data summary for this date range
    /// </summary>
    /// <value>Schedule data summary for this date range</value>
    [JsonPropertyName("scheduleDataSummary")]
    public BuIntradayScheduleData ScheduleDataSummary { get; set; }



    /// <summary>
    /// Schedule data per interval for this date range
    /// </summary>
    /// <value>Schedule data per interval for this date range</value>
    [JsonPropertyName("scheduleDataPerInterval")]
    public List<BuIntradayScheduleData> ScheduleDataPerInterval { get; set; }



    /// <summary>
    /// Performance prediction data summary for this date range
    /// </summary>
    /// <value>Performance prediction data summary for this date range</value>
    [JsonPropertyName("performancePredictionDataSummary")]
    public IntradayPerformancePredictionData PerformancePredictionDataSummary { get; set; }



    /// <summary>
    /// Performance prediction data per interval for this date range
    /// </summary>
    /// <value>Performance prediction data per interval for this date range</value>
    [JsonPropertyName("performancePredictionDataPerInterval")]
    public List<IntradayPerformancePredictionData> PerformancePredictionDataPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuIntradayDataGroup {\n");

        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ForecastDataSummary: ").Append(ForecastDataSummary).Append("\n");
        sb.Append("  ForecastDataPerInterval: ").Append(ForecastDataPerInterval).Append("\n");
        sb.Append("  ScheduleDataSummary: ").Append(ScheduleDataSummary).Append("\n");
        sb.Append("  ScheduleDataPerInterval: ").Append(ScheduleDataPerInterval).Append("\n");
        sb.Append("  PerformancePredictionDataSummary: ").Append(PerformancePredictionDataSummary).Append("\n");
        sb.Append("  PerformancePredictionDataPerInterval: ").Append(PerformancePredictionDataPerInterval).Append("\n");
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
        return Equals(obj as BuIntradayDataGroup);
    }

    /// <summary>
    /// Returns true if BuIntradayDataGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of BuIntradayDataGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuIntradayDataGroup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ForecastDataSummary == other.ForecastDataSummary ||
                ForecastDataSummary != null &&
                ForecastDataSummary.Equals(other.ForecastDataSummary)
            ) &&
            (
                ForecastDataPerInterval == other.ForecastDataPerInterval ||
                ForecastDataPerInterval != null &&
                ForecastDataPerInterval.SequenceEqual(other.ForecastDataPerInterval)
            ) &&
            (
                ScheduleDataSummary == other.ScheduleDataSummary ||
                ScheduleDataSummary != null &&
                ScheduleDataSummary.Equals(other.ScheduleDataSummary)
            ) &&
            (
                ScheduleDataPerInterval == other.ScheduleDataPerInterval ||
                ScheduleDataPerInterval != null &&
                ScheduleDataPerInterval.SequenceEqual(other.ScheduleDataPerInterval)
            ) &&
            (
                PerformancePredictionDataSummary == other.PerformancePredictionDataSummary ||
                PerformancePredictionDataSummary != null &&
                PerformancePredictionDataSummary.Equals(other.PerformancePredictionDataSummary)
            ) &&
            (
                PerformancePredictionDataPerInterval == other.PerformancePredictionDataPerInterval ||
                PerformancePredictionDataPerInterval != null &&
                PerformancePredictionDataPerInterval.SequenceEqual(other.PerformancePredictionDataPerInterval)
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
            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ForecastDataSummary != null)
            {
                hash = hash * 59 + ForecastDataSummary.GetHashCode();
            }

            if (ForecastDataPerInterval != null)
            {
                hash = hash * 59 + ForecastDataPerInterval.GetHashCode();
            }

            if (ScheduleDataSummary != null)
            {
                hash = hash * 59 + ScheduleDataSummary.GetHashCode();
            }

            if (ScheduleDataPerInterval != null)
            {
                hash = hash * 59 + ScheduleDataPerInterval.GetHashCode();
            }

            if (PerformancePredictionDataSummary != null)
            {
                hash = hash * 59 + PerformancePredictionDataSummary.GetHashCode();
            }

            if (PerformancePredictionDataPerInterval != null)
            {
                hash = hash * 59 + PerformancePredictionDataPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
