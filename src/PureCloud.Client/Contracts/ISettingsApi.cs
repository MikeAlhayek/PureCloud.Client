using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ISettingsApi
{
    /// <summary>
    /// Get email Contact Center settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EmailSettings> GetEmailsSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update email Contact Center settings
    /// </summary>
    /// <param name="body">Email settings to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EmailSettings> UpdateEmailsSettingsAsync(EmailSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get email threading settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EmailThreadingSettings> GetEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update email threading settings
    /// </summary>
    /// <param name="body">Email threading settings to update</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EmailThreadingSettings> UpdateEmailsSettingsThreadingAsync(EmailThreadingSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reset email threading settings to default
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEmailsSettingsThreadingAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the execution history enabled setting
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExecutionDataGlobalSettingsResponse> GetSettingsExecutiondataAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the execution history enabled setting
    /// </summary>
    /// <param name="body">New execution data setting</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExecutionDataGlobalSettingsResponse> UpdateSettingsExecutiondataAsync(ExecutionDataSettingsRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get agent auto answer settings
    /// </summary>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update agent auto answer settings
    /// </summary>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AutoAnswerSettings> UpdateUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete agent auto answer settings
    /// </summary>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create agent auto answer settings
    /// </summary>
    /// <param name="agentId">The agent to apply the auto answer settings to</param>
    /// <param name="body">AutoAnswerSettings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AutoAnswerSettings> CreateUsersAgentuiAgentsAutoanswerSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);
}
