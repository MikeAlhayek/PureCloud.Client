using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BulkResponseResultExternalContactEntityBulkEntityErrorEntity
/// </summary>

public partial class BulkResponseResultExternalContactEntityBulkEntityErrorEntity : IEquatable<BulkResponseResultExternalContactEntityBulkEntityErrorEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkResponseResultExternalContactEntityBulkEntityErrorEntity" /> class.
    /// </summary>
    /// <param name="Id">The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity..</param>
    /// <param name="Success">Whether the requested operation completed successfully..</param>
    /// <param name="Entity">The entity which was affected by this Bulk operation. Only returned on success..</param>
    /// <param name="Error">An error describing why this Bulk operation failed. Only returned on failure..</param>
    public BulkResponseResultExternalContactEntityBulkEntityErrorEntity(string Id = null, bool? Success = null, ExternalContact Entity = null, BulkEntityErrorEntity Error = null)
    {
        this.Id = Id;
        this.Success = Success;
        this.Entity = Entity;
        this.Error = Error;

    }



    /// <summary>
    /// The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.
    /// </summary>
    /// <value>The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Whether the requested operation completed successfully.
    /// </summary>
    /// <value>Whether the requested operation completed successfully.</value>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }



    /// <summary>
    /// The entity which was affected by this Bulk operation. Only returned on success.
    /// </summary>
    /// <value>The entity which was affected by this Bulk operation. Only returned on success.</value>
    [JsonPropertyName("entity")]
    public ExternalContact Entity { get; set; }



    /// <summary>
    /// An error describing why this Bulk operation failed. Only returned on failure.
    /// </summary>
    /// <value>An error describing why this Bulk operation failed. Only returned on failure.</value>
    [JsonPropertyName("error")]
    public BulkEntityErrorEntity Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkResponseResultExternalContactEntityBulkEntityErrorEntity {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Entity: ").Append(Entity).Append("\n");
        sb.Append("  Error: ").Append(Error).Append("\n");
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
        return Equals(obj as BulkResponseResultExternalContactEntityBulkEntityErrorEntity);
    }

    /// <summary>
    /// Returns true if BulkResponseResultExternalContactEntityBulkEntityErrorEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkResponseResultExternalContactEntityBulkEntityErrorEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkResponseResultExternalContactEntityBulkEntityErrorEntity other)
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
            ) &&
            (
                Success == other.Success ||
                Success != null &&
                Success.Equals(other.Success)
            ) &&
            (
                Entity == other.Entity ||
                Entity != null &&
                Entity.Equals(other.Entity)
            ) &&
            (
                Error == other.Error ||
                Error != null &&
                Error.Equals(other.Error)
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

            if (Success != null)
            {
                hash = hash * 59 + Success.GetHashCode();
            }

            if (Entity != null)
            {
                hash = hash * 59 + Entity.GetHashCode();
            }

            if (Error != null)
            {
                hash = hash * 59 + Error.GetHashCode();
            }

            return hash;
        }
    }
}
