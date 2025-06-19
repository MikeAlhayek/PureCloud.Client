using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CommonRuleBulkDeleteRequest
{
    /// <summary>
    /// The user supplied rule ids to be deleted
    /// </summary>
    /// <value>The user supplied rule ids to be deleted</value>
    public IEnumerable<string> RuleIds { get; set; }
}
