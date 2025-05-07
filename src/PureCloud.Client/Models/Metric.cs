using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Metric
/// </summary>

public partial class Metric : IEquatable<Metric>
{
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    
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
    [JsonPropertyName("timeDisplayUnit")]
    public TimeDisplayUnitEnum? TimeDisplayUnit { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Metric" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Metric() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Metric" /> class.
    /// </summary>
    /// <param name="Name">The name of this metric (required).</param>
    /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
    /// <param name="ExternalMetricDefinitionId">The id of associated external metric definition.</param>
    /// <param name="Objective">Associated objective for this metric.</param>
    /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
    /// <param name="TimeDisplayUnit">The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values.</param>
    public Metric(string Name = null, string MetricDefinitionId = null, string ExternalMetricDefinitionId = null, Objective Objective = null, string PerformanceProfileId = null, TimeDisplayUnitEnum? TimeDisplayUnit = null)
    {
        this.Name = Name;
        this.MetricDefinitionId = MetricDefinitionId;
        this.ExternalMetricDefinitionId = ExternalMetricDefinitionId;
        this.Objective = Objective;
        this.PerformanceProfileId = PerformanceProfileId;
        this.TimeDisplayUnit = TimeDisplayUnit;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of this metric
    /// </summary>
    /// <value>The name of this metric</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The id of associated metric definition
    /// </summary>
    /// <value>The id of associated metric definition</value>
    [JsonPropertyName("metricDefinitionId")]
    public string MetricDefinitionId { get; set; }



    /// <summary>
    /// The id of associated external metric definition
    /// </summary>
    /// <value>The id of associated external metric definition</value>
    [JsonPropertyName("externalMetricDefinitionId")]
    public string ExternalMetricDefinitionId { get; set; }



    /// <summary>
    /// Associated objective for this metric
    /// </summary>
    /// <value>Associated objective for this metric</value>
    [JsonPropertyName("objective")]
    public Objective Objective { get; set; }



    /// <summary>
    /// Performance profile id of this metric
    /// </summary>
    /// <value>Performance profile id of this metric</value>
    [JsonPropertyName("performanceProfileId")]
    public string PerformanceProfileId { get; set; }



    /// <summary>
    /// The linked metric entity reference
    /// </summary>
    /// <value>The linked metric entity reference</value>
    [JsonPropertyName("linkedMetric")]
    public AddressableEntityRef LinkedMetric { get; set; }



    /// <summary>
    /// The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateUnlinked")]
    public string DateUnlinked { get; set; }



    /// <summary>
    /// The precision of the metric, must be between 0 and 5
    /// </summary>
    /// <value>The precision of the metric, must be between 0 and 5</value>
    [JsonPropertyName("precision")]
    public int? Precision { get; set; }





    /// <summary>
    /// The source performance profile when this metric is linked
    /// </summary>
    /// <value>The source performance profile when this metric is linked</value>
    [JsonPropertyName("sourcePerformanceProfile")]
    public PerformanceProfile SourcePerformanceProfile { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Metric {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
        sb.Append("  ExternalMetricDefinitionId: ").Append(ExternalMetricDefinitionId).Append("\n");
        sb.Append("  Objective: ").Append(Objective).Append("\n");
        sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
        sb.Append("  LinkedMetric: ").Append(LinkedMetric).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateUnlinked: ").Append(DateUnlinked).Append("\n");
        sb.Append("  Precision: ").Append(Precision).Append("\n");
        sb.Append("  TimeDisplayUnit: ").Append(TimeDisplayUnit).Append("\n");
        sb.Append("  SourcePerformanceProfile: ").Append(SourcePerformanceProfile).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as Metric);
    }

    /// <summary>
    /// Returns true if Metric instances are equal
    /// </summary>
    /// <param name="other">Instance of Metric to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Metric other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
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
                LinkedMetric == other.LinkedMetric ||
                LinkedMetric != null &&
                LinkedMetric.Equals(other.LinkedMetric)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateUnlinked == other.DateUnlinked ||
                DateUnlinked != null &&
                DateUnlinked.Equals(other.DateUnlinked)
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
            ) &&
            (
                SourcePerformanceProfile == other.SourcePerformanceProfile ||
                SourcePerformanceProfile != null &&
                SourcePerformanceProfile.Equals(other.SourcePerformanceProfile)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

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

            if (LinkedMetric != null)
            {
                hash = hash * 59 + LinkedMetric.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateUnlinked != null)
            {
                hash = hash * 59 + DateUnlinked.GetHashCode();
            }

            if (Precision != null)
            {
                hash = hash * 59 + Precision.GetHashCode();
            }

            if (TimeDisplayUnit != null)
            {
                hash = hash * 59 + TimeDisplayUnit.GetHashCode();
            }

            if (SourcePerformanceProfile != null)
            {
                hash = hash * 59 + SourcePerformanceProfile.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
