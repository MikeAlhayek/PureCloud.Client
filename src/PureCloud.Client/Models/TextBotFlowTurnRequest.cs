namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a turn request to a bot flow.
/// </summary>
public sealed class TextBotFlowTurnRequest
{
    /// <summary>
    /// The reference to a previous turn if appropriate, used to avoid race conditions.
    /// </summary>
    public TextBotTurnReference PreviousTurn { get; set; }

    /// <summary>
    /// Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.
    /// </summary>
    public TextBotFlowTurnRequestInputEventType? InputEventType { get; set; }

    /// <summary>
    /// The data for the input event of this turn if it is a user input event. Only one inputEvent may be set.
    /// </summary>
    public TextBotUserInputEvent InputEventUserInput { get; set; }

    /// <summary>
    /// The data for the input event of this turn if it is an error event. Only one inputEvent may be set.
    /// </summary>
    public TextBotErrorInputEvent InputEventError { get; set; }
}