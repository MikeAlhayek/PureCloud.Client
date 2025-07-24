using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Genesys Cloud user extensions to SCIM RFC.
/// </summary>

public sealed class ScimUserExtensions
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimUserExtensions" /> class.
    /// </summary>
    /// <param name="RoutingSkills">The list of routing skills assigned to a user. Maximum 50 skills..</param>
    /// <param name="RoutingLanguages">The list of routing languages assigned to a user. Maximum 50 languages..</param>
    /// <param name="ExternalIds">The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;]..</param>



    /// <summary>
    /// The list of routing skills assigned to a user. Maximum 50 skills.
    /// </summary>
    /// <value>The list of routing skills assigned to a user. Maximum 50 skills.</value>
    public IEnumerable<ScimUserRoutingSkill> RoutingSkills { get; set; }



    /// <summary>
    /// The list of routing languages assigned to a user. Maximum 50 languages.
    /// </summary>
    /// <value>The list of routing languages assigned to a user. Maximum 50 languages.</value>
    public IEnumerable<ScimUserRoutingLanguage> RoutingLanguages { get; set; }



    /// <summary>
    /// The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;].
    /// </summary>
    /// <value>The list of external identifiers assigned to user. Always includes an immutable SCIM authority prefixed with \&quot;x-pc:scimv2:v1\&quot;. ExternalIds are searchable with complex filter query parameter using &#39;authority&#39; and &#39;value&#39;, e.g., filter&#x3D;urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User:externalIds[authority eq \&quot;matchAuthName\&quot; and value eq \&quot;matchingExternalKeyValue\&quot;].</value>
    public IEnumerable<ScimGenesysUserExternalId> ExternalIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if ScimUserExtensions instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimUserExtensions to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
