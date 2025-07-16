using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class MergeRequest
{
    /// <summary>
    /// The ID of the source contact for the merge operation
    /// </summary>
    /// <value>The ID of the source contact for the merge operation</value>
    public string SourceContactId { get; set; }

    /// <summary>
    /// The ID of the target contact for the merge operation
    /// </summary>
    /// <value>The ID of the target contact for the merge operation</value>
    public string TargetContactId { get; set; }
}
