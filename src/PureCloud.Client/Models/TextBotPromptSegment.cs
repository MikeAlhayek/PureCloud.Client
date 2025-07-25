using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TextBotPromptSegment
{
    /// <summary>
    /// The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.
    /// </summary>
    /// <value>The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.</value>
    public TextBotPromptSegmentTypeEnum? Type { get; set; }

    /// <summary>
    /// The text of this prompt segment.
    /// </summary>
    /// <value>The text of this prompt segment.</value>
    public string Text { get; set; }

    /// <summary>
    /// Additional details describing the segment’s contents, which the client should honour where possible.
    /// </summary>
    /// <value>Additional details describing the segment’s contents, which the client should honour where possible.</value>
    public Format Format { get; set; }

    /// <summary>
    /// Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;.
    /// </summary>
    /// <value>Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;.</value>
    public IEnumerable<MessageContent> Content { get; set; }
}
