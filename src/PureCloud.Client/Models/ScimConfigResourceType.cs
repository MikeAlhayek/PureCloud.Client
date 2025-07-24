using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM resource.
/// </summary>

public sealed class ScimConfigResourceType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceType" /> class.
    /// </summary>



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
    /// The name of the resource type.
    /// </summary>
    /// <value>The name of the resource type.</value>
    public string Name { get; set; }



    /// <summary>
    /// The description of the resource type.
    /// </summary>
    /// <value>The description of the resource type.</value>
    public string Description { get; set; }



    /// <summary>
    /// The URI of the primary or base schema for the resource type.
    /// </summary>
    /// <value>The URI of the primary or base schema for the resource type.</value>
    public string Schema { get; set; }



    /// <summary>
    /// The list of schema extensions for the resource type.
    /// </summary>
    /// <value>The list of schema extensions for the resource type.</value>
    public IEnumerable<ScimConfigResourceTypeSchemaExtension> SchemaExtensions { get; set; }



    /// <summary>
    /// The HTTP-addressable endpoint of the resource type. Appears after the base URL.
    /// </summary>
    /// <value>The HTTP-addressable endpoint of the resource type. Appears after the base URL.</value>
    public string Endpoint { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;ResourceType\&quot; resources.</value>
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
    /// Returns true if ScimConfigResourceType instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceType to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
