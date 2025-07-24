using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Output definition of Action.
/// </summary>
public sealed class ActionOutput
{
    // JSON schema that defines the transformed, successful result that will be sent back to the caller.
    public JsonSchemaDocument SuccessSchema { get; set; }

    // URI to retrieve success schema.
    public string SuccessSchemaUri { get; set; }

    // JSON schema that defines the body of response when request is not successful.
    public JsonSchemaDocument ErrorSchema { get; set; }

    // URI to retrieve error schema.
    public string ErrorSchemaUri { get; set; }

    // JSON schema that defines the transformed, successful result that will be sent back to the caller (flattened format).
    public object SuccessSchemaFlattened { get; set; }

    // JSON schema that defines the body of response when request is not successful (flattened format).
    public object ErrorSchemaFlattened { get; set; }
}
