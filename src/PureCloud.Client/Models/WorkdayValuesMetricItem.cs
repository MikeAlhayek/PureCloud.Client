using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkdayValuesMetricItem
/// </summary>

public partial class WorkdayValuesMetricItem : IEquatable<WorkdayValuesMetricItem>
{
    /// <summary>
    /// The unit type of the metric value
    /// </summary>
    /// <value>The unit type of the metric value</value>
    
    public enum UnitTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,

        /// <summary>
        /// Enum Percent for "Percent"
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent,

        /// <summary>
        /// Enum Currency for "Currency"
        /// </summary>
        [EnumMember(Value = "Currency")]
        Currency,

        /// <summary>
        /// Enum Seconds for "Seconds"
        /// </summary>
        [EnumMember(Value = "Seconds")]
        Seconds,

        /// <summary>
        /// Enum Number for "Number"
        /// </summary>
        [EnumMember(Value = "Number")]
        Number,

        /// <summary>
        /// Enum Attendancestatus for "AttendanceStatus"
        /// </summary>
        [EnumMember(Value = "AttendanceStatus")]
        Attendancestatus,

        /// <summary>
        /// Enum Unit for "Unit"
        /// </summary>
        [EnumMember(Value = "Unit")]
        Unit
    }
    /// <summary>
    /// The unit type of the metric value
    /// </summary>
    /// <value>The unit type of the metric value</value>
    [JsonPropertyName("unitType")]
    public UnitTypeEnum? UnitType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkdayValuesMetricItem" /> class.
    /// </summary>
    public WorkdayValuesMetricItem()
    {

    }



    /// <summary>
    /// Gamification metric for the average and the trend
    /// </summary>
    /// <value>Gamification metric for the average and the trend</value>
    [JsonPropertyName("metric")]
    public AddressableEntityRef Metric { get; set; }



    /// <summary>
    /// Gamification metric definition for the average and the trend
    /// </summary>
    /// <value>Gamification metric definition for the average and the trend</value>
    [JsonPropertyName("metricDefinition")]
    public DomainEntityRef MetricDefinition { get; set; }



    /// <summary>
    /// The average value of the metric
    /// </summary>
    /// <value>The average value of the metric</value>
    [JsonPropertyName("average")]
    public double? Average { get; set; }





    /// <summary>
    /// The metric value trend
    /// </summary>
    /// <value>The metric value trend</value>
    [JsonPropertyName("trend")]
    public List<WorkdayValuesTrendItem> Trend { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkdayValuesMetricItem {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  MetricDefinition: ").Append(MetricDefinition).Append("\n");
        sb.Append("  Average: ").Append(Average).Append("\n");
        sb.Append("  UnitType: ").Append(UnitType).Append("\n");
        sb.Append("  Trend: ").Append(Trend).Append("\n");
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
        return Equals(obj as WorkdayValuesMetricItem);
    }

    /// <summary>
    /// Returns true if WorkdayValuesMetricItem instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkdayValuesMetricItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkdayValuesMetricItem other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                MetricDefinition == other.MetricDefinition ||
                MetricDefinition != null &&
                MetricDefinition.Equals(other.MetricDefinition)
            ) &&
            (
                Average == other.Average ||
                Average != null &&
                Average.Equals(other.Average)
            ) &&
            (
                UnitType == other.UnitType ||
                UnitType != null &&
                UnitType.Equals(other.UnitType)
            ) &&
            (
                Trend == other.Trend ||
                Trend != null &&
                Trend.SequenceEqual(other.Trend)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (MetricDefinition != null)
            {
                hash = hash * 59 + MetricDefinition.GetHashCode();
            }

            if (Average != null)
            {
                hash = hash * 59 + Average.GetHashCode();
            }

            if (UnitType != null)
            {
                hash = hash * 59 + UnitType.GetHashCode();
            }

            if (Trend != null)
            {
                hash = hash * 59 + Trend.GetHashCode();
            }

            return hash;
        }
    }
}
