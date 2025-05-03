namespace PureCloud.Client.Models;

public partial class ResourceConditionNode
{
    /// <summary>
    /// Gets or Sets Conjunction
    /// </summary>
    public ConjunctionEnum? Conjunction { get; set; }

    /// <summary>
    /// Gets or Sets Operator
    /// </summary>
    public ResourceConditionOperator? Operator { get; set; }

    /// <summary>
    /// Gets or Sets VariableName
    /// </summary>
    public string VariableName { get; set; }

    /// <summary>
    /// Gets or Sets Operands
    /// </summary>
    public IEnumerable<ResourceConditionValue> Operands { get; set; }

    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    public IEnumerable<ResourceConditionNode> Terms { get; set; }
}
