using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluUtterance
{
    /// <summary>
    /// The source of the utterance.
    /// </summary>
    /// <value>The source of the utterance.</value>
    public NluUtteranceSourceEnum? Source { get; set; }

    /// <summary>
    /// ID of the utterance.
    /// </summary>
    /// <value>ID of the utterance.</value>
    public string Id { get; set; }

    /// <summary>
    /// The list of segments that that constitute this utterance for the given intent.
    /// </summary>
    /// <value>The list of segments that that constitute this utterance for the given intent.</value>
    public IEnumerable<NluUtteranceSegment> Segments { get; set; }
}
