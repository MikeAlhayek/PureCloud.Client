using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FaxSummary
{
    /// <summary>
    /// Gets or Sets ReadCount
    /// </summary>
    public int? ReadCount { get; set; }

    /// <summary>
    /// Gets or Sets UnreadCount
    /// </summary>
    public int? UnreadCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    public int? TotalCount { get; set; }
}
