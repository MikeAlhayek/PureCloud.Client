using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmHistoricalAdherenceBulkUserDayMetrics
/// </summary>

public partial class WfmHistoricalAdherenceBulkUserDayMetrics : IEquatable<WfmHistoricalAdherenceBulkUserDayMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmHistoricalAdherenceBulkUserDayMetrics" /> class.
    /// </summary>
    /// <param name="DayStartOffsetSeconds">Start of day offset in seconds relative to query start time.</param>
    /// <param name="AdherenceScheduleSeconds">Duration of schedule in seconds included for adherence percentage calculation.</param>
    /// <param name="ConformanceScheduleSeconds">Total scheduled duration in seconds for OnQueue activities.</param>
    /// <param name="ConformanceActualSeconds">Total actually worked duration in seconds for OnQueue activities.</param>
    /// <param name="ExceptionCount">Total number of adherence exceptions for this user.</param>
    /// <param name="ExceptionDurationSeconds">Total duration in seconds of adherence exceptions for this user.</param>
    /// <param name="ImpactSeconds">The impact duration in seconds of current adherence state for this user.</param>
    /// <param name="ScheduleLengthSeconds">Total duration in seconds for all scheduled activities.</param>
    /// <param name="ActualLengthSeconds">Total duration in seconds for all actually worked activities.</param>
    /// <param name="AdherencePercentage">Total adherence percentage for this user, in the scale of 0 - 100.</param>
    /// <param name="ConformancePercentage">Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
    public WfmHistoricalAdherenceBulkUserDayMetrics(int? DayStartOffsetSeconds = null, int? AdherenceScheduleSeconds = null, int? ConformanceScheduleSeconds = null, int? ConformanceActualSeconds = null, int? ExceptionCount = null, int? ExceptionDurationSeconds = null, int? ImpactSeconds = null, int? ScheduleLengthSeconds = null, int? ActualLengthSeconds = null, double? AdherencePercentage = null, double? ConformancePercentage = null)
    {
        this.DayStartOffsetSeconds = DayStartOffsetSeconds;
        this.AdherenceScheduleSeconds = AdherenceScheduleSeconds;
        this.ConformanceScheduleSeconds = ConformanceScheduleSeconds;
        this.ConformanceActualSeconds = ConformanceActualSeconds;
        this.ExceptionCount = ExceptionCount;
        this.ExceptionDurationSeconds = ExceptionDurationSeconds;
        this.ImpactSeconds = ImpactSeconds;
        this.ScheduleLengthSeconds = ScheduleLengthSeconds;
        this.ActualLengthSeconds = ActualLengthSeconds;
        this.AdherencePercentage = AdherencePercentage;
        this.ConformancePercentage = ConformancePercentage;

    }



    /// <summary>
    /// Start of day offset in seconds relative to query start time
    /// </summary>
    /// <value>Start of day offset in seconds relative to query start time</value>
    [JsonPropertyName("dayStartOffsetSeconds")]
    public int? DayStartOffsetSeconds { get; set; }



    /// <summary>
    /// Duration of schedule in seconds included for adherence percentage calculation
    /// </summary>
    /// <value>Duration of schedule in seconds included for adherence percentage calculation</value>
    [JsonPropertyName("adherenceScheduleSeconds")]
    public int? AdherenceScheduleSeconds { get; set; }



    /// <summary>
    /// Total scheduled duration in seconds for OnQueue activities
    /// </summary>
    /// <value>Total scheduled duration in seconds for OnQueue activities</value>
    [JsonPropertyName("conformanceScheduleSeconds")]
    public int? ConformanceScheduleSeconds { get; set; }



    /// <summary>
    /// Total actually worked duration in seconds for OnQueue activities
    /// </summary>
    /// <value>Total actually worked duration in seconds for OnQueue activities</value>
    [JsonPropertyName("conformanceActualSeconds")]
    public int? ConformanceActualSeconds { get; set; }



    /// <summary>
    /// Total number of adherence exceptions for this user
    /// </summary>
    /// <value>Total number of adherence exceptions for this user</value>
    [JsonPropertyName("exceptionCount")]
    public int? ExceptionCount { get; set; }



    /// <summary>
    /// Total duration in seconds of adherence exceptions for this user
    /// </summary>
    /// <value>Total duration in seconds of adherence exceptions for this user</value>
    [JsonPropertyName("exceptionDurationSeconds")]
    public int? ExceptionDurationSeconds { get; set; }



    /// <summary>
    /// The impact duration in seconds of current adherence state for this user
    /// </summary>
    /// <value>The impact duration in seconds of current adherence state for this user</value>
    [JsonPropertyName("impactSeconds")]
    public int? ImpactSeconds { get; set; }



    /// <summary>
    /// Total duration in seconds for all scheduled activities
    /// </summary>
    /// <value>Total duration in seconds for all scheduled activities</value>
    [JsonPropertyName("scheduleLengthSeconds")]
    public int? ScheduleLengthSeconds { get; set; }



    /// <summary>
    /// Total duration in seconds for all actually worked activities
    /// </summary>
    /// <value>Total duration in seconds for all actually worked activities</value>
    [JsonPropertyName("actualLengthSeconds")]
    public int? ActualLengthSeconds { get; set; }



    /// <summary>
    /// Total adherence percentage for this user, in the scale of 0 - 100
    /// </summary>
    /// <value>Total adherence percentage for this user, in the scale of 0 - 100</value>
    [JsonPropertyName("adherencePercentage")]
    public double? AdherencePercentage { get; set; }



    /// <summary>
    /// Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
    /// </summary>
    /// <value>Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
    [JsonPropertyName("conformancePercentage")]
    public double? ConformancePercentage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmHistoricalAdherenceBulkUserDayMetrics {\n");

        sb.Append("  DayStartOffsetSeconds: ").Append(DayStartOffsetSeconds).Append("\n");
        sb.Append("  AdherenceScheduleSeconds: ").Append(AdherenceScheduleSeconds).Append("\n");
        sb.Append("  ConformanceScheduleSeconds: ").Append(ConformanceScheduleSeconds).Append("\n");
        sb.Append("  ConformanceActualSeconds: ").Append(ConformanceActualSeconds).Append("\n");
        sb.Append("  ExceptionCount: ").Append(ExceptionCount).Append("\n");
        sb.Append("  ExceptionDurationSeconds: ").Append(ExceptionDurationSeconds).Append("\n");
        sb.Append("  ImpactSeconds: ").Append(ImpactSeconds).Append("\n");
        sb.Append("  ScheduleLengthSeconds: ").Append(ScheduleLengthSeconds).Append("\n");
        sb.Append("  ActualLengthSeconds: ").Append(ActualLengthSeconds).Append("\n");
        sb.Append("  AdherencePercentage: ").Append(AdherencePercentage).Append("\n");
        sb.Append("  ConformancePercentage: ").Append(ConformancePercentage).Append("\n");
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
        return Equals(obj as WfmHistoricalAdherenceBulkUserDayMetrics);
    }

    /// <summary>
    /// Returns true if WfmHistoricalAdherenceBulkUserDayMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmHistoricalAdherenceBulkUserDayMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmHistoricalAdherenceBulkUserDayMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DayStartOffsetSeconds == other.DayStartOffsetSeconds ||
                DayStartOffsetSeconds != null &&
                DayStartOffsetSeconds.Equals(other.DayStartOffsetSeconds)
            ) &&
            (
                AdherenceScheduleSeconds == other.AdherenceScheduleSeconds ||
                AdherenceScheduleSeconds != null &&
                AdherenceScheduleSeconds.Equals(other.AdherenceScheduleSeconds)
            ) &&
            (
                ConformanceScheduleSeconds == other.ConformanceScheduleSeconds ||
                ConformanceScheduleSeconds != null &&
                ConformanceScheduleSeconds.Equals(other.ConformanceScheduleSeconds)
            ) &&
            (
                ConformanceActualSeconds == other.ConformanceActualSeconds ||
                ConformanceActualSeconds != null &&
                ConformanceActualSeconds.Equals(other.ConformanceActualSeconds)
            ) &&
            (
                ExceptionCount == other.ExceptionCount ||
                ExceptionCount != null &&
                ExceptionCount.Equals(other.ExceptionCount)
            ) &&
            (
                ExceptionDurationSeconds == other.ExceptionDurationSeconds ||
                ExceptionDurationSeconds != null &&
                ExceptionDurationSeconds.Equals(other.ExceptionDurationSeconds)
            ) &&
            (
                ImpactSeconds == other.ImpactSeconds ||
                ImpactSeconds != null &&
                ImpactSeconds.Equals(other.ImpactSeconds)
            ) &&
            (
                ScheduleLengthSeconds == other.ScheduleLengthSeconds ||
                ScheduleLengthSeconds != null &&
                ScheduleLengthSeconds.Equals(other.ScheduleLengthSeconds)
            ) &&
            (
                ActualLengthSeconds == other.ActualLengthSeconds ||
                ActualLengthSeconds != null &&
                ActualLengthSeconds.Equals(other.ActualLengthSeconds)
            ) &&
            (
                AdherencePercentage == other.AdherencePercentage ||
                AdherencePercentage != null &&
                AdherencePercentage.Equals(other.AdherencePercentage)
            ) &&
            (
                ConformancePercentage == other.ConformancePercentage ||
                ConformancePercentage != null &&
                ConformancePercentage.Equals(other.ConformancePercentage)
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
            if (DayStartOffsetSeconds != null)
            {
                hash = hash * 59 + DayStartOffsetSeconds.GetHashCode();
            }

            if (AdherenceScheduleSeconds != null)
            {
                hash = hash * 59 + AdherenceScheduleSeconds.GetHashCode();
            }

            if (ConformanceScheduleSeconds != null)
            {
                hash = hash * 59 + ConformanceScheduleSeconds.GetHashCode();
            }

            if (ConformanceActualSeconds != null)
            {
                hash = hash * 59 + ConformanceActualSeconds.GetHashCode();
            }

            if (ExceptionCount != null)
            {
                hash = hash * 59 + ExceptionCount.GetHashCode();
            }

            if (ExceptionDurationSeconds != null)
            {
                hash = hash * 59 + ExceptionDurationSeconds.GetHashCode();
            }

            if (ImpactSeconds != null)
            {
                hash = hash * 59 + ImpactSeconds.GetHashCode();
            }

            if (ScheduleLengthSeconds != null)
            {
                hash = hash * 59 + ScheduleLengthSeconds.GetHashCode();
            }

            if (ActualLengthSeconds != null)
            {
                hash = hash * 59 + ActualLengthSeconds.GetHashCode();
            }

            if (AdherencePercentage != null)
            {
                hash = hash * 59 + AdherencePercentage.GetHashCode();
            }

            if (ConformancePercentage != null)
            {
                hash = hash * 59 + ConformancePercentage.GetHashCode();
            }

            return hash;
        }
    }
}
