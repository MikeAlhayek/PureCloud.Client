using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignConfigChangePhoneColumn
{
    /// <summary>
    /// The name of the phone column
    /// </summary>
    /// <value>The name of the phone column</value>
    public string ColumnName { get; set; }

    /// <summary>
    /// The type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;
    /// </summary>
    /// <value>The type of the phone column, for example, &#39;cell&#39; or &#39;home&#39;</value>
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
