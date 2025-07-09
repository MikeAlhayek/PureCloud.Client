using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Prompt
{
    /// <summary>
    /// The prompt identifier
    /// </summary>
    /// <value>The prompt identifier</value>
    public string Id { get; set; }

    /// <summary>
    /// The prompt name.
    /// </summary>
    /// <value>The prompt name.</value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// List of resources associated with this prompt
    /// </summary>
    /// <value>List of resources associated with this prompt</value>
    public IEnumerable<PromptAsset> Resources { get; set; }

    /// <summary>
    /// Current prompt operation status
    /// </summary>
    /// <value>Current prompt operation status</value>
    public Operation CurrentOperation { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
