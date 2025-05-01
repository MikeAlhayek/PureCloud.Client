using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition
/// </summary>
[DataContract]
public partial class EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition : IEquatable<EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition>
{
    /// <summary>
    /// Gets or Sets Unit
    /// </summary>
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
        Currency,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets DefaultObjectiveType
    /// </summary>
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
        Targetarea,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets Unit
    /// </summary>
    [DataMember(Name = "unit", EmitDefaultValue = false)]
    public UnitEnum? Unit { get; set; }
    /// <summary>
    /// Gets or Sets DefaultObjectiveType
    /// </summary>
    [DataMember(Name = "defaultObjectiveType", EmitDefaultValue = false)]
    public DefaultObjectiveTypeEnum? DefaultObjectiveType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Unit">Unit.</param>
    /// <param name="UnitDefinition">UnitDefinition.</param>
    /// <param name="Precision">Precision.</param>
    /// <param name="DefaultObjectiveType">DefaultObjectiveType.</param>
    /// <param name="RetentionMonths">RetentionMonths.</param>
    /// <param name="Enabled">Enabled.</param>
    /// <param name="InUse">InUse.</param>
    /// <param name="DateLastRefreshed">DateLastRefreshed.</param>
    public EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition(string Id = null, string Name = null, UnitEnum? Unit = null, string UnitDefinition = null, long? Precision = null, DefaultObjectiveTypeEnum? DefaultObjectiveType = null, long? RetentionMonths = null, bool? Enabled = null, bool? InUse = null, DateTime? DateLastRefreshed = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Unit = Unit;
        this.UnitDefinition = UnitDefinition;
        this.Precision = Precision;
        this.DefaultObjectiveType = DefaultObjectiveType;
        this.RetentionMonths = RetentionMonths;
        this.Enabled = Enabled;
        this.InUse = InUse;
        this.DateLastRefreshed = DateLastRefreshed;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// Gets or Sets UnitDefinition
    /// </summary>
    [DataMember(Name = "unitDefinition", EmitDefaultValue = false)]
    public string UnitDefinition { get; set; }



    /// <summary>
    /// Gets or Sets Precision
    /// </summary>
    [DataMember(Name = "precision", EmitDefaultValue = false)]
    public long? Precision { get; set; }





    /// <summary>
    /// Gets or Sets RetentionMonths
    /// </summary>
    [DataMember(Name = "retentionMonths", EmitDefaultValue = false)]
    public long? RetentionMonths { get; set; }



    /// <summary>
    /// Gets or Sets Enabled
    /// </summary>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Gets or Sets InUse
    /// </summary>
    [DataMember(Name = "inUse", EmitDefaultValue = false)]
    public bool? InUse { get; set; }



    /// <summary>
    /// Gets or Sets DateLastRefreshed
    /// </summary>
    [DataMember(Name = "dateLastRefreshed", EmitDefaultValue = false)]
    public DateTime? DateLastRefreshed { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition {\n");

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
        return Equals(obj as EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition);
    }

    /// <summary>
    /// Returns true if EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmployeePerformanceExternalMetricsDefinitionExternalMetricsDefinition other)
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

            return hash;
        }
    }
}
