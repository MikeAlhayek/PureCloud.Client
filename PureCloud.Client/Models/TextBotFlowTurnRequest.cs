using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a turn request to a bot flow.
/// </summary>
[DataContract]
public partial class TextBotFlowTurnRequest : IEquatable<TextBotFlowTurnRequest>
{
    /// <summary>
    /// Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.
    /// </summary>
    /// <value>Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InputEventTypeEnum
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
        /// Enum Userinput for "UserInput"
        /// </summary>
        [EnumMember(Value = "UserInput")]
        Userinput,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Nomatch for "NoMatch"
        /// </summary>
        [EnumMember(Value = "NoMatch")]
        Nomatch,

        /// <summary>
        /// Enum Noinput for "NoInput"
        /// </summary>
        [EnumMember(Value = "NoInput")]
        Noinput,

        /// <summary>
        /// Enum Userdisconnect for "UserDisconnect"
        /// </summary>
        [EnumMember(Value = "UserDisconnect")]
        Userdisconnect,

        /// <summary>
        /// Enum Clientsessionexpired for "ClientSessionExpired"
        /// </summary>
        [EnumMember(Value = "ClientSessionExpired")]
        Clientsessionexpired
    }
    /// <summary>
    /// Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.
    /// </summary>
    /// <value>Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request.</value>
    [DataMember(Name = "inputEventType", EmitDefaultValue = false)]
    public InputEventTypeEnum? InputEventType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowTurnRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotFlowTurnRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotFlowTurnRequest" /> class.
    /// </summary>
    /// <param name="PreviousTurn">The reference to a previous turn if appropriate, used to avoid race conditions..</param>
    /// <param name="InputEventType">Indicates the type of input event being requested. If appropriate, fill out the matching user input object details on this request. (required).</param>
    /// <param name="InputEventUserInput">The data for the input event of this turn if it is a user input event. Only one inputEvent may be set..</param>
    /// <param name="InputEventError">The data for the input event of this turn if it is an error event. Only one inputEvent may be set..</param>
    public TextBotFlowTurnRequest(TextBotTurnReference PreviousTurn = null, InputEventTypeEnum? InputEventType = null, TextBotUserInputEvent InputEventUserInput = null, TextBotErrorInputEvent InputEventError = null)
    {
        this.PreviousTurn = PreviousTurn;
        this.InputEventType = InputEventType;
        this.InputEventUserInput = InputEventUserInput;
        this.InputEventError = InputEventError;

    }



    /// <summary>
    /// The reference to a previous turn if appropriate, used to avoid race conditions.
    /// </summary>
    /// <value>The reference to a previous turn if appropriate, used to avoid race conditions.</value>
    [DataMember(Name = "previousTurn", EmitDefaultValue = false)]
    public TextBotTurnReference PreviousTurn { get; set; }





    /// <summary>
    /// The data for the input event of this turn if it is a user input event. Only one inputEvent may be set.
    /// </summary>
    /// <value>The data for the input event of this turn if it is a user input event. Only one inputEvent may be set.</value>
    [DataMember(Name = "inputEventUserInput", EmitDefaultValue = false)]
    public TextBotUserInputEvent InputEventUserInput { get; set; }



    /// <summary>
    /// The data for the input event of this turn if it is an error event. Only one inputEvent may be set.
    /// </summary>
    /// <value>The data for the input event of this turn if it is an error event. Only one inputEvent may be set.</value>
    [DataMember(Name = "inputEventError", EmitDefaultValue = false)]
    public TextBotErrorInputEvent InputEventError { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotFlowTurnRequest {\n");

        sb.Append("  PreviousTurn: ").Append(PreviousTurn).Append("\n");
        sb.Append("  InputEventType: ").Append(InputEventType).Append("\n");
        sb.Append("  InputEventUserInput: ").Append(InputEventUserInput).Append("\n");
        sb.Append("  InputEventError: ").Append(InputEventError).Append("\n");
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
        return Equals(obj as TextBotFlowTurnRequest);
    }

    /// <summary>
    /// Returns true if TextBotFlowTurnRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotFlowTurnRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotFlowTurnRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PreviousTurn == other.PreviousTurn ||
                PreviousTurn != null &&
                PreviousTurn.Equals(other.PreviousTurn)
            ) &&
            (
                InputEventType == other.InputEventType ||
                InputEventType != null &&
                InputEventType.Equals(other.InputEventType)
            ) &&
            (
                InputEventUserInput == other.InputEventUserInput ||
                InputEventUserInput != null &&
                InputEventUserInput.Equals(other.InputEventUserInput)
            ) &&
            (
                InputEventError == other.InputEventError ||
                InputEventError != null &&
                InputEventError.Equals(other.InputEventError)
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
            if (PreviousTurn != null)
            {
                hash = hash * 59 + PreviousTurn.GetHashCode();
            }

            if (InputEventType != null)
            {
                hash = hash * 59 + InputEventType.GetHashCode();
            }

            if (InputEventUserInput != null)
            {
                hash = hash * 59 + InputEventUserInput.GetHashCode();
            }

            if (InputEventError != null)
            {
                hash = hash * 59 + InputEventError.GetHashCode();
            }

            return hash;
        }
    }
}
