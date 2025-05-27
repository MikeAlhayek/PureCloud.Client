using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class AsyncQueryResponse
{
    /// <summary>
    /// Unique identifier for the async query execution. Can be used to check the status of the query and retrieve results.
    /// </summary>
    /// <value>Unique identifier for the async query execution. Can be used to check the status of the query and retrieve results.</value>
    public string JobId { get; set; }
}
