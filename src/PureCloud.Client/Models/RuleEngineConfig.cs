using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class RuleEngineConfig
{
    /// <summary>
    /// List of rules to evaluate by the engine.
    /// </summary>
    /// <value>List of rules to evaluate by the engine.</value>
    public IEnumerable<RuleConfig> Rules { get; set; }

    /// <summary>
    /// Fallback configuration.
    /// </summary>
    /// <value>Fallback configuration.</value>
    public Fallback Fallback { get; set; }
}
