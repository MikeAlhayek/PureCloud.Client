using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalMetricDefinition
/// </summary>
[DataContract]
public partial class ExternalMetricDefinition : IEquatable<ExternalMetricDefinition>
{
    /// <summary>
    /// The unit of the External Metric Definition
    /// </summary>
    /// <value>The unit of the External Metric Definition</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UnitEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Seconds for "Seconds"
        /// </summary>
        [EnumMember(Value = "Seconds")]
        Seconds,

        /// <summary>
        /// Enum Percent for "Percent"
        /// </summary>
        [EnumMember(Value = "Percent")]
        Percent,

        /// <summary>
        /// Enum Number for "Number"
        /// </summary>
        [EnumMember(Value = "Number")]
        Number,

        /// <summary>
        /// Enum Currency for "Currency"
        /// </summary>
        [EnumMember(Value = "Currency")]
        Currency
    }
    /// <summary>
    /// The default objective type of the External Metric Definition
    /// </summary>
    /// <value>The default objective type of the External Metric Definition</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefaultObjectiveTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Higherisbetter for "HigherIsBetter"
        /// </summary>
        [EnumMember(Value = "HigherIsBetter")]
        Higherisbetter,

        /// <summary>
        /// Enum Lowerisbetter for "LowerIsBetter"
        /// </summary>
        [EnumMember(Value = "LowerIsBetter")]
        Lowerisbetter,

        /// <summary>
        /// Enum Targetarea for "TargetArea"
        /// </summary>
        [EnumMember(Value = "TargetArea")]
        Targetarea
    }
    /// <summary>
    /// The unit of the External Metric Definition
    /// </summary>
    /// <value>The unit of the External Metric Definition</value>
    [DataMember(Name = "unit", EmitDefaultValue = false)]
    public UnitEnum? Unit { get; set; }
    /// <summary>
    /// The default objective type of the External Metric Definition
    /// </summary>
    /// <value>The default objective type of the External Metric Definition</value>
    [DataMember(Name = "defaultObjectiveType", EmitDefaultValue = false)]
    public DefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalMetricDefinition" /> class.
    /// </summary>
    /// <param name="Name">The name of the External Metric Definition.</param>
    /// <param name="Unit">The unit of the External Metric Definition.</param>
    /// <param name="UnitDefinition">The unit definition of the External Metric Definition.</param>
    /// <param name="Precision">The decimal precision of the External Metric Definition.</param>
    /// <param name="DefaultObjectiveType">The default objective type of the External Metric Definition.</param>
    /// <param name="RetentionMonths">The retention in months of the External Metric Definition.</param>
    /// <param name="Enabled">True if the External Metric Definition is enabled.</param>
    /// <param name="DateLastRefreshed">The last date and time that the metric data was refreshed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ExternalMetricDefinition(string Name = null, UnitEnum? Unit = null, string UnitDefinition = null, int? Precision = null, DefaultObjectiveTypeEnum? DefaultObjectiveType = null, int? RetentionMonths = null, bool? Enabled = null, DateTime? DateLastRefreshed = null)
    {
        this.Name = Name;
        this.Unit = Unit;
        this.UnitDefinition = UnitDefinition;
        this.Precision = Precision;
        this.DefaultObjectiveType = DefaultObjectiveType;
        this.RetentionMonths = RetentionMonths;
        this.Enabled = Enabled;
        this.DateLastRefreshed = DateLastRefreshed;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the External Metric Definition
    /// </summary>
    /// <value>The name of the External Metric Definition</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// The unit definition of the External Metric Definition
    /// </summary>
    /// <value>The unit definition of the External Metric Definition</value>
    [DataMember(Name = "unitDefinition", EmitDefaultValue = false)]
    public string UnitDefinition { get; set; }



    /// <summary>
    /// The decimal precision of the External Metric Definition
    /// </summary>
    /// <value>The decimal precision of the External Metric Definition</value>
    [DataMember(Name = "precision", EmitDefaultValue = false)]
    public int? Precision { get; set; }





    /// <summary>
    /// The retention in months of the External Metric Definition
    /// </summary>
    /// <value>The retention in months of the External Metric Definition</value>
    [DataMember(Name = "retentionMonths", EmitDefaultValue = false)]
    public int? RetentionMonths { get; set; }



    /// <summary>
    /// True if the External Metric Definition is enabled
    /// </summary>
    /// <value>True if the External Metric Definition is enabled</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// True if the External Metric Definition is in use
    /// </summary>
    /// <value>True if the External Metric Definition is in use</value>
    [DataMember(Name = "inUse", EmitDefaultValue = false)]
    public bool? InUse { get; private set; }



    /// <summary>
    /// The last date and time that the metric data was refreshed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The last date and time that the metric data was refreshed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateLastRefreshed", EmitDefaultValue = false)]
    public DateTime? DateLastRefreshed { get; set; }



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
        sb.Append("class ExternalMetricDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Unit: ").Append(Unit).Append("\n");
        sb.Append("  UnitDefinition: ").Append(UnitDefinition).Append("\n");
        sb.Append("  Precision: ").Append(Precision).Append("\n");
        sb.Append("  DefaultObjectiveType: ").Append(DefaultObjectiveType).Append("\n");
        sb.Append("  RetentionMonths: ").Append(RetentionMonths).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  InUse: ").Append(InUse).Append("\n");
        sb.Append("  DateLastRefreshed: ").Append(DateLastRefreshed).Append("\n");
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
        return this.Equals(obj as ExternalMetricDefinition);
    }

    /// <summary>
    /// Returns true if ExternalMetricDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalMetricDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalMetricDefinition other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.Unit == other.Unit ||
                this.Unit != null &&
                this.Unit.Equals(other.Unit)
            ) &&
            (
                this.UnitDefinition == other.UnitDefinition ||
                this.UnitDefinition != null &&
                this.UnitDefinition.Equals(other.UnitDefinition)
            ) &&
            (
                this.Precision == other.Precision ||
                this.Precision != null &&
                this.Precision.Equals(other.Precision)
            ) &&
            (
                this.DefaultObjectiveType == other.DefaultObjectiveType ||
                this.DefaultObjectiveType != null &&
                this.DefaultObjectiveType.Equals(other.DefaultObjectiveType)
            ) &&
            (
                this.RetentionMonths == other.RetentionMonths ||
                this.RetentionMonths != null &&
                this.RetentionMonths.Equals(other.RetentionMonths)
            ) &&
            (
                this.Enabled == other.Enabled ||
                this.Enabled != null &&
                this.Enabled.Equals(other.Enabled)
            ) &&
            (
                this.InUse == other.InUse ||
                this.InUse != null &&
                this.InUse.Equals(other.InUse)
            ) &&
            (
                this.DateLastRefreshed == other.DateLastRefreshed ||
                this.DateLastRefreshed != null &&
                this.DateLastRefreshed.Equals(other.DateLastRefreshed)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.Unit != null)
            {
                hash = hash * 59 + this.Unit.GetHashCode();
            }

            if (this.UnitDefinition != null)
            {
                hash = hash * 59 + this.UnitDefinition.GetHashCode();
            }

            if (this.Precision != null)
            {
                hash = hash * 59 + this.Precision.GetHashCode();
            }

            if (this.DefaultObjectiveType != null)
            {
                hash = hash * 59 + this.DefaultObjectiveType.GetHashCode();
            }

            if (this.RetentionMonths != null)
            {
                hash = hash * 59 + this.RetentionMonths.GetHashCode();
            }

            if (this.Enabled != null)
            {
                hash = hash * 59 + this.Enabled.GetHashCode();
            }

            if (this.InUse != null)
            {
                hash = hash * 59 + this.InUse.GetHashCode();
            }

            if (this.DateLastRefreshed != null)
            {
                hash = hash * 59 + this.DateLastRefreshed.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
