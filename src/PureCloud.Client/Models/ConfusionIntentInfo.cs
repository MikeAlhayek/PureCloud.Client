using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConfusionIntentInfo
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    public string Name { get; set; }

    /// <summary>
    /// Number of utterances in this intent which are similar to parent utterance.
    /// </summary>
    /// <value>Number of utterances in this intent which are similar to parent utterance.</value>
    public int? UtteranceCount { get; set; }
}
