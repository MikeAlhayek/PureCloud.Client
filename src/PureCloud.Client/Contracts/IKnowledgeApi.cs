namespace PureCloud.Client.Contracts;

public interface IKnowledgeApi
{
    /// <summary>
    /// Get knowledge base
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Knowledge base</returns>
    Task<Models.KnowledgeBase> GetKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create new knowledge base
    /// </summary>
    /// <param name="body">Knowledge base create request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Knowledge base</returns>
    Task<Models.KnowledgeBase> PostKnowledgeKnowledgebasesAsync(Models.KnowledgeBaseCreateRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update Salesforce source
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="sourceId">Source ID</param>
    /// <param name="body">Salesforce source request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Salesforce source response</returns>
    Task<Models.SalesforceSourceResponse> PutKnowledgeKnowledgebaseSourcesSalesforceSourceIdAsync(string knowledgeBaseId, string sourceId, Models.SalesforceSourceRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete knowledge base
    /// </summary>
    /// <param name="knowledgeBaseId">Knowledge base ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Knowledge base</returns>
    Task<Models.KnowledgeBase> DeleteKnowledgeKnowledgebaseAsync(string knowledgeBaseId, CancellationToken cancellationToken = default);
}