using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISettingsApi
{
    /// <summary>
    /// Get email Contact Center settings
    /// </summary>
    Task<EmailSettings> GetEmailsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update email Contact Center settings
    /// </summary>
    Task<EmailSettings> UpdateEmailsSettingsAsync(EmailSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get email threading settings
    /// </summary>
    Task<EmailThreadingSettings> GetEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update email threading settings
    /// </summary>
    Task<EmailThreadingSettings> UpdateEmailsSettingsThreadingAsync(EmailThreadingSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reset email threading settings to default
    /// </summary>
    Task<bool> DeleteEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the execution history enabled setting
    /// </summary>
    Task<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the execution history enabled setting
    /// </summary>
    Task<ExecutionDataGlobalSettingsResponse> UpdateSettingsExecutiondataAsync(ExecutionDataSettingsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    Task<AutoAnswerSettings> UpdateUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    Task<bool> DeleteUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create agent auto answer settings
    /// </summary>
    Task<AutoAnswerSettings> CreateUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);
}