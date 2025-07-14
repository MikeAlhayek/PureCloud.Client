using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class WorkspaceSummary
{
    /// <summary>
    /// Gets or Sets TotalDocumentCount
    /// </summary>
    public long? TotalDocumentCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalDocumentByteCount
    /// </summary>
    public long? TotalDocumentByteCount { get; set; }
}
