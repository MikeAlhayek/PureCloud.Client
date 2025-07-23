namespace PureCloud.Client.Models.Organizations;

public sealed class Organization
{
    public OrganizationState? State { get; set; }
    public ProductPlatform? ProductPlatform { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public string DefaultLanguage { get; set; }
    public string DefaultCountryCode { get; set; }
    public string ThirdPartyOrgName { get; set; }
    public string ThirdPartyURI { get; set; }
    public string Domain { get; set; }
    public int? Version { get; set; }
    public string DefaultSiteId { get; set; }
    public string SupportURI { get; set; }
    public bool? VoicemailEnabled { get; set; }
    public string SelfUri { get; set; }
    public Dictionary<string, bool?> Features { get; set; }
}
