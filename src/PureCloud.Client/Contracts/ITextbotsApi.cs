using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITextbotsApi
{
    Task<BotSearchResponseEntityListing> GetTextbotsBotsSearchAsync(IEnumerable<string> botType = null, string botName = null, IEnumerable<string> botId = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<TextBotFlowTurnResponse> CreateTextbotsBotflowsSessionTurnsAsync(string sessionId, TextBotFlowTurnRequest turnRequest, CancellationToken cancellationToken = default);

    Task<TextBotFlowLaunchResponse> CreateTextbotsBotflowsSessionsAsync(TextBotFlowLaunchRequest launchRequest, CancellationToken cancellationToken = default);

    Task<PostTextResponse> CreateTextbotsBotsExecuteAsync(PostTextRequest postTextRequest, CancellationToken cancellationToken = default);
}