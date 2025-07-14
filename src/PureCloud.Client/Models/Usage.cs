using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Usage
{
    /// <summary>
    /// Gets or Sets Types
    /// </summary>
    public IEnumerable<UsageItem> Types { get; set; }
}
