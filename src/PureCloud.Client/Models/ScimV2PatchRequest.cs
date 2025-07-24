namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH request. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>
public sealed class ScimV2PatchRequest
{
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
}
