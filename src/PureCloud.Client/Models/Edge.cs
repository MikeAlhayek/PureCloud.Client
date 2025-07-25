namespace PureCloud.Client.Models;

public sealed class Edge
{
    public EdgeState? State { get; set; }
    public EdgeStatusCode? StatusCode { get; set; }
    public EdgeOnlineStatus? OnlineStatus { get; set; }
    public EdgeDeploymentType? EdgeDeploymentType { get; set; }
    public EdgeCertType? CertType { get; set; }
    public EdgeCallDrainingState? CallDrainingState { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public Division Division { get; set; }
    public string Description { get; set; }
    public int? Version { get; set; }
    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }
    public string ModifiedBy { get; set; }
    public string CreatedBy { get; set; }
    public string ModifiedByApp { get; set; }
    public string CreatedByApp { get; set; }
    public IEnumerable<EdgeInterface> Interfaces { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string ApiVersion { get; set; }
    public string SoftwareVersion { get; set; }
    public string SoftwareVersionTimestamp { get; set; }
    public string SoftwareVersionPlatform { get; set; }
    public string SoftwareVersionConfiguration { get; set; }
    public string FullSoftwareVersion { get; set; }
    public string PairingId { get; set; }
    public string Fingerprint { get; set; }
    public string FingerprintHint { get; set; }
    public string CurrentVersion { get; set; }
    public string StagedVersion { get; set; }
    public string Patch { get; set; }
    public EdgeGroup EdgeGroup { get; set; }
    public Site Site { get; set; }
    public DomainEdgeSoftwareUpdateDto SoftwareStatus { get; set; }
    public string SerialNumber { get; set; }
    public bool? PhysicalEdge { get; set; }
    public bool? Managed { get; set; }
    public int? ConversationCount { get; set; }
    public string Proxy { get; set; }
    public bool? OfflineConfigCalled { get; set; }
    public string OsName { get; set; }
    public string SelfUri { get; set; }
}