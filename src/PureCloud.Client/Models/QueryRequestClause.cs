using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryRequestClause
/// </summary>

public partial class QueryRequestClause : IEquatable<QueryRequestClause>
{
    /// <summary>
    /// The logic used to combine the predicates
    /// </summary>
    /// <value>The logic used to combine the predicates</value>
    
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
        And,

        /// <summary>
        /// Enum Or for "Or"
        /// </summary>
        [EnumMember(Value = "Or")]
        Or
    }
    /// <summary>
    /// The logic used to combine the predicates
    /// </summary>
    /// <value>The logic used to combine the predicates</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryRequestClause" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryRequestClause() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryRequestClause" /> class.
    /// </summary>
    /// <param name="Type">The logic used to combine the predicates (required).</param>
    /// <param name="Predicates">The list of predicates used to filter the data (required).</param>
    public QueryRequestClause(TypeEnum? Type = null, List<QueryRequestPredicate> Predicates = null)
    {
        this.Type = Type;
        this.Predicates = Predicates;

    }





    /// <summary>
    /// The list of predicates used to filter the data
    /// </summary>
    /// <value>The list of predicates used to filter the data</value>
    [JsonPropertyName("predicates")]
    public List<QueryRequestPredicate> Predicates { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryRequestClause {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as QueryRequestClause);
    }

    /// <summary>
    /// Returns true if QueryRequestClause instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryRequestClause to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryRequestClause other)
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

            return hash;
        }
    }
}
