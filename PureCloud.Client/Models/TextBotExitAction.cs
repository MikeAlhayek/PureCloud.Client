using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a next-action of exiting the bot flow. Any output variables are available in the details.
/// </summary>
[DataContract]
public partial class TextBotExitAction : IEquatable<TextBotExitAction>
{
    /// <summary>
    /// The reason for the exit.
    /// </summary>
    /// <value>The reason for the exit.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Triggeredbyuser for "TriggeredByUser"
        /// </summary>
        [EnumMember(Value = "TriggeredByUser")]
        Triggeredbyuser,

        /// <summary>
        /// Enum Agentrequestedbyuser for "AgentRequestedByUser"
        /// </summary>
        [EnumMember(Value = "AgentRequestedByUser")]
        Agentrequestedbyuser,

        /// <summary>
        /// Enum Triggeredbyflow for "TriggeredByFlow"
        /// </summary>
        [EnumMember(Value = "TriggeredByFlow")]
        Triggeredbyflow,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Recognitionfailure for "RecognitionFailure"
        /// </summary>
        [EnumMember(Value = "RecognitionFailure")]
        Recognitionfailure
    }
    /// <summary>
    /// The reason for the exit.
    /// </summary>
    /// <value>The reason for the exit.</value>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public ReasonEnum? Reason { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotExitAction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotExitAction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotExitAction" /> class.
    /// </summary>
    /// <param name="Reason">The reason for the exit. (required).</param>
    /// <param name="ReasonExtendedInfo">Extended information related to the reason, if available..</param>
    /// <param name="ActiveIntent">The active intent at the time of the exit..</param>
    /// <param name="FlowLocation">Describes where in the Bot Flow the user was when the exit occurred..</param>
    /// <param name="OutputData">The output data for the bot flow..</param>
    /// <param name="FlowOutcomes">The list of Flow Outcomes for the bot flow and their details..</param>
    public TextBotExitAction(ReasonEnum? Reason = null, string ReasonExtendedInfo = null, string ActiveIntent = null, TextBotFlowLocation FlowLocation = null, TextBotInputOutputData OutputData = null, List<TextBotFlowOutcome> FlowOutcomes = null)
    {
        this.Reason = Reason;
        this.ReasonExtendedInfo = ReasonExtendedInfo;
        this.ActiveIntent = ActiveIntent;
        this.FlowLocation = FlowLocation;
        this.OutputData = OutputData;
        this.FlowOutcomes = FlowOutcomes;

    }





    /// <summary>
    /// Extended information related to the reason, if available.
    /// </summary>
    /// <value>Extended information related to the reason, if available.</value>
    [DataMember(Name = "reasonExtendedInfo", EmitDefaultValue = false)]
    public string ReasonExtendedInfo { get; set; }



    /// <summary>
    /// The active intent at the time of the exit.
    /// </summary>
    /// <value>The active intent at the time of the exit.</value>
    [DataMember(Name = "activeIntent", EmitDefaultValue = false)]
    public string ActiveIntent { get; set; }



    /// <summary>
    /// Describes where in the Bot Flow the user was when the exit occurred.
    /// </summary>
    /// <value>Describes where in the Bot Flow the user was when the exit occurred.</value>
    [DataMember(Name = "flowLocation", EmitDefaultValue = false)]
    public TextBotFlowLocation FlowLocation { get; set; }



    /// <summary>
    /// The output data for the bot flow.
    /// </summary>
    /// <value>The output data for the bot flow.</value>
    [DataMember(Name = "outputData", EmitDefaultValue = false)]
    public TextBotInputOutputData OutputData { get; set; }



    /// <summary>
    /// The list of Flow Outcomes for the bot flow and their details.
    /// </summary>
    /// <value>The list of Flow Outcomes for the bot flow and their details.</value>
    [DataMember(Name = "flowOutcomes", EmitDefaultValue = false)]
    public List<TextBotFlowOutcome> FlowOutcomes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotExitAction {\n");

        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  ReasonExtendedInfo: ").Append(ReasonExtendedInfo).Append("\n");
        sb.Append("  ActiveIntent: ").Append(ActiveIntent).Append("\n");
        sb.Append("  FlowLocation: ").Append(FlowLocation).Append("\n");
        sb.Append("  OutputData: ").Append(OutputData).Append("\n");
        sb.Append("  FlowOutcomes: ").Append(FlowOutcomes).Append("\n");
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
        return Equals(obj as TextBotExitAction);
    }

    /// <summary>
    /// Returns true if TextBotExitAction instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotExitAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotExitAction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                ReasonExtendedInfo == other.ReasonExtendedInfo ||
                ReasonExtendedInfo != null &&
                ReasonExtendedInfo.Equals(other.ReasonExtendedInfo)
            ) &&
            (
                ActiveIntent == other.ActiveIntent ||
                ActiveIntent != null &&
                ActiveIntent.Equals(other.ActiveIntent)
            ) &&
            (
                FlowLocation == other.FlowLocation ||
                FlowLocation != null &&
                FlowLocation.Equals(other.FlowLocation)
            ) &&
            (
                OutputData == other.OutputData ||
                OutputData != null &&
                OutputData.Equals(other.OutputData)
            ) &&
            (
                FlowOutcomes == other.FlowOutcomes ||
                FlowOutcomes != null &&
                FlowOutcomes.SequenceEqual(other.FlowOutcomes)
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
            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (ReasonExtendedInfo != null)
            {
                hash = hash * 59 + ReasonExtendedInfo.GetHashCode();
            }

            if (ActiveIntent != null)
            {
                hash = hash * 59 + ActiveIntent.GetHashCode();
            }

            if (FlowLocation != null)
            {
                hash = hash * 59 + FlowLocation.GetHashCode();
            }

            if (OutputData != null)
            {
                hash = hash * 59 + OutputData.GetHashCode();
            }

            if (FlowOutcomes != null)
            {
                hash = hash * 59 + FlowOutcomes.GetHashCode();
            }

            return hash;
        }
    }
}
