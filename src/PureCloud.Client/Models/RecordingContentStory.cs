using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingContentStory
/// </summary>
public sealed class RecordingContentStory
{
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Gets or Sets Duration
    /// </summary>
    public int? Duration { get; set; }
}
