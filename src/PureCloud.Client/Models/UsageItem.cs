using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UsageItem
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public UsageItemTypeEnum? Type { get; set; }

    /// <summary>
    /// Gets or Sets TotalDocumentByteCount
    /// </summary>
    public long? TotalDocumentByteCount { get; set; }

    /// <summary>
    /// Gets or Sets TotalDocumentCount
    /// </summary>
    public long? TotalDocumentCount { get; set; }
}
