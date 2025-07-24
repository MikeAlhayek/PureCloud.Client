using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH operation. The path and value follow very specific rules based on operation types. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>
public sealed class ScimV2PatchOperation
{
    /// <summary>
    /// The PATCH operation to perform.
    /// </summary>
    /// <value>The PATCH operation to perform.</value>
    public ScimV2PatchOperationOpEnum? Op { get; set; }

    /// <summary>
    /// The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.
    /// </summary>
    /// <value>The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.</value>
    public string Path { get; set; }

    /// <summary>
    /// The value to set in the path.
    /// </summary>
    /// <value>The value to set in the path.</value>
    public object Value { get; set; }
}
