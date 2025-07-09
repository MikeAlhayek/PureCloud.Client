using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ExecutionDataRequest
{
    /// <summary>
    /// A list of ids to retrieve
    /// </summary>
    /// <value>A list of ids to retrieve</value>
    public IEnumerable<string> Ids { get; set; }
}
