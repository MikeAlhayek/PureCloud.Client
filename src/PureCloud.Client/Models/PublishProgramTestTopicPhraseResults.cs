using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PublishProgramTestTopicPhraseResults
{
    /// <summary>
    /// Gets or Sets ProcessedTranscriptsCount
    /// </summary>
    public long? ProcessedTranscriptsCount { get; set; }

    /// <summary>
    /// Gets or Sets MatchedTranscriptsCount
    /// </summary>
    public long? MatchedTranscriptsCount { get; set; }

    /// <summary>
    /// Gets or Sets MatchedTranscripts
    /// </summary>
    public IEnumerable<PublishProgramTestPhraseMatchedTranscript> MatchedTranscripts { get; set; }
}
