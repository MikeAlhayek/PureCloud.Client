using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;
public interface IAgentCopilotApi
{
    Task<Copilot> GetAssistantCopilotAsync(string assistantId, CancellationToken cancellationToken = default);

    Task<Copilot> PutAssistantCopilotAsync(string assistantId, Copilot body, CancellationToken cancellationToken = default);
}
