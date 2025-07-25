namespace PureCloud.Client.Models;

public sealed class DomainCertificateAuthority
{
    public DomainCertificateAuthorityState? State { get; set; }
    public DomainCertificateAuthorityType? Type { get; set; }
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
    public string Certificate { get; set; }
    public IEnumerable<DomainCertificateAuthorityServices> Services { get; set; }
    public IEnumerable<CertificateDetails> CertificateDetails { get; set; }
    public string SelfUri { get; set; }
}