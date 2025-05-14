using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingWhatsappCampaignConfigChangeMessagingCampaign
{
    /// <summary>
    /// Gets or Sets CampaignStatus
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeMessagingCampaignCampaignStatusEnum? CampaignStatus { get; set; }

    /// <summary>
    /// Gets or Sets CallableTimeSet
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference CallableTimeSet { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference ContactList { get; set; }

    /// <summary>
    /// The dnc lists to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The dnc lists to check before sending a message for this messaging campaign.</value>
    public IEnumerable<OutboundMessagingWhatsappCampaignConfigChangeUriReference> DncLists { get; set; }

    /// <summary>
    /// The contact list filters to check before sending a message for this messaging campaign.
    /// </summary>
    /// <value>The contact list filters to check before sending a message for this messaging campaign.</value>
    public IEnumerable<OutboundMessagingWhatsappCampaignConfigChangeUriReference> ContactListFilters { get; set; }

    /// <summary>
    /// Whether this messaging campaign is always running.
    /// </summary>
    /// <value>Whether this messaging campaign is always running.</value>
    public bool? AlwaysRunning { get; set; }

    /// <summary>
    /// The order in which to sort contacts for dialing, based on up to four columns.
    /// </summary>
    /// <value>The order in which to sort contacts for dialing, based on up to four columns.</value>
    public IEnumerable<OutboundMessagingWhatsappCampaignConfigChangeContactSort> ContactSorts { get; set; }

    /// <summary>
    /// How many messages this messaging campaign will send per minute.
    /// </summary>
    /// <value>How many messages this messaging campaign will send per minute.</value>
    public long? MessagesPerMinute { get; set; }

    /// <summary>
    /// Gets or Sets RuleSets
    /// </summary>
    public IEnumerable<OutboundMessagingWhatsappCampaignConfigChangeUriReference> RuleSets { get; set; }

    /// <summary>
    /// Gets or Sets SmsConfig
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeSmsConfig SmsConfig { get; set; }

    /// <summary>
    /// Gets or Sets EmailConfig
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeEmailConfig EmailConfig { get; set; }

    /// <summary>
    /// Gets or Sets WhatsAppConfig
    /// </summary>
    public OutboundMessagingWhatsappCampaignConfigChangeWhatsAppConfig WhatsAppConfig { get; set; }

    /// <summary>
    /// A list of current error conditions associated with this messaging campaign
    /// </summary>
    /// <value>A list of current error conditions associated with this messaging campaign</value>
    public IEnumerable<OutboundMessagingWhatsappCampaignConfigChangeErrorDetail> Errors { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public OutboundMessagingWhatsappCampaignConfigChangeUriReference Division { get; set; }
}
