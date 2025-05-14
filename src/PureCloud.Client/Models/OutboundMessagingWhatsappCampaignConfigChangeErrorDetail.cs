using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OutboundMessagingWhatsappCampaignConfigChangeErrorDetail
{
    /// <summary>
    /// The name of the error code.
    /// </summary>
    /// <value>The name of the error code.</value>
    public string Error { get; set; }

    /// <summary>
    /// The additional information regarding the error message.
    /// </summary>
    /// <value>The additional information regarding the error message.</value>
    public string Details { get; set; }
}
