using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Assistant
{
    /// <summary>
    /// State of the assistant.
    /// </summary>
    /// <value>State of the assistant.</value>
    public AssistantStateEnum? State { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the assistant that will assist the agent.
    /// </summary>
    /// <value>The name of the assistant that will assist the agent.</value>
    public string Name { get; set; }

    /// <summary>
    /// Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The user who created the assistant.
    /// </summary>
    /// <value>The user who created the assistant.</value>
    public UserReference CreatedBy { get; set; }

    /// <summary>
    /// The user who last modified the assistant.
    /// </summary>
    /// <value>The user who last modified the assistant.</value>
    public UserReference ModifiedBy { get; set; }

    /// <summary>
    /// (Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.
    /// </summary>
    /// <value>(Deprecated: use the &#39;knowledgeSuggestionConfig&#39; for genesys knowledge suggestions) Configuration of Dialogflow used to assist the agent with transcriptions and knowledge suggestions.</value>
    public GoogleDialogflowConfig GoogleDialogflowConfig { get; set; }

    /// <summary>
    /// Configuration for speech transcription used to assist the agent.
    /// </summary>
    /// <value>Configuration for speech transcription used to assist the agent.</value>
    public TranscriptionConfig TranscriptionConfig { get; set; }

    /// <summary>
    /// Configuration that defines how to produce knowledge suggestions.
    /// </summary>
    /// <value>Configuration that defines how to produce knowledge suggestions.</value>
    public KnowledgeSuggestionConfig KnowledgeSuggestionConfig { get; set; }

    /// <summary>
    /// Agent copilot configuration.
    /// </summary>
    /// <value>Agent copilot configuration.</value>
    public Copilot Copilot { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
