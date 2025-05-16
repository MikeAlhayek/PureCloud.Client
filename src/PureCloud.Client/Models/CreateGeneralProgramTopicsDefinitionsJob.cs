using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CreateGeneralProgramTopicsDefinitionsJob
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    public CreateGeneralProgramTopicsDefinitionsJobStateEnum? State { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TestTopicPhraseResults
    /// </summary>
    public IEnumerable<CreateGeneralProgramTestTopicPhraseResults> TestTopicPhraseResults { get; set; }
}
