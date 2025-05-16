using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ProgramTopicLinksTopicsDefinitionsJob
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public ProgramTopicLinksTopicsDefinitionsJobStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TestTopicPhraseResults
    /// </summary>
    public IEnumerable<ProgramTopicLinksTestTopicPhraseResults> TestTopicPhraseResults { get; set; }
}
