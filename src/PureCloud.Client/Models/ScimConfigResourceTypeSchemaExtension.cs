using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM resource type&#39;s schema extension.
/// </summary>

public sealed class ScimConfigResourceTypeSchemaExtension
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceTypeSchemaExtension" /> class.
    /// </summary>



    /// <summary>
    /// The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.
    /// </summary>
    /// <value>The URI of an extended schema, for example, \&quot;urn:edu:2.0:Staff\&quot;. Must be equal to the \&quot;id\&quot; attribute of a schema.</value>
    public string Schema { get; set; }



    /// <summary>
    /// Indicates whether a schema extension is required.
    /// </summary>
    /// <value>Indicates whether a schema extension is required.</value>
    public bool? Required { get; set; }


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
    /// Returns true if ScimConfigResourceTypeSchemaExtension instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceTypeSchemaExtension to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
