using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryFacetInfo
/// </summary>
[DataContract]
public partial class QueryFacetInfo : IEquatable<QueryFacetInfo>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryFacetInfo" /> class.
    /// </summary>
    /// <param name="Attributes">Attributes.</param>
    /// <param name="Facets">Facets.</param>
    public QueryFacetInfo(List<FacetKeyAttribute> Attributes = null, List<FacetEntry> Facets = null)
    {
        this.Attributes = Attributes;
        this.Facets = Facets;

    }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public List<FacetKeyAttribute> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets Facets
    /// </summary>
    [DataMember(Name = "facets", EmitDefaultValue = false)]
    public List<FacetEntry> Facets { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryFacetInfo {\n");

        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  Facets: ").Append(Facets).Append("\n");
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
        return Equals(obj as QueryFacetInfo);
    }

    /// <summary>
    /// Returns true if QueryFacetInfo instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryFacetInfo to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryFacetInfo other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                Facets == other.Facets ||
                Facets != null &&
                Facets.SequenceEqual(other.Facets)
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
            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (Facets != null)
            {
                hash = hash * 59 + Facets.GetHashCode();
            }

            return hash;
        }
    }
}
