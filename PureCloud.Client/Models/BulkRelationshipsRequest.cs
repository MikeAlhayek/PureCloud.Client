using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkRelationshipsRequest
/// </summary>
[DataContract]
public partial class BulkRelationshipsRequest : IEquatable<BulkRelationshipsRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkRelationshipsRequest" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    public BulkRelationshipsRequest(List<Relationship> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<Relationship> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkRelationshipsRequest {\n");

        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as BulkRelationshipsRequest);
    }

    /// <summary>
    /// Returns true if BulkRelationshipsRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkRelationshipsRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkRelationshipsRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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
            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
