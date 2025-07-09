using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SystemPrompt
{
    /// <summary>
    /// The system prompt identifier
    /// </summary>
    /// <value>The system prompt identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Resources
    /// </summary>
    public IEnumerable<SystemPromptAsset> Resources { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
