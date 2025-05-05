using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExternalOrganizationTrustorLink
/// </summary>

public partial class ExternalOrganizationTrustorLink : IEquatable<ExternalOrganizationTrustorLink>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExternalOrganizationTrustorLink" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="ExternalOrganizationId">The id of a PureCloudEnvironment External Organization entity in the External Contacts system that will be used to represent the trustor org.</param>
    /// <param name="TrustorOrgId">The id of a PureCloudEnvironment organization that has granted trust to this PureCloudEnvironment organization.</param>
    /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ExternalOrganizationTrustorLink(WritableStarrableDivision Division = null, string ExternalOrganizationId = null, string TrustorOrgId = null, DateTime? DateCreated = null)
    {
        this.Division = Division;
        this.ExternalOrganizationId = ExternalOrganizationId;
        this.TrustorOrgId = TrustorOrgId;
        this.DateCreated = DateCreated;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// The id of a PureCloudEnvironment External Organization entity in the External Contacts system that will be used to represent the trustor org
    /// </summary>
    /// <value>The id of a PureCloudEnvironment External Organization entity in the External Contacts system that will be used to represent the trustor org</value>
    [JsonPropertyName("externalOrganizationId")]
    public string ExternalOrganizationId { get; set; }



    /// <summary>
    /// The id of a PureCloudEnvironment organization that has granted trust to this PureCloudEnvironment organization
    /// </summary>
    /// <value>The id of a PureCloudEnvironment organization that has granted trust to this PureCloudEnvironment organization</value>
    [JsonPropertyName("trustorOrgId")]
    public string TrustorOrgId { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The URI for the External Organization that is linked to the trustor org
    /// </summary>
    /// <value>The URI for the External Organization that is linked to the trustor org</value>
    [JsonPropertyName("externalOrganizationUri")]
    public string ExternalOrganizationUri { get; private set; }



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
        sb.Append("class ExternalOrganizationTrustorLink {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
        sb.Append("  TrustorOrgId: ").Append(TrustorOrgId).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ExternalOrganizationUri: ").Append(ExternalOrganizationUri).Append("\n");
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
        return Equals(obj as ExternalOrganizationTrustorLink);
    }

    /// <summary>
    /// Returns true if ExternalOrganizationTrustorLink instances are equal
    /// </summary>
    /// <param name="other">Instance of ExternalOrganizationTrustorLink to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExternalOrganizationTrustorLink other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                ExternalOrganizationId == other.ExternalOrganizationId ||
                ExternalOrganizationId != null &&
                ExternalOrganizationId.Equals(other.ExternalOrganizationId)
            ) &&
            (
                TrustorOrgId == other.TrustorOrgId ||
                TrustorOrgId != null &&
                TrustorOrgId.Equals(other.TrustorOrgId)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ExternalOrganizationUri == other.ExternalOrganizationUri ||
                ExternalOrganizationUri != null &&
                ExternalOrganizationUri.Equals(other.ExternalOrganizationUri)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (ExternalOrganizationId != null)
            {
                hash = hash * 59 + ExternalOrganizationId.GetHashCode();
            }

            if (TrustorOrgId != null)
            {
                hash = hash * 59 + TrustorOrgId.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ExternalOrganizationUri != null)
            {
                hash = hash * 59 + ExternalOrganizationUri.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
