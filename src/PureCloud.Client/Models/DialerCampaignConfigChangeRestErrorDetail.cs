using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignConfigChangeRestErrorDetail
{
    /// <summary>
    /// name of the error
    /// </summary>
    /// <value>name of the error</value>
    public string Error { get; set; }

    /// <summary>
    /// additional information regarding the error
    /// </summary>
    /// <value>additional information regarding the error</value>
    public string Details { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
