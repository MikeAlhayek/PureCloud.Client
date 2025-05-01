using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalMetricDefinitionCreateRequest
/// </summary>
[DataContract]
public partial class ExternalMetricDefinitionCreateRequest : IEquatable<ExternalMetricDefinitionCreateRequest>
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
    /// Initializes a new instance of the <see cref="ExternalMetricDefinitionCreateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ExternalMetricDefinitionCreateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalMetricDefinitionCreateRequest" /> class.
    /// </summary>
    /// <param name="Name">The name of the External Metric Definition (required).</param>
    /// <param name="Unit">The unit of the External Metric Definition (required).</param>
    /// <param name="UnitDefinition">The unit definition of the External Metric Definition.</param>
    /// <param name="Precision">The decimal precision of the External Metric Definition. Must be at least 0 and at most 5 (required).</param>
    /// <param name="DefaultObjectiveType">The default objective type of the External Metric Definition (required).</param>
    /// <param name="Enabled">True if the External Metric Definition is enabled (required).</param>
    public ExternalMetricDefinitionCreateRequest(string Name = null, UnitEnum? Unit = null, string UnitDefinition = null, int? Precision = null, DefaultObjectiveTypeEnum? DefaultObjectiveType = null, bool? Enabled = null)
    {
        this.Name = Name;
        this.Unit = Unit;
        this.UnitDefinition = UnitDefinition;
        this.Precision = Precision;
        this.DefaultObjectiveType = DefaultObjectiveType;
        this.Enabled = Enabled;

    }



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
    /// The decimal precision of the External Metric Definition. Must be at least 0 and at most 5
    /// </summary>
    /// <value>The decimal precision of the External Metric Definition. Must be at least 0 and at most 5</value>
    [DataMember(Name = "precision", EmitDefaultValue = false)]
    public int? Precision { get; set; }





    /// <summary>
    /// True if the External Metric Definition is enabled
    /// </summary>
    /// <value>True if the External Metric Definition is enabled</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExternalMetricDefinitionCreateRequest {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Unit: ").Append(Unit).Append("\n");
        sb.Append("  UnitDefinition: ").Append(UnitDefinition).Append("\n");
        sb.Append("  Precision: ").Append(Precision).Append("\n");
        sb.Append("  DefaultObjectiveType: ").Append(DefaultObjectiveType).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        return Equals(obj as ExternalMetricDefinitionCreateRequest);
    }

    /// <summary>
    /// Returns true if ExternalMetricDefinitionCreateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalMetricDefinitionCreateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalMetricDefinitionCreateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            return hash;
        }
    }
}
