using PureCloud.Client.Models;

namespace PureCloud.Client.Contracts;

public interface ITelephonyProvidersEdgeApi
{
    /// <summary>
    /// Get an edge by ID
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Edge> GetEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete an edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="body">Edge configuration</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Edge> CreateEdgeAsync(Edge body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Edge> UpdateEdgeAsync(string edgeId, Edge body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get DID pool
    /// </summary>
    /// <param name="didPoolId">DID pool ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DIDPool> GetDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new DID pool
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DIDPool> CreateDidPoolAsync(DIDPool body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update DID pool
    /// </summary>
    /// <param name="didPoolId">DID pool ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DIDPool> UpdateDidPoolAsync(string didPoolId, DIDPool body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete DID pool
    /// </summary>
    /// <param name="didPoolId">DID pool ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteDidPoolAsync(string didPoolId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Site> GetSiteAsync(string siteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new site
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Site> CreateSiteAsync(Site body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Site> UpdateSiteAsync(string siteId, Site body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteSiteAsync(string siteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get certificate authority
    /// </summary>
    /// <param name="certificateId">Certificate ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainCertificateAuthority> GetCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new certificate authority
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainCertificateAuthority> CreateCertificateAuthorityAsync(DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update certificate authority
    /// </summary>
    /// <param name="certificateId">Certificate ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainCertificateAuthority> UpdateCertificateAuthorityAsync(string certificateId, DomainCertificateAuthority body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete certificate authority
    /// </summary>
    /// <param name="certificateId">Certificate ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteCertificateAuthorityAsync(string certificateId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get extension pool
    /// </summary>
    /// <param name="extensionPoolId">Extension pool ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExtensionPool> GetExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new extension pool
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExtensionPool> CreateExtensionPoolAsync(ExtensionPool body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update extension pool
    /// </summary>
    /// <param name="extensionPoolId">Extension pool ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExtensionPool> UpdateExtensionPoolAsync(string extensionPoolId, ExtensionPool body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete extension pool
    /// </summary>
    /// <param name="extensionPoolId">Extension pool ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteExtensionPoolAsync(string extensionPoolId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edges
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="name">Filter by name</param>
    /// <param name="siteId">Site ID</param>
    /// <param name="edgeGroupId">Edge group ID</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="managed">Filter by managed status</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeEntityListing> GetEdgesAsync(int? pageSize = null, int? pageNumber = null, string name = null, string siteId = null, string edgeGroupId = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticNslookupAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticPingAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticRouteAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnosticResponse> GetEdgeDiagnosticTracepathAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="interfaceId">Interface ID</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainLogicalInterface> GetEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgelogicalinterfaces
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LogicalInterfaceEntityListing> GetEdgeLogicalinterfacesAsync(string edgeId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="interfaceId">Interface ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="jobId">Job ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeLogsJob> GetEdgeLogsJobAsync(string edgeId, string jobId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeMetrics> GetEdgeMetricsAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="interfaceId">Interface ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainPhysicalInterface> GetEdgePhysicalinterfaceAsync(string edgeId, string interfaceId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgephysicalinterfaces
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhysicalInterfaceEntityListing> GetEdgePhysicalinterfacesAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainEdgeSoftwareUpdateDto> GetEdgeSoftwareupdateAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgesoftwareversions
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainEdgeSoftwareVersionDtoEntityListing> GetEdgeSoftwareversionsAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="lineId">Line ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Line> GetEdgeLineAsync(string edgeId, string lineId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgelines
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LineEntityListing> GetEdgeLinesAsync(string edgeId, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete edge
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEdgeAlertablepresencesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<VmPairingInfo> GetEdgeSetuppackageAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgetrunks
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="trunkBaseId">trunkBaseId parameter</param>
    /// <param name="trunkType">trunkType parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkEntityListing> GetEdgeTrunksAsync(string edgeId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string trunkBaseId = null, string trunkType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="type">type parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<AlertablePresences> GetEdgeAlertablepresencesAsync(string type = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgecertificateauthorities
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<CertificateAuthorityEntityListing> GetEdgeCertificateauthoritiesAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="didId">didId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DID> GetEdgeDidAsync(string didId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgedids
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DIDEntityListing> GetEdgeDidsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgedidpools
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DIDPoolEntityListing> GetEdgeDidpoolsAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="edgeGroupId">Edge group ID</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeGroup> GetEdgeEdgegroupAsync(string edgeGroupId, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgeedgegroups
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="name">Filter by name</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="managed">Filter by managed status</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeGroupEntityListing> GetEdgeEdgegroupsAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgeextensionpools
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExtensionPoolEntityListing> GetEdgeExtensionpoolsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="lineBaseId">lineBaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LineBase> GetEdgeLinebasesettingAsync(string lineBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgelinebasesettings
    /// </summary>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<LineBaseEntityListing> GetEdgeLinebasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="phoneId">Phone ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Phone> GetEdgePhoneAsync(string phoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="phoneBaseId">phoneBaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneBase> GetEdgePhonebasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgephonebasesettings
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="name">Filter by name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneBaseEntityListing> GetEdgePhonebasesettingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgephones
    /// </summary>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="siteId">Site ID</param>
    /// <param name="webRtcUserId">webRtcUserId parameter</param>
    /// <param name="phoneBaseSettingsId">Phone base settings ID</param>
    /// <param name="linesLoggedInUserId">linesLoggedInUserId parameter</param>
    /// <param name="linesDefaultForUserId">linesDefaultForUserId parameter</param>
    /// <param name="phoneHardwareId">phoneHardwareId parameter</param>
    /// <param name="linesId">linesId parameter</param>
    /// <param name="linesName">linesName parameter</param>
    /// <param name="name">Filter by name</param>
    /// <param name="statusOperationalStatus">statusOperationalStatus parameter</param>
    /// <param name="secondaryStatusOperationalStatus">secondaryStatusOperationalStatus parameter</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="fieldNames">Field names to include</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneEntityListing> GetEdgePhonesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, string name = null, string statusOperationalStatus = null, string secondaryStatusOperationalStatus = null, IEnumerable<string> expands = null, IEnumerable<string> fieldNames = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="phoneMetabaseId">phoneMetabaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneMetaBaseEntityListing> GetEdgePhonesTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgesites
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="name">Filter by name</param>
    /// <param name="locationId">locationId parameter</param>
    /// <param name="managed">Filter by managed status</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SiteEntityListing> GetEdgeSitesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null, bool? managed = null, IEnumerable<string> expands = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="outboundRouteId">outboundRouteId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OutboundRouteBase> GetEdgeSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgesiteoutboundroutes
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="name">Filter by name</param>
    /// <param name="externalTrunkBaseIds">externalTrunkBaseIds parameter</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OutboundRouteBaseEntityListing> GetEdgeSiteOutboundroutesAsync(string siteId, int? pageSize = null, int? pageNumber = null, string name = null, string externalTrunkBaseIds = null, string sortBy = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgetimezones
    /// </summary>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TimeZoneEntityListing> GetEdgeTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="trunkId">Trunk ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Trunk> GetEdgeTrunkAsync(string trunkId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="trunkBaseSettingsId">Trunk base settings ID</param>
    /// <param name="ignoreHidden">ignoreHidden parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkBase> GetEdgeTrunkbasesettingAsync(string trunkBaseSettingsId, bool? ignoreHidden = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgetrunkbasesettings
    /// </summary>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="sortBy">Sort field</param>
    /// <param name="sortOrder">sortOrder parameter</param>
    /// <param name="recordingEnabled">recordingEnabled parameter</param>
    /// <param name="ignoreHidden">ignoreHidden parameter</param>
    /// <param name="managed">Filter by managed status</param>
    /// <param name="expands">Fields to expand</param>
    /// <param name="name">Filter by name</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkBaseEntityListing> GetEdgeTrunkbasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null, bool? ignoreHidden = null, bool? managed = null, IEnumerable<string> expands = null, string name = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of edgetrunkbasesettingsavailablemetabases
    /// </summary>
    /// <param name="type">type parameter</param>
    /// <param name="pageSize">Page size for pagination</param>
    /// <param name="pageNumber">Page number for pagination</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkMetabaseEntityListing> GetEdgeTrunkbasesettingsAvailablemetabasesAsync(string type = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="trunkMetabaseId">trunkMetabaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkMetrics> GetEdgeTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="trunkIds">trunkIds parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkRecordingEnabledCount> GetEdgeTrunksMetricsAsync(string trunkIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete edge
    /// </summary>
    /// <param name="edgeGroupId">Edge group ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteEdgeGroupAsync(string edgeGroupId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete phone
    /// </summary>
    /// <param name="phoneId">Phone ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeletePhoneAsync(string phoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete phone
    /// </summary>
    /// <param name="phoneBaseId">phoneBaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeletePhoneBasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="outboundRouteId">outboundRouteId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete trunk
    /// </summary>
    /// <param name="trunkBaseSettingsId">Trunk base settings ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<bool> DeleteTrunkbasesettingAsync(string trunkBaseSettingsId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeVersionReport> GetEdgeversionreportAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get expired
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ExpiredEdgeListing> GetExpiredAsync(CancellationToken cancellationToken = default);

    /// <summary>
    /// Get extension
    /// </summary>
    /// <param name="extensionId">extensionId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Extension> GetExtensionAsync(string extensionId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get line
    /// </summary>
    /// <param name="lineId">Line ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Line> GetLineAsync(string lineId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get line
    /// </summary>
    /// <param name="lineMetabaseId">lineMetabaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Line> GetLinesTemplateAsync(string lineMetabaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get mediastatisticsconversation
    /// </summary>
    /// <param name="conversationId">conversationId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<MediaStatisticsListing> GetMediastatisticsConversationAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get edge metrics
    /// </summary>
    /// <param name="edgeIds">Edge IDs</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<IEnumerable<EdgeMetrics>> GetEdgesMetricsAsync(string edgeIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get phone
    /// </summary>
    /// <param name="phoneMetabaseId">phoneMetabaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneBase> GetPhonebasesettingsTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get list of physicalinterfaces
    /// </summary>
    /// <param name="edgeIds">edgeIds parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhysicalInterfaceEntityListing> GetPhysicalinterfacesAsync(string edgeIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get site number plans
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<IEnumerable<NumberPlan>> GetSiteNumberplansAsync(string siteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SiteConnections> GetSiteSiteconnectionsAsync(string siteId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trunk
    /// </summary>
    /// <param name="trunkId">Trunk ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkMetrics> GetTrunkMetricsAsync(string trunkId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trunk
    /// </summary>
    /// <param name="trunkMetabaseId">trunkMetabaseId parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkBase> GetTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get trunk
    /// </summary>
    /// <param name="trunkType">trunkType parameter</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkRecordingEnabledCount> GetTrunkswithrecordingAsync(string trunkType = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Validate address
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<ValidateAddressResponse> ValidateAddressAsync(ValidateAddressRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// reboot edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<string> RebootEdgeAsync(string edgeId, EdgeRebootParameters body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// reboot phone
    /// </summary>
    /// <param name="phoneId">Phone ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RebootPhoneAsync(string phoneId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Upload edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="jobId">Job ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task UploadEdgeLogsJobAsync(string edgeId, string jobId, EdgeLogsJobUploadRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeLogsJobResponse> CreateEdgeLogsJobAsync(string edgeId, EdgeLogsJobRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainEdgeSoftwareUpdateDto> CreateEdgeSoftwareupdateAsync(string edgeId, DomainEdgeSoftwareUpdateDto body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Change edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<string> ChangeEdgeStatusAsync(string edgeId, EdgeServiceStateRequest body = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// unpair edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<string> UnpairEdgeAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticNslookupAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticPingAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticRouteAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeNetworkDiagnostic> CreateEdgeDiagnosticTracepathAsync(string edgeId, EdgeNetworkDiagnosticRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// reboot phone
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task RebootPhonesAsync(PhonesReboot body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Search site
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<SitesSearchResponse> SearchSitesAsync(SiteSearchRequest body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainLogicalInterface> CreateEdgeLogicalinterfaceAsync(string edgeId, DomainLogicalInterface body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update edge
    /// </summary>
    /// <param name="edgeId">Edge ID</param>
    /// <param name="interfaceId">Interface ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<DomainLogicalInterface> UpdateEdgeLogicalinterfaceAsync(string edgeId, string interfaceId, DomainLogicalInterface body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OutboundRouteBase> CreateSiteOutboundrouteAsync(string siteId, OutboundRouteBase body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new phone
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Phone> CreatePhoneAsync(Phone body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new phone
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneBase> CreatePhonebasesettingAsync(PhoneBase body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new edge
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeGroup> CreateEdgegroupAsync(EdgeGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a new trunk
    /// </summary>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkBase> CreateTrunkbasesettingAsync(TrunkBase body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update edge
    /// </summary>
    /// <param name="edgeGroupId">Edge group ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<EdgeGroup> UpdateEdgegroupAsync(string edgeGroupId, EdgeGroup body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update phone
    /// </summary>
    /// <param name="phoneId">Phone ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<Phone> UpdatePhoneAsync(string phoneId, Phone body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update phone
    /// </summary>
    /// <param name="phoneBaseId">phoneBaseId parameter</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<PhoneBase> UpdatePhonebasesettingAsync(string phoneBaseId, PhoneBase body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update site
    /// </summary>
    /// <param name="siteId">Site ID</param>
    /// <param name="outboundRouteId">outboundRouteId parameter</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<OutboundRouteBase> UpdateSiteOutboundrouteAsync(string siteId, string outboundRouteId, OutboundRouteBase body, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update trunk
    /// </summary>
    /// <param name="trunkBaseSettingsId">Trunk base settings ID</param>
    /// <param name="body">Request body</param>
    /// <param name="cancellationToken">Cancellation token</param>
    Task<TrunkBase> UpdateTrunkbasesettingAsync(string trunkBaseSettingsId, TrunkBase body, CancellationToken cancellationToken = default);
}
