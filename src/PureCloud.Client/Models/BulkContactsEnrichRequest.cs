using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkContactsEnrichRequest
/// </summary>

public partial class BulkContactsEnrichRequest : IEquatable<BulkContactsEnrichRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkContactsEnrichRequest" /> class.
    /// </summary>
    /// <param name="Entities">Entities.</param>
    public BulkContactsEnrichRequest(List<ContactEnrichRequest> Entities = null)
    {
        this.Entities = Entities;

    }



    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    [JsonPropertyName("entities")]
    public List<ContactEnrichRequest> Entities { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkContactsEnrichRequest {\n");

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
        return Equals(obj as BulkContactsEnrichRequest);
    }

    /// <summary>
    /// Returns true if BulkContactsEnrichRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkContactsEnrichRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkContactsEnrichRequest other)
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
