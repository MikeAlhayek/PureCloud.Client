using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IOutboundApi
{
    /// <summary>
    /// Get an attempt limits resource by ID
    /// </summary>
    /// <param name="attemptLimitsId">Attempt limits ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Attempt limits resource</returns>
    Task<AttemptLimits> GetOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Query attempt limits list
    /// </summary>
    /// <param name="pageSize">Page size. The max that will be returned is 100.</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="allowEmptyResult">Whether to return an empty result when there are no results</param>
    /// <param name="filterType">Filter type</param>
    /// <param name="name">Name</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Attempt limits entity listing</returns>
    Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Create attempt limits
    /// </summary>
    /// <param name="body">AttemptLimits</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created attempt limits</returns>
    Task<AttemptLimits> CreateOutboundAttemptlimitAsync(AttemptLimits body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Update attempt limits
    /// </summary>
    /// <param name="attemptLimitsId">Attempt limits ID</param>
    /// <param name="body">AttemptLimits</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated attempt limits</returns>
    Task<AttemptLimits> UpdateOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Delete attempt limits
    /// </summary>
    /// <param name="attemptLimitsId">Attempt limits ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successfully deleted</returns>
    Task<bool> DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a callable time set by ID
    /// </summary>
    /// <param name="callableTimeSetId">Callable Time Set ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Callable time set</returns>
    Task<CallableTimeSet> GetOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Query callable time set list
    /// </summary>
    /// <param name="pageSize">Page size. The max that will be returned is 100.</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="allowEmptyResult">Whether to return an empty result when there are no results</param>
    /// <param name="filterType">Filter type</param>
    /// <param name="name">Name</param>
    /// <param name="sortBy">Sort by</param>
    /// <param name="sortOrder">Sort order</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Callable time set entity listing</returns>
    Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Create a callable time set
    /// </summary>
    /// <param name="body">DialerCallableTimeSet</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created callable time set</returns>
    Task<CallableTimeSet> CreateOutboundCallabletimesetAsync(CallableTimeSet body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Update a callable time set
    /// </summary>
    /// <param name="callableTimeSetId">Callable Time Set ID</param>
    /// <param name="body">DialerCallableTimeSet</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated callable time set</returns>
    Task<CallableTimeSet> UpdateOutboundCallabletimesetAsync(string callableTimeSetId, CallableTimeSet body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Delete a callable time set
    /// </summary>
    /// <param name="callableTimeSetId">Callable Time Set ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successfully deleted</returns>
    Task<bool> DeleteOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a campaign by ID
    /// </summary>
    /// <param name="campaignId">Campaign ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Campaign</returns>
    Task<Campaign> GetOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Create a campaign
    /// </summary>
    /// <param name="body">Campaign</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Created campaign</returns>
    Task<Campaign> CreateOutboundCampaignAsync(Campaign body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Update a campaign
    /// </summary>
    /// <param name="campaignId">Campaign ID</param>
    /// <param name="body">Campaign</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Updated campaign</returns>
    Task<Campaign> UpdateOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Delete a campaign
    /// </summary>
    /// <param name="campaignId">Campaign ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if successfully deleted</returns>
    Task<bool> DeleteOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
}
