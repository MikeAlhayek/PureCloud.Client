using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmIntradayDataUpdateTopicIntradayDataGroup
/// </summary>

public partial class WfmIntradayDataUpdateTopicIntradayDataGroup : IEquatable<WfmIntradayDataUpdateTopicIntradayDataGroup>
{
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    
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
    /// Gets or Sets MediaType
    /// </summary>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmIntradayDataUpdateTopicIntradayDataGroup" /> class.
    /// </summary>
    /// <param name="MediaType">MediaType.</param>
    /// <param name="ForecastDataPerInterval">ForecastDataPerInterval.</param>
    /// <param name="ScheduleDataPerInterval">ScheduleDataPerInterval.</param>
    /// <param name="HistoricalAgentDataPerInterval">HistoricalAgentDataPerInterval.</param>
    /// <param name="HistoricalQueueDataPerInterval">HistoricalQueueDataPerInterval.</param>
    /// <param name="PerformancePredictionAgentDataPerInterval">PerformancePredictionAgentDataPerInterval.</param>
    /// <param name="PerformancePredictionQueueDataPerInterval">PerformancePredictionQueueDataPerInterval.</param>
    public WfmIntradayDataUpdateTopicIntradayDataGroup(MediaTypeEnum? MediaType = null, List<WfmIntradayDataUpdateTopicIntradayForecastData> ForecastDataPerInterval = null, List<WfmIntradayDataUpdateTopicIntradayScheduleData> ScheduleDataPerInterval = null, List<WfmIntradayDataUpdateTopicIntradayHistoricalAgentData> HistoricalAgentDataPerInterval = null, List<WfmIntradayDataUpdateTopicIntradayHistoricalQueueData> HistoricalQueueDataPerInterval = null, List<WfmIntradayDataUpdateTopicIntradayPerformancePredictionAgentData> PerformancePredictionAgentDataPerInterval = null, List<WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData> PerformancePredictionQueueDataPerInterval = null)
    {
        this.MediaType = MediaType;
        this.ForecastDataPerInterval = ForecastDataPerInterval;
        this.ScheduleDataPerInterval = ScheduleDataPerInterval;
        this.HistoricalAgentDataPerInterval = HistoricalAgentDataPerInterval;
        this.HistoricalQueueDataPerInterval = HistoricalQueueDataPerInterval;
        this.PerformancePredictionAgentDataPerInterval = PerformancePredictionAgentDataPerInterval;
        this.PerformancePredictionQueueDataPerInterval = PerformancePredictionQueueDataPerInterval;

    }





    /// <summary>
    /// Gets or Sets ForecastDataPerInterval
    /// </summary>
    [JsonPropertyName("forecastDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayForecastData> ForecastDataPerInterval { get; set; }



    /// <summary>
    /// Gets or Sets ScheduleDataPerInterval
    /// </summary>
    [JsonPropertyName("scheduleDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayScheduleData> ScheduleDataPerInterval { get; set; }



    /// <summary>
    /// Gets or Sets HistoricalAgentDataPerInterval
    /// </summary>
    [JsonPropertyName("historicalAgentDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayHistoricalAgentData> HistoricalAgentDataPerInterval { get; set; }



    /// <summary>
    /// Gets or Sets HistoricalQueueDataPerInterval
    /// </summary>
    [JsonPropertyName("historicalQueueDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayHistoricalQueueData> HistoricalQueueDataPerInterval { get; set; }



    /// <summary>
    /// Gets or Sets PerformancePredictionAgentDataPerInterval
    /// </summary>
    [JsonPropertyName("performancePredictionAgentDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayPerformancePredictionAgentData> PerformancePredictionAgentDataPerInterval { get; set; }



    /// <summary>
    /// Gets or Sets PerformancePredictionQueueDataPerInterval
    /// </summary>
    [JsonPropertyName("performancePredictionQueueDataPerInterval")]
    public List<WfmIntradayDataUpdateTopicIntradayPerformancePredictionQueueData> PerformancePredictionQueueDataPerInterval { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmIntradayDataUpdateTopicIntradayDataGroup {\n");

        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ForecastDataPerInterval: ").Append(ForecastDataPerInterval).Append("\n");
        sb.Append("  ScheduleDataPerInterval: ").Append(ScheduleDataPerInterval).Append("\n");
        sb.Append("  HistoricalAgentDataPerInterval: ").Append(HistoricalAgentDataPerInterval).Append("\n");
        sb.Append("  HistoricalQueueDataPerInterval: ").Append(HistoricalQueueDataPerInterval).Append("\n");
        sb.Append("  PerformancePredictionAgentDataPerInterval: ").Append(PerformancePredictionAgentDataPerInterval).Append("\n");
        sb.Append("  PerformancePredictionQueueDataPerInterval: ").Append(PerformancePredictionQueueDataPerInterval).Append("\n");
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
        return Equals(obj as WfmIntradayDataUpdateTopicIntradayDataGroup);
    }

    /// <summary>
    /// Returns true if WfmIntradayDataUpdateTopicIntradayDataGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmIntradayDataUpdateTopicIntradayDataGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmIntradayDataUpdateTopicIntradayDataGroup other)
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
                ForecastDataPerInterval == other.ForecastDataPerInterval ||
                ForecastDataPerInterval != null &&
                ForecastDataPerInterval.SequenceEqual(other.ForecastDataPerInterval)
            ) &&
            (
                ScheduleDataPerInterval == other.ScheduleDataPerInterval ||
                ScheduleDataPerInterval != null &&
                ScheduleDataPerInterval.SequenceEqual(other.ScheduleDataPerInterval)
            ) &&
            (
                HistoricalAgentDataPerInterval == other.HistoricalAgentDataPerInterval ||
                HistoricalAgentDataPerInterval != null &&
                HistoricalAgentDataPerInterval.SequenceEqual(other.HistoricalAgentDataPerInterval)
            ) &&
            (
                HistoricalQueueDataPerInterval == other.HistoricalQueueDataPerInterval ||
                HistoricalQueueDataPerInterval != null &&
                HistoricalQueueDataPerInterval.SequenceEqual(other.HistoricalQueueDataPerInterval)
            ) &&
            (
                PerformancePredictionAgentDataPerInterval == other.PerformancePredictionAgentDataPerInterval ||
                PerformancePredictionAgentDataPerInterval != null &&
                PerformancePredictionAgentDataPerInterval.SequenceEqual(other.PerformancePredictionAgentDataPerInterval)
            ) &&
            (
                PerformancePredictionQueueDataPerInterval == other.PerformancePredictionQueueDataPerInterval ||
                PerformancePredictionQueueDataPerInterval != null &&
                PerformancePredictionQueueDataPerInterval.SequenceEqual(other.PerformancePredictionQueueDataPerInterval)
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

            if (ForecastDataPerInterval != null)
            {
                hash = hash * 59 + ForecastDataPerInterval.GetHashCode();
            }

            if (ScheduleDataPerInterval != null)
            {
                hash = hash * 59 + ScheduleDataPerInterval.GetHashCode();
            }

            if (HistoricalAgentDataPerInterval != null)
            {
                hash = hash * 59 + HistoricalAgentDataPerInterval.GetHashCode();
            }

            if (HistoricalQueueDataPerInterval != null)
            {
                hash = hash * 59 + HistoricalQueueDataPerInterval.GetHashCode();
            }

            if (PerformancePredictionAgentDataPerInterval != null)
            {
                hash = hash * 59 + PerformancePredictionAgentDataPerInterval.GetHashCode();
            }

            if (PerformancePredictionQueueDataPerInterval != null)
            {
                hash = hash * 59 + PerformancePredictionQueueDataPerInterval.GetHashCode();
            }

            return hash;
        }
    }
}
