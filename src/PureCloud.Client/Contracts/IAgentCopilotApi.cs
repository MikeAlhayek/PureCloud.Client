using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;
public interface IAgentCopilotApi
{
    Task<Copilot> GetAssistantCopilotAsync(string assistantId, CancellationToken cancellationToken = default);

    Task<Copilot> UpdateAssistantCopilotAsync(string assistantId, Copilot body, CancellationToken cancellationToken = default);
}
