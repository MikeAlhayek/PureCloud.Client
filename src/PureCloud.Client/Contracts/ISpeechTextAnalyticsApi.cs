using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// Represents speech and text analytics API operations
/// </summary>
public interface ISpeechTextAnalyticsApi
{
    /// <summary>
    /// Get Speech and Text Analytics for a specific conversation
    /// </summary>
    Task<ConversationMetrics> GetSpeechTextAnalyticsConversationAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new Speech & Text Analytics category
    /// </summary>
    Task<StaCategory> CreateSpeechTextAnalyticsCategoryAsync(CategoryRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update existing Speech & Text Analytics program
    /// </summary>
    Task<Program> UpdateSpeechTextAnalyticsProgramAsync(string programId, ProgramRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a Speech & Text Analytics category by ID
    /// </summary>
    Task DeleteSpeechTextAnalyticsCategoryAsync(string categoryId, CancellationToken cancellationToken = default);
}