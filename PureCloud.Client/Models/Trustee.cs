using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Trustee
/// </summary>
[DataContract]
public partial class Trustee : IEquatable<Trustee>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Trustee" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Trustee() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Trustee" /> class.
    /// </summary>
    /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
    /// <param name="UsesDefaultRole">Denotes if trustee uses admin role by default..</param>
    /// <param name="HasFullAccess">Denotes if trustee uses full access role by default..</param>
    /// <param name="IsTrustedUser">Denotes if trustee is given Trusted User access by default..</param>
    /// <param name="DateExpired">The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Trustee(bool? Enabled = null, bool? UsesDefaultRole = null, bool? HasFullAccess = null, bool? IsTrustedUser = null, DateTime? DateExpired = null)
    {
        this.Enabled = Enabled;
        this.UsesDefaultRole = UsesDefaultRole;
        this.HasFullAccess = HasFullAccess;
        this.IsTrustedUser = IsTrustedUser;
        this.DateExpired = DateExpired;

    }



    /// <summary>
    /// Organization Id for this trust.
    /// </summary>
    /// <value>Organization Id for this trust.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// If disabled no trustee user will have access, even if they were previously added.
    /// </summary>
    /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
    [DataMember(Name = "enabled", EmitDefaultValue = false)]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Denotes if trustee uses admin role by default.
    /// </summary>
    /// <value>Denotes if trustee uses admin role by default.</value>
    [DataMember(Name = "usesDefaultRole", EmitDefaultValue = false)]
    public bool? UsesDefaultRole { get; set; }



    /// <summary>
    /// Denotes if trustee uses full access role by default.
    /// </summary>
    /// <value>Denotes if trustee uses full access role by default.</value>
    [DataMember(Name = "hasFullAccess", EmitDefaultValue = false)]
    public bool? HasFullAccess { get; set; }



    /// <summary>
    /// Denotes if trustee is given Trusted User access by default.
    /// </summary>
    /// <value>Denotes if trustee is given Trusted User access by default.</value>
    [DataMember(Name = "isTrustedUser", EmitDefaultValue = false)]
    public bool? IsTrustedUser { get; set; }



    /// <summary>
    /// Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The expiration date of the trust. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateExpired", EmitDefaultValue = false)]
    public DateTime? DateExpired { get; set; }



    /// <summary>
    /// User that created trust.
    /// </summary>
    /// <value>User that created trust.</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public OrgUser CreatedBy { get; private set; }



    /// <summary>
    /// Organization associated with this trust.
    /// </summary>
    /// <value>Organization associated with this trust.</value>
    [DataMember(Name = "organization", EmitDefaultValue = false)]
    public Organization Organization { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Trustee {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  UsesDefaultRole: ").Append(UsesDefaultRole).Append("\n");
        sb.Append("  HasFullAccess: ").Append(HasFullAccess).Append("\n");
        sb.Append("  IsTrustedUser: ").Append(IsTrustedUser).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateExpired: ").Append(DateExpired).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Organization: ").Append(Organization).Append("\n");
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
        return Equals(obj as Trustee);
    }

    /// <summary>
    /// Returns true if Trustee instances are equal
    /// </summary>
    /// <param name="other">Instance of Trustee to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Trustee other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                UsesDefaultRole == other.UsesDefaultRole ||
                UsesDefaultRole != null &&
                UsesDefaultRole.Equals(other.UsesDefaultRole)
            ) &&
            (
                HasFullAccess == other.HasFullAccess ||
                HasFullAccess != null &&
                HasFullAccess.Equals(other.HasFullAccess)
            ) &&
            (
                IsTrustedUser == other.IsTrustedUser ||
                IsTrustedUser != null &&
                IsTrustedUser.Equals(other.IsTrustedUser)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateExpired == other.DateExpired ||
                DateExpired != null &&
                DateExpired.Equals(other.DateExpired)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                Organization == other.Organization ||
                Organization != null &&
                Organization.Equals(other.Organization)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (UsesDefaultRole != null)
            {
                hash = hash * 59 + UsesDefaultRole.GetHashCode();
            }

            if (HasFullAccess != null)
            {
                hash = hash * 59 + HasFullAccess.GetHashCode();
            }

            if (IsTrustedUser != null)
            {
                hash = hash * 59 + IsTrustedUser.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateExpired != null)
            {
                hash = hash * 59 + DateExpired.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (Organization != null)
            {
                hash = hash * 59 + Organization.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
