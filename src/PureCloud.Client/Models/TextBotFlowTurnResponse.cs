namespace PureCloud.Client.Models;

/// <summary>
/// Information related to a success bot flow turn request.
/// </summary>
public sealed class TextBotFlowTurnResponse
{
    /// <summary>
    /// The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// The reference to a previous turn, if applicable.
    /// </summary>
    public TextBotTurnReference PreviousTurn { get; set; }

    /// <summary>
    /// The output prompts for this turn.
    /// </summary>
    public TextBotOutputPrompts Prompts { get; set; }

    /// <summary>
    /// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
    /// </summary>
    public TextBotFlowTurnResponseNextActionType? NextActionType { get; set; }

    /// <summary>
    /// The next action directive for this turn if it is a Disconnect type.
    /// </summary>
    public TextBotDisconnectAction NextActionDisconnect { get; set; }

    /// <summary>
    /// The next action directive for this turn if it is a WaitForInput type.
    /// </summary>
    public TextBotWaitForInputAction NextActionWaitForInput { get; set; }

    /// <summary>
    /// The next action directive for this turn if it is an Exit type.
    /// </summary>
    public TextBotExitAction NextActionExit { get; set; }
}