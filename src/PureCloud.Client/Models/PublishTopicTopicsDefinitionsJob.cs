using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PublishTopicTopicsDefinitionsJob
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public PublishTopicTopicsDefinitionsJobStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TestTopicPhraseResults
    /// </summary>
    public IEnumerable<PublishTopicTestTopicPhraseResults> TestTopicPhraseResults { get; set; }
}
