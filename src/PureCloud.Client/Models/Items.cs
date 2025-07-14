using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Items
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Pattern
    /// </summary>
    public string Pattern { get; set; }
}
