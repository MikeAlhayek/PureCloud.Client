using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerRulesetConfigChangeCondition
{
    /// <summary>
    /// Determines the type of the value associated with the condition
    /// </summary>
    /// <value>Determines the type of the value associated with the condition</value>
    public DialerRulesetConfigChangeConditionValueTypeEnum? ValueType { get; set; }

    /// <summary>
    /// An operation type for condition evaluation
    /// </summary>
    /// <value>An operation type for condition evaluation</value>
    public DialerRulesetConfigChangeConditionOperatorEnum? Operator { get; set; }

    /// <summary>
    /// Determines the type of the property associated with the condition
    /// </summary>
    /// <value>Determines the type of the property associated with the condition</value>
    public DialerRulesetConfigChangeConditionPropertyTypeEnum? PropertyType { get; set; }

    /// <summary>
    /// A UriReference for a resource
    /// </summary>
    /// <value>A UriReference for a resource</value>
    public DialerRulesetConfigChangeUriReference DataAction { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }

    /// <summary>
    /// The type of the condition
    /// </summary>
    /// <value>The type of the condition</value>
    public string Type { get; set; }

    /// <summary>
    /// Indicates whether to evaluate for the opposite of the stated condition; default is false
    /// </summary>
    /// <value>Indicates whether to evaluate for the opposite of the stated condition; default is false</value>
    public bool? Inverted { get; set; }

    /// <summary>
    /// An attribute name associated with the condition (applies only to certain rule conditions)
    /// </summary>
    /// <value>An attribute name associated with the condition (applies only to certain rule conditions)</value>
    public string AttributeName { get; set; }

    /// <summary>
    /// A value associated with the condition
    /// </summary>
    /// <value>A value associated with the condition</value>
    public string Value { get; set; }

    /// <summary>
    /// List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;)
    /// </summary>
    /// <value>List of wrap-up code identifiers (used only in conditions of type &#39;wrapupCondition&#39;)</value>
    public IEnumerable<string> Codes { get; set; }

    /// <summary>
    /// A value associated with the property type of this condition
    /// </summary>
    /// <value>A value associated with the property type of this condition</value>
    public string Property { get; set; }

    /// <summary>
    /// The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.
    /// </summary>
    /// <value>The result of this condition if the data action returns a result indicating there was no data. Required for a DataActionCondition.</value>
    public bool? DataNotFoundResolution { get; set; }

    /// <summary>
    /// The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the contactId will be passed to for this condition. Valid for a dataActionCondition.</value>
    public string ContactIdField { get; set; }

    /// <summary>
    /// The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the callAnalysisResult will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
    public string CallAnalysisResultField { get; set; }

    /// <summary>
    /// The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.
    /// </summary>
    /// <value>The input field from the data action that the agentWrapup will be passed to for this condition. Valid for a wrapup dataActionCondition.</value>
    public string AgentWrapupField { get; set; }

    /// <summary>
    /// A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.
    /// </summary>
    /// <value>A list of mappings defining which contact data fields will be passed to which data action input fields for this condition. Valid for a dataActionCondition.</value>
    public IEnumerable<DialerRulesetConfigChangeContactColumnToDataActionFieldMapping> ContactColumnToDataActionFieldMappings { get; set; }

    /// <summary>
    /// A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.
    /// </summary>
    /// <value>A list of predicates defining the comparisons to use for this condition. Required for a dataActionCondition.</value>
    public IEnumerable<DialerRulesetConfigChangeDataActionConditionPredicate> Predicates { get; set; }
}
