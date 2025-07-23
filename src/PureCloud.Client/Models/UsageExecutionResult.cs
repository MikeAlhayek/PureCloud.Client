using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UsageExecutionResult
{
    public string ExecutionId { get; set; }
    public string ResultsUri { get; set; }
}
