using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IOutboundApi
{
    Task<AttemptLimits> GetOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);
    Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    
    Task<AttemptLimits> CreateOutboundAttemptlimitAsync(AttemptLimits body, CancellationToken cancellationToken = default);
    
    Task<AttemptLimits> UpdateOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default);
    
    Task DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);

    // CallableTimeSet methods
    Task<CallableTimeSet> GetOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);
    Task<CallableTimeSetEntityListing> GetOutboundCallabletimesetsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    Task<CallableTimeSet> CreateOutboundCallabletimesetAsync(CallableTimeSet body, CancellationToken cancellationToken = default);
    Task<CallableTimeSet> UpdateOutboundCallabletimesetAsync(string callableTimeSetId, CallableTimeSet body, CancellationToken cancellationToken = default);
    Task DeleteOutboundCallabletimesetAsync(string callableTimeSetId, CancellationToken cancellationToken = default);

    // Campaign methods (basic operations)
    Task<Campaign> GetOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
    Task<Campaign> CreateOutboundCampaignAsync(Campaign body, CancellationToken cancellationToken = default);
    Task<Campaign> UpdateOutboundCampaignAsync(string campaignId, Campaign body, CancellationToken cancellationToken = default);
    Task DeleteOutboundCampaignAsync(string campaignId, CancellationToken cancellationToken = default);
}
