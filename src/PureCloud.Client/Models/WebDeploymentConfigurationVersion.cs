namespace PureCloud.Client.Models;

/// <summary>
/// Details about the configuration version of a Web Deployment
/// </summary>
public sealed class WebDeploymentConfigurationVersion
{
    /// <summary>
    /// The configuration version ID
    /// </summary>
    /// <value>The configuration version ID</value>
    public string Id { get; set; }

    /// <summary>
    /// The configuration version name
    /// </summary>
    /// <value>The configuration version name</value>
    public string Name { get; set; }

    /// <summary>
    /// The version of the configuration
    /// </summary>
    /// <value>The version of the configuration</value>
    public string Version { get; set; }

    /// <summary>
    /// Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.
    /// </summary>
    /// <value>Headless Mode Support which Controls UI components. When enabled, native UI components will be disabled and allows for custom-built UI.</value>
    public WebDeploymentHeadlessMode HeadlessMode { get; set; }

    /// <summary>
    /// The description of the configuration
    /// </summary>
    /// <value>The description of the configuration</value>
    public string Description { get; set; }

    /// <summary>
    /// A list of languages supported on the configuration required if the messenger is enabled
    /// </summary>
    /// <value>A list of languages supported on the configuration required if the messenger is enabled</value>
    public IEnumerable<string> Languages { get; set; }

    /// <summary>
    /// The default language to use for the configuration required if the messenger is enabled
    /// </summary>
    /// <value>The default language to use for the configuration required if the messenger is enabled</value>
    public string DefaultLanguage { get; set; }

    /// <summary>
    /// The localization settings for homescreen app
    /// </summary>
    /// <value>The localization settings for homescreen app</value>
    public IEnumerable<CustomI18nLabels> CustomI18nLabels { get; set; }

    /// <summary>
    /// The settings for messenger
    /// </summary>
    /// <value>The settings for messenger</value>
    public MessengerSettings Messenger { get; set; }

    /// <summary>
    /// The settings for position
    /// </summary>
    /// <value>The settings for position</value>
    public PositionSettings Position { get; set; }

    /// <summary>
    /// The settings for knowledge portal (previously support center)
    /// </summary>
    /// <value>The settings for knowledge portal (previously support center)</value>
    public SupportCenterSettings SupportCenter { get; set; }

    /// <summary>
    /// The settings for cobrowse
    /// </summary>
    /// <value>The settings for cobrowse</value>
    public CobrowseSettings Cobrowse { get; set; }

    /// <summary>
    /// The settings for journey events
    /// </summary>
    /// <value>The settings for journey events</value>
    public JourneyEventsSettings JourneyEvents { get; set; }

    /// <summary>
    /// The settings for authenticated deployments
    /// </summary>
    /// <value>The settings for authenticated deployments</value>
    public AuthenticationSettings AuthenticationSettings { get; set; }

    /// <summary>
    /// The settings for video
    /// </summary>
    /// <value>The settings for video</value>
    public VideoSettings Video { get; set; }

    /// <summary>
    /// The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the configuration version was most recently published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    public DateTime? DatePublished { get; set; }

    /// <summary>
    /// A reference to the user who most recently modified the configuration version
    /// </summary>
    /// <value>A reference to the user who most recently modified the configuration version</value>
    public AddressableEntityRef LastModifiedUser { get; set; }

    /// <summary>
    /// A reference to the user who created the configuration version
    /// </summary>
    /// <value>A reference to the user who created the configuration version</value>
    public AddressableEntityRef CreatedUser { get; set; }

    /// <summary>
    /// A reference to the user who published the configuration version
    /// </summary>
    /// <value>A reference to the user who published the configuration version</value>
    public AddressableEntityRef PublishedUser { get; set; }

    /// <summary>
    /// The current status of the configuration version
    /// </summary>
    /// <value>The current status of the configuration version</value>
    public WebDeploymentConfigurationVersionStatus? Status { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}