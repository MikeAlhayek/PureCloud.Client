using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InfixOperator
/// </summary>
public sealed class InfixOperator
{
    /// <summary>
    /// The logical operation that is applied on the operand against the following operand
    /// </summary>
    /// <value>The logical operation that is applied on the operand against the following operand</value>
    public InfixOperatorOperatorTypeEnum? OperatorType { get; set; }

    /// <summary>
    /// Dictates when the following operand should occur relative to current operand
    /// </summary>
    /// <value>Dictates when the following operand should occur relative to current operand</value>
    public OperatorPosition OperatorPosition { get; set; }
}
