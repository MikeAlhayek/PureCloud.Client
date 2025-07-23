namespace PureCloud.Client.Models.Organizations;

public sealed class OrganizationPresenceDefinition
{
    public OrganizationPresenceDefinitionType? Type { get; set; }
    public SystemPresence? SystemPresence { get; set; }
    public string Id { get; set; }
    public string Name { get; set; }
    public Dictionary<string, string> LanguageLabels { get; set; }
    public string DivisionId { get; set; }
    public bool? Deactivated { get; set; }
    public string SelfUri { get; set; }
}
