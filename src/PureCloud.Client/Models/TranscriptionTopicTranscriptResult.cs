namespace PureCloud.Client.Models;

public sealed class TranscriptionTopicTranscriptResult
{
    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    public TranscriptionTopicTranscriptResultChannel? Channel { get; set; }

    /// <summary>
    /// Gets or Sets UtteranceId
    /// </summary>
    public string UtteranceId { get; set; }

    /// <summary>
    /// Gets or Sets IsFinal
    /// </summary>
    public bool? IsFinal { get; set; }

    /// <summary>
    /// Gets or Sets Alternatives
    /// </summary>
    public IEnumerable<TranscriptionTopicTranscriptAlternative> Alternatives { get; set; }

    /// <summary>
    /// Gets or Sets AgentAssistantId
    /// </summary>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Gets or Sets EngineProvider
    /// </summary>
    public string EngineProvider { get; set; }

    /// <summary>
    /// Gets or Sets EngineId
    /// </summary>
    public string EngineId { get; set; }

    /// <summary>
    /// Gets or Sets EngineName
    /// </summary>
    public string EngineName { get; set; }

    /// <summary>
    /// Gets or Sets Dialect
    /// </summary>
    public string Dialect { get; set; }

    /// <summary>
    /// Gets or Sets SpeechTextAnalyticsProgramId
    /// </summary>
    public string SpeechTextAnalyticsProgramId { get; set; }

    /// <summary>
    /// Gets or Sets AgentAssistEnabled
    /// </summary>
    public bool? AgentAssistEnabled { get; set; }

    /// <summary>
    /// Gets or Sets VoiceTranscriptionEnabled
    /// </summary>
    public bool? VoiceTranscriptionEnabled { get; set; }
}
