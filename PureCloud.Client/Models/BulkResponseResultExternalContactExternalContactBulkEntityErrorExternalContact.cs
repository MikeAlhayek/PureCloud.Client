using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact
/// </summary>
[DataContract]
public partial class BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact : IEquatable<BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact" /> class.
    /// </summary>
    /// <param name="Id">The id associated with this operation. For Bulk Enrich, this id is specified in the request; for all other Bulk endpoints, this id is the id of the affected entity..</param>
    /// <param name="Success">Whether the requested operation completed successfully..</param>
    /// <param name="Entity">The entity which was affected by this Bulk operation. Only returned on success..</param>
    /// <param name="Error">An error describing why this Bulk operation failed. Only returned on failure..</param>
    public BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact(string Id = null, bool? Success = null, ExternalContact Entity = null, BulkEntityErrorExternalContact Error = null)
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Whether the requested operation completed successfully.
    /// </summary>
    /// <value>Whether the requested operation completed successfully.</value>
    [DataMember(Name = "success", EmitDefaultValue = false)]
    public bool? Success { get; set; }



    /// <summary>
    /// The entity which was affected by this Bulk operation. Only returned on success.
    /// </summary>
    /// <value>The entity which was affected by this Bulk operation. Only returned on success.</value>
    [DataMember(Name = "entity", EmitDefaultValue = false)]
    public ExternalContact Entity { get; set; }



    /// <summary>
    /// An error describing why this Bulk operation failed. Only returned on failure.
    /// </summary>
    /// <value>An error describing why this Bulk operation failed. Only returned on failure.</value>
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public BulkEntityErrorExternalContact Error { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact {\n");

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
        return this.Equals(obj as BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact);
    }

    /// <summary>
    /// Returns true if BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact instances are equal
    /// </summary>
    /// <param name="other">Instance of BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BulkResponseResultExternalContactExternalContactBulkEntityErrorExternalContact other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Success == other.Success ||
                this.Success != null &&
                this.Success.Equals(other.Success)
            ) &&
            (
                this.Entity == other.Entity ||
                this.Entity != null &&
                this.Entity.Equals(other.Entity)
            ) &&
            (
                this.Error == other.Error ||
                this.Error != null &&
                this.Error.Equals(other.Error)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Success != null)
            {
                hash = hash * 59 + this.Success.GetHashCode();
            }

            if (this.Entity != null)
            {
                hash = hash * 59 + this.Entity.GetHashCode();
            }

            if (this.Error != null)
            {
                hash = hash * 59 + this.Error.GetHashCode();
            }

            return hash;
        }
    }
}
