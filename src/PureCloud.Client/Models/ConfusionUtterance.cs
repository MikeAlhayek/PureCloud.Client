using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ConfusionUtterance
{
    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Utterance Text.
    /// </summary>
    /// <value>Utterance Text.</value>
    public string Text { get; set; }

    /// <summary>
    /// Utterance&#39;s similarity score, 0 being dissimilar and 1 being very similar.
    /// </summary>
    /// <value>Utterance&#39;s similarity score, 0 being dissimilar and 1 being very similar.</value>
    public float? Similarity { get; set; }
}
