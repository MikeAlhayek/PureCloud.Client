using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkResult
/// </summary>

public partial class BulkResult : IEquatable<BulkResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkResult" /> class.
    /// </summary>
    /// <param name="Error">Error details if the operation failed..</param>
    /// <param name="Entity">The result of the operation if it succeeded..</param>
    public BulkResult(BulkError Error = null, object Entity = null)
    {
        this.Error = Error;
        this.Entity = Entity;

    }



    /// <summary>
    /// Error details if the operation failed.
    /// </summary>
    /// <value>Error details if the operation failed.</value>
    [JsonPropertyName("error")]
    public BulkError Error { get; set; }



    /// <summary>
    /// The result of the operation if it succeeded.
    /// </summary>
    /// <value>The result of the operation if it succeeded.</value>
    [JsonPropertyName("entity")]
    public object Entity { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkResult {\n");

        sb.Append("  Error: ").Append(Error).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
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
        return Equals(obj as BulkResult);
    }

    /// <summary>
    /// Returns true if BulkResult instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
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
            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            return hash;
        }
    }
}
