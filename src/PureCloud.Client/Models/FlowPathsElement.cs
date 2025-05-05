using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowPathsElement
/// </summary>

public partial class FlowPathsElement : IEquatable<FlowPathsElement>
{
    /// <summary>
    /// Type of the element.
    /// </summary>
    /// <value>Type of the element.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Abandoned for "Abandoned"
        /// </summary>
        [EnumMember(Value = "Abandoned")]
        Abandoned,

        /// <summary>
        /// Enum Agentescalation for "AgentEscalation"
        /// </summary>
        [EnumMember(Value = "AgentEscalation")]
        Agentescalation,

        /// <summary>
        /// Enum Disconnect for "Disconnect"
        /// </summary>
        [EnumMember(Value = "Disconnect")]
        Disconnect,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Exit for "Exit"
        /// </summary>
        [EnumMember(Value = "Exit")]
        Exit,

        /// <summary>
        /// Enum Milestone for "Milestone"
        /// </summary>
        [EnumMember(Value = "Milestone")]
        Milestone,

        /// <summary>
        /// Enum Outcome for "Outcome"
        /// </summary>
        [EnumMember(Value = "Outcome")]
        Outcome,

        /// <summary>
        /// Enum Recognitionfailure for "RecognitionFailure"
        /// </summary>
        [EnumMember(Value = "RecognitionFailure")]
        Recognitionfailure,

        /// <summary>
        /// Enum Root for "Root"
        /// </summary>
        [EnumMember(Value = "Root")]
        Root,

        /// <summary>
        /// Enum Transferreturntoagent for "TransferReturnToAgent"
        /// </summary>
        [EnumMember(Value = "TransferReturnToAgent")]
        Transferreturntoagent,

        /// <summary>
        /// Enum Transfertoacd for "TransferToAcd"
        /// </summary>
        [EnumMember(Value = "TransferToAcd")]
        Transfertoacd,

        /// <summary>
        /// Enum Transfertoacdvoicemail for "TransferToAcdVoicemail"
        /// </summary>
        [EnumMember(Value = "TransferToAcdVoicemail")]
        Transfertoacdvoicemail,

        /// <summary>
        /// Enum Transfertoflow for "TransferToFlow"
        /// </summary>
        [EnumMember(Value = "TransferToFlow")]
        Transfertoflow,

        /// <summary>
        /// Enum Transfertogroup for "TransferToGroup"
        /// </summary>
        [EnumMember(Value = "TransferToGroup")]
        Transfertogroup,

        /// <summary>
        /// Enum Transfertogroupvoicemail for "TransferToGroupVoicemail"
        /// </summary>
        [EnumMember(Value = "TransferToGroupVoicemail")]
        Transfertogroupvoicemail,

        /// <summary>
        /// Enum Transfertonumber for "TransferToNumber"
        /// </summary>
        [EnumMember(Value = "TransferToNumber")]
        Transfertonumber,

        /// <summary>
        /// Enum Transfertosecureflow for "TransferToSecureFlow"
        /// </summary>
        [EnumMember(Value = "TransferToSecureFlow")]
        Transfertosecureflow,

        /// <summary>
        /// Enum Transfertouser for "TransferToUser"
        /// </summary>
        [EnumMember(Value = "TransferToUser")]
        Transfertouser,

        /// <summary>
        /// Enum Transfertouservoicemail for "TransferToUserVoicemail"
        /// </summary>
        [EnumMember(Value = "TransferToUserVoicemail")]
        Transfertouservoicemail
    }
    /// <summary>
    /// The value of the flow outcome, if the element type is Outcome.
    /// </summary>
    /// <value>The value of the flow outcome, if the element type is Outcome.</value>
    
    public enum FlowOutcomeValueEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure,

        /// <summary>
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown
    }
    /// <summary>
    /// Type of the element.
    /// </summary>
    /// <value>Type of the element.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// The value of the flow outcome, if the element type is Outcome.
    /// </summary>
    /// <value>The value of the flow outcome, if the element type is Outcome.</value>
    [JsonPropertyName("flowOutcomeValue")]
    public FlowOutcomeValueEnum? FlowOutcomeValue { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsElement" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowPathsElement() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsElement" /> class.
    /// </summary>
    /// <param name="ParentId">Unique identifier of the parent element. Will be null for the root element..</param>
    /// <param name="Type">Type of the element. (required).</param>
    /// <param name="Count">Count of all journeys that include this element. (required).</param>
    /// <param name="Flows">Details of flows involved in journeys that include this element. (required).</param>
    /// <param name="FlowOutcomeValue">The value of the flow outcome, if the element type is Outcome..</param>
    public FlowPathsElement(string ParentId = null, TypeEnum? Type = null, int? Count = null, List<FlowPathsFlowDetails> Flows = null, FlowOutcomeValueEnum? FlowOutcomeValue = null)
    {
        this.ParentId = ParentId;
        this.Type = Type;
        this.Count = Count;
        this.Flows = Flows;
        this.FlowOutcomeValue = FlowOutcomeValue;

    }



    /// <summary>
    /// Unique identifier of the parent element. Will be null for the root element.
    /// </summary>
    /// <value>Unique identifier of the parent element. Will be null for the root element.</value>
    [JsonPropertyName("parentId")]
    public string ParentId { get; set; }





    /// <summary>
    /// Count of all journeys that include this element.
    /// </summary>
    /// <value>Count of all journeys that include this element.</value>
    [JsonPropertyName("count")]
    public int? Count { get; set; }



    /// <summary>
    /// Details of flows involved in journeys that include this element.
    /// </summary>
    /// <value>Details of flows involved in journeys that include this element.</value>
    [JsonPropertyName("flows")]
    public List<FlowPathsFlowDetails> Flows { get; set; }





    /// <summary>
    /// The flow milestone, set if the element type is Milestone.
    /// </summary>
    /// <value>The flow milestone, set if the element type is Milestone.</value>
    [JsonPropertyName("flowMilestone")]
    public AddressableEntityRef FlowMilestone { get; private set; }



    /// <summary>
    /// The flow outcome, set if the element type is Outcome or Milestone.
    /// </summary>
    /// <value>The flow outcome, set if the element type is Outcome or Milestone.</value>
    [JsonPropertyName("flowOutcome")]
    public AddressableEntityRef FlowOutcome { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowPathsElement {\n");

        sb.Append("  ParentId: ").Append(ParentId).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  Flows: ").Append(Flows).Append("\n");
        sb.Append("  FlowOutcomeValue: ").Append(FlowOutcomeValue).Append("\n");
        sb.Append("  FlowMilestone: ").Append(FlowMilestone).Append("\n");
        sb.Append("  FlowOutcome: ").Append(FlowOutcome).Append("\n");
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
        return Equals(obj as FlowPathsElement);
    }

    /// <summary>
    /// Returns true if FlowPathsElement instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowPathsElement to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowPathsElement other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ParentId == other.ParentId ||
                ParentId != null &&
                ParentId.Equals(other.ParentId)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
            ) &&
            (
                Flows == other.Flows ||
                Flows != null &&
                Flows.SequenceEqual(other.Flows)
            ) &&
            (
                FlowOutcomeValue == other.FlowOutcomeValue ||
                FlowOutcomeValue != null &&
                FlowOutcomeValue.Equals(other.FlowOutcomeValue)
            ) &&
            (
                FlowMilestone == other.FlowMilestone ||
                FlowMilestone != null &&
                FlowMilestone.Equals(other.FlowMilestone)
            ) &&
            (
                FlowOutcome == other.FlowOutcome ||
                FlowOutcome != null &&
                FlowOutcome.Equals(other.FlowOutcome)
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
            if (ParentId != null)
            {
                hash = hash * 59 + ParentId.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            if (Flows != null)
            {
                hash = hash * 59 + Flows.GetHashCode();
            }

            if (FlowOutcomeValue != null)
            {
                hash = hash * 59 + FlowOutcomeValue.GetHashCode();
            }

            if (FlowMilestone != null)
            {
                hash = hash * 59 + FlowMilestone.GetHashCode();
            }

            if (FlowOutcome != null)
            {
                hash = hash * 59 + FlowOutcome.GetHashCode();
            }

            return hash;
        }
    }
}
