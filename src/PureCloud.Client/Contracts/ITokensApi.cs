using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITokensApi
{
    /// <summary>
    /// Fetch information about the current token
    /// </summary>
    /// <param name="preserveIdleTTL">preserveIdleTTL indicates whether the idle token timeout should be reset or preserved. If preserveIdleTTL is true, then TTL value is not reset. If unset or false, the value is reset.</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Token information</returns>
    Task<TokenInfo> GetTokensMeAsync(bool? preserveIdleTTL = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete all auth tokens for the specified user
    /// </summary>
    /// <param name="userId">User ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task</returns>
    Task<bool> DeleteTokenAsync(string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete auth token used to make the request
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task</returns>
    Task<bool> DeleteTokensMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the current Idle Token Timeout Value
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Current idle token timeout settings</returns>
    Task<IdleTokenTimeout> GetTokensTimeoutAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Verify user token
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Task</returns>
    Task<bool> HeadTokensMeAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update or Enable/Disable the Idle Token Timeout
    /// </summary>
    /// <param name="body">Idle token timeout settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated idle token timeout settings</returns>
    Task<IdleTokenTimeout> UpdateTokensTimeoutAsync(IdleTokenTimeout body, CancellationToken cancellationToken = default);
}