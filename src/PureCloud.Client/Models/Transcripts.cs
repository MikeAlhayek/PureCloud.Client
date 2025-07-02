using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Transcripts
{
    /// <summary>
    /// List of transcript contents which needs to satisfy exact match criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy exact match criteria</value>
    public IEnumerable<string> ExactMatch { get; set; }

    /// <summary>
    /// List of transcript contents which needs to satisfy contains criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy contains criteria</value>
    public IEnumerable<string> Contains { get; set; }

    /// <summary>
    /// List of transcript contents which needs to satisfy does not contain criteria
    /// </summary>
    /// <value>List of transcript contents which needs to satisfy does not contain criteria</value>
    public IEnumerable<string> DoesNotContain { get; set; }
}
