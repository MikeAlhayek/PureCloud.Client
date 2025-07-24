namespace PureCloud.Client.Models;

/// <summary>
/// Operand
/// </summary>
public sealed class Operand
{
    /// <summary>
    /// The Operand type of the category
    /// </summary>
    /// <value>The Operand type of the category</value>
    public OperandType? Type { get; set; }

    /// <summary>
    /// The minimum number of occurrences of the defined operand type
    /// </summary>
    /// <value>The minimum number of occurrences of the defined operand type</value>
    public int? Occurrence { get; set; }

    /// <summary>
    /// Applies a NOT modifier to the operand group
    /// </summary>
    /// <value>Applies a NOT modifier to the operand group</value>
    public bool? Inverted { get; set; }

    /// <summary>
    /// Filter interaction by word(s)
    /// </summary>
    /// <value>Filter interaction by word(s)</value>
    public Term Term { get; set; }

    /// <summary>
    /// Filter interaction by topic ID
    /// </summary>
    /// <value>Filter interaction by topic ID</value>
    public string TopicId { get; set; }

    /// <summary>
    /// Dictates when the operand must occur in a voice interaction
    /// </summary>
    /// <value>Dictates when the operand must occur in a voice interaction</value>
    public OperandPosition VoiceSecondsPosition { get; set; }

    /// <summary>
    /// Dictates when the operand must occur in a digital interaction
    /// </summary>
    /// <value>Dictates when the operand must occur in a digital interaction</value>
    public OperandPosition DigitalWordsPosition { get; set; }

    /// <summary>
    /// Defines a logical operation that is applied on the current operand, against the following operand
    /// </summary>
    /// <value>Defines a logical operation that is applied on the current operand, against the following operand</value>
    public InfixOperator InfixOperator { get; set; }

    /// <summary>
    /// Contains a new level of operands
    /// </summary>
    /// <value>Contains a new level of operands</value>
    public IEnumerable<Operand> Operands { get; set; }
}
