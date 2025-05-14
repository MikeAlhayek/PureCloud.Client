using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerCampaignRuleConfigChangeCampaignRule
{
    /// <summary>
    /// Gets or Sets CampaignRuleEntities
    /// </summary>
    public DialerCampaignRuleConfigChangeCampaignRuleEntities CampaignRuleEntities { get; set; }

    /// <summary>
    /// The list of conditions that will trigger this Campaign Rule
    /// </summary>
    /// <value>The list of conditions that will trigger this Campaign Rule</value>
    public IEnumerable<DialerCampaignRuleConfigChangeCampaignRuleCondition> CampaignRuleConditions { get; set; }

    /// <summary>
    /// The list of actions that will be taken when this Campaign Rule&#39;s conditions are met
    /// </summary>
    /// <value>The list of actions that will be taken when this Campaign Rule&#39;s conditions are met</value>
    public IEnumerable<DialerCampaignRuleConfigChangeCampaignRuleAction> CampaignRuleActions { get; set; }

    /// <summary>
    /// Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)
    /// </summary>
    /// <value>Whether this Campaign Rule should match any conditions (inclusive OR) or match all conditions (ALL)</value>
    public bool? MatchAnyConditions { get; set; }

    /// <summary>
    /// Whether this campaign rule is enabled
    /// </summary>
    /// <value>Whether this campaign rule is enabled</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    public string Name { get; set; }

    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    public DateTime? DateCreated { get; set; }

    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    public DateTime? DateModified { get; set; }

    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    public long? Version { get; set; }
}
