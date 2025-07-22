using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PostInputContract
{
    /// <summary>
    /// JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path.
    /// </summary>
    /// <value>JSON Schema that defines the body of the request that the client (edge/architect/postman) is sending to the service, on the /execute path.</value>
    public JsonSchemaDocument InputSchema { get; set; }
}
