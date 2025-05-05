using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// V2FlowExecutionDataFlowidTopicFlowExecutionHistory
/// </summary>

public partial class V2FlowExecutionDataFlowidTopicFlowExecutionHistory : IEquatable<V2FlowExecutionDataFlowidTopicFlowExecutionHistory>
{
    /// <summary>
    /// If applicable, the type of message platform from which the message originated.
    /// </summary>
    /// <value>If applicable, the type of message platform from which the message originated.</value>
    
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "facebook"
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// Enum Instagram for "instagram"
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// Enum Line for "line"
        /// </summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "webmessaging"
        /// </summary>
        [EnumMember(Value = "webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open
    }
    /// <summary>
    /// If applicable, the type of message platform from which the message originated.
    /// </summary>
    /// <value>If applicable, the type of message platform from which the message originated.</value>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="V2FlowExecutionDataFlowidTopicFlowExecutionHistory" /> class.
    /// </summary>
    /// <param name="ExecutionId">The execution identifier which represents this unique instance of the flow that ran..</param>
    /// <param name="ConversationId">The Genesys Cloud conversation identifier associated with this flow instance execution data..</param>
    /// <param name="DivisionId">The division identifier for the division associated with the flow for this flow instance..</param>
    /// <param name="EndDateTime">The end date time for this flow instance execution data..</param>
    /// <param name="Endpoint">The public endpoint a user can use to retrieve the full historical log from the service..</param>
    /// <param name="Errors">If the flow invoked error handling, an array of errors..</param>
    /// <param name="Execution">An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot..</param>
    /// <param name="FlowExitReason">Provides information about why a flow ended..</param>
    /// <param name="FlowId">The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect..</param>
    /// <param name="FlowIsDebug">Whether the flow that ran for this flow instance execution data was in debug mode..</param>
    /// <param name="ExecutionItemsTruncated">If true, the execution items in this event have been truncated to be deliverable..</param>
    /// <param name="FlowType">The flow type of the Architect flow that was run..</param>
    /// <param name="FlowVersion">The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39;.</param>
    /// <param name="MessageType">If applicable, the type of message platform from which the message originated..</param>
    /// <param name="InvokingContext">InvokingContext.</param>
    /// <param name="StartDateTime">The start date time for this flow instance execution data..</param>
    /// <param name="Warnings">If the flow encountered a warning during execution, this is an array of the warnings..</param>
    public V2FlowExecutionDataFlowidTopicFlowExecutionHistory(string ExecutionId = null, string ConversationId = null, string DivisionId = null, DateTime? EndDateTime = null, string Endpoint = null, List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Errors = null, List<V2FlowExecutionDataFlowidTopicExecution> Execution = null, string FlowExitReason = null, string FlowId = null, bool? FlowIsDebug = null, bool? ExecutionItemsTruncated = null, string FlowType = null, string FlowVersion = null, MessageTypeEnum? MessageType = null, V2FlowExecutionDataFlowidTopicInvokingContext InvokingContext = null, DateTime? StartDateTime = null, List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Warnings = null)
    {
        this.ExecutionId = ExecutionId;
        this.ConversationId = ConversationId;
        this.DivisionId = DivisionId;
        this.EndDateTime = EndDateTime;
        this.Endpoint = Endpoint;
        this.Errors = Errors;
        this.Execution = Execution;
        this.FlowExitReason = FlowExitReason;
        this.FlowId = FlowId;
        this.FlowIsDebug = FlowIsDebug;
        this.ExecutionItemsTruncated = ExecutionItemsTruncated;
        this.FlowType = FlowType;
        this.FlowVersion = FlowVersion;
        this.MessageType = MessageType;
        this.InvokingContext = InvokingContext;
        this.StartDateTime = StartDateTime;
        this.Warnings = Warnings;

    }



    /// <summary>
    /// The execution identifier which represents this unique instance of the flow that ran.
    /// </summary>
    /// <value>The execution identifier which represents this unique instance of the flow that ran.</value>
    [JsonPropertyName("executionId")]
    public string ExecutionId { get; set; }



    /// <summary>
    /// The Genesys Cloud conversation identifier associated with this flow instance execution data.
    /// </summary>
    /// <value>The Genesys Cloud conversation identifier associated with this flow instance execution data.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The division identifier for the division associated with the flow for this flow instance.
    /// </summary>
    /// <value>The division identifier for the division associated with the flow for this flow instance.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }



    /// <summary>
    /// The end date time for this flow instance execution data.
    /// </summary>
    /// <value>The end date time for this flow instance execution data.</value>
    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }



    /// <summary>
    /// The public endpoint a user can use to retrieve the full historical log from the service.
    /// </summary>
    /// <value>The public endpoint a user can use to retrieve the full historical log from the service.</value>
    [JsonPropertyName("endpoint")]
    public string Endpoint { get; set; }



    /// <summary>
    /// If the flow invoked error handling, an array of errors.
    /// </summary>
    /// <value>If the flow invoked error handling, an array of errors.</value>
    [JsonPropertyName("errors")]
    public List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Errors { get; set; }



    /// <summary>
    /// An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.
    /// </summary>
    /// <value>An array of execution items that describe what happened when an Architect flow action container ran such as a flow, task, state or bot.</value>
    [JsonPropertyName("execution")]
    public List<V2FlowExecutionDataFlowidTopicExecution> Execution { get; set; }



    /// <summary>
    /// Provides information about why a flow ended.
    /// </summary>
    /// <value>Provides information about why a flow ended.</value>
    [JsonPropertyName("flowExitReason")]
    public string FlowExitReason { get; set; }



    /// <summary>
    /// The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.
    /// </summary>
    /// <value>The flow identifier for this flow instance execution data.  This is the identifier of the flow configuration that users load up in Architect.</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }



    /// <summary>
    /// Whether the flow that ran for this flow instance execution data was in debug mode.
    /// </summary>
    /// <value>Whether the flow that ran for this flow instance execution data was in debug mode.</value>
    [JsonPropertyName("flowIsDebug")]
    public bool? FlowIsDebug { get; set; }



    /// <summary>
    /// If true, the execution items in this event have been truncated to be deliverable.
    /// </summary>
    /// <value>If true, the execution items in this event have been truncated to be deliverable.</value>
    [JsonPropertyName("executionItemsTruncated")]
    public bool? ExecutionItemsTruncated { get; set; }



    /// <summary>
    /// The flow type of the Architect flow that was run.
    /// </summary>
    /// <value>The flow type of the Architect flow that was run.</value>
    [JsonPropertyName("flowType")]
    public string FlowType { get; set; }



    /// <summary>
    /// The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39;
    /// </summary>
    /// <value>The version of the flow for this flow instance execution data. Typically this is a numeric value like 1.0 represented as a string but can also be &#39;debug&#39;</value>
    [JsonPropertyName("flowVersion")]
    public string FlowVersion { get; set; }





    /// <summary>
    /// Gets or Sets InvokingContext
    /// </summary>
    [JsonPropertyName("invokingContext")]
    public V2FlowExecutionDataFlowidTopicInvokingContext InvokingContext { get; set; }



    /// <summary>
    /// The start date time for this flow instance execution data.
    /// </summary>
    /// <value>The start date time for this flow instance execution data.</value>
    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }



    /// <summary>
    /// If the flow encountered a warning during execution, this is an array of the warnings.
    /// </summary>
    /// <value>If the flow encountered a warning during execution, this is an array of the warnings.</value>
    [JsonPropertyName("warnings")]
    public List<V2FlowExecutionDataFlowidTopicFlowErrorWarningInfo> Warnings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class V2FlowExecutionDataFlowidTopicFlowExecutionHistory {\n");

        sb.Append("  ExecutionId: ").Append(ExecutionId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
        sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
        sb.Append("  Execution: ").Append(Execution).Append("\n");
        sb.Append("  FlowExitReason: ").Append(FlowExitReason).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowIsDebug: ").Append(FlowIsDebug).Append("\n");
        sb.Append("  ExecutionItemsTruncated: ").Append(ExecutionItemsTruncated).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  InvokingContext: ").Append(InvokingContext).Append("\n");
        sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
        sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
        return Equals(obj as V2FlowExecutionDataFlowidTopicFlowExecutionHistory);
    }

    /// <summary>
    /// Returns true if V2FlowExecutionDataFlowidTopicFlowExecutionHistory instances are equal
    /// </summary>
    /// <param name="other">Instance of V2FlowExecutionDataFlowidTopicFlowExecutionHistory to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(V2FlowExecutionDataFlowidTopicFlowExecutionHistory other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExecutionId == other.ExecutionId ||
                ExecutionId != null &&
                ExecutionId.Equals(other.ExecutionId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                EndDateTime == other.EndDateTime ||
                EndDateTime != null &&
                EndDateTime.Equals(other.EndDateTime)
            ) &&
            (
                Endpoint == other.Endpoint ||
                Endpoint != null &&
                Endpoint.Equals(other.Endpoint)
            ) &&
            (
                Errors == other.Errors ||
                Errors != null &&
                Errors.SequenceEqual(other.Errors)
            ) &&
            (
                Execution == other.Execution ||
                Execution != null &&
                Execution.SequenceEqual(other.Execution)
            ) &&
            (
                FlowExitReason == other.FlowExitReason ||
                FlowExitReason != null &&
                FlowExitReason.Equals(other.FlowExitReason)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowIsDebug == other.FlowIsDebug ||
                FlowIsDebug != null &&
                FlowIsDebug.Equals(other.FlowIsDebug)
            ) &&
            (
                ExecutionItemsTruncated == other.ExecutionItemsTruncated ||
                ExecutionItemsTruncated != null &&
                ExecutionItemsTruncated.Equals(other.ExecutionItemsTruncated)
            ) &&
            (
                FlowType == other.FlowType ||
                FlowType != null &&
                FlowType.Equals(other.FlowType)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                InvokingContext == other.InvokingContext ||
                InvokingContext != null &&
                InvokingContext.Equals(other.InvokingContext)
            ) &&
            (
                StartDateTime == other.StartDateTime ||
                StartDateTime != null &&
                StartDateTime.Equals(other.StartDateTime)
            ) &&
            (
                Warnings == other.Warnings ||
                Warnings != null &&
                Warnings.SequenceEqual(other.Warnings)
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
            if (ExecutionId != null)
            {
                hash = hash * 59 + ExecutionId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (EndDateTime != null)
            {
                hash = hash * 59 + EndDateTime.GetHashCode();
            }

            if (Endpoint != null)
            {
                hash = hash * 59 + Endpoint.GetHashCode();
            }

            if (Errors != null)
            {
                hash = hash * 59 + Errors.GetHashCode();
            }

            if (Execution != null)
            {
                hash = hash * 59 + Execution.GetHashCode();
            }

            if (FlowExitReason != null)
            {
                hash = hash * 59 + FlowExitReason.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowIsDebug != null)
            {
                hash = hash * 59 + FlowIsDebug.GetHashCode();
            }

            if (ExecutionItemsTruncated != null)
            {
                hash = hash * 59 + ExecutionItemsTruncated.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (InvokingContext != null)
            {
                hash = hash * 59 + InvokingContext.GetHashCode();
            }

            if (StartDateTime != null)
            {
                hash = hash * 59 + StartDateTime.GetHashCode();
            }

            if (Warnings != null)
            {
                hash = hash * 59 + Warnings.GetHashCode();
            }

            return hash;
        }
    }
}
