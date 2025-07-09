using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluInfo
{
    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public AddressableEntityRef Domain { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public NluDomainVersion Version { get; set; }

    /// <summary>
    /// Gets or Sets Intents
    /// </summary>
    public IEnumerable<Intent> Intents { get; set; }

    /// <summary>
    /// Gets or Sets EngineVersion
    /// </summary>
    public string EngineVersion { get; set; }

    /// <summary>
    /// Gets or Sets NluData
    /// </summary>
    public NluDomainVersion NluData { get; set; }
}
