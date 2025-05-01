using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AnalyticsFlow
/// </summary>
[DataContract]
public partial class AnalyticsFlow : IEquatable<AnalyticsFlow>
{
    /// <summary>
    /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
    /// </summary>
    /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EntryTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Agent for "agent"
        /// </summary>
        [EnumMember(Value = "agent")]
        Agent,

        /// <summary>
        /// Enum Direct for "direct"
        /// </summary>
        [EnumMember(Value = "direct")]
        Direct,

        /// <summary>
        /// Enum Dnis for "dnis"
        /// </summary>
        [EnumMember(Value = "dnis")]
        Dnis,

        /// <summary>
        /// Enum Flow for "flow"
        /// </summary>
        [EnumMember(Value = "flow")]
        Flow,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Bot for "BOT"
        /// </summary>
        [EnumMember(Value = "BOT")]
        Bot,

        /// <summary>
        /// Enum Commonmodule for "COMMONMODULE"
        /// </summary>
        [EnumMember(Value = "COMMONMODULE")]
        Commonmodule,

        /// <summary>
        /// Enum Digitalbot for "DIGITALBOT"
        /// </summary>
        [EnumMember(Value = "DIGITALBOT")]
        Digitalbot,

        /// <summary>
        /// Enum Inboundcall for "INBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "INBOUNDCALL")]
        Inboundcall,

        /// <summary>
        /// Enum Inboundchat for "INBOUNDCHAT"
        /// </summary>
        [EnumMember(Value = "INBOUNDCHAT")]
        Inboundchat,

        /// <summary>
        /// Enum Inboundemail for "INBOUNDEMAIL"
        /// </summary>
        [EnumMember(Value = "INBOUNDEMAIL")]
        Inboundemail,

        /// <summary>
        /// Enum Inboundshortmessage for "INBOUNDSHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INBOUNDSHORTMESSAGE")]
        Inboundshortmessage,

        /// <summary>
        /// Enum Inqueuecall for "INQUEUECALL"
        /// </summary>
        [EnumMember(Value = "INQUEUECALL")]
        Inqueuecall,

        /// <summary>
        /// Enum Inqueueemail for "INQUEUEEMAIL"
        /// </summary>
        [EnumMember(Value = "INQUEUEEMAIL")]
        Inqueueemail,

        /// <summary>
        /// Enum Inqueueshortmessage for "INQUEUESHORTMESSAGE"
        /// </summary>
        [EnumMember(Value = "INQUEUESHORTMESSAGE")]
        Inqueueshortmessage,

        /// <summary>
        /// Enum Outboundcall for "OUTBOUNDCALL"
        /// </summary>
        [EnumMember(Value = "OUTBOUNDCALL")]
        Outboundcall,

        /// <summary>
        /// Enum Securecall for "SECURECALL"
        /// </summary>
        [EnumMember(Value = "SECURECALL")]
        Securecall,

        /// <summary>
        /// Enum Speech for "SPEECH"
        /// </summary>
        [EnumMember(Value = "SPEECH")]
        Speech,

        /// <summary>
        /// Enum Surveyinvite for "SURVEYINVITE"
        /// </summary>
        [EnumMember(Value = "SURVEYINVITE")]
        Surveyinvite,

        /// <summary>
        /// Enum Voice for "VOICE"
        /// </summary>
        [EnumMember(Value = "VOICE")]
        Voice,

        /// <summary>
        /// Enum Voicemail for "VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "VOICEMAIL")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurvey for "VOICESURVEY"
        /// </summary>
        [EnumMember(Value = "VOICESURVEY")]
        Voicesurvey,

        /// <summary>
        /// Enum Workflow for "WORKFLOW"
        /// </summary>
        [EnumMember(Value = "WORKFLOW")]
        Workflow,

        /// <summary>
        /// Enum Workitem for "WORKITEM"
        /// </summary>
        [EnumMember(Value = "WORKITEM")]
        Workitem
    }
    /// <summary>
    /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
    /// </summary>
    /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
    [DataMember(Name = "entryType", EmitDefaultValue = false)]
    public EntryTypeEnum? EntryType { get; set; }
    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    [DataMember(Name = "flowType", EmitDefaultValue = false)]
    public FlowTypeEnum? FlowType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyticsFlow" /> class.
    /// </summary>
    /// <param name="EndingLanguage">Flow ending language, e.g. en-us.</param>
    /// <param name="EntryReason">The particular entry reason for this flow, e.g. an address, userId, or flowId.</param>
    /// <param name="EntryType">The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct.</param>
    /// <param name="ExitReason">The exit reason for this flow, e.g. DISCONNECT.</param>
    /// <param name="FlowId">The unique identifier of this flow.</param>
    /// <param name="FlowName">The name of this flow at the time of flow execution.</param>
    /// <param name="FlowType">The type of this flow.</param>
    /// <param name="FlowVersion">The version of this flow.</param>
    /// <param name="IssuedCallback">Flag indicating whether the flow issued a callback.</param>
    /// <param name="RecognitionFailureReason">The recognition failure reason causing to exit/disconnect.</param>
    /// <param name="StartingLanguage">Flow starting language, e.g. en-us.</param>
    /// <param name="TransferTargetAddress">The address of a flow transfer target, e.g. a phone number, an email address, or a queueId.</param>
    /// <param name="TransferTargetName">The name of a flow transfer target.</param>
    /// <param name="TransferType">The type of transfer for flows that ended with a transfer.</param>
    /// <param name="Outcomes">Flow outcomes.</param>
    public AnalyticsFlow(string EndingLanguage = null, string EntryReason = null, EntryTypeEnum? EntryType = null, string ExitReason = null, string FlowId = null, string FlowName = null, FlowTypeEnum? FlowType = null, string FlowVersion = null, bool? IssuedCallback = null, string RecognitionFailureReason = null, string StartingLanguage = null, string TransferTargetAddress = null, string TransferTargetName = null, string TransferType = null, List<AnalyticsFlowOutcome> Outcomes = null)
    {
        this.EndingLanguage = EndingLanguage;
        this.EntryReason = EntryReason;
        this.EntryType = EntryType;
        this.ExitReason = ExitReason;
        this.FlowId = FlowId;
        this.FlowName = FlowName;
        this.FlowType = FlowType;
        this.FlowVersion = FlowVersion;
        this.IssuedCallback = IssuedCallback;
        this.RecognitionFailureReason = RecognitionFailureReason;
        this.StartingLanguage = StartingLanguage;
        this.TransferTargetAddress = TransferTargetAddress;
        this.TransferTargetName = TransferTargetName;
        this.TransferType = TransferType;
        this.Outcomes = Outcomes;

    }



    /// <summary>
    /// Flow ending language, e.g. en-us
    /// </summary>
    /// <value>Flow ending language, e.g. en-us</value>
    [DataMember(Name = "endingLanguage", EmitDefaultValue = false)]
    public string EndingLanguage { get; set; }



    /// <summary>
    /// The particular entry reason for this flow, e.g. an address, userId, or flowId
    /// </summary>
    /// <value>The particular entry reason for this flow, e.g. an address, userId, or flowId</value>
    [DataMember(Name = "entryReason", EmitDefaultValue = false)]
    public string EntryReason { get; set; }





    /// <summary>
    /// The exit reason for this flow, e.g. DISCONNECT
    /// </summary>
    /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
    [DataMember(Name = "exitReason", EmitDefaultValue = false)]
    public string ExitReason { get; set; }



    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    [DataMember(Name = "flowId", EmitDefaultValue = false)]
    public string FlowId { get; set; }



    /// <summary>
    /// The name of this flow at the time of flow execution
    /// </summary>
    /// <value>The name of this flow at the time of flow execution</value>
    [DataMember(Name = "flowName", EmitDefaultValue = false)]
    public string FlowName { get; set; }





    /// <summary>
    /// The version of this flow
    /// </summary>
    /// <value>The version of this flow</value>
    [DataMember(Name = "flowVersion", EmitDefaultValue = false)]
    public string FlowVersion { get; set; }



    /// <summary>
    /// Flag indicating whether the flow issued a callback
    /// </summary>
    /// <value>Flag indicating whether the flow issued a callback</value>
    [DataMember(Name = "issuedCallback", EmitDefaultValue = false)]
    public bool? IssuedCallback { get; set; }



    /// <summary>
    /// The recognition failure reason causing to exit/disconnect
    /// </summary>
    /// <value>The recognition failure reason causing to exit/disconnect</value>
    [DataMember(Name = "recognitionFailureReason", EmitDefaultValue = false)]
    public string RecognitionFailureReason { get; set; }



    /// <summary>
    /// Flow starting language, e.g. en-us
    /// </summary>
    /// <value>Flow starting language, e.g. en-us</value>
    [DataMember(Name = "startingLanguage", EmitDefaultValue = false)]
    public string StartingLanguage { get; set; }



    /// <summary>
    /// The address of a flow transfer target, e.g. a phone number, an email address, or a queueId
    /// </summary>
    /// <value>The address of a flow transfer target, e.g. a phone number, an email address, or a queueId</value>
    [DataMember(Name = "transferTargetAddress", EmitDefaultValue = false)]
    public string TransferTargetAddress { get; set; }



    /// <summary>
    /// The name of a flow transfer target
    /// </summary>
    /// <value>The name of a flow transfer target</value>
    [DataMember(Name = "transferTargetName", EmitDefaultValue = false)]
    public string TransferTargetName { get; set; }



    /// <summary>
    /// The type of transfer for flows that ended with a transfer
    /// </summary>
    /// <value>The type of transfer for flows that ended with a transfer</value>
    [DataMember(Name = "transferType", EmitDefaultValue = false)]
    public string TransferType { get; set; }



    /// <summary>
    /// Flow outcomes
    /// </summary>
    /// <value>Flow outcomes</value>
    [DataMember(Name = "outcomes", EmitDefaultValue = false)]
    public List<AnalyticsFlowOutcome> Outcomes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AnalyticsFlow {\n");

        sb.Append("  EndingLanguage: ").Append(EndingLanguage).Append("\n");
        sb.Append("  EntryReason: ").Append(EntryReason).Append("\n");
        sb.Append("  EntryType: ").Append(EntryType).Append("\n");
        sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowName: ").Append(FlowName).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  IssuedCallback: ").Append(IssuedCallback).Append("\n");
        sb.Append("  RecognitionFailureReason: ").Append(RecognitionFailureReason).Append("\n");
        sb.Append("  StartingLanguage: ").Append(StartingLanguage).Append("\n");
        sb.Append("  TransferTargetAddress: ").Append(TransferTargetAddress).Append("\n");
        sb.Append("  TransferTargetName: ").Append(TransferTargetName).Append("\n");
        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
        sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
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
        return Equals(obj as AnalyticsFlow);
    }

    /// <summary>
    /// Returns true if AnalyticsFlow instances are equal
    /// </summary>
    /// <param name="other">Instance of AnalyticsFlow to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AnalyticsFlow other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EndingLanguage == other.EndingLanguage ||
                EndingLanguage != null &&
                EndingLanguage.Equals(other.EndingLanguage)
            ) &&
            (
                EntryReason == other.EntryReason ||
                EntryReason != null &&
                EntryReason.Equals(other.EntryReason)
            ) &&
            (
                EntryType == other.EntryType ||
                EntryType != null &&
                EntryType.Equals(other.EntryType)
            ) &&
            (
                ExitReason == other.ExitReason ||
                ExitReason != null &&
                ExitReason.Equals(other.ExitReason)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowName == other.FlowName ||
                FlowName != null &&
                FlowName.Equals(other.FlowName)
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
                IssuedCallback == other.IssuedCallback ||
                IssuedCallback != null &&
                IssuedCallback.Equals(other.IssuedCallback)
            ) &&
            (
                RecognitionFailureReason == other.RecognitionFailureReason ||
                RecognitionFailureReason != null &&
                RecognitionFailureReason.Equals(other.RecognitionFailureReason)
            ) &&
            (
                StartingLanguage == other.StartingLanguage ||
                StartingLanguage != null &&
                StartingLanguage.Equals(other.StartingLanguage)
            ) &&
            (
                TransferTargetAddress == other.TransferTargetAddress ||
                TransferTargetAddress != null &&
                TransferTargetAddress.Equals(other.TransferTargetAddress)
            ) &&
            (
                TransferTargetName == other.TransferTargetName ||
                TransferTargetName != null &&
                TransferTargetName.Equals(other.TransferTargetName)
            ) &&
            (
                TransferType == other.TransferType ||
                TransferType != null &&
                TransferType.Equals(other.TransferType)
            ) &&
            (
                Outcomes == other.Outcomes ||
                Outcomes != null &&
                Outcomes.SequenceEqual(other.Outcomes)
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
            if (EndingLanguage != null)
            {
                hash = hash * 59 + EndingLanguage.GetHashCode();
            }

            if (EntryReason != null)
            {
                hash = hash * 59 + EntryReason.GetHashCode();
            }

            if (EntryType != null)
            {
                hash = hash * 59 + EntryType.GetHashCode();
            }

            if (ExitReason != null)
            {
                hash = hash * 59 + ExitReason.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowName != null)
            {
                hash = hash * 59 + FlowName.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (IssuedCallback != null)
            {
                hash = hash * 59 + IssuedCallback.GetHashCode();
            }

            if (RecognitionFailureReason != null)
            {
                hash = hash * 59 + RecognitionFailureReason.GetHashCode();
            }

            if (StartingLanguage != null)
            {
                hash = hash * 59 + StartingLanguage.GetHashCode();
            }

            if (TransferTargetAddress != null)
            {
                hash = hash * 59 + TransferTargetAddress.GetHashCode();
            }

            if (TransferTargetName != null)
            {
                hash = hash * 59 + TransferTargetName.GetHashCode();
            }

            if (TransferType != null)
            {
                hash = hash * 59 + TransferType.GetHashCode();
            }

            if (Outcomes != null)
            {
                hash = hash * 59 + Outcomes.GetHashCode();
            }

            return hash;
        }
    }
}
