using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IMessagingApi
{
    Task<bool> DeleteMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default);

    Task<bool> DeleteMessagingSettingsDefaultAsync(CancellationToken cancellationToken = default);

    Task<bool> DeleteMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default);

    Task<MessagingSetting> GetMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default);

    Task<MessagingConfigListing> GetMessagingSettingsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<MessagingSetting> GetMessagingSettingsDefaultAsync(CancellationToken cancellationToken = default);

    Task<SupportedContentListing> GetMessagingSupportedContentAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    Task<SupportedContent> GetMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default);

    Task<MessagingSetting> UpdateMessagingSettingAsync(string messageSettingId, MessagingSettingRequest body, CancellationToken cancellationToken = default);

    Task<SupportedContent> UpdateMessagingSupportedContentAsync(string supportedContentId, SupportedContent body, CancellationToken cancellationToken = default);

    Task<MessagingSetting> CreateMessagingSettingAsync(MessagingSettingRequest body, CancellationToken cancellationToken = default);

    Task<SupportedContent> CreateMessagingSupportedContentAsync(SupportedContent body, CancellationToken cancellationToken = default);

    Task<MessagingSetting> UpdateMessagingSettingsDefaultAsync(MessagingSettingDefaultRequest body, CancellationToken cancellationToken = default);
}