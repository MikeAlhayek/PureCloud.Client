using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateMetric
/// </summary>
[DataContract]
public partial class CreateMetric : IEquatable<CreateMetric>
{
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TimeDisplayUnitEnum
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
        /// Enum Seconds for "Seconds"
        /// </summary>
        [EnumMember(Value = "Seconds")]
        Seconds,

        /// <summary>
        /// Enum Minutes for "Minutes"
        /// </summary>
        [EnumMember(Value = "Minutes")]
        Minutes,

        /// <summary>
        /// Enum Hours for "Hours"
        /// </summary>
        [EnumMember(Value = "Hours")]
        Hours
    }
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    [DataMember(Name = "timeDisplayUnit", EmitDefaultValue = false)]
    public TimeDisplayUnitEnum? TimeDisplayUnit { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateMetric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateMetric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateMetric" /> class.
    /// </summary>
    /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
    /// <param name="ExternalMetricDefinitionId">The id of associated external metric definition.</param>
    /// <param name="Objective">Associated objective for this metric.</param>
    /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
    /// <param name="Name">The name of this metric (required).</param>
    /// <param name="Precision">The precision of the metric, must be between 0 and 5.</param>
    /// <param name="TimeDisplayUnit">The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values.</param>
    public CreateMetric(string MetricDefinitionId = null, string ExternalMetricDefinitionId = null, CreateObjective Objective = null, string PerformanceProfileId = null, string Name = null, int? Precision = null, TimeDisplayUnitEnum? TimeDisplayUnit = null)
    {
        this.MetricDefinitionId = MetricDefinitionId;
        this.ExternalMetricDefinitionId = ExternalMetricDefinitionId;
        this.Objective = Objective;
        this.PerformanceProfileId = PerformanceProfileId;
        this.Name = Name;
        this.Precision = Precision;
        this.TimeDisplayUnit = TimeDisplayUnit;

    }



    /// <summary>
    /// The id of associated metric definition
    /// </summary>
    /// <value>The id of associated metric definition</value>
    [DataMember(Name = "metricDefinitionId", EmitDefaultValue = false)]
    public string MetricDefinitionId { get; set; }



    /// <summary>
    /// The id of associated external metric definition
    /// </summary>
    /// <value>The id of associated external metric definition</value>
    [DataMember(Name = "externalMetricDefinitionId", EmitDefaultValue = false)]
    public string ExternalMetricDefinitionId { get; set; }



    /// <summary>
    /// Associated objective for this metric
    /// </summary>
    /// <value>Associated objective for this metric</value>
    [DataMember(Name = "objective", EmitDefaultValue = false)]
    public CreateObjective Objective { get; set; }



    /// <summary>
    /// Performance profile id of this metric
    /// </summary>
    /// <value>Performance profile id of this metric</value>
    [DataMember(Name = "performanceProfileId", EmitDefaultValue = false)]
    public string PerformanceProfileId { get; set; }



    /// <summary>
    /// The name of this metric
    /// </summary>
    /// <value>The name of this metric</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The precision of the metric, must be between 0 and 5
    /// </summary>
    /// <value>The precision of the metric, must be between 0 and 5</value>
    [DataMember(Name = "precision", EmitDefaultValue = false)]
    public int? Precision { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateMetric {\n");

        sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
        sb.Append("  ExternalMetricDefinitionId: ").Append(ExternalMetricDefinitionId).Append("\n");
        sb.Append("  Objective: ").Append(Objective).Append("\n");
        sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Precision: ").Append(Precision).Append("\n");
        sb.Append("  TimeDisplayUnit: ").Append(TimeDisplayUnit).Append("\n");
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
        return Equals(obj as CreateMetric);
    }

    /// <summary>
    /// Returns true if CreateMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateMetric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateMetric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MetricDefinitionId == other.MetricDefinitionId ||
                MetricDefinitionId != null &&
                MetricDefinitionId.Equals(other.MetricDefinitionId)
            ) &&
            (
                ExternalMetricDefinitionId == other.ExternalMetricDefinitionId ||
                ExternalMetricDefinitionId != null &&
                ExternalMetricDefinitionId.Equals(other.ExternalMetricDefinitionId)
            ) &&
            (
                Objective == other.Objective ||
                Objective != null &&
                Objective.Equals(other.Objective)
            ) &&
            (
                PerformanceProfileId == other.PerformanceProfileId ||
                PerformanceProfileId != null &&
                PerformanceProfileId.Equals(other.PerformanceProfileId)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Precision == other.Precision ||
                Precision != null &&
                Precision.Equals(other.Precision)
            ) &&
            (
                TimeDisplayUnit == other.TimeDisplayUnit ||
                TimeDisplayUnit != null &&
                TimeDisplayUnit.Equals(other.TimeDisplayUnit)
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
            if (MetricDefinitionId != null)
            {
                hash = hash * 59 + MetricDefinitionId.GetHashCode();
            }

            if (ExternalMetricDefinitionId != null)
            {
                hash = hash * 59 + ExternalMetricDefinitionId.GetHashCode();
            }

            if (Objective != null)
            {
                hash = hash * 59 + Objective.GetHashCode();
            }

            if (PerformanceProfileId != null)
            {
                hash = hash * 59 + PerformanceProfileId.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Precision != null)
            {
                hash = hash * 59 + Precision.GetHashCode();
            }

            if (TimeDisplayUnit != null)
            {
                hash = hash * 59 + TimeDisplayUnit.GetHashCode();
            }

            return hash;
        }
    }
}
