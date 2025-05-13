using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignRuleConfigChangeCampaignRuleAction
{

    /// <summary>
    /// The type of this action
    /// </summary>
    /// <value>The type of this action</value>
    public DialerCampaignRuleConfigChangeCampaignRuleActionActionTypeEnum? ActionType { get; set; }

    /// <summary>
    /// The globally unique identifier for the action
    /// </summary>
    /// <value>The globally unique identifier for the action</value>
    public string Id { get; set; }

    /// <summary>
    /// The parameters to match this action
    /// </summary>
    /// <value>The parameters to match this action</value>
    public Dictionary<string, string> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets CampaignRuleActionEntities
    /// </summary>
    public DialerCampaignRuleConfigChangeCampaignRuleActionEntities CampaignRuleActionEntities { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
