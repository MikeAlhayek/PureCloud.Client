using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IMessagingApi
{
    /// <summary>
    /// Delete a messaging setting.
    /// </summary>
    /// <param name="messageSettingId">The messaging setting ID.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if the deletion was successful; otherwise, false.</returns>
    Task<bool> DeleteMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete the organization's default messaging setting.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if the deletion was successful; otherwise, false.</returns>
    Task<bool> DeleteMessagingSettingsDefaultAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a supported content profile.
    /// </summary>
    /// <param name="supportedContentId">The supported content ID.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>True if the deletion was successful; otherwise, false.</returns>
    Task<bool> DeleteMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a messaging setting.
    /// </summary>
    /// <param name="messageSettingId">The messaging setting ID.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The messaging setting.</returns>
    Task<MessagingSetting> GetMessagingSettingAsync(string messageSettingId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of messaging settings.
    /// </summary>
    /// <param name="pageSize">Page size for pagination.</param>
    /// <param name="pageNumber">Page number for pagination.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>A list of messaging settings.</returns>
    Task<MessagingConfigListing> GetMessagingSettingsAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the organization's default messaging setting.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The default messaging setting.</returns>
    Task<MessagingSetting> GetMessagingSettingsDefaultAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a list of supported content profiles.
    /// </summary>
    /// <param name="pageSize">Page size for pagination.</param>
    /// <param name="pageNumber">Page number for pagination.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>A list of supported content profiles.</returns>
    Task<SupportedContentListing> GetMessagingSupportedContentAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a supported content profile.
    /// </summary>
    /// <param name="supportedContentId">The supported content ID.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The supported content profile.</returns>
    Task<SupportedContent> GetMessagingSupportedContentAsync(string supportedContentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a messaging setting.
    /// </summary>
    /// <param name="messageSettingId">The messaging setting ID.</param>
    /// <param name="body">The messaging setting request body.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The updated messaging setting.</returns>
    Task<MessagingSetting> UpdateMessagingSettingAsync(string messageSettingId, MessagingSettingRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a supported content profile.
    /// </summary>
    /// <param name="supportedContentId">The supported content ID.</param>
    /// <param name="body">The supported content body.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The updated supported content profile.</returns>
    Task<SupportedContent> UpdateMessagingSupportedContentAsync(string supportedContentId, SupportedContent body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a messaging setting.
    /// </summary>
    /// <param name="body">The messaging setting request body.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The created messaging setting.</returns>
    Task<MessagingSetting> CreateMessagingSettingAsync(MessagingSettingRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a supported content profile.
    /// </summary>
    /// <param name="body">The supported content body.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The created supported content profile.</returns>
    Task<SupportedContent> CreateMessagingSupportedContentAsync(SupportedContent body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the organization's default messaging setting.
    /// </summary>
    /// <param name="body">The messaging setting default request body.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>The updated default messaging setting.</returns>
    Task<MessagingSetting> UpdateMessagingSettingsDefaultAsync(MessagingSettingDefaultRequest body, CancellationToken cancellationToken = default);
}