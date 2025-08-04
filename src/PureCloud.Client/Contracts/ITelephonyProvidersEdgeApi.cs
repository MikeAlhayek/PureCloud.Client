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

    /// <inheritdoc />
    Task<EdgeEntityListing> GetEdgesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticNslookupAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticPingAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticRouteAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticTracepathAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync(string edgeId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeLogsJob> GetEdgeLogsJobAsync(string edgeId, string jobId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeMetrics> GetEdgeMetricsAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainPhysicalInterface> GetEdgePhysicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DomainEdgeSoftwareVersionDtoEntityListing> GetEdgeSoftwareversionsAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Line> GetEdgeLineAsync(string edgeId, string lineId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LineEntityListing> GetEdgeLinesAsync(string edgeId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);
}