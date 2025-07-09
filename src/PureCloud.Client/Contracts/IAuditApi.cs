using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IAuditApi
{
    Task<AuditQueryServiceMapping> GetAuditsQueryRealtimeServicemappingAsync(CancellationToken cancellationToken = default);

    Task<AuditQueryServiceMapping> GetAuditsQueryServicemappingAsync(CancellationToken cancellationToken = default);

    Task<AuditQueryExecutionStatusResponse> GetAuditsQueryTransactionIdAsync(string transactionId, CancellationToken cancellationToken = default);

    Task<AuditQueryExecutionResultsResponse> GetAuditsQueryTransactionIdResultsAsync(string transactionId, string cursor = null, int? pageSize = null, IList<string> expand = null, bool? allowRedirect = null, CancellationToken cancellationToken = default);

    Task<AuditQueryExecutionStatusResponse> PostAuditsQueryAsync(AuditQueryRequest body, CancellationToken cancellationToken = default);

    Task<AuditRealtimeQueryResultsResponse> PostAuditsQueryRealtimeAsync(AuditRealtimeQueryRequest body, List<string> expand = null, CancellationToken cancellationToken = default);

    Task<AuditRealtimeRelatedResultsResponse> CreateAuditsQueryRealtimeRelatedAsync(AuditRealtimeRelatedRequest body, List<string> expand = null, CancellationToken cancellationToken = default);
}
