using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;
public sealed class DialerCampaignConfigChangeContactSort
{
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    public DialerCampaignConfigChangeContactSortDirectionEnum? Direction { get; set; }

    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    public string FieldName { get; set; }

    /// <summary>
    /// Whether that column contains numeric data
    /// </summary>
    /// <value>Whether that column contains numeric data</value>
    public bool? Numeric { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
