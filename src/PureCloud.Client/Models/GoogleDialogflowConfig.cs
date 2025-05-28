using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class GoogleDialogflowConfig
{
    /// <summary>
    /// The integration identifier with which the assistant will fetch transcriptions and knowledge suggestions.
    /// </summary>
    /// <value>The integration identifier with which the assistant will fetch transcriptions and knowledge suggestions.</value>
    public string IntegrationId { get; set; }

    /// <summary>
    /// The conversation profiles for which the assistant will fetch transcription and knowledge suggestions.
    /// </summary>
    /// <value>The conversation profiles for which the assistant will fetch transcription and knowledge suggestions.</value>
    public IEnumerable<ConversationProfile> ConversationProfiles { get; set; }
}
