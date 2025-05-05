namespace PureCloud.Client.Models;

public partial class DomainResourceConditionNode
{
    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public DomainResourceConditionNodeOperator? Operator { get; set; }

    /// <summary>
    /// Gets or Sets Conjunction
    /// </summary>
    public ConjunctionEnum? Conjunction { get; set; }

    /// <summary>
    /// Gets or Sets VariableName
    /// </summary>
    public string VariableName { get; set; }

    /// <summary>
    /// Gets or Sets Operands
    /// </summary>
    public IEnumerable<DomainResourceConditionValue> Operands { get; set; }

    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    public IEnumerable<DomainResourceConditionNode> Terms { get; set; }
}
