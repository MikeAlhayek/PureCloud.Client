using PureCloud.Client.Models;
using PureCloud.Client.Models.Organizations;

namespace PureCloud.Client.Contracts;

public interface IOrganizationApi
{
    /// <summary>
    /// Get organization.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Organization</returns>
    Task<Organization> GetOrganizationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the organization's settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>OrgAuthSettings</returns>
    Task<OrgAuthSettings> GetOrganizationAuthenticationSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the organization's settings
    /// </summary>
    /// <param name="body">Org settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>OrgAuthSettings</returns>
    Task<OrgAuthSettings> UpdateOrganizationAuthenticationSettingsAsync(OrgAuthSettings body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization.
    /// </summary>
    /// <param name="body">Organization</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Organization</returns>
    Task<Organization> UpdateOrganizationAsync(Organization body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get a limit change request
    /// </summary>
    /// <param name="requestId">Unique id for the limit change request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitChangeRequestDetails</returns>
    Task<LimitChangeRequestDetails> GetOrganizationLimitsChangeRequestAsync(string requestId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the available limit change requests
    /// </summary>
    /// <param name="after">Timestamp indicating the date to begin after when searching for requests</param>
    /// <param name="before">Timestamp indicating the date to end before when searching for requests</param>
    /// <param name="status">Status of the request to be filtered by</param>
    /// <param name="pageSize">Page Size</param>
    /// <param name="expand">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitChangeRequestsEntityListing</returns>
    Task<LimitChangeRequestsEntityListing> GetOrganizationLimitsChangeRequestsAsync(long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expand = null, CancellationToken cancellationToken = default);
}