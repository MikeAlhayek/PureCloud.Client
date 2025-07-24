using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class OperandPosition
{
    /// <summary>
    /// Dictates starting position directionality
    /// </summary>
    /// <value>Dictates starting position directionality</value>
    public OperandPositionStartingPositionDirectionEnum? StartingPositionDirection { get; set; }

    /// <summary>
    /// Dictates ending position directionality
    /// </summary>
    /// <value>Dictates ending position directionality</value>
    public OperandPositionEndingPositionDirectionEnum? EndingPositionDirection { get; set; }

    /// <summary>
    /// Defines starting point of a position range - number of seconds or words from the start or from the end of the interaction
    /// </summary>
    /// <value>Defines starting point of a position range - number of seconds or words from the start or from the end of the interaction</value>
    public int? StartingPositionValue { get; set; }

    /// <summary>
    /// Defines ending point of a position range - number of seconds or words from the start or from the end of the interaction
    /// </summary>
    /// <value>Defines ending point of a position range - number of seconds or words from the start or from the end of the interaction</value>
    public int? EndingPositionValue { get; set; }
}
