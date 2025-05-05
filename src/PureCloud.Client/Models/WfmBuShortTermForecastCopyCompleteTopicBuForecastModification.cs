using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmBuShortTermForecastCopyCompleteTopicBuForecastModification
/// </summary>

public partial class WfmBuShortTermForecastCopyCompleteTopicBuForecastModification : IEquatable<WfmBuShortTermForecastCopyCompleteTopicBuForecastModification>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Minimumperinterval for "MinimumPerInterval"
        /// </summary>
        [EnumMember(Value = "MinimumPerInterval")]
        Minimumperinterval,

        /// <summary>
        /// Enum Maximumperinterval for "MaximumPerInterval"
        /// </summary>
        [EnumMember(Value = "MaximumPerInterval")]
        Maximumperinterval,

        /// <summary>
        /// Enum Setvalueperinterval for "SetValuePerInterval"
        /// </summary>
        [EnumMember(Value = "SetValuePerInterval")]
        Setvalueperinterval,

        /// <summary>
        /// Enum Changevalueperinterval for "ChangeValuePerInterval"
        /// </summary>
        [EnumMember(Value = "ChangeValuePerInterval")]
        Changevalueperinterval,

        /// <summary>
        /// Enum Changepercentperinterval for "ChangePercentPerInterval"
        /// </summary>
        [EnumMember(Value = "ChangePercentPerInterval")]
        Changepercentperinterval,

        /// <summary>
        /// Enum Setvalueoverrange for "SetValueOverRange"
        /// </summary>
        [EnumMember(Value = "SetValueOverRange")]
        Setvalueoverrange,

        /// <summary>
        /// Enum Changevalueoverrange for "ChangeValueOverRange"
        /// </summary>
        [EnumMember(Value = "ChangeValueOverRange")]
        Changevalueoverrange,

        /// <summary>
        /// Enum Setvaluesforintervalset for "SetValuesForIntervalSet"
        /// </summary>
        [EnumMember(Value = "SetValuesForIntervalSet")]
        Setvaluesforintervalset,

        /// <summary>
        /// Enum Setmultigranularityvaluesforintervalset for "SetMultiGranularityValuesForIntervalSet"
        /// </summary>
        [EnumMember(Value = "SetMultiGranularityValuesForIntervalSet")]
        Setmultigranularityvaluesforintervalset
    }
    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Offered for "Offered"
        /// </summary>
        [EnumMember(Value = "Offered")]
        Offered,

        /// <summary>
        /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
        /// </summary>
        [EnumMember(Value = "AverageHandleTimeSeconds")]
        Averagehandletimeseconds
    }
    /// <summary>
    /// Gets or Sets LegacyMetric
    /// </summary>
    
    public enum LegacyMetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Averageaftercallworktimeseconds for "AverageAfterCallWorkTimeSeconds"
        /// </summary>
        [EnumMember(Value = "AverageAfterCallWorkTimeSeconds")]
        Averageaftercallworktimeseconds,

        /// <summary>
        /// Enum Averagehandletimeseconds for "AverageHandleTimeSeconds"
        /// </summary>
        [EnumMember(Value = "AverageHandleTimeSeconds")]
        Averagehandletimeseconds,

        /// <summary>
        /// Enum Averagetalktimeseconds for "AverageTalkTimeSeconds"
        /// </summary>
        [EnumMember(Value = "AverageTalkTimeSeconds")]
        Averagetalktimeseconds,

        /// <summary>
        /// Enum Offered for "Offered"
        /// </summary>
        [EnumMember(Value = "Offered")]
        Offered
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets Metric
    /// </summary>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Gets or Sets LegacyMetric
    /// </summary>
    [JsonPropertyName("legacyMetric")]
    public LegacyMetricEnum? LegacyMetric { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmBuShortTermForecastCopyCompleteTopicBuForecastModification" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="StartIntervalIndex">StartIntervalIndex.</param>
    /// <param name="EndIntervalIndex">EndIntervalIndex.</param>
    /// <param name="Metric">Metric.</param>
    /// <param name="LegacyMetric">LegacyMetric.</param>
    /// <param name="Value">Value.</param>
    /// <param name="Values">Values.</param>
    /// <param name="SecondaryValues">SecondaryValues.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="Granularity">Granularity.</param>
    /// <param name="SecondaryGranularity">SecondaryGranularity.</param>
    /// <param name="DisplayGranularity">DisplayGranularity.</param>
    /// <param name="PlanningGroupIds">PlanningGroupIds.</param>
    public WfmBuShortTermForecastCopyCompleteTopicBuForecastModification(TypeEnum? Type = null, long? StartIntervalIndex = null, long? EndIntervalIndex = null, MetricEnum? Metric = null, LegacyMetricEnum? LegacyMetric = null, double? Value = null, List<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> Values = null, List<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> SecondaryValues = null, bool? Enabled = null, string Granularity = null, string SecondaryGranularity = null, string DisplayGranularity = null, List<string> PlanningGroupIds = null)
    {
        this.Type = Type;
        this.StartIntervalIndex = StartIntervalIndex;
        this.EndIntervalIndex = EndIntervalIndex;
        this.Metric = Metric;
        this.LegacyMetric = LegacyMetric;
        this.Value = Value;
        this.Values = Values;
        this.SecondaryValues = SecondaryValues;
        this.Enabled = Enabled;
        this.Granularity = Granularity;
        this.SecondaryGranularity = SecondaryGranularity;
        this.DisplayGranularity = DisplayGranularity;
        this.PlanningGroupIds = PlanningGroupIds;

    }





    /// <summary>
    /// Gets or Sets StartIntervalIndex
    /// </summary>
    [JsonPropertyName("startIntervalIndex")]
    public long? StartIntervalIndex { get; set; }



    /// <summary>
    /// Gets or Sets EndIntervalIndex
    /// </summary>
    [JsonPropertyName("endIntervalIndex")]
    public long? EndIntervalIndex { get; set; }







    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonPropertyName("values")]
    public List<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> Values { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryValues
    /// </summary>
    [JsonPropertyName("secondaryValues")]
    public List<WfmBuShortTermForecastCopyCompleteTopicModificationIntervalOffsetValue> SecondaryValues { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets Granularity
    /// </summary>
    [JsonPropertyName("granularity")]
    public string Granularity { get; set; }



    /// <summary>
    /// Gets or Sets SecondaryGranularity
    /// </summary>
    [JsonPropertyName("secondaryGranularity")]
    public string SecondaryGranularity { get; set; }



    /// <summary>
    /// Gets or Sets DisplayGranularity
    /// </summary>
    [JsonPropertyName("displayGranularity")]
    public string DisplayGranularity { get; set; }



    /// <summary>
    /// Gets or Sets PlanningGroupIds
    /// </summary>
    [JsonPropertyName("planningGroupIds")]
    public List<string> PlanningGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmBuShortTermForecastCopyCompleteTopicBuForecastModification {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  StartIntervalIndex: ").Append(StartIntervalIndex).Append("\n");
        sb.Append("  EndIntervalIndex: ").Append(EndIntervalIndex).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  LegacyMetric: ").Append(LegacyMetric).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  SecondaryValues: ").Append(SecondaryValues).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  SecondaryGranularity: ").Append(SecondaryGranularity).Append("\n");
        sb.Append("  DisplayGranularity: ").Append(DisplayGranularity).Append("\n");
        sb.Append("  PlanningGroupIds: ").Append(PlanningGroupIds).Append("\n");
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
        return Equals(obj as WfmBuShortTermForecastCopyCompleteTopicBuForecastModification);
    }

    /// <summary>
    /// Returns true if WfmBuShortTermForecastCopyCompleteTopicBuForecastModification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmBuShortTermForecastCopyCompleteTopicBuForecastModification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmBuShortTermForecastCopyCompleteTopicBuForecastModification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                StartIntervalIndex == other.StartIntervalIndex ||
                StartIntervalIndex != null &&
                StartIntervalIndex.Equals(other.StartIntervalIndex)
            ) &&
            (
                EndIntervalIndex == other.EndIntervalIndex ||
                EndIntervalIndex != null &&
                EndIntervalIndex.Equals(other.EndIntervalIndex)
            ) &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                LegacyMetric == other.LegacyMetric ||
                LegacyMetric != null &&
                LegacyMetric.Equals(other.LegacyMetric)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                SecondaryValues == other.SecondaryValues ||
                SecondaryValues != null &&
                SecondaryValues.SequenceEqual(other.SecondaryValues)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                Granularity == other.Granularity ||
                Granularity != null &&
                Granularity.Equals(other.Granularity)
            ) &&
            (
                SecondaryGranularity == other.SecondaryGranularity ||
                SecondaryGranularity != null &&
                SecondaryGranularity.Equals(other.SecondaryGranularity)
            ) &&
            (
                DisplayGranularity == other.DisplayGranularity ||
                DisplayGranularity != null &&
                DisplayGranularity.Equals(other.DisplayGranularity)
            ) &&
            (
                PlanningGroupIds == other.PlanningGroupIds ||
                PlanningGroupIds != null &&
                PlanningGroupIds.SequenceEqual(other.PlanningGroupIds)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (StartIntervalIndex != null)
            {
                hash = hash * 59 + StartIntervalIndex.GetHashCode();
            }

            if (EndIntervalIndex != null)
            {
                hash = hash * 59 + EndIntervalIndex.GetHashCode();
            }

            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (LegacyMetric != null)
            {
                hash = hash * 59 + LegacyMetric.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (SecondaryValues != null)
            {
                hash = hash * 59 + SecondaryValues.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (SecondaryGranularity != null)
            {
                hash = hash * 59 + SecondaryGranularity.GetHashCode();
            }

            if (DisplayGranularity != null)
            {
                hash = hash * 59 + DisplayGranularity.GetHashCode();
            }

            if (PlanningGroupIds != null)
            {
                hash = hash * 59 + PlanningGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
