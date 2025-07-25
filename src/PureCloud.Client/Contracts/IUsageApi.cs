using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IUsageApi
{
    Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync(string executionId, string clientId, CancellationToken cancellationToken = default);

    Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync(string clientId, string days = null, CancellationToken cancellationToken = default);

    Task<ApiUsageQueryResult> GetUsageQueryResultsAsync(string executionId, CancellationToken cancellationToken = default);

    Task<ApiUsageQueryResult> GetUsageSimpleSearchResultsAsync(string executionId, string after = null, int? pageSize = null, CancellationToken cancellationToken = default);

    Task<UsageExecutionResult> CreateOauthClientUsageQueryAsync(string clientId, ApiUsageClientQuery body, CancellationToken cancellationToken = default);

    Task<UsageExecutionResult> CreateUsageQueryAsync(ApiUsageOrganizationQuery body, CancellationToken cancellationToken = default);

    Task<UsageExecutionResult> CreateUsageSimpleSearchAsync(ApiUsageSimpleSearch body, CancellationToken cancellationToken = default);
}