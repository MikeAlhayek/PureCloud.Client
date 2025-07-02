using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IAgentUIApi
{
    Task<bool> DeleteUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    Task<AutoAnswerSettings> GetUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, CancellationToken cancellationToken = default);

    Task<AutoAnswerSettings> PatchUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);

    Task<AutoAnswerSettings> UpdateUsersAgentuiAgentsAutoanswerAgentIdSettingsAsync(string agentId, AutoAnswerSettings body, CancellationToken cancellationToken = default);
}
