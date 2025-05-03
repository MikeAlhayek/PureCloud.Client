using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A set of filters on an element within a journey view
/// </summary>

public partial class JourneyViewElementFilter : IEquatable<JourneyViewElementFilter>
{
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses. Valid values: And
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses. Valid values: And</value>
    
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
        /// Enum And for "And"
        /// </summary>
        [EnumMember(Value = "And")]
        And
    }
    /// <summary>
    /// Boolean operation to apply to the provided predicates and clauses. Valid values: And
    /// </summary>
    /// <value>Boolean operation to apply to the provided predicates and clauses. Valid values: And</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewElementFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementFilter" /> class.
    /// </summary>
    /// <param name="Type">Boolean operation to apply to the provided predicates and clauses. Valid values: And (required).</param>
    /// <param name="Predicates">predicates.</param>
    /// <param name="NumberPredicates">numberPredicates.</param>
    public JourneyViewElementFilter(TypeEnum? Type = null, List<JourneyViewElementFilterPredicate> Predicates = null, List<JourneyViewElementFilterNumberPredicate> NumberPredicates = null)
    {
        this.Type = Type;
        this.Predicates = Predicates;
        this.NumberPredicates = NumberPredicates;

    }





    /// <summary>
    /// predicates
    /// </summary>
    /// <value>predicates</value>
    [JsonPropertyName("predicates")]
    public List<JourneyViewElementFilterPredicate> Predicates { get; set; }



    /// <summary>
    /// numberPredicates
    /// </summary>
    /// <value>numberPredicates</value>
    [JsonPropertyName("numberPredicates")]
    public List<JourneyViewElementFilterNumberPredicate> NumberPredicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewElementFilter {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
        sb.Append("  NumberPredicates: ").Append(NumberPredicates).Append("\n");
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
        return Equals(obj as JourneyViewElementFilter);
    }

    /// <summary>
    /// Returns true if JourneyViewElementFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewElementFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewElementFilter other)
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
                Predicates == other.Predicates ||
                Predicates != null &&
                Predicates.SequenceEqual(other.Predicates)
            ) &&
            (
                NumberPredicates == other.NumberPredicates ||
                NumberPredicates != null &&
                NumberPredicates.SequenceEqual(other.NumberPredicates)
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

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            if (NumberPredicates != null)
            {
                hash = hash * 59 + NumberPredicates.GetHashCode();
            }

            return hash;
        }
    }
}
