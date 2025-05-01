using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A group of logical or a singular criteria used to create a query of executionData
/// </summary>
[DataContract]
public partial class CriteriaGroup : IEquatable<CriteriaGroup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CriteriaGroup" /> class.
    /// </summary>
    /// <param name="And">These criteriaItems will be AND&#39;d together to find a match..</param>
    /// <param name="Or">These criteriaItems will be OR&#39;d together to find a match..</param>
    /// <param name="Not">These criteriaItems must all be false to find a match..</param>
    /// <param name="Criteria">A singular critieriaItem to match..</param>
    public CriteriaGroup(List<CriteriaItem> And = null, List<CriteriaItem> Or = null, List<CriteriaItem> Not = null, CriteriaItem Criteria = null)
    {
        this.And = And;
        this.Or = Or;
        this.Not = Not;
        this.Criteria = Criteria;

    }



    /// <summary>
    /// These criteriaItems will be AND&#39;d together to find a match.
    /// </summary>
    /// <value>These criteriaItems will be AND&#39;d together to find a match.</value>
    [DataMember(Name = "and", EmitDefaultValue = false)]
    public List<CriteriaItem> And { get; set; }



    /// <summary>
    /// These criteriaItems will be OR&#39;d together to find a match.
    /// </summary>
    /// <value>These criteriaItems will be OR&#39;d together to find a match.</value>
    [DataMember(Name = "or", EmitDefaultValue = false)]
    public List<CriteriaItem> Or { get; set; }



    /// <summary>
    /// These criteriaItems must all be false to find a match.
    /// </summary>
    /// <value>These criteriaItems must all be false to find a match.</value>
    [DataMember(Name = "not", EmitDefaultValue = false)]
    public List<CriteriaItem> Not { get; set; }



    /// <summary>
    /// A singular critieriaItem to match.
    /// </summary>
    /// <value>A singular critieriaItem to match.</value>
    [DataMember(Name = "criteria", EmitDefaultValue = false)]
    public CriteriaItem Criteria { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CriteriaGroup {\n");

        sb.Append("  And: ").Append(And).Append("\n");
        sb.Append("  Or: ").Append(Or).Append("\n");
        sb.Append("  Not: ").Append(Not).Append("\n");
        sb.Append("  Criteria: ").Append(Criteria).Append("\n");
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
        return Equals(obj as CriteriaGroup);
    }

    /// <summary>
    /// Returns true if CriteriaGroup instances are equal
    /// </summary>
    /// <param name="other">Instance of CriteriaGroup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CriteriaGroup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                And == other.And ||
                And != null &&
                And.SequenceEqual(other.And)
            ) &&
            (
                Or == other.Or ||
                Or != null &&
                Or.SequenceEqual(other.Or)
            ) &&
            (
                Not == other.Not ||
                Not != null &&
                Not.SequenceEqual(other.Not)
            ) &&
            (
                Criteria == other.Criteria ||
                Criteria != null &&
                Criteria.Equals(other.Criteria)
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
            if (And != null)
            {
                hash = hash * 59 + And.GetHashCode();
            }

            if (Or != null)
            {
                hash = hash * 59 + Or.GetHashCode();
            }

            if (Not != null)
            {
                hash = hash * 59 + Not.GetHashCode();
            }

            if (Criteria != null)
            {
                hash = hash * 59 + Criteria.GetHashCode();
            }

            return hash;
        }
    }
}
