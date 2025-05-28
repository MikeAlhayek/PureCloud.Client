using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RuleConfig
{
    /// <summary>
    /// Rule ID.
    /// </summary>
    /// <value>Rule ID.</value>
    public string Id { get; set; }

    /// <summary>
    /// Rule enabled.
    /// </summary>
    /// <value>Rule enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Rule configuration.
    /// </summary>
    /// <value>Rule configuration.</value>
    public CopilotRule Rule { get; set; }
}
