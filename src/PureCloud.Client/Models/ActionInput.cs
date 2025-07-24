using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Input requirements of Action.
/// </summary>
public sealed class ActionInput
{
    // JSON Schema that defines the body of the request that the client is sending to the service, on the /execute path.
    public JsonSchemaDocument InputSchema { get; set; }

    // JSON Schema that defines the body of the request that the client is sending to the service, on the /execute path. The schema is transformed based on Architect's flattened format.
    public JsonSchemaDocument InputSchemaFlattened { get; set; }

    // The URI of the input schema.
    public string InputSchemaUri { get; set; }
}
