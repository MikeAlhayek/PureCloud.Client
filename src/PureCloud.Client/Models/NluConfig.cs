using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluConfig
{
    /// <summary>
    /// NLU domain.
    /// </summary>
    /// <value>NLU domain.</value>
    public CopilotNluDomain Domain { get; set; }

    /// <summary>
    /// Minimum confidence value of accepting NLU intents, must be greater than 0 and less than 1.
    /// </summary>
    /// <value>Minimum confidence value of accepting NLU intents, must be greater than 0 and less than 1.</value>
    public float? IntentConfidenceThreshold { get; set; }
}
