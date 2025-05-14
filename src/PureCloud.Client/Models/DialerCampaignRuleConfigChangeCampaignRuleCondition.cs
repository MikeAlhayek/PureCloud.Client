using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignRuleConfigChangeCampaignRuleCondition
{
    /// <summary>
    /// The type of this condition
    /// </summary>
    /// <value>The type of this condition</value>
    public DialerCampaignRuleConfigChangeCampaignRuleConditionConditionTypeEnum? ConditionType { get; set; }

    /// <summary>
    /// The globally unique identifier for the condition
    /// </summary>
    /// <value>The globally unique identifier for the condition</value>
    public string Id { get; set; }

    /// <summary>
    /// The parameters to match this condition
    /// </summary>
    /// <value>The parameters to match this condition</value>
    public Dictionary<string, string> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
