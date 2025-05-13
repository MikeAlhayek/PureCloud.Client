using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerRulesetConfigChangeDataActionConditionPredicate
{
    /// <summary>
    /// The operation with which to evaluate this condition
    /// </summary>
    /// <value>The operation with which to evaluate this condition</value>
    public DialerRulesetConfigChangeDataActionConditionPredicateOutputOperatorEnum? OutputOperator { get; set; }

    /// <summary>
    /// The name of an output field from the data action&#39;s output to use for this condition
    /// </summary>
    /// <value>The name of an output field from the data action&#39;s output to use for this condition</value>
    public string OutputField { get; set; }

    /// <summary>
    /// The value to compare against for this condition
    /// </summary>
    /// <value>The value to compare against for this condition</value>
    public string ComparisonValue { get; set; }

    /// <summary>
    /// The result of this predicate if the requested output field is missing from the data action&#39;s result
    /// </summary>
    /// <value>The result of this predicate if the requested output field is missing from the data action&#39;s result</value>
    public bool? OutputFieldMissingResolution { get; set; }

    /// <summary>
    /// If true, inverts the result of evaluating this Predicate. Default is false.
    /// </summary>
    /// <value>If true, inverts the result of evaluating this Predicate. Default is false.</value>
    public bool? Inverted { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
