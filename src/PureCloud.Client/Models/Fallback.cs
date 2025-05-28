using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Fallback
{
    /// <summary>
    /// Fallback actions are enabled.
    /// </summary>
    /// <value>Fallback actions are enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Fallback actions.
    /// </summary>
    /// <value>Fallback actions.</value>
    public IEnumerable<CopilotFallbackAction> Actions { get; set; }
}
