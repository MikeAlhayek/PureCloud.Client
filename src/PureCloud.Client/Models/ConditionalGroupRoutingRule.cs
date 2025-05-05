namespace PureCloud.Client.Models;

public sealed class ConditionalGroupRoutingRule
{
    /// <summary>
    /// The queue metric being evaluated
    /// </summary>
    /// <value>The queue metric being evaluated</value>
    public ConditionalGroupRoutingRuleMetric? Metric { get; set; }

    /// <summary>
    /// The operator that compares the actual value against the condition value
    /// </summary>
    /// <value>The operator that compares the actual value against the condition value</value>
    public ConditionalGroupRoutingRuleOperator? Operator { get; set; }

    /// <summary>
    /// The queue being evaluated for this rule.  If null, the current queue will be used.
    /// </summary>
    /// <value>The queue being evaluated for this rule.  If null, the current queue will be used.</value>
    public DomainEntityRef Queue { get; set; }

    /// <summary>
    /// The limit value, beyond which a rule evaluates as true
    /// </summary>
    /// <value>The limit value, beyond which a rule evaluates as true</value>
    public double? ConditionValue { get; set; }

    /// <summary>
    /// The group(s) to activate if the rule evaluates as true
    /// </summary>
    /// <value>The group(s) to activate if the rule evaluates as true</value>
    public IEnumerable<MemberGroup> Groups { get; set; }

    /// <summary>
    /// The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified.
    /// </summary>
    /// <value>The number of seconds to wait in this rule, if it evaluates as true, before evaluating the next rule.  For the final rule, this is ignored, so need not be specified.</value>
    public int? WaitSeconds { get; set; }
}
