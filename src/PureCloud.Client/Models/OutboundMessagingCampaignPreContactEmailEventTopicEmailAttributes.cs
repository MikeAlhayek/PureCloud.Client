using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingCampaignPreContactEmailEventTopicEmailAttributes
{
    /// <summary>
    /// Gets or Sets EmailSubject
    /// </summary>
    public string EmailSubject { get; set; }

    /// <summary>
    /// Gets or Sets ConfiguredEmailAddress
    /// </summary>
    public string ConfiguredEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets ContactEmailAddress
    /// </summary>
    public string ContactEmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets ReplyToAddress
    /// </summary>
    public string ReplyToAddress { get; set; }

    /// <summary>
    /// Gets or Sets ContactEmailColumnName
    /// </summary>
    public string ContactEmailColumnName { get; set; }
}
