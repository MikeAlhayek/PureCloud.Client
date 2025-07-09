using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class NluUtteranceSegment
{
    /// <summary>
    /// The text of the segment.
    /// </summary>
    /// <value>The text of the segment.</value>
    public string Text { get; set; }

    /// <summary>
    /// The entity annotation of the segment.
    /// </summary>
    /// <value>The entity annotation of the segment.</value>
    public NamedEntityAnnotation Entity { get; set; }
}
