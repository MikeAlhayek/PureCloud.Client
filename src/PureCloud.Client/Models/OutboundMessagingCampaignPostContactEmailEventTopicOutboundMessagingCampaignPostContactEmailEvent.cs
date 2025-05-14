using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingCampaignPostContactEmailEventTopicOutboundMessagingCampaignPostContactEmailEvent
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    public OutboundMessagingCampaignPostContactEmailEventTopicOutboundMessagingCampaignPostContactEmailEventOutboundCampaignTypeEnum? OutboundCampaignType { get; set; }

    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    public OutboundMessagingCampaignPostContactEmailEventTopicOutboundMessagingCampaignPostContactEmailEventWrapupCodeEnum? WrapupCode { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public long? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    public Guid? ConversationId { get; set; }

    /// <summary>
    /// Gets or Sets EmailAttributes
    /// </summary>
    public OutboundMessagingCampaignPostContactEmailEventTopicEmailAttributes EmailAttributes { get; set; }

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
