using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface IOutboundApi
{
    // GET operations
    Task<AttemptLimits> GetOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);
    Task<AttemptLimitsEntityListing> GetOutboundAttemptlimitsAsync(int? pageSize = null, int? pageNumber = null, bool? allowEmptyResult = null, string filterType = null, string name = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);
    
    // POST operations  
    Task<AttemptLimits> CreateOutboundAttemptlimitAsync(AttemptLimits body, CancellationToken cancellationToken = default);
    
    // PUT operations
    Task<AttemptLimits> UpdateOutboundAttemptlimitAsync(string attemptLimitsId, AttemptLimits body, CancellationToken cancellationToken = default);
    
    // DELETE operations
    Task DeleteOutboundAttemptlimitAsync(string attemptLimitsId, CancellationToken cancellationToken = default);
}