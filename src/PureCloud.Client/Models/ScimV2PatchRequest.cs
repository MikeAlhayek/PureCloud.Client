using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH request. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>

public sealed class ScimV2PatchRequest
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimV2PatchRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchRequest" /> class.
    /// </summary>
    /// <param name="Schemas">The list of schemas used in the PATCH request. (required).</param>
    /// <param name="Operations">The list of operations to perform for the PATCH request..</param>



    /// <summary>
    /// The list of schemas used in the PATCH request.
    /// </summary>
    /// <value>The list of schemas used in the PATCH request.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// The list of operations to perform for the PATCH request.
    /// </summary>
    /// <value>The list of operations to perform for the PATCH request.</value>
    public IEnumerable<ScimV2PatchOperation> Operations { get; set; }


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
    /// Returns true if ScimV2PatchRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2PatchRequest to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
