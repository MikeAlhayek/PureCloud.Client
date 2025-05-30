using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkJobEntity
/// </summary>

public partial class BulkJobEntity : IEquatable<BulkJobEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkJobEntity" /> class.
    /// </summary>
    /// <param name="Id">The id of the bulk job entity..</param>
    public BulkJobEntity(string Id = null)
    {
        this.Id = Id;

    }



    /// <summary>
    /// The id of the bulk job entity.
    /// </summary>
    /// <value>The id of the bulk job entity.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkJobEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
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
        return Equals(obj as BulkJobEntity);
    }

    /// <summary>
    /// Returns true if BulkJobEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkJobEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkJobEntity other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            return hash;
        }
    }
}
