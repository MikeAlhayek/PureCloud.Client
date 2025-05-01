using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoricalAdherenceDayMetrics
/// </summary>
[DataContract]
public partial class HistoricalAdherenceDayMetrics : IEquatable<HistoricalAdherenceDayMetrics>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoricalAdherenceDayMetrics" /> class.
    /// </summary>
    /// <param name="DayStartOffsetSecs">Start of day offset in seconds relative to query start time.</param>
    /// <param name="AdherenceScheduleSecs">Duration of schedule in seconds included for adherence percentage calculation.</param>
    /// <param name="ConformanceScheduleSecs">Total scheduled duration in seconds for OnQueue activities.</param>
    /// <param name="ConformanceActualSecs">Total actually worked duration in seconds for OnQueue activities.</param>
    /// <param name="ExceptionCount">Total number of adherence exceptions for this user.</param>
    /// <param name="ExceptionDurationSecs">Total duration in seconds of adherence exceptions for this user.</param>
    /// <param name="ImpactSeconds">The impact duration in seconds of current adherence state for this user.</param>
    /// <param name="ScheduleLengthSecs">Total duration in seconds for all scheduled activities.</param>
    /// <param name="ActualLengthSecs">Total duration in seconds for all actually worked activities.</param>
    /// <param name="AdherencePercentage">Total adherence percentage for this user, in the scale of 0 - 100.</param>
    /// <param name="ConformancePercentage">Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period..</param>
    public HistoricalAdherenceDayMetrics(int? DayStartOffsetSecs = null, int? AdherenceScheduleSecs = null, int? ConformanceScheduleSecs = null, int? ConformanceActualSecs = null, int? ExceptionCount = null, int? ExceptionDurationSecs = null, int? ImpactSeconds = null, int? ScheduleLengthSecs = null, int? ActualLengthSecs = null, double? AdherencePercentage = null, double? ConformancePercentage = null)
    {
        this.DayStartOffsetSecs = DayStartOffsetSecs;
        this.AdherenceScheduleSecs = AdherenceScheduleSecs;
        this.ConformanceScheduleSecs = ConformanceScheduleSecs;
        this.ConformanceActualSecs = ConformanceActualSecs;
        this.ExceptionCount = ExceptionCount;
        this.ExceptionDurationSecs = ExceptionDurationSecs;
        this.ImpactSeconds = ImpactSeconds;
        this.ScheduleLengthSecs = ScheduleLengthSecs;
        this.ActualLengthSecs = ActualLengthSecs;
        this.AdherencePercentage = AdherencePercentage;
        this.ConformancePercentage = ConformancePercentage;

    }



    /// <summary>
    /// Start of day offset in seconds relative to query start time
    /// </summary>
    /// <value>Start of day offset in seconds relative to query start time</value>
    [DataMember(Name = "dayStartOffsetSecs", EmitDefaultValue = false)]
    public int? DayStartOffsetSecs { get; set; }



    /// <summary>
    /// Duration of schedule in seconds included for adherence percentage calculation
    /// </summary>
    /// <value>Duration of schedule in seconds included for adherence percentage calculation</value>
    [DataMember(Name = "adherenceScheduleSecs", EmitDefaultValue = false)]
    public int? AdherenceScheduleSecs { get; set; }



    /// <summary>
    /// Total scheduled duration in seconds for OnQueue activities
    /// </summary>
    /// <value>Total scheduled duration in seconds for OnQueue activities</value>
    [DataMember(Name = "conformanceScheduleSecs", EmitDefaultValue = false)]
    public int? ConformanceScheduleSecs { get; set; }



    /// <summary>
    /// Total actually worked duration in seconds for OnQueue activities
    /// </summary>
    /// <value>Total actually worked duration in seconds for OnQueue activities</value>
    [DataMember(Name = "conformanceActualSecs", EmitDefaultValue = false)]
    public int? ConformanceActualSecs { get; set; }



    /// <summary>
    /// Total number of adherence exceptions for this user
    /// </summary>
    /// <value>Total number of adherence exceptions for this user</value>
    [DataMember(Name = "exceptionCount", EmitDefaultValue = false)]
    public int? ExceptionCount { get; set; }



    /// <summary>
    /// Total duration in seconds of adherence exceptions for this user
    /// </summary>
    /// <value>Total duration in seconds of adherence exceptions for this user</value>
    [DataMember(Name = "exceptionDurationSecs", EmitDefaultValue = false)]
    public int? ExceptionDurationSecs { get; set; }



    /// <summary>
    /// The impact duration in seconds of current adherence state for this user
    /// </summary>
    /// <value>The impact duration in seconds of current adherence state for this user</value>
    [DataMember(Name = "impactSeconds", EmitDefaultValue = false)]
    public int? ImpactSeconds { get; set; }



    /// <summary>
    /// Total duration in seconds for all scheduled activities
    /// </summary>
    /// <value>Total duration in seconds for all scheduled activities</value>
    [DataMember(Name = "scheduleLengthSecs", EmitDefaultValue = false)]
    public int? ScheduleLengthSecs { get; set; }



    /// <summary>
    /// Total duration in seconds for all actually worked activities
    /// </summary>
    /// <value>Total duration in seconds for all actually worked activities</value>
    [DataMember(Name = "actualLengthSecs", EmitDefaultValue = false)]
    public int? ActualLengthSecs { get; set; }



    /// <summary>
    /// Total adherence percentage for this user, in the scale of 0 - 100
    /// </summary>
    /// <value>Total adherence percentage for this user, in the scale of 0 - 100</value>
    [DataMember(Name = "adherencePercentage", EmitDefaultValue = false)]
    public double? AdherencePercentage { get; set; }



    /// <summary>
    /// Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.
    /// </summary>
    /// <value>Total conformance percentage for this user, in the scale of 0 - 100. Conformance percentage can be greater than 100 when the actual on queue time is greater than the scheduled on queue time for the same period.</value>
    [DataMember(Name = "conformancePercentage", EmitDefaultValue = false)]
    public double? ConformancePercentage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoricalAdherenceDayMetrics {\n");

        sb.Append("  DayStartOffsetSecs: ").Append(DayStartOffsetSecs).Append("\n");
        sb.Append("  AdherenceScheduleSecs: ").Append(AdherenceScheduleSecs).Append("\n");
        sb.Append("  ConformanceScheduleSecs: ").Append(ConformanceScheduleSecs).Append("\n");
        sb.Append("  ConformanceActualSecs: ").Append(ConformanceActualSecs).Append("\n");
        sb.Append("  ExceptionCount: ").Append(ExceptionCount).Append("\n");
        sb.Append("  ExceptionDurationSecs: ").Append(ExceptionDurationSecs).Append("\n");
        sb.Append("  ImpactSeconds: ").Append(ImpactSeconds).Append("\n");
        sb.Append("  ScheduleLengthSecs: ").Append(ScheduleLengthSecs).Append("\n");
        sb.Append("  ActualLengthSecs: ").Append(ActualLengthSecs).Append("\n");
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
        return Equals(obj as HistoricalAdherenceDayMetrics);
    }

    /// <summary>
    /// Returns true if HistoricalAdherenceDayMetrics instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoricalAdherenceDayMetrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoricalAdherenceDayMetrics other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DayStartOffsetSecs == other.DayStartOffsetSecs ||
                DayStartOffsetSecs != null &&
                DayStartOffsetSecs.Equals(other.DayStartOffsetSecs)
            ) &&
            (
                AdherenceScheduleSecs == other.AdherenceScheduleSecs ||
                AdherenceScheduleSecs != null &&
                AdherenceScheduleSecs.Equals(other.AdherenceScheduleSecs)
            ) &&
            (
                ConformanceScheduleSecs == other.ConformanceScheduleSecs ||
                ConformanceScheduleSecs != null &&
                ConformanceScheduleSecs.Equals(other.ConformanceScheduleSecs)
            ) &&
            (
                ConformanceActualSecs == other.ConformanceActualSecs ||
                ConformanceActualSecs != null &&
                ConformanceActualSecs.Equals(other.ConformanceActualSecs)
            ) &&
            (
                ExceptionCount == other.ExceptionCount ||
                ExceptionCount != null &&
                ExceptionCount.Equals(other.ExceptionCount)
            ) &&
            (
                ExceptionDurationSecs == other.ExceptionDurationSecs ||
                ExceptionDurationSecs != null &&
                ExceptionDurationSecs.Equals(other.ExceptionDurationSecs)
            ) &&
            (
                ImpactSeconds == other.ImpactSeconds ||
                ImpactSeconds != null &&
                ImpactSeconds.Equals(other.ImpactSeconds)
            ) &&
            (
                ScheduleLengthSecs == other.ScheduleLengthSecs ||
                ScheduleLengthSecs != null &&
                ScheduleLengthSecs.Equals(other.ScheduleLengthSecs)
            ) &&
            (
                ActualLengthSecs == other.ActualLengthSecs ||
                ActualLengthSecs != null &&
                ActualLengthSecs.Equals(other.ActualLengthSecs)
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
            if (DayStartOffsetSecs != null)
            {
                hash = hash * 59 + DayStartOffsetSecs.GetHashCode();
            }

            if (AdherenceScheduleSecs != null)
            {
                hash = hash * 59 + AdherenceScheduleSecs.GetHashCode();
            }

            if (ConformanceScheduleSecs != null)
            {
                hash = hash * 59 + ConformanceScheduleSecs.GetHashCode();
            }

            if (ConformanceActualSecs != null)
            {
                hash = hash * 59 + ConformanceActualSecs.GetHashCode();
            }

            if (ExceptionCount != null)
            {
                hash = hash * 59 + ExceptionCount.GetHashCode();
            }

            if (ExceptionDurationSecs != null)
            {
                hash = hash * 59 + ExceptionDurationSecs.GetHashCode();
            }

            if (ImpactSeconds != null)
            {
                hash = hash * 59 + ImpactSeconds.GetHashCode();
            }

            if (ScheduleLengthSecs != null)
            {
                hash = hash * 59 + ScheduleLengthSecs.GetHashCode();
            }

            if (ActualLengthSecs != null)
            {
                hash = hash * 59 + ActualLengthSecs.GetHashCode();
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
