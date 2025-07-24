using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM group.
/// </summary>

public sealed class ScimV2Group
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2Group" /> class.
    /// </summary>
    /// <param name="ExternalId">The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;..</param>
    /// <param name="Members">The list of members in the group..</param>



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    public string Id { get; set; }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// The display name of the group.
    /// </summary>
    /// <value>The display name of the group.</value>
    public string DisplayName { get; set; }



    /// <summary>
    /// The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.
    /// </summary>
    /// <value>The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.</value>
    public string ExternalId { get; set; }



    /// <summary>
    /// The list of members in the group.
    /// </summary>
    /// <value>The list of members in the group.</value>
    public IEnumerable<ScimV2MemberReference> Members { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
    public ScimMetadata Meta { get; set; }


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
    /// Returns true if ScimV2Group instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2Group to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
