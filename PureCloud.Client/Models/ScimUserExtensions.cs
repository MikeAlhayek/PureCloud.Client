using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Genesys Cloud user extensions to SCIM RFC.
/// </summary>
[DataContract]
public partial class ScimUserExtensions : IEquatable<ScimUserExtensions>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserExtensions" /> class.
    /// </summary>
    /// <param name="RoutingSkills">The list of routing skills assigned to a user. Maximum 50 skills..</param>
    /// <param name="RoutingLanguages">The list of routing languages assigned to a user. Maximum 50 languages..</param>
    /// <param name="ExternalIds">The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;]..</param>
    public ScimUserExtensions(List<ScimUserRoutingSkill> RoutingSkills = null, List<ScimUserRoutingLanguage> RoutingLanguages = null, List<ScimGenesysUserExternalId> ExternalIds = null)
    {
        this.RoutingSkills = RoutingSkills;
        this.RoutingLanguages = RoutingLanguages;
        this.ExternalIds = ExternalIds;

    }



    /// <summary>
    /// The list of routing skills assigned to a user. Maximum 50 skills.
    /// </summary>
    /// <value>The list of routing skills assigned to a user. Maximum 50 skills.</value>
    [DataMember(Name = "routingSkills", EmitDefaultValue = false)]
    public List<ScimUserRoutingSkill> RoutingSkills { get; set; }



    /// <summary>
    /// The list of routing languages assigned to a user. Maximum 50 languages.
    /// </summary>
    /// <value>The list of routing languages assigned to a user. Maximum 50 languages.</value>
    [DataMember(Name = "routingLanguages", EmitDefaultValue = false)]
    public List<ScimUserRoutingLanguage> RoutingLanguages { get; set; }



    /// <summary>
    /// The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;].
    /// </summary>
    /// <value>The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;].</value>
    [DataMember(Name = "externalIds", EmitDefaultValue = false)]
    public List<ScimGenesysUserExternalId> ExternalIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimUserExtensions {\n");

        sb.Append("  RoutingSkills: ").Append(RoutingSkills).Append("\n");
        sb.Append("  RoutingLanguages: ").Append(RoutingLanguages).Append("\n");
        sb.Append("  ExternalIds: ").Append(ExternalIds).Append("\n");
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
        return Equals(obj as ScimUserExtensions);
    }

    /// <summary>
    /// Returns true if ScimUserExtensions instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserExtensions to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimUserExtensions other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RoutingSkills == other.RoutingSkills ||
                RoutingSkills != null &&
                RoutingSkills.SequenceEqual(other.RoutingSkills)
            ) &&
            (
                RoutingLanguages == other.RoutingLanguages ||
                RoutingLanguages != null &&
                RoutingLanguages.SequenceEqual(other.RoutingLanguages)
            ) &&
            (
                ExternalIds == other.ExternalIds ||
                ExternalIds != null &&
                ExternalIds.SequenceEqual(other.ExternalIds)
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
            if (RoutingSkills != null)
            {
                hash = hash * 59 + RoutingSkills.GetHashCode();
            }

            if (RoutingLanguages != null)
            {
                hash = hash * 59 + RoutingLanguages.GetHashCode();
            }

            if (ExternalIds != null)
            {
                hash = hash * 59 + ExternalIds.GetHashCode();
            }

            return hash;
        }
    }
}
