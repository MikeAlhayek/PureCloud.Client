using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BuForecastModificationResponse
/// </summary>

public partial class BuForecastModificationResponse : IEquatable<BuForecastModificationResponse>
{
    /// <summary>
    /// The type of the modification
    /// </summary>
    /// <value>The type of the modification</value>
    
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
    /// The metric to which this modification applies
    /// </summary>
    /// <value>The metric to which this modification applies</value>
    
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
    /// The legacy metric to which this modification applies if applicable
    /// </summary>
    /// <value>The legacy metric to which this modification applies if applicable</value>
    
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
    /// The type of the modification
    /// </summary>
    /// <value>The type of the modification</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The metric to which this modification applies
    /// </summary>
    /// <value>The metric to which this modification applies</value>
    [JsonPropertyName("metric")]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// The legacy metric to which this modification applies if applicable
    /// </summary>
    /// <value>The legacy metric to which this modification applies if applicable</value>
    [JsonPropertyName("legacyMetric")]
    public LegacyMetricEnum? LegacyMetric { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastModificationResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BuForecastModificationResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="BuForecastModificationResponse" /> class.
    /// </summary>
    /// <param name="Type">The type of the modification (required).</param>
    /// <param name="StartIntervalIndex">The number of intervals past referenceStartDate representing the first interval to which this modification applies.</param>
    /// <param name="EndIntervalIndex">The number of intervals past referenceStartDate representing the last interval to which this modification applies.</param>
    /// <param name="Metric">The metric to which this modification applies (required).</param>
    /// <param name="LegacyMetric">The legacy metric to which this modification applies if applicable.</param>
    /// <param name="Value">The value of the modification.</param>
    /// <param name="Values">The list of modification values. Only applicable for grid-type modifications (required).</param>
    /// <param name="SecondaryValues">The list of modification secondary values. Only applicable for multi granularity modifications.</param>
    /// <param name="DisplayGranularity">The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
    /// <param name="Granularity">The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H (required).</param>
    /// <param name="SecondaryGranularity">The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H.</param>
    /// <param name="Enabled">Whether the modification is enabled for the forecast (required).</param>
    /// <param name="PlanningGroupIds">The IDs of the planning groups to which this forecast modification applies (required).</param>
    public BuForecastModificationResponse(TypeEnum? Type = null, int? StartIntervalIndex = null, int? EndIntervalIndex = null, MetricEnum? Metric = null, LegacyMetricEnum? LegacyMetric = null, double? Value = null, List<WfmForecastModificationIntervalOffsetValue> Values = null, List<WfmForecastModificationIntervalOffsetValue> SecondaryValues = null, string DisplayGranularity = null, string Granularity = null, string SecondaryGranularity = null, bool? Enabled = null, List<string> PlanningGroupIds = null)
    {
        this.Type = Type;
        this.StartIntervalIndex = StartIntervalIndex;
        this.EndIntervalIndex = EndIntervalIndex;
        this.Metric = Metric;
        this.LegacyMetric = LegacyMetric;
        this.Value = Value;
        this.Values = Values;
        this.SecondaryValues = SecondaryValues;
        this.DisplayGranularity = DisplayGranularity;
        this.Granularity = Granularity;
        this.SecondaryGranularity = SecondaryGranularity;
        this.Enabled = Enabled;
        this.PlanningGroupIds = PlanningGroupIds;

    }





    /// <summary>
    /// The number of intervals past referenceStartDate representing the first interval to which this modification applies
    /// </summary>
    /// <value>The number of intervals past referenceStartDate representing the first interval to which this modification applies</value>
    [JsonPropertyName("startIntervalIndex")]
    public int? StartIntervalIndex { get; set; }



    /// <summary>
    /// The number of intervals past referenceStartDate representing the last interval to which this modification applies
    /// </summary>
    /// <value>The number of intervals past referenceStartDate representing the last interval to which this modification applies</value>
    [JsonPropertyName("endIntervalIndex")]
    public int? EndIntervalIndex { get; set; }







    /// <summary>
    /// The value of the modification
    /// </summary>
    /// <value>The value of the modification</value>
    [JsonPropertyName("value")]
    public double? Value { get; set; }



    /// <summary>
    /// The list of modification values. Only applicable for grid-type modifications
    /// </summary>
    /// <value>The list of modification values. Only applicable for grid-type modifications</value>
    [JsonPropertyName("values")]
    public List<WfmForecastModificationIntervalOffsetValue> Values { get; set; }



    /// <summary>
    /// The list of modification secondary values. Only applicable for multi granularity modifications
    /// </summary>
    /// <value>The list of modification secondary values. Only applicable for multi granularity modifications</value>
    [JsonPropertyName("secondaryValues")]
    public List<WfmForecastModificationIntervalOffsetValue> SecondaryValues { get; set; }



    /// <summary>
    /// The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>The client side display granularity of the modification, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("displayGranularity")]
    public string DisplayGranularity { get; set; }



    /// <summary>
    /// The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>The actual granularity of the modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("granularity")]
    public string Granularity { get; set; }



    /// <summary>
    /// The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H
    /// </summary>
    /// <value>The granularity of the &#39;secondaryValues&#39; modification as stored behind the scenes, expressed in the ISO-8601 duration format. Periods are represented as an ISO-8601 string. For example: P1D or P1DT12H</value>
    [JsonPropertyName("secondaryGranularity")]
    public string SecondaryGranularity { get; set; }



    /// <summary>
    /// Whether the modification is enabled for the forecast
    /// </summary>
    /// <value>Whether the modification is enabled for the forecast</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The IDs of the planning groups to which this forecast modification applies
    /// </summary>
    /// <value>The IDs of the planning groups to which this forecast modification applies</value>
    [JsonPropertyName("planningGroupIds")]
    public List<string> PlanningGroupIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BuForecastModificationResponse {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  StartIntervalIndex: ").Append(StartIntervalIndex).Append("\n");
        sb.Append("  EndIntervalIndex: ").Append(EndIntervalIndex).Append("\n");
        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  LegacyMetric: ").Append(LegacyMetric).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  SecondaryValues: ").Append(SecondaryValues).Append("\n");
        sb.Append("  DisplayGranularity: ").Append(DisplayGranularity).Append("\n");
        sb.Append("  Granularity: ").Append(Granularity).Append("\n");
        sb.Append("  SecondaryGranularity: ").Append(SecondaryGranularity).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return Equals(obj as BuForecastModificationResponse);
    }

    /// <summary>
    /// Returns true if BuForecastModificationResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of BuForecastModificationResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BuForecastModificationResponse other)
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
                DisplayGranularity == other.DisplayGranularity ||
                DisplayGranularity != null &&
                DisplayGranularity.Equals(other.DisplayGranularity)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
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

            if (DisplayGranularity != null)
            {
                hash = hash * 59 + DisplayGranularity.GetHashCode();
            }

            if (Granularity != null)
            {
                hash = hash * 59 + Granularity.GetHashCode();
            }

            if (SecondaryGranularity != null)
            {
                hash = hash * 59 + SecondaryGranularity.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (PlanningGroupIds != null)
            {
                hash = hash * 59 + PlanningGroupIds.GetHashCode();
            }

            return hash;
        }
    }
}
