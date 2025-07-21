using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWebChatApi
{
    Task<WebChatSettings> GetSettingsAsync(CancellationToken cancellationToken = default);

    Task<WebChatSettings> UpdateSettingsAsync(WebChatSettings body, CancellationToken cancellationToken = default);

    Task<bool> DeleteSettingsAsync(CancellationToken cancellationToken = default);

    Task<CreateWebChatConversationResponse> CreateGuestConversationAsync(CreateWebChatConversationRequest body, CancellationToken cancellationToken = default);
}