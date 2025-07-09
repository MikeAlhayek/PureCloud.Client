using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class FlowHealth
{
    /// <summary>
    /// Info about given flow version.
    /// </summary>
    /// <value>Info about given flow version.</value>
    public FlowHealthVersionInfo FlowVersionInfo { get; set; }

    /// <summary>
    /// Each language&#39;s status about its health computation.
    /// </summary>
    /// <value>Each language&#39;s status about its health computation.</value>
    public Dictionary<string, LocaleInfo> LanguageInfo { get; set; }

    /// <summary>
    /// Health metrics information for the intents.
    /// </summary>
    /// <value>Health metrics information for the intents.</value>
    public IEnumerable<FlowHealthIntentInfo> Intents { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
