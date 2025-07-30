using System;
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
    /// <param name="expands">Which fields, if any, to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitChangeRequestsEntityListing</returns>
    Task<LimitChangeRequestsEntityListing> GetOrganizationLimitsChangeRequestsAsync(long? after = null, long? before = null, string status = null, int? pageSize = null, List<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get field config for an entity type
    /// </summary>
    /// <param name="type">Field type</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>FieldConfig</returns>
    Task<FieldConfig> GetFieldConfigAsync(string type, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the list of domains that will be allowed to embed PureCloud applications
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EmbeddedIntegration</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<EmbeddedIntegration> GetOrganizationEmbeddedIntegrationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get organization IP address whitelist settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IpAddressAuthentication</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<IpAddressAuthentication> GetOrganizationIpAddressAuthenticationAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get limit documentation
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitDocumentation</returns>
    Task<LimitDocumentation> GetOrganizationLimitsDocsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get free trial limit documentation
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>FreeTrialLimitDocs</returns>
    Task<FreeTrialLimitDocs> GetOrganizationLimitsDocsFreeTrialAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the effective limits in a namespace for an organization
    /// </summary>
    /// <param name="namespaceName">The namespace to fetch limits for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitsEntityListing</returns>
    Task<LimitsEntityListing> GetOrganizationLimitsNamespaceAsync(string namespaceName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the default limits in a namespace for an organization
    /// </summary>
    /// <param name="namespaceName">The namespace to fetch defaults limits for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>LimitsEntityListing</returns>
    Task<LimitsEntityListing> GetOrganizationLimitsNamespaceDefaultsAsync(string namespaceName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the available limit namespaces
    /// </summary>
    /// <param name="pageSize">Page size</param>
    /// <param name="pageNumber">Page number</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Object</returns>
    Task<object> GetOrganizationLimitsNamespacesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get organization whitelist settings
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>OrgWhitelistSettings</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<OrgWhitelistSettings> GetOrganizationWhitelistAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization feature
    /// </summary>
    /// <param name="featureName">Organization feature</param>
    /// <param name="enabled">New state of feature</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>OrganizationFeatures</returns>
    Task<OrganizationFeatures> UpdateOrganizationFeatureAsync(string featureName, FeatureState enabled, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update the list of domains that will be allowed to embed PureCloud applications
    /// </summary>
    /// <param name="body">Whitelist settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>EmbeddedIntegration</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<EmbeddedIntegration> UpdateOrganizationEmbeddedIntegrationAsync(EmbeddedIntegration body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization IP address whitelist settings
    /// </summary>
    /// <param name="body">IP address Whitelist settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>IpAddressAuthentication</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<IpAddressAuthentication> UpdateOrganizationIpAddressAuthenticationAsync(IpAddressAuthentication body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update organization whitelist settings
    /// </summary>
    /// <param name="body">Whitelist settings</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>OrgWhitelistSettings</returns>
    [Obsolete("This route is deprecated, please use /api/v2/organizations/authentication/settings instead")]
    Task<OrgWhitelistSettings> UpdateOrganizationWhitelistAsync(OrgWhitelistSettings body, CancellationToken cancellationToken = default);
}
