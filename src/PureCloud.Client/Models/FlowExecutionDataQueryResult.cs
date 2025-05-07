using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// This is the metadata of an executionData entry for a flow.
/// </summary>

public partial class FlowExecutionDataQueryResult : IEquatable<FlowExecutionDataQueryResult>
{
    /// <summary>
    /// The type of flow.
    /// </summary>
    /// <value>The type of flow.</value>
    
    public enum FlowTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bot for "bot"
        /// </summary>
        [EnumMember(Value = "bot")]
        Bot,

        /// <summary>
        /// Enum Commonmodule for "commonmodule"
        /// </summary>
        [EnumMember(Value = "commonmodule")]
        Commonmodule,

        /// <summary>
        /// Enum Digitalbot for "digitalbot"
        /// </summary>
        [EnumMember(Value = "digitalbot")]
        Digitalbot,

        /// <summary>
        /// Enum Inboundcall for "inboundcall"
        /// </summary>
        [EnumMember(Value = "inboundcall")]
        Inboundcall,

        /// <summary>
        /// Enum Inboundchat for "inboundchat"
        /// </summary>
        [EnumMember(Value = "inboundchat")]
        Inboundchat,

        /// <summary>
        /// Enum Inboundemail for "inboundemail"
        /// </summary>
        [EnumMember(Value = "inboundemail")]
        Inboundemail,

        /// <summary>
        /// Enum Inboundshortmessage for "inboundshortmessage"
        /// </summary>
        [EnumMember(Value = "inboundshortmessage")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inqueuecall for "inqueuecall"
        /// </summary>
        [EnumMember(Value = "inqueuecall")]
        Inqueuecall,

        /// <summary>
        /// Enum Inqueueshortmessage for "inqueueshortmessage"
        /// </summary>
        [EnumMember(Value = "inqueueshortmessage")]
        Inqueueshortmessage,

        /// <summary>
        /// Enum Inqueueemail for "inqueueemail"
        /// </summary>
        [EnumMember(Value = "inqueueemail")]
        Inqueueemail,

        /// <summary>
        /// Enum Outboundcall for "outboundcall"
        /// </summary>
        [EnumMember(Value = "outboundcall")]
        Outboundcall,

        /// <summary>
        /// Enum Securecall for "securecall"
        /// </summary>
        [EnumMember(Value = "securecall")]
        Securecall,

        /// <summary>
        /// Enum Surveyinvite for "surveyinvite"
        /// </summary>
        [EnumMember(Value = "surveyinvite")]
        Surveyinvite,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurvey for "voicesurvey"
        /// </summary>
        [EnumMember(Value = "voicesurvey")]
        Voicesurvey,

        /// <summary>
        /// Enum Workflow for "workflow"
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow,

        /// <summary>
        /// Enum Workitem for "workitem"
        /// </summary>
        [EnumMember(Value = "workitem")]
        Workitem
    }
    /// <summary>
    /// The type of flow.
    /// </summary>
    /// <value>The type of flow.</value>
    [JsonPropertyName("flowType")]
    public FlowTypeEnum? FlowType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowExecutionDataQueryResult" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="StartDateTime">The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="EndDateTime">The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="FlowId">The id of the flow that was executed..</param>
    /// <param name="FlowVersion">The version of the flow that was executed..</param>
    /// <param name="ConversationId">The id of the conversation that executed this flow..</param>
    /// <param name="WorkitemId">The id of the workitem that executed this flow..</param>
    /// <param name="FlowType">The type of flow..</param>
    /// <param name="FlowErrorReason">If the flow errored out this is the reason..</param>
    /// <param name="FlowWarningReason">If the flow had a warning, this is the reason..</param>
    /// <param name="FlowName">The name of the flow..</param>
    public FlowExecutionDataQueryResult(string Name = null, DateTime? StartDateTime = null, DateTime? EndDateTime = null, string FlowId = null, string FlowVersion = null, string ConversationId = null, string WorkitemId = null, FlowTypeEnum? FlowType = null, string FlowErrorReason = null, string FlowWarningReason = null, string FlowName = null)
    {
        this.Name = Name;
        this.StartDateTime = StartDateTime;
        this.EndDateTime = EndDateTime;
        this.FlowId = FlowId;
        this.FlowVersion = FlowVersion;
        this.ConversationId = ConversationId;
        this.WorkitemId = WorkitemId;
        this.FlowType = FlowType;
        this.FlowErrorReason = FlowErrorReason;
        this.FlowWarningReason = FlowWarningReason;
        this.FlowName = FlowName;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startDateTime")]
    public DateTime? StartDateTime { get; set; }



    /// <summary>
    /// The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end time for the execution of this flow. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("endDateTime")]
    public DateTime? EndDateTime { get; set; }



    /// <summary>
    /// The id of the flow that was executed.
    /// </summary>
    /// <value>The id of the flow that was executed.</value>
    [JsonPropertyName("flowId")]
    public string FlowId { get; set; }



    /// <summary>
    /// The version of the flow that was executed.
    /// </summary>
    /// <value>The version of the flow that was executed.</value>
    [JsonPropertyName("flowVersion")]
    public string FlowVersion { get; set; }



    /// <summary>
    /// The id of the conversation that executed this flow.
    /// </summary>
    /// <value>The id of the conversation that executed this flow.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// The id of the workitem that executed this flow.
    /// </summary>
    /// <value>The id of the workitem that executed this flow.</value>
    [JsonPropertyName("workitemId")]
    public string WorkitemId { get; set; }





    /// <summary>
    /// If the flow errored out this is the reason.
    /// </summary>
    /// <value>If the flow errored out this is the reason.</value>
    [JsonPropertyName("flowErrorReason")]
    public string FlowErrorReason { get; set; }



    /// <summary>
    /// If the flow had a warning, this is the reason.
    /// </summary>
    /// <value>If the flow had a warning, this is the reason.</value>
    [JsonPropertyName("flowWarningReason")]
    public string FlowWarningReason { get; set; }



    /// <summary>
    /// The name of the flow.
    /// </summary>
    /// <value>The name of the flow.</value>
    [JsonPropertyName("flowName")]
    public string FlowName { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowExecutionDataQueryResult {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
        sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  WorkitemId: ").Append(WorkitemId).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  FlowErrorReason: ").Append(FlowErrorReason).Append("\n");
        sb.Append("  FlowWarningReason: ").Append(FlowWarningReason).Append("\n");
        sb.Append("  FlowName: ").Append(FlowName).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as FlowExecutionDataQueryResult);
    }

    /// <summary>
    /// Returns true if FlowExecutionDataQueryResult instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowExecutionDataQueryResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowExecutionDataQueryResult other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                StartDateTime == other.StartDateTime ||
                StartDateTime != null &&
                StartDateTime.Equals(other.StartDateTime)
            ) &&
            (
                EndDateTime == other.EndDateTime ||
                EndDateTime != null &&
                EndDateTime.Equals(other.EndDateTime)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowVersion == other.FlowVersion ||
                FlowVersion != null &&
                FlowVersion.Equals(other.FlowVersion)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                WorkitemId == other.WorkitemId ||
                WorkitemId != null &&
                WorkitemId.Equals(other.WorkitemId)
            ) &&
            (
                FlowType == other.FlowType ||
                FlowType != null &&
                FlowType.Equals(other.FlowType)
            ) &&
            (
                FlowErrorReason == other.FlowErrorReason ||
                FlowErrorReason != null &&
                FlowErrorReason.Equals(other.FlowErrorReason)
            ) &&
            (
                FlowWarningReason == other.FlowWarningReason ||
                FlowWarningReason != null &&
                FlowWarningReason.Equals(other.FlowWarningReason)
            ) &&
            (
                FlowName == other.FlowName ||
                FlowName != null &&
                FlowName.Equals(other.FlowName)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (StartDateTime != null)
            {
                hash = hash * 59 + StartDateTime.GetHashCode();
            }

            if (EndDateTime != null)
            {
                hash = hash * 59 + EndDateTime.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (WorkitemId != null)
            {
                hash = hash * 59 + WorkitemId.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (FlowErrorReason != null)
            {
                hash = hash * 59 + FlowErrorReason.GetHashCode();
            }

            if (FlowWarningReason != null)
            {
                hash = hash * 59 + FlowWarningReason.GetHashCode();
            }

            if (FlowName != null)
            {
                hash = hash * 59 + FlowName.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
