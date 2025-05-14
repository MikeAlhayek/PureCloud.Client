using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEvent
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    public OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEventOutboundCampaignTypeEnum? OutboundCampaignType { get; set; }

    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    public OutboundMessagingCampaignPreContactEmailEventTopicOutboundMessagingCampaignPreContactEmailEventWrapupCodeEnum? WrapupCode { get; set; }

    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    public long? EventTime { get; set; }

    /// <summary>
    /// Gets or Sets EmailAttributes
    /// </summary>
    public OutboundMessagingCampaignPreContactEmailEventTopicEmailAttributes EmailAttributes { get; set; }

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
