namespace PureCloud.Client.Models;

public partial class OrganizationPresenceDefinition
{
    /// <summary>
    /// The type of definition
    /// </summary>
    /// <value>The type of definition</value>
    public OrganizationPresenceDefinitionType? Type { get; set; }

    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    public SystemPresence? SystemPresence { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The label used for the definition in each specified language
    /// </summary>
    /// <value>The label used for the definition in each specified language</value>
    public Dictionary<string, string> LanguageLabels { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public string DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets Deactivated
    /// </summary>
    public bool? Deactivated { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
