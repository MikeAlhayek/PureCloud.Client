using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

/// <summary>
/// OAuth API for managing OAuth clients, scopes, and authorizations
/// </summary>
public interface IOAuthApi
{
    /// <summary>
    /// Delete OAuth Client
    /// </summary>
    Task DeleteOauthClientAsync(string clientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a client that is authorized by the resource owner
    /// </summary>
    Task<OAuthAuthorization> GetOauthAuthorizationAsync(string clientId, string acceptLanguage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// List clients that have been authorized, requested, or revoked by the resource owner
    /// </summary>
    Task<OAuthAuthorizationListing> GetOauthAuthorizationsAsync(string acceptLanguage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get OAuth Client
    /// </summary>
    Task<OAuthClient> GetOauthClientAsync(string clientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the results of a usage query
    /// </summary>
    Task<ApiUsageQueryResult> GetOauthClientUsageQueryResultAsync(string executionId, string clientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a summary of OAuth client API usage
    /// </summary>
    Task<UsageExecutionResult> GetOauthClientUsageSummaryAsync(string clientId, string days = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of OAuth clients
    /// </summary>
    Task<OAuthClientEntityListing> GetOauthClientsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// An OAuth scope
    /// </summary>
    Task<OAuthScope> GetOauthScopeAsync(string scopeId, string acceptLanguage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The list of OAuth scopes
    /// </summary>
    Task<OAuthScopeListing> GetOauthScopesAsync(string acceptLanguage = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Regenerate Client Secret
    /// </summary>
    Task<OAuthClient> CreateOauthClientSecretAsync(string clientId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query for OAuth client API usage
    /// </summary>
    Task<UsageExecutionResult> CreateOauthClientUsageQueryAsync(string clientId, ApiUsageClientQuery body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create OAuth client
    /// </summary>
    Task<OAuthClient> CreateOauthClientAsync(OAuthClientRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update OAuth Client
    /// </summary>
    Task<OAuthClient> UpdateOauthClientAsync(string clientId, OAuthClientRequest body, CancellationToken cancellationToken = default);
}