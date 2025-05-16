using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PublishProgramTopicsDefinitionsJob
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public PublishProgramTopicsDefinitionsJobStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TestTopicPhraseResults
    /// </summary>
    public IEnumerable<PublishProgramTestTopicPhraseResults> TestTopicPhraseResults { get; set; }
}
