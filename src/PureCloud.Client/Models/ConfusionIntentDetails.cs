using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConfusionIntentDetails
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Number of utterances in this intent which are similar to parent utterance.
    /// </summary>
    /// <value>Number of utterances in this intent which are similar to parent utterance.</value>
    public int? UtteranceCount { get; set; }

    /// <summary>
    /// List of utterance which are similar to parent utterance.
    /// </summary>
    /// <value>List of utterance which are similar to parent utterance.</value>
    public IEnumerable<ConfusionUtterance> Utterances { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
