using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentQueryClause
/// </summary>

public partial class DocumentQueryClause : IEquatable<DocumentQueryClause>
{
    /// <summary>
    /// Specifies how the predicates will be applied together.
    /// </summary>
    /// <value>Specifies how the predicates will be applied together.</value>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Or for "Or"
        /// </summary>
        [EnumMember(Value = "Or")]
        Or,

        /// <summary>
        /// Enum And for "And"
        /// </summary>
        [EnumMember(Value = "And")]
        And
    }
    /// <summary>
    /// Specifies how the predicates will be applied together.
    /// </summary>
    /// <value>Specifies how the predicates will be applied together.</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentQueryClause" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentQueryClause() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentQueryClause" /> class.
    /// </summary>
    /// <param name="Operator">Specifies how the predicates will be applied together. (required).</param>
    /// <param name="Predicates">To apply multiple conditions. Limit of 10 predicates across all clauses. (required).</param>
    public DocumentQueryClause(OperatorEnum? Operator = null, List<DocumentQueryPredicate> Predicates = null)
    {
        this.Operator = Operator;
        this.Predicates = Predicates;

    }





    /// <summary>
    /// To apply multiple conditions. Limit of 10 predicates across all clauses.
    /// </summary>
    /// <value>To apply multiple conditions. Limit of 10 predicates across all clauses.</value>
    [JsonPropertyName("predicates")]
    public List<DocumentQueryPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentQueryClause {\n");

        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
        return Equals(obj as DocumentQueryClause);
    }

    /// <summary>
    /// Returns true if DocumentQueryClause instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentQueryClause to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentQueryClause other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Predicates == other.Predicates ||
                Predicates != null &&
                Predicates.SequenceEqual(other.Predicates)
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
            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Predicates != null)
            {
                hash = hash * 59 + Predicates.GetHashCode();
            }

            return hash;
        }
    }
}
