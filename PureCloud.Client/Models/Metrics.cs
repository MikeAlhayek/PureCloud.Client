using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Metrics
/// </summary>
[DataContract]
public partial class Metrics : IEquatable<Metrics>
{
    /// <summary>
    /// Corresponding unit type for this metric
    /// </summary>
    /// <value>Corresponding unit type for this metric</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    /// Corresponding unit type for this metric
    /// </summary>
    /// <value>Corresponding unit type for this metric</value>
    [DataMember(Name = "unitType", EmitDefaultValue = false)]
    public UnitTypeEnum? UnitType { get; set; }
    /// <summary>
    /// The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values
    /// </summary>
    /// <value>The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values</value>
    [DataMember(Name = "timeDisplayUnit", EmitDefaultValue = false)]
    public TimeDisplayUnitEnum? TimeDisplayUnit { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Metrics" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Order">The order of metric within a performance profile.</param>
    /// <param name="MetricDefinitionName">The name of associated metric definition.</param>
    /// <param name="MetricDefinitionId">The id of associated metric definition.</param>
    /// <param name="ExternalMetricDefinitionId">The id of associated external metric definition.</param>
    /// <param name="UnitType">Corresponding unit type for this metric.</param>
    /// <param name="Enabled">A flag for whether this metric is enabled for a performance profile.</param>
    /// <param name="TemplateName">The name of associated objective template.</param>
    /// <param name="MaxPoints">Achievable maximum points for this metric.</param>
    /// <param name="PerformanceProfileId">Performance profile id of this metric.</param>
    /// <param name="TimeDisplayUnit">The time unit in which the metric should be displayed - - this parameter is ignored when displaying non-time values.</param>
    public Metrics(string Name = null, int? Order = null, string MetricDefinitionName = null, string MetricDefinitionId = null, string ExternalMetricDefinitionId = null, UnitTypeEnum? UnitType = null, bool? Enabled = null, string TemplateName = null, int? MaxPoints = null, string PerformanceProfileId = null, TimeDisplayUnitEnum? TimeDisplayUnit = null)
    {
        this.Name = Name;
        this.Order = Order;
        this.MetricDefinitionName = MetricDefinitionName;
        this.MetricDefinitionId = MetricDefinitionId;
        this.ExternalMetricDefinitionId = ExternalMetricDefinitionId;
        this.UnitType = UnitType;
        this.Enabled = Enabled;
        this.TemplateName = TemplateName;
        this.MaxPoints = MaxPoints;
        this.PerformanceProfileId = PerformanceProfileId;
        this.TimeDisplayUnit = TimeDisplayUnit;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The order of metric within a performance profile
    /// </summary>
    /// <value>The order of metric within a performance profile</value>
    [DataMember(Name = "order", EmitDefaultValue = false)]
    public int? Order { get; set; }



    /// <summary>
    /// The name of associated metric definition
    /// </summary>
    /// <value>The name of associated metric definition</value>
    [DataMember(Name = "metricDefinitionName", EmitDefaultValue = false)]
    public string MetricDefinitionName { get; set; }



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
    /// A flag for whether this metric is enabled for a performance profile
    /// </summary>
    /// <value>A flag for whether this metric is enabled for a performance profile</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// The name of associated objective template
    /// </summary>
    /// <value>The name of associated objective template</value>
    [DataMember(Name = "templateName", EmitDefaultValue = false)]
    public string TemplateName { get; set; }



    /// <summary>
    /// Achievable maximum points for this metric
    /// </summary>
    /// <value>Achievable maximum points for this metric</value>
    [DataMember(Name = "maxPoints", EmitDefaultValue = false)]
    public int? MaxPoints { get; set; }



    /// <summary>
    /// Performance profile id of this metric
    /// </summary>
    /// <value>Performance profile id of this metric</value>
    [DataMember(Name = "performanceProfileId", EmitDefaultValue = false)]
    public string PerformanceProfileId { get; set; }



    /// <summary>
    /// The linked metric entity reference
    /// </summary>
    /// <value>The linked metric entity reference</value>
    [DataMember(Name = "linkedMetric", EmitDefaultValue = false)]
    public AddressableEntityRef LinkedMetric { get; private set; }



    /// <summary>
    /// The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The created date of this metric. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>The unlinked workday for this metric if this metric was ever unlinked. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [DataMember(Name = "dateUnlinked", EmitDefaultValue = false)]
    public string DateUnlinked { get; private set; }



    /// <summary>
    /// The source performance profile when this metric is linked
    /// </summary>
    /// <value>The source performance profile when this metric is linked</value>
    [DataMember(Name = "sourcePerformanceProfile", EmitDefaultValue = false)]
    public PerformanceProfile SourcePerformanceProfile { get; private set; }



    /// <summary>
    /// Unit definition of linked external metric
    /// </summary>
    /// <value>Unit definition of linked external metric</value>
    [DataMember(Name = "unitDefinition", EmitDefaultValue = false)]
    public string UnitDefinition { get; private set; }



    /// <summary>
    /// Precision of linked external metric
    /// </summary>
    /// <value>Precision of linked external metric</value>
    [DataMember(Name = "precision", EmitDefaultValue = false)]
    public int? Precision { get; private set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Metrics {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
        sb.Append("  MetricDefinitionName: ").Append(MetricDefinitionName).Append("\n");
        sb.Append("  MetricDefinitionId: ").Append(MetricDefinitionId).Append("\n");
        sb.Append("  ExternalMetricDefinitionId: ").Append(ExternalMetricDefinitionId).Append("\n");
        sb.Append("  UnitType: ").Append(UnitType).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  PerformanceProfileId: ").Append(PerformanceProfileId).Append("\n");
        sb.Append("  LinkedMetric: ").Append(LinkedMetric).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateUnlinked: ").Append(DateUnlinked).Append("\n");
        sb.Append("  SourcePerformanceProfile: ").Append(SourcePerformanceProfile).Append("\n");
        sb.Append("  UnitDefinition: ").Append(UnitDefinition).Append("\n");
        sb.Append("  Precision: ").Append(Precision).Append("\n");
        sb.Append("  TimeDisplayUnit: ").Append(TimeDisplayUnit).Append("\n");
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
        return Equals(obj as Metrics);
    }

    /// <summary>
    /// Returns true if Metrics instances are equal
    /// </summary>
    /// <param name="other">Instance of Metrics to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Metrics other)
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
                Order == other.Order ||
                Order != null &&
                Order.Equals(other.Order)
            ) &&
            (
                MetricDefinitionName == other.MetricDefinitionName ||
                MetricDefinitionName != null &&
                MetricDefinitionName.Equals(other.MetricDefinitionName)
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
                UnitType == other.UnitType ||
                UnitType != null &&
                UnitType.Equals(other.UnitType)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                TemplateName == other.TemplateName ||
                TemplateName != null &&
                TemplateName.Equals(other.TemplateName)
            ) &&
            (
                MaxPoints == other.MaxPoints ||
                MaxPoints != null &&
                MaxPoints.Equals(other.MaxPoints)
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
                SourcePerformanceProfile == other.SourcePerformanceProfile ||
                SourcePerformanceProfile != null &&
                SourcePerformanceProfile.Equals(other.SourcePerformanceProfile)
            ) &&
            (
                UnitDefinition == other.UnitDefinition ||
                UnitDefinition != null &&
                UnitDefinition.Equals(other.UnitDefinition)
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

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            if (MetricDefinitionName != null)
            {
                hash = hash * 59 + MetricDefinitionName.GetHashCode();
            }

            if (MetricDefinitionId != null)
            {
                hash = hash * 59 + MetricDefinitionId.GetHashCode();
            }

            if (ExternalMetricDefinitionId != null)
            {
                hash = hash * 59 + ExternalMetricDefinitionId.GetHashCode();
            }

            if (UnitType != null)
            {
                hash = hash * 59 + UnitType.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (TemplateName != null)
            {
                hash = hash * 59 + TemplateName.GetHashCode();
            }

            if (MaxPoints != null)
            {
                hash = hash * 59 + MaxPoints.GetHashCode();
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

            if (SourcePerformanceProfile != null)
            {
                hash = hash * 59 + SourcePerformanceProfile.GetHashCode();
            }

            if (UnitDefinition != null)
            {
                hash = hash * 59 + UnitDefinition.GetHashCode();
            }

            if (Precision != null)
            {
                hash = hash * 59 + Precision.GetHashCode();
            }

            if (TimeDisplayUnit != null)
            {
                hash = hash * 59 + TimeDisplayUnit.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
