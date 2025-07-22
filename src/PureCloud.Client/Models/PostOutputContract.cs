using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PostOutputContract
{
    /// <summary>
    /// JSON schema that defines the transformed, successful result that will be sent back to the caller.
    /// </summary>
    /// <value>JSON schema that defines the transformed, successful result that will be sent back to the caller.</value>
    public JsonSchemaDocument SuccessSchema { get; set; }
}
