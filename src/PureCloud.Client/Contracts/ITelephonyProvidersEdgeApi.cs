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

    /// <inheritdoc />
    Task DeleteEdgeAlertablepresencesAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<VmPairingInfo> GetEdgeSetuppackageAsync(string edgeId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkEntityListing> GetEdgeTrunksAsync(string edgeId, int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string trunkBaseId = null, string trunkType = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<AlertablePresences> GetEdgeAlertablepresencesAsync(string type = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<CertificateAuthorityEntityListing> GetEdgeCertificateauthoritiesAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DID> GetEdgeDidAsync(string didId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DIDEntityListing> GetEdgeDidsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<DIDPoolEntityListing> GetEdgeDidpoolsAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeGroup> GetEdgeEdgegroupAsync(string edgeGroupId, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeGroupEntityListing> GetEdgeEdgegroupsAsync(int? pageSize = null, int? pageNumber = null, string name = null, string sortBy = null, bool? managed = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ExtensionPoolEntityListing> GetEdgeExtensionpoolsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LineBase> GetEdgeLinebasesettingAsync(string lineBaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<LineBaseEntityListing> GetEdgeLinebasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Phone> GetEdgePhoneAsync(string phoneId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhoneBase> GetEdgePhonebasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhoneBaseEntityListing> GetEdgePhonebasesettingsAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhoneEntityListing> GetEdgePhonesAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, string siteId = null, string webRtcUserId = null, string phoneBaseSettingsId = null, string linesLoggedInUserId = null, string linesDefaultForUserId = null, string phoneHardwareId = null, string linesId = null, string linesName = null, string name = null, string statusOperationalStatus = null, string secondaryStatusOperationalStatus = null, IEnumerable<string> expand = null, IEnumerable<string> fields = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhoneMetaBaseEntityListing> GetEdgePhonesTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SiteEntityListing> GetEdgeSitesAsync(int? pageSize = null, int? pageNumber = null, string sortBy = null, string sortOrder = null, string name = null, string locationId = null, bool? managed = null, IEnumerable<string> expand = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundRouteBase> GetEdgeSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<OutboundRouteBaseEntityListing> GetEdgeSiteOutboundroutesAsync(string siteId, int? pageSize = null, int? pageNumber = null, string name = null, string externalTrunkBaseIds = null, string sortBy = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TimeZoneEntityListing> GetEdgeTimezonesAsync(int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Trunk> GetEdgeTrunkAsync(string trunkId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkBase> GetEdgeTrunkbasesettingAsync(string trunkBaseSettingsId, bool? ignoreHidden = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkBaseEntityListing> GetEdgeTrunkbasesettingsAsync(int? pageNumber = null, int? pageSize = null, string sortBy = null, string sortOrder = null, bool? recordingEnabled = null, bool? ignoreHidden = null, bool? managed = null, IEnumerable<string> expand = null, string name = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkMetabaseEntityListing> GetEdgeTrunkbasesettingsAvailablemetabasesAsync(string type = null, int? pageSize = null, int? pageNumber = null, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkMetrics> GetEdgeTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkRecordingEnabledCount> GetEdgeTrunksMetricsAsync(string trunkIds, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteEdgeGroupAsync(string edgeGroupId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeletePhoneAsync(string phoneId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeletePhoneBasesettingAsync(string phoneBaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteSiteOutboundrouteAsync(string siteId, string outboundRouteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task DeleteTrunkbasesettingAsync(string trunkBaseSettingsId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<EdgeVersionReport> GetEdgeversionreportAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<ExpiredEdgeListing> GetExpiredAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Extension> GetExtensionAsync(string extensionId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Line> GetLineAsync(string lineId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<Line> GetLinesTemplateAsync(string lineMetabaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<MediaStatisticsListing> GetMediastatisticsConversationAsync(string conversationId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IEnumerable<EdgeMetrics>> GetEdgesMetricsAsync(string edgeIds, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhoneBase> GetPhonebasesettingsTemplateAsync(string phoneMetabaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<PhysicalInterfaceEntityListing> GetPhysicalinterfacesAsync(string edgeIds, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<IEnumerable<NumberPlan>> GetSiteNumberplansAsync(string siteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<SiteConnections> GetSiteSiteconnectionsAsync(string siteId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkMetrics> GetTrunkMetricsAsync(string trunkId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkBase> GetTrunkbasesettingsTemplateAsync(string trunkMetabaseId, CancellationToken cancellationToken = default);

    /// <inheritdoc />
    Task<TrunkRecordingEnabledCount> GetTrunkswithrecordingAsync(string trunkType = null, CancellationToken cancellationToken = default);
}