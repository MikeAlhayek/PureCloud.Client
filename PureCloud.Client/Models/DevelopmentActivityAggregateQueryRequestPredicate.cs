using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// DevelopmentActivityAggregateQueryRequestPredicate
/// </summary>
[DataContract]
public partial class DevelopmentActivityAggregateQueryRequestPredicate : IEquatable<DevelopmentActivityAggregateQueryRequestPredicate>
{
    /// <summary>
    /// Each predicates specifies a dimension.
    /// </summary>
    /// <value>Each predicates specifies a dimension.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attendeeid for "attendeeId"
        /// </summary>
        [EnumMember(Value = "attendeeId")]
        Attendeeid,

        /// <summary>
        /// Enum Type for "type"
        /// </summary>
        [EnumMember(Value = "type")]
        Type,

        /// <summary>
        /// Enum Moduleid for "moduleId"
        /// </summary>
        [EnumMember(Value = "moduleId")]
        Moduleid,

        /// <summary>
        /// Enum Ispassed for "isPassed"
        /// </summary>
        [EnumMember(Value = "isPassed")]
        Ispassed
    }
    /// <summary>
    /// Each predicates specifies a dimension.
    /// </summary>
    /// <value>Each predicates specifies a dimension.</value>
    [DataMember(Name = "dimension", EmitDefaultValue = false)]
    public DimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateQueryRequestPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DevelopmentActivityAggregateQueryRequestPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DevelopmentActivityAggregateQueryRequestPredicate" /> class.
    /// </summary>
    /// <param name="Dimension">Each predicates specifies a dimension. (required).</param>
    /// <param name="Value">Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), Coaching, External, Native (required).</param>
    public DevelopmentActivityAggregateQueryRequestPredicate(DimensionEnum? Dimension = null, string Value = null)
    {
        this.Dimension = Dimension;
        this.Value = Value;

    }





    /// <summary>
    /// Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), Coaching, External, Native
    /// </summary>
    /// <value>Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), Coaching, External, Native</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DevelopmentActivityAggregateQueryRequestPredicate {\n");

        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return this.Equals(obj as DevelopmentActivityAggregateQueryRequestPredicate);
    }

    /// <summary>
    /// Returns true if DevelopmentActivityAggregateQueryRequestPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of DevelopmentActivityAggregateQueryRequestPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DevelopmentActivityAggregateQueryRequestPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Dimension == other.Dimension ||
                this.Dimension != null &&
                this.Dimension.Equals(other.Dimension)
            ) &&
            (
                this.Value == other.Value ||
                this.Value != null &&
                this.Value.Equals(other.Value)
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
            if (this.Dimension != null)
            {
                hash = hash * 59 + this.Dimension.GetHashCode();
            }

            if (this.Value != null)
            {
                hash = hash * 59 + this.Value.GetHashCode();
            }

            return hash;
        }
    }
}
