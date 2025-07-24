using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITelephonyProvidersEdgeApi
{
    Task<Edge> GetEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    Task DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    Task<EdgeEntityListing> GetEdgesAsync(CancellationToken cancellationToken = default);  

    Task<Edge> CreateEdgeAsync(Edge body, CancellationToken cancellationToken = default);

    Task<Edge> UpdateEdgeAsync(string edgeId, Edge body, CancellationToken cancellationToken = default);

    Task<DIDPool> GetDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    Task<DIDPool> CreateDidPoolAsync(DIDPool body, CancellationToken cancellationToken = default);

    Task<DIDPool> UpdateDidPoolAsync(string didPoolId, DIDPool body, CancellationToken cancellationToken = default);

    Task DeleteDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    Task<Site> GetSiteAsync(string siteId, CancellationToken cancellationToken = default);

    Task<Site> CreateSiteAsync(Site body, CancellationToken cancellationToken = default);

    Task<Site> UpdateSiteAsync(string siteId, Site body, CancellationToken cancellationToken = default);

    Task DeleteSiteAsync(string siteId, CancellationToken cancellationToken = default);

    // Certificate Authority operations
    Task<DomainCertificateAuthority> GetCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    Task<DomainCertificateAuthority> CreateCertificateAuthorityAsync(DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    Task<DomainCertificateAuthority> UpdateCertificateAuthorityAsync(string certificateId, DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    Task DeleteCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    // Extension Pool operations
    Task<ExtensionPool> GetExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);

    Task<ExtensionPool> CreateExtensionPoolAsync(ExtensionPool body, CancellationToken cancellationToken = default);

    Task<ExtensionPool> UpdateExtensionPoolAsync(string extensionPoolId, ExtensionPool body, CancellationToken cancellationToken = default);

    Task DeleteExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);
}