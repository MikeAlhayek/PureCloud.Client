using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class DialerContactlistfilterConfigChangeFilterPredicate
{
    /// <summary>
    /// Whether a contact column is numeric or alphabetic
    /// </summary>
    /// <value>Whether a contact column is numeric or alphabetic</value>
    public DialerContactlistfilterConfigChangeFilterPredicateColumnTypeEnum? ColumnType { get; set; }
    /// <summary>
    /// The comparison operator
    /// </summary>
    /// <value>The comparison operator</value>
    public DialerContactlistfilterConfigChangeFilterPredicateOperatorEnum? Operator { get; set; }

    /// <summary>
    /// The contact list column
    /// </summary>
    /// <value>The contact list column</value>
    public string Column { get; set; }

    /// <summary>
    /// The value the predicate applies to
    /// </summary>
    /// <value>The value the predicate applies to</value>
    public string Value { get; set; }

    /// <summary>
    /// Gets or Sets Range
    /// </summary>
    public DialerContactlistfilterConfigChangeRange Range { get; set; }

    /// <summary>
    /// Whether or not to invert to result of evaluating the predicate
    /// </summary>
    /// <value>Whether or not to invert to result of evaluating the predicate</value>
    public bool? Inverted { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    public Dictionary<string, object> AdditionalProperties { get; set; }
}
