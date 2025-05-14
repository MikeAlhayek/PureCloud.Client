using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignRuleConfigChangeCampaignRuleActionEntities
{
    /// <summary>
    /// Whether this action should act on the entity that triggered it
    /// </summary>
    /// <value>Whether this action should act on the entity that triggered it</value>
    public bool? UseTriggeringEntity { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// A list of campaignIds to act on
    /// </summary>
    /// <value>A list of campaignIds to act on</value>
    public IEnumerable<DialerCampaignRuleConfigChangeUriReference> Campaigns { get; set; }

    /// <summary>
    /// A list of sequenceIds to act on
    /// </summary>
    /// <value>A list of sequenceIds to act on</value>
    public IEnumerable<DialerCampaignRuleConfigChangeUriReference> Sequences { get; set; }
}
