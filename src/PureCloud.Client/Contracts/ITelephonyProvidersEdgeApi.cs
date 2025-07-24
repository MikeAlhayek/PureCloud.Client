using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITelephonyProvidersEdgeApi
{
    /// <inheritdoc />
    Task<Edge> GetEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeEntityListing> GetEdgesAsync(CancellationToken cancellationToken = default);  

    /// <inheritdoc />
    Task<Edge> CreateEdgeAsync(Edge body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Edge> UpdateEdgeAsync(string edgeId, Edge body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DIDPool> GetDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DIDPool> CreateDidPoolAsync(DIDPool body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DIDPool> UpdateDidPoolAsync(string didPoolId, DIDPool body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Site> GetSiteAsync(string siteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Site> CreateSiteAsync(Site body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Site> UpdateSiteAsync(string siteId, Site body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteSiteAsync(string siteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainCertificateAuthority> GetCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainCertificateAuthority> CreateCertificateAuthorityAsync(DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainCertificateAuthority> UpdateCertificateAuthorityAsync(string certificateId, DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ExtensionPool> GetExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ExtensionPool> CreateExtensionPoolAsync(ExtensionPool body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ExtensionPool> UpdateExtensionPoolAsync(string extensionPoolId, ExtensionPool body, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);
}