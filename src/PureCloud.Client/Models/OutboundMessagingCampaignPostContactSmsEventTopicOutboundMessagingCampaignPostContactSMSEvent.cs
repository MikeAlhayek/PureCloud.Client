using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    public OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEventOutboundCampaignTypeEnum? OutboundCampaignType { get; set; }

    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    public OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEventWrapupCodeEnum? WrapupCode { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public long? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets SmsAttributes
    /// </summary>
    public OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes SmsAttributes { get; set; }

    /// <summary>
    /// Gets or Sets OutboundCampaignId
    /// </summary>
    public Guid? OutboundCampaignId { get; set; }

    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    public Guid? DivisionId { get; set; }

    /// <summary>
    /// Gets or Sets ContentTemplateId
    /// </summary>
    public Guid? ContentTemplateId { get; set; }

    /// <summary>
    /// Gets or Sets OutboundContactListId
    /// </summary>
    public Guid? OutboundContactListId { get; set; }

    /// <summary>
    /// Gets or Sets OutboundContactId
    /// </summary>
    public string OutboundContactId { get; set; }

    /// <summary>
    /// Gets or Sets IsCampaignAlwaysRunning
    /// </summary>
    public bool? IsCampaignAlwaysRunning { get; set; }
}
