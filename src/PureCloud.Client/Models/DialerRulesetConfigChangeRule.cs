using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerRulesetConfigChangeRule
{
    /// <summary>
    /// The category of the rule
    /// </summary>
    /// <value>The category of the rule</value>
    public DialerRulesetConfigChangeRuleCategoryEnum? Category { get; set; }

    /// <summary>
    /// The list of rule conditions; all must evaluate to true to trigger the rule actions
    /// </summary>
    /// <value>The list of rule conditions; all must evaluate to true to trigger the rule actions</value>
    public IEnumerable<DialerRulesetConfigChangeCondition> Conditions { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The identifier of the rule
    /// </summary>
    /// <value>The identifier of the rule</value>
    public string Id { get; set; }

    /// <summary>
    /// The name of the rule
    /// </summary>
    /// <value>The name of the rule</value>
    public string Name { get; set; }

    /// <summary>
    /// The ranked order of the rule; rules are processed from lowest number to highest
    /// </summary>
    /// <value>The ranked order of the rule; rules are processed from lowest number to highest</value>
    public long? Order { get; set; }

    /// <summary>
    /// The list of rule actions to be taken if the conditions are true
    /// </summary>
    /// <value>The list of rule actions to be taken if the conditions are true</value>
    public IEnumerable<DialerRulesetConfigChangeAction> Actions { get; set; }
}
