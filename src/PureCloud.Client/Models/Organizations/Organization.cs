namespace PureCloud.Client.Models;

public sealed class Organization
{

    /// <summary>
    /// The current state. Examples are active, inactive, deleted.
    /// </summary>
    /// <value>The current state. Examples are active, inactive, deleted.</value>
    public OrganizationState? State { get; set; }

    /// <summary>
    /// Organizations Originating Platform.
    /// </summary>
    /// <value>Organizations Originating Platform.</value>
    public ProductPlatform? ProductPlatform { get; set; }

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
    /// The default language for this organization. Example: &#39;en&#39;
    /// </summary>
    /// <value>The default language for this organization. Example: &#39;en&#39;</value>
    public string DefaultLanguage { get; set; }

    /// <summary>
    /// The default country code for this organization. Example: &#39;US&#39;
    /// </summary>
    /// <value>The default country code for this organization. Example: &#39;US&#39;</value>
    public string DefaultCountryCode { get; set; }

    /// <summary>
    /// The short name for the organization. This field is globally unique and cannot be changed.
    /// </summary>
    /// <value>The short name for the organization. This field is globally unique and cannot be changed.</value>
    public string ThirdPartyOrgName { get; set; }

    /// <summary>
    /// Gets or Sets ThirdPartyURI
    /// </summary>
    public string ThirdPartyURI { get; set; }

    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// The current version of the organization.
    /// </summary>
    /// <value>The current version of the organization.</value>
    public int? Version { get; set; }

    /// <summary>
    /// Gets or Sets DefaultSiteId
    /// </summary>
    public string DefaultSiteId { get; set; }

    /// <summary>
    /// Email address where support tickets are sent to.
    /// </summary>
    /// <value>Email address where support tickets are sent to.</value>
    public string SupportURI { get; set; }

    /// <summary>
    /// Gets or Sets VoicemailEnabled
    /// </summary>
    public bool? VoicemailEnabled { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }

    /// <summary>
    /// The state of features available for the organization.
    /// </summary>
    /// <value>The state of features available for the organization.</value>
    public Dictionary<string, bool?> Features { get; set; }
}
