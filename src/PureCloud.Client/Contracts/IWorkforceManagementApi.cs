using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IWorkforceManagementApi
{
    Task<UserScheduleAdherence[]> GetAdherenceAsync(IEnumerable<string> userId, CancellationToken cancellationToken = default);

    Task<AdherenceExplanationAsyncResponse> CreateAdherenceExplanationAsync(AddAdherenceExplanationAgentRequest body, CancellationToken cancellationToken = default);

    Task DeleteBusinessUnitAsync(string businessUnitId, CancellationToken cancellationToken = default);

    Task<AgentIntegrationsResponse> UpdateAgentIntegrationsHrisAsync(string agentId, AgentIntegrationsRequest body, CancellationToken cancellationToken = default);
}