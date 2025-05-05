using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LearningAssignmentAggregateQueryRequestPredicate
/// </summary>

public partial class LearningAssignmentAggregateQueryRequestPredicate : IEquatable<LearningAssignmentAggregateQueryRequestPredicate>
{
    /// <summary>
    /// Each predicates specifies a dimension.
    /// </summary>
    /// <value>Each predicates specifies a dimension.</value>
    
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
    [JsonPropertyName("dimension")]
    public DimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryRequestPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LearningAssignmentAggregateQueryRequestPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LearningAssignmentAggregateQueryRequestPredicate" /> class.
    /// </summary>
    /// <param name="Dimension">Each predicates specifies a dimension. (required).</param>
    /// <param name="Value">Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), External, Native (required).</param>
    public LearningAssignmentAggregateQueryRequestPredicate(DimensionEnum? Dimension = null, string Value = null)
    {
        this.Dimension = Dimension;
        this.Value = Value;

    }





    /// <summary>
    /// Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), External, Native
    /// </summary>
    /// <value>Corresponding value for dimensions in predicates. If the dimension is type, Valid Values: Informational (deprecated), AssessedContent (deprecated), Assessment (deprecated), External, Native</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LearningAssignmentAggregateQueryRequestPredicate {\n");

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
        return Equals(obj as LearningAssignmentAggregateQueryRequestPredicate);
    }

    /// <summary>
    /// Returns true if LearningAssignmentAggregateQueryRequestPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of LearningAssignmentAggregateQueryRequestPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LearningAssignmentAggregateQueryRequestPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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
            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
