using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Trustor
/// </summary>

public partial class Trustor : IEquatable<Trustor>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Trustor" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Trustor() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Trustor" /> class.
    /// </summary>
    /// <param name="Enabled">If disabled no trustee user will have access, even if they were previously added. (required).</param>
    public Trustor(bool? Enabled = null)
    {
        this.Enabled = Enabled;

    }



    /// <summary>
    /// Organization Id for this trust.
    /// </summary>
    /// <value>Organization Id for this trust.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// If disabled no trustee user will have access, even if they were previously added.
    /// </summary>
    /// <value>If disabled no trustee user will have access, even if they were previously added.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date Trust was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// User that created trust.
    /// </summary>
    /// <value>User that created trust.</value>
    [JsonPropertyName("createdBy")]
    public OrgUser CreatedBy { get; private set; }



    /// <summary>
    /// Organization associated with this trust.
    /// </summary>
    /// <value>Organization associated with this trust.</value>
    [JsonPropertyName("organization")]
    public Organization Organization { get; private set; }



    /// <summary>
    /// Authorization for the trustee user has in this trustor organization
    /// </summary>
    /// <value>Authorization for the trustee user has in this trustor organization</value>
    [JsonPropertyName("authorization")]
    public TrusteeAuthorization Authorization { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Trustor {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  Organization: ").Append(Organization).Append("\n");
        sb.Append("  Authorization: ").Append(Authorization).Append("\n");
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
        return Equals(obj as Trustor);
    }

    /// <summary>
    /// Returns true if Trustor instances are equal
    /// </summary>
    /// <param name="other">Instance of Trustor to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Trustor other)
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
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
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
                Authorization == other.Authorization ||
                Authorization != null &&
                Authorization.Equals(other.Authorization)
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

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (Organization != null)
            {
                hash = hash * 59 + Organization.GetHashCode();
            }

            if (Authorization != null)
            {
                hash = hash * 59 + Authorization.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
