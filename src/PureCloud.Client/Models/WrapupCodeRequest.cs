using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WrapupCodeRequest
/// </summary>

public partial class WrapupCodeRequest : IEquatable<WrapupCodeRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="WrapupCodeRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WrapupCodeRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WrapupCodeRequest" /> class.
    /// </summary>
    /// <param name="Name">The wrap-up code name. (required).</param>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="Description">The wrap-up code description..</param>
    /// <param name="DateCreated">Date when the wrap-up code was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Date when the wrap-up code was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">The ID of the user that created the wrap-up code..</param>
    /// <param name="ModifiedBy">The ID of the user that modified the wrap-up code..</param>
    public WrapupCodeRequest(string Name = null, WritableStarrableDivision Division = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string CreatedBy = null, string ModifiedBy = null)
    {
        this.Name = Name;
        this.Division = Division;
        this.Description = Description;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.CreatedBy = CreatedBy;
        this.ModifiedBy = ModifiedBy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The wrap-up code name.
    /// </summary>
    /// <value>The wrap-up code name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// The wrap-up code description.
    /// </summary>
    /// <value>The wrap-up code description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Date when the wrap-up code was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the wrap-up code was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Date when the wrap-up code was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the wrap-up code was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The ID of the user that created the wrap-up code.
    /// </summary>
    /// <value>The ID of the user that created the wrap-up code.</value>
    [JsonPropertyName("createdBy")]
    public string CreatedBy { get; set; }



    /// <summary>
    /// The ID of the user that modified the wrap-up code.
    /// </summary>
    /// <value>The ID of the user that modified the wrap-up code.</value>
    [JsonPropertyName("modifiedBy")]
    public string ModifiedBy { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WrapupCodeRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WrapupCodeRequest);
    }

    /// <summary>
    /// Returns true if WrapupCodeRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WrapupCodeRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WrapupCodeRequest other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
