using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM schema.
/// </summary>

public sealed class ScimV2SchemaDefinition
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2SchemaDefinition" /> class.
    /// </summary>



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    public string Id { get; set; }



    /// <summary>
    /// The name of the schema.
    /// </summary>
    /// <value>The name of the schema.</value>
    public string Name { get; set; }



    /// <summary>
    /// The description of the schema.
    /// </summary>
    /// <value>The description of the schema.</value>
    public string Description { get; set; }



    /// <summary>
    /// The list of service provider attributes.
    /// </summary>
    /// <value>The list of service provider attributes.</value>
    public IEnumerable<ScimV2SchemaAttribute> Attributes { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;Schema\&quot; resources.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Only \&quot;location\&quot; and \&quot;resourceType\&quot; are set for \&quot;Schema\&quot; resources.</value>
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
    /// Returns true if ScimV2SchemaDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2SchemaDefinition to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
