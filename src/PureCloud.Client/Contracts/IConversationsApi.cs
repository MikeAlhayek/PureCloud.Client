using PureCloud.Client.Models;
using PureCloud.Client.Models.Analytics;

namespace PureCloud.Client.Contracts;

public interface IConversationsApi
{
    Task<bool> DeleteFacebookMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);
    Task<bool> DeleteMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default);
    Task<bool> DeleteMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default);
    Task<bool> DeleteOpenMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);
    Task<bool> DeleteParticipantCodeAsync(string conversationId, string participantId, string addCommunicationCode, CancellationToken cancellationToken = default);
    Task<bool> DeleteParticipantConsultAsync(string conversationId, string participantId, CancellationToken cancellationToken = default);
    Task<bool> DeleteTwitterMessagingIntegrationAsync(string integrationId, CancellationToken cancellationToken = default);
    Task<Conversation> GetConversationAsync(string conversationId, CancellationToken cancellationToken = default);
    Task<AnalyticsConversationWithoutAttributes> GetConversationDetailsAsync(string conversationId, CancellationToken cancellationToken = default);
}
