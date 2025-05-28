using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Copilot
{
    /// <summary>
    /// Language understanding engine type.
    /// </summary>
    /// <value>Language understanding engine type.</value>
    public CopilotNluEngineTypeEnum? NluEngineType { get; set; }

    /// <summary>
    /// Copilot is enabled.
    /// </summary>
    /// <value>Copilot is enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Copilot is live on selected queue.
    /// </summary>
    /// <value>Copilot is live on selected queue.</value>
    public bool? LiveOnQueue { get; set; }

    /// <summary>
    /// Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.
    /// </summary>
    /// <value>Copilot default language, e.g. [en-US, es-US, es-ES]. Once set, it can not be modified.</value>
    public string DefaultLanguage { get; set; }

    /// <summary>
    /// Knowledge answer configuration.
    /// </summary>
    /// <value>Knowledge answer configuration.</value>
    public KnowledgeAnswerConfig KnowledgeAnswerConfig { get; set; }

    /// <summary>
    /// Copilot generated summary configuration.
    /// </summary>
    /// <value>Copilot generated summary configuration.</value>
    public SummaryGenerationConfig SummaryGenerationConfig { get; set; }

    /// <summary>
    /// Copilot generated wrapup code prediction configuration.
    /// </summary>
    /// <value>Copilot generated wrapup code prediction configuration.</value>
    public WrapupCodePredictionConfig WrapupCodePredictionConfig { get; set; }

    /// <summary>
    /// Answer generation configuration.
    /// </summary>
    /// <value>Answer generation configuration.</value>
    public AnswerGenerationConfig AnswerGenerationConfig { get; set; }

    /// <summary>
    /// NLU configuration.
    /// </summary>
    /// <value>NLU configuration.</value>
    public NluConfig NluConfig { get; set; }

    /// <summary>
    /// Rule engine configuration.
    /// </summary>
    /// <value>Rule engine configuration.</value>
    public RuleEngineConfig RuleEngineConfig { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
