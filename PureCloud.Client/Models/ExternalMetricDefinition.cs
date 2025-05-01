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
        return Equals(obj as ExternalMetricDefinition);
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
                Unit == other.Unit ||
                Unit != null &&
                Unit.Equals(other.Unit)
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
                DefaultObjectiveType == other.DefaultObjectiveType ||
                DefaultObjectiveType != null &&
                DefaultObjectiveType.Equals(other.DefaultObjectiveType)
            ) &&
            (
                RetentionMonths == other.RetentionMonths ||
                RetentionMonths != null &&
                RetentionMonths.Equals(other.RetentionMonths)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                InUse == other.InUse ||
                InUse != null &&
                InUse.Equals(other.InUse)
            ) &&
            (
                DateLastRefreshed == other.DateLastRefreshed ||
                DateLastRefreshed != null &&
                DateLastRefreshed.Equals(other.DateLastRefreshed)
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

            if (Unit != null)
            {
                hash = hash * 59 + Unit.GetHashCode();
            }

            if (UnitDefinition != null)
            {
                hash = hash * 59 + UnitDefinition.GetHashCode();
            }

            if (Precision != null)
            {
                hash = hash * 59 + Precision.GetHashCode();
            }

            if (DefaultObjectiveType != null)
            {
                hash = hash * 59 + DefaultObjectiveType.GetHashCode();
            }

            if (RetentionMonths != null)
            {
                hash = hash * 59 + RetentionMonths.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (InUse != null)
            {
                hash = hash * 59 + InUse.GetHashCode();
            }

            if (DateLastRefreshed != null)
            {
                hash = hash * 59 + DateLastRefreshed.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
