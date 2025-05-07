using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrustRequest
/// </summary>

public partial class TrustRequest : IEquatable<TrustRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrustRequest" /> class.
    /// </summary>
    public TrustRequest()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// User who created this request.
    /// </summary>
    /// <value>User who created this request.</value>
    [JsonPropertyName("createdBy")]
    public OrgUser CreatedBy { get; set; }



    /// <summary>
    /// Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date request was created. There is a 48 hour expiration on all requests. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Trustee organization who generated this request.
    /// </summary>
    /// <value>Trustee organization who generated this request.</value>
    [JsonPropertyName("trustee")]
    public Organization Trustee { get; set; }



    /// <summary>
    /// The list of trustee users that are requesting access.
    /// </summary>
    /// <value>The list of trustee users that are requesting access.</value>
    [JsonPropertyName("users")]
    public List<OrgUser> Users { get; set; }



    /// <summary>
    /// The list of trustee groups that are requesting access.
    /// </summary>
    /// <value>The list of trustee groups that are requesting access.</value>
    [JsonPropertyName("groups")]
    public List<TrustGroup> Groups { get; set; }



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
        sb.Append("class TrustRequest {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Trustee: ").Append(Trustee).Append("\n");
        sb.Append("  Users: ").Append(Users).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
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
        return Equals(obj as TrustRequest);
    }

    /// <summary>
    /// Returns true if TrustRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TrustRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrustRequest other)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                Trustee == other.Trustee ||
                Trustee != null &&
                Trustee.Equals(other.Trustee)
            ) &&
            (
                Users == other.Users ||
                Users != null &&
                Users.SequenceEqual(other.Users)
            ) &&
            (
                Groups == other.Groups ||
                Groups != null &&
                Groups.SequenceEqual(other.Groups)
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

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Trustee != null)
            {
                hash = hash * 59 + Trustee.GetHashCode();
            }

            if (Users != null)
            {
                hash = hash * 59 + Users.GetHashCode();
            }

            if (Groups != null)
            {
                hash = hash * 59 + Groups.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
