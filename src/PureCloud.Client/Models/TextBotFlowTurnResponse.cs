using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Information related to a success bot flow turn request.
/// </summary>

public partial class TextBotFlowTurnResponse : IEquatable<TextBotFlowTurnResponse>
{
    /// <summary>
    /// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
    /// </summary>
    /// <value>Indicates the suggested next action. If appropriate, the matching output event object includes additional information.</value>
    
    public enum NextActionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Noop for "NoOp"
        /// </summary>
        [EnumMember(Value = "NoOp")]
        Noop,

        /// <summary>
        /// Enum Disconnect for "Disconnect"
        /// </summary>
        [EnumMember(Value = "Disconnect")]
        Disconnect,

        /// <summary>
        /// Enum Waitforinput for "WaitForInput"
        /// </summary>
        [EnumMember(Value = "WaitForInput")]
        Waitforinput,

        /// <summary>
        /// Enum Exit for "Exit"
        /// </summary>
        [EnumMember(Value = "Exit")]
        Exit
    }
    /// <summary>
    /// Indicates the suggested next action. If appropriate, the matching output event object includes additional information.
    /// </summary>
    /// <value>Indicates the suggested next action. If appropriate, the matching output event object includes additional information.</value>
    [JsonPropertyName("nextActionType")]
    public NextActionTypeEnum? NextActionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowTurnResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotFlowTurnResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowTurnResponse" /> class.
    /// </summary>
    /// <param name="Id">The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request. (required).</param>
    /// <param name="PreviousTurn">The reference to a previous turn, if applicable..</param>
    /// <param name="Prompts">The output prompts for this turn..</param>
    /// <param name="NextActionType">Indicates the suggested next action. If appropriate, the matching output event object includes additional information. (required).</param>
    /// <param name="NextActionDisconnect">The next action directive for this turn if it is a Disconnect type..</param>
    /// <param name="NextActionWaitForInput">The next action directive for this turn if it is a WaitForInput type..</param>
    /// <param name="NextActionExit">The next action directive for this turn if it is an Exit type..</param>
    public TextBotFlowTurnResponse(string Id = null, TextBotTurnReference PreviousTurn = null, TextBotOutputPrompts Prompts = null, NextActionTypeEnum? NextActionType = null, TextBotDisconnectAction NextActionDisconnect = null, TextBotWaitForInputAction NextActionWaitForInput = null, TextBotExitAction NextActionExit = null)
    {
        this.Id = Id;
        this.PreviousTurn = PreviousTurn;
        this.Prompts = Prompts;
        this.NextActionType = NextActionType;
        this.NextActionDisconnect = NextActionDisconnect;
        this.NextActionWaitForInput = NextActionWaitForInput;
        this.NextActionExit = NextActionExit;

    }



    /// <summary>
    /// The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request.
    /// </summary>
    /// <value>The ID of the bot flow turn. If additional turns are needed, supply this ID as the previous turn in your next turn request.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The reference to a previous turn, if applicable.
    /// </summary>
    /// <value>The reference to a previous turn, if applicable.</value>
    [JsonPropertyName("previousTurn")]
    public TextBotTurnReference PreviousTurn { get; set; }



    /// <summary>
    /// The output prompts for this turn.
    /// </summary>
    /// <value>The output prompts for this turn.</value>
    [JsonPropertyName("prompts")]
    public TextBotOutputPrompts Prompts { get; set; }





    /// <summary>
    /// The next action directive for this turn if it is a Disconnect type.
    /// </summary>
    /// <value>The next action directive for this turn if it is a Disconnect type.</value>
    [JsonPropertyName("nextActionDisconnect")]
    public TextBotDisconnectAction NextActionDisconnect { get; set; }



    /// <summary>
    /// The next action directive for this turn if it is a WaitForInput type.
    /// </summary>
    /// <value>The next action directive for this turn if it is a WaitForInput type.</value>
    [JsonPropertyName("nextActionWaitForInput")]
    public TextBotWaitForInputAction NextActionWaitForInput { get; set; }



    /// <summary>
    /// The next action directive for this turn if it is an Exit type.
    /// </summary>
    /// <value>The next action directive for this turn if it is an Exit type.</value>
    [JsonPropertyName("nextActionExit")]
    public TextBotExitAction NextActionExit { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowTurnResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  PreviousTurn: ").Append(PreviousTurn).Append("\n");
        sb.Append("  Prompts: ").Append(Prompts).Append("\n");
        sb.Append("  NextActionType: ").Append(NextActionType).Append("\n");
        sb.Append("  NextActionDisconnect: ").Append(NextActionDisconnect).Append("\n");
        sb.Append("  NextActionWaitForInput: ").Append(NextActionWaitForInput).Append("\n");
        sb.Append("  NextActionExit: ").Append(NextActionExit).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as TextBotFlowTurnResponse);
    }

    /// <summary>
    /// Returns true if TextBotFlowTurnResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowTurnResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowTurnResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                PreviousTurn == other.PreviousTurn ||
                PreviousTurn != null &&
                PreviousTurn.Equals(other.PreviousTurn)
            ) &&
            (
                Prompts == other.Prompts ||
                Prompts != null &&
                Prompts.Equals(other.Prompts)
            ) &&
            (
                NextActionType == other.NextActionType ||
                NextActionType != null &&
                NextActionType.Equals(other.NextActionType)
            ) &&
            (
                NextActionDisconnect == other.NextActionDisconnect ||
                NextActionDisconnect != null &&
                NextActionDisconnect.Equals(other.NextActionDisconnect)
            ) &&
            (
                NextActionWaitForInput == other.NextActionWaitForInput ||
                NextActionWaitForInput != null &&
                NextActionWaitForInput.Equals(other.NextActionWaitForInput)
            ) &&
            (
                NextActionExit == other.NextActionExit ||
                NextActionExit != null &&
                NextActionExit.Equals(other.NextActionExit)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (PreviousTurn != null)
            {
                hash = hash * 59 + PreviousTurn.GetHashCode();
            }

            if (Prompts != null)
            {
                hash = hash * 59 + Prompts.GetHashCode();
            }

            if (NextActionType != null)
            {
                hash = hash * 59 + NextActionType.GetHashCode();
            }

            if (NextActionDisconnect != null)
            {
                hash = hash * 59 + NextActionDisconnect.GetHashCode();
            }

            if (NextActionWaitForInput != null)
            {
                hash = hash * 59 + NextActionWaitForInput.GetHashCode();
            }

            if (NextActionExit != null)
            {
                hash = hash * 59 + NextActionExit.GetHashCode();
            }

            return hash;
        }
    }
}
