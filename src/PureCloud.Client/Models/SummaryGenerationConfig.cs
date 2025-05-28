using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SummaryGenerationConfig
{
    /// <summary>
    /// Copilot generated summary is enabled.
    /// </summary>
    /// <value>Copilot generated summary is enabled.</value>
    public bool? Enabled { get; set; }
}
