using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowMetricsTopicFlowMetricRecord
/// </summary>
[DataContract]
public partial class FlowMetricsTopicFlowMetricRecord : IEquatable<FlowMetricsTopicFlowMetricRecord>
{
    /// <summary>
    /// Metric name
    /// </summary>
    /// <value>Metric name</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MetricEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Nflow for "nFlow"
        /// </summary>
        [EnumMember(Value = "nFlow")]
        Nflow,

        /// <summary>
        /// Enum Nflowmilestone for "nFlowMilestone"
        /// </summary>
        [EnumMember(Value = "nFlowMilestone")]
        Nflowmilestone,

        /// <summary>
        /// Enum Nflowoutcome for "nFlowOutcome"
        /// </summary>
        [EnumMember(Value = "nFlowOutcome")]
        Nflowoutcome,

        /// <summary>
        /// Enum Nflowoutcomefailed for "nFlowOutcomeFailed"
        /// </summary>
        [EnumMember(Value = "nFlowOutcomeFailed")]
        Nflowoutcomefailed,

        /// <summary>
        /// Enum Oflowmilestone for "oFlowMilestone"
        /// </summary>
        [EnumMember(Value = "oFlowMilestone")]
        Oflowmilestone,

        /// <summary>
        /// Enum Tflow for "tFlow"
        /// </summary>
        [EnumMember(Value = "tFlow")]
        Tflow,

        /// <summary>
        /// Enum Tflowdisconnect for "tFlowDisconnect"
        /// </summary>
        [EnumMember(Value = "tFlowDisconnect")]
        Tflowdisconnect,

        /// <summary>
        /// Enum Tflowexit for "tFlowExit"
        /// </summary>
        [EnumMember(Value = "tFlowExit")]
        Tflowexit,

        /// <summary>
        /// Enum Tflowoutcome for "tFlowOutcome"
        /// </summary>
        [EnumMember(Value = "tFlowOutcome")]
        Tflowoutcome
    }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActiveRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ConversationInitiatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acd for "acd"
        /// </summary>
        [EnumMember(Value = "acd")]
        Acd,

        /// <summary>
        /// Enum Agent for "agent"
        /// </summary>
        [EnumMember(Value = "agent")]
        Agent,

        /// <summary>
        /// Enum Api for "api"
        /// </summary>
        [EnumMember(Value = "api")]
        Api,

        /// <summary>
        /// Enum Botflow for "botflow"
        /// </summary>
        [EnumMember(Value = "botflow")]
        Botflow,

        /// <summary>
        /// Enum Campaign for "campaign"
        /// </summary>
        [EnumMember(Value = "campaign")]
        Campaign,

        /// <summary>
        /// Enum Customer for "customer"
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// Enum Dialer for "dialer"
        /// </summary>
        [EnumMember(Value = "dialer")]
        Dialer,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// Enum Fax for "fax"
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,

        /// <summary>
        /// Enum Group for "group"
        /// </summary>
        [EnumMember(Value = "group")]
        Group,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Ivr for "ivr"
        /// </summary>
        [EnumMember(Value = "ivr")]
        Ivr,

        /// <summary>
        /// Enum Manual for "manual"
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound,

        /// <summary>
        /// Enum Station for "station"
        /// </summary>
        [EnumMember(Value = "station")]
        Station,

        /// <summary>
        /// Enum User for "user"
        /// </summary>
        [EnumMember(Value = "user")]
        User,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurveyflow for "voicesurveyflow"
        /// </summary>
        [EnumMember(Value = "voicesurveyflow")]
        Voicesurveyflow,

        /// <summary>
        /// Enum Workflow for "workflow"
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow
    }
    /// <summary>
    /// The email or SMS delivery status
    /// </summary>
    /// <value>The email or SMS delivery status</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DeliveryStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Deliveryfailed for "DeliveryFailed"
        /// </summary>
        [EnumMember(Value = "DeliveryFailed")]
        Deliveryfailed,

        /// <summary>
        /// Enum Deliverypushed for "DeliveryPushed"
        /// </summary>
        [EnumMember(Value = "DeliveryPushed")]
        Deliverypushed,

        /// <summary>
        /// Enum Deliverysuccess for "DeliverySuccess"
        /// </summary>
        [EnumMember(Value = "DeliverySuccess")]
        Deliverysuccess,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Published for "Published"
        /// </summary>
        [EnumMember(Value = "Published")]
        Published,

        /// <summary>
        /// Enum Queued for "Queued"
        /// </summary>
        [EnumMember(Value = "Queued")]
        Queued,

        /// <summary>
        /// Enum Read for "Read"
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,

        /// <summary>
        /// Enum Received for "Received"
        /// </summary>
        [EnumMember(Value = "Received")]
        Received,

        /// <summary>
        /// Enum Sent for "Sent"
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent
    }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisconnectTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Client for "client"
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// Enum Conferencetransfer for "conferenceTransfer"
        /// </summary>
        [EnumMember(Value = "conferenceTransfer")]
        Conferencetransfer,

        /// <summary>
        /// Enum Consulttransfer for "consultTransfer"
        /// </summary>
        [EnumMember(Value = "consultTransfer")]
        Consulttransfer,

        /// <summary>
        /// Enum Endpoint for "endpoint"
        /// </summary>
        [EnumMember(Value = "endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Endpointdnd for "endpointDnd"
        /// </summary>
        [EnumMember(Value = "endpointDnd")]
        Endpointdnd,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Forwardtransfer for "forwardTransfer"
        /// </summary>
        [EnumMember(Value = "forwardTransfer")]
        Forwardtransfer,

        /// <summary>
        /// Enum Noanswertransfer for "noAnswerTransfer"
        /// </summary>
        [EnumMember(Value = "noAnswerTransfer")]
        Noanswertransfer,

        /// <summary>
        /// Enum Notavailabletransfer for "notAvailableTransfer"
        /// </summary>
        [EnumMember(Value = "notAvailableTransfer")]
        Notavailabletransfer,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Spam for "spam"
        /// </summary>
        [EnumMember(Value = "spam")]
        Spam,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum Transferdnd for "transferDnd"
        /// </summary>
        [EnumMember(Value = "transferDnd")]
        Transferdnd,

        /// <summary>
        /// Enum Transportfailure for "transportFailure"
        /// </summary>
        [EnumMember(Value = "transportFailure")]
        Transportfailure,

        /// <summary>
        /// Enum Uncallable for "uncallable"
        /// </summary>
        [EnumMember(Value = "uncallable")]
        Uncallable
    }
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
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FlaggedReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum General for "general"
        /// </summary>
        [EnumMember(Value = "general")]
        General
    }
    /// <summary>
    /// Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.
    /// </summary>
    /// <value>Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum FlowSubTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum VirtualAgent for "VIRTUAL_AGENT"
        /// </summary>
        [EnumMember(Value = "VIRTUAL_AGENT")]
        VirtualAgent
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
        /// Enum Inqueueemail for "inqueueemail"
        /// </summary>
        [EnumMember(Value = "inqueueemail")]
        Inqueueemail,

        /// <summary>
        /// Enum Inqueueshortmessage for "inqueueshortmessage"
        /// </summary>
        [EnumMember(Value = "inqueueshortmessage")]
        Inqueueshortmessage,

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
        /// Enum Speech for "speech"
        /// </summary>
        [EnumMember(Value = "speech")]
        Speech,

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
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Chat for "chat"
        /// </summary>
        [EnumMember(Value = "chat")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "cobrowse"
        /// </summary>
        [EnumMember(Value = "cobrowse")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Internalmessage for "internalmessage"
        /// </summary>
        [EnumMember(Value = "internalmessage")]
        Internalmessage,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message,

        /// <summary>
        /// Enum Screenshare for "screenshare"
        /// </summary>
        [EnumMember(Value = "screenshare")]
        Screenshare,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Video for "video"
        /// </summary>
        [EnumMember(Value = "video")]
        Video,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice
    }
    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OriginatingDirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound
    }
    /// <summary>
    /// The participant's purpose
    /// </summary>
    /// <value>The participant's purpose</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PurposeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acd for "acd"
        /// </summary>
        [EnumMember(Value = "acd")]
        Acd,

        /// <summary>
        /// Enum Agent for "agent"
        /// </summary>
        [EnumMember(Value = "agent")]
        Agent,

        /// <summary>
        /// Enum Api for "api"
        /// </summary>
        [EnumMember(Value = "api")]
        Api,

        /// <summary>
        /// Enum Botflow for "botflow"
        /// </summary>
        [EnumMember(Value = "botflow")]
        Botflow,

        /// <summary>
        /// Enum Campaign for "campaign"
        /// </summary>
        [EnumMember(Value = "campaign")]
        Campaign,

        /// <summary>
        /// Enum Customer for "customer"
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// Enum Dialer for "dialer"
        /// </summary>
        [EnumMember(Value = "dialer")]
        Dialer,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// Enum Fax for "fax"
        /// </summary>
        [EnumMember(Value = "fax")]
        Fax,

        /// <summary>
        /// Enum Group for "group"
        /// </summary>
        [EnumMember(Value = "group")]
        Group,

        /// <summary>
        /// Enum Inbound for "inbound"
        /// </summary>
        [EnumMember(Value = "inbound")]
        Inbound,

        /// <summary>
        /// Enum Ivr for "ivr"
        /// </summary>
        [EnumMember(Value = "ivr")]
        Ivr,

        /// <summary>
        /// Enum Manual for "manual"
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// Enum Outbound for "outbound"
        /// </summary>
        [EnumMember(Value = "outbound")]
        Outbound,

        /// <summary>
        /// Enum Station for "station"
        /// </summary>
        [EnumMember(Value = "station")]
        Station,

        /// <summary>
        /// Enum User for "user"
        /// </summary>
        [EnumMember(Value = "user")]
        User,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Voicesurveyflow for "voicesurveyflow"
        /// </summary>
        [EnumMember(Value = "voicesurveyflow")]
        Voicesurveyflow,

        /// <summary>
        /// Enum Workflow for "workflow"
        /// </summary>
        [EnumMember(Value = "workflow")]
        Workflow
    }
    /// <summary>
    /// Gets or Sets RequestedRoutings
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RequestedRoutingsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Routing rule type
    /// </summary>
    /// <value>Routing rule type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RoutingRuleTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred
    }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UsedRoutingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Bullseye for "Bullseye"
        /// </summary>
        [EnumMember(Value = "Bullseye")]
        Bullseye,

        /// <summary>
        /// Enum Conditional for "Conditional"
        /// </summary>
        [EnumMember(Value = "Conditional")]
        Conditional,

        /// <summary>
        /// Enum Direct for "Direct"
        /// </summary>
        [EnumMember(Value = "Direct")]
        Direct,

        /// <summary>
        /// Enum Last for "Last"
        /// </summary>
        [EnumMember(Value = "Last")]
        Last,

        /// <summary>
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual,

        /// <summary>
        /// Enum Predictive for "Predictive"
        /// </summary>
        [EnumMember(Value = "Predictive")]
        Predictive,

        /// <summary>
        /// Enum Preferred for "Preferred"
        /// </summary>
        [EnumMember(Value = "Preferred")]
        Preferred,

        /// <summary>
        /// Enum Standard for "Standard"
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard,

        /// <summary>
        /// Enum Vip for "Vip"
        /// </summary>
        [EnumMember(Value = "Vip")]
        Vip
    }
    /// <summary>
    /// Metric name
    /// </summary>
    /// <value>Metric name</value>
    [DataMember(Name = "metric", EmitDefaultValue = false)]
    public MetricEnum? Metric { get; set; }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    [DataMember(Name = "activeRouting", EmitDefaultValue = false)]
    public ActiveRoutingEnum? ActiveRouting { get; set; }
    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    [DataMember(Name = "conversationInitiator", EmitDefaultValue = false)]
    public ConversationInitiatorEnum? ConversationInitiator { get; set; }
    /// <summary>
    /// The email or SMS delivery status
    /// </summary>
    /// <value>The email or SMS delivery status</value>
    [DataMember(Name = "deliveryStatus", EmitDefaultValue = false)]
    public DeliveryStatusEnum? DeliveryStatus { get; set; }
    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct
    /// </summary>
    /// <value>The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct</value>
    [DataMember(Name = "entryType", EmitDefaultValue = false)]
    public EntryTypeEnum? EntryType { get; set; }
    /// <summary>
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>
    [DataMember(Name = "flaggedReason", EmitDefaultValue = false)]
    public FlaggedReasonEnum? FlaggedReason { get; set; }
    /// <summary>
    /// Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.
    /// </summary>
    /// <value>Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities.</value>
    [DataMember(Name = "flowSubType", EmitDefaultValue = false)]
    public FlowSubTypeEnum? FlowSubType { get; set; }
    /// <summary>
    /// The type of this flow
    /// </summary>
    /// <value>The type of this flow</value>
    [DataMember(Name = "flowType", EmitDefaultValue = false)]
    public FlowTypeEnum? FlowType { get; set; }
    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    [DataMember(Name = "originatingDirection", EmitDefaultValue = false)]
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }
    /// <summary>
    /// The participant's purpose
    /// </summary>
    /// <value>The participant's purpose</value>
    [DataMember(Name = "purpose", EmitDefaultValue = false)]
    public PurposeEnum? Purpose { get; set; }
    /// <summary>
    /// Routing rule type
    /// </summary>
    /// <value>Routing rule type</value>
    [DataMember(Name = "routingRuleType", EmitDefaultValue = false)]
    public RoutingRuleTypeEnum? RoutingRuleType { get; set; }
    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    [DataMember(Name = "usedRouting", EmitDefaultValue = false)]
    public UsedRoutingEnum? UsedRouting { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowMetricsTopicFlowMetricRecord" /> class.
    /// </summary>
    /// <param name="Metric">Metric name.</param>
    /// <param name="MetricDate">The date and time of metric creation.</param>
    /// <param name="Value">Metric value.</param>
    /// <param name="RecordId">Record identifier.</param>
    /// <param name="ActiveRouting">Active routing method.</param>
    /// <param name="ActiveSkillIds">ID(s) of Skill(s) that are active on the conversation.</param>
    /// <param name="AddressFrom">The address that initiated an action.</param>
    /// <param name="AddressTo">The address receiving an action.</param>
    /// <param name="AgentAssistantId">Unique identifier of the active virtual agent assistant.</param>
    /// <param name="AgentBullseyeRing">Bullseye ring of the targeted agent.</param>
    /// <param name="AgentOwned">Flag indicating an agent-owned callback.</param>
    /// <param name="Ani">Automatic Number Identification (caller&#39;s number).</param>
    /// <param name="AssignerId">ID of the user that manually assigned a conversation.</param>
    /// <param name="Authenticated">Flag that indicates that the identity of the customer has been asserted as verified by the provider..</param>
    /// <param name="ConversationId">Unique identifier for the conversation.</param>
    /// <param name="ConversationInitiator">Indicates the participant purpose of the participant initiating a message conversation.</param>
    /// <param name="ConvertedFrom">Session media type that was converted from in case of a media type conversion.</param>
    /// <param name="ConvertedTo">Session media type that was converted to in case of a media type conversion.</param>
    /// <param name="CustomerParticipation">Indicates a messaging conversation in which the customer participated by sending at least one message.</param>
    /// <param name="DeliveryStatus">The email or SMS delivery status.</param>
    /// <param name="DestinationAddresses">Destination address(es) of transfers or consults.</param>
    /// <param name="Direction">The direction of the communication.</param>
    /// <param name="DisconnectType">The session disconnect type.</param>
    /// <param name="DivisionIds">Identifier(s) of division(s) associated with a conversation.</param>
    /// <param name="Dnis">Dialed number identification service (number dialed by the calling party).</param>
    /// <param name="EdgeId">Unique identifier of the edge device.</param>
    /// <param name="EligibleAgentCounts">Number of eligible agents for each predictive routing attempt.</param>
    /// <param name="EndingLanguage">Flow ending language, e.g. en-us.</param>
    /// <param name="EntryReason">The particular entry reason for this flow, e.g. an address, userId, or flowId.</param>
    /// <param name="EntryType">The entry type for this flow, e.g. dnis, dialer, agent, flow, or direct.</param>
    /// <param name="ErrorCode">A code corresponding to the error that occurred.</param>
    /// <param name="ExitReason">The exit reason for this flow, e.g. DISCONNECT.</param>
    /// <param name="ExtendedDeliveryStatus">Extended delivery status.</param>
    /// <param name="ExternalContactId">External contact identifier.</param>
    /// <param name="ExternalMediaCount">Count of any media (images, files, etc) included on the external session.</param>
    /// <param name="ExternalOrganizationId">External organization identifier.</param>
    /// <param name="ExternalTag">External tag for the conversation.</param>
    /// <param name="FirstQueue">Marker that is set if the current queue is the first queue in a conversation.</param>
    /// <param name="FlaggedReason">Reason for which participant flagged conversation.</param>
    /// <param name="FlowId">The unique identifier of this flow.</param>
    /// <param name="FlowInType">Type of flow in that occurred when entering ACD..</param>
    /// <param name="FlowMilestoneIds">The ID of a flow outcome milestone.</param>
    /// <param name="FlowName">The name of this flow at the time of flow execution.</param>
    /// <param name="FlowOutType">Type of flow out that occurred when emitting tFlowOut..</param>
    /// <param name="FlowSubType">Represents the subtype of the flow. For example a Digital Bot Flow that has been upgraded with Virtual Agent capabilities..</param>
    /// <param name="FlowType">The type of this flow.</param>
    /// <param name="FlowVersion">The version of this flow.</param>
    /// <param name="GroupId">Unique identifier for a Genesys Cloud group.</param>
    /// <param name="InteractionType">The interaction type (enterprise or contactCenter).</param>
    /// <param name="JourneyActionId">Identifier of the journey action..</param>
    /// <param name="JourneyActionMapId">Identifier of the journey action map that triggered the action..</param>
    /// <param name="JourneyActionMapVersion">Version of the journey action map that triggered the action..</param>
    /// <param name="JourneyCustomerId">Primary identifier of the journey customer in the source where the activities originate from..</param>
    /// <param name="JourneyCustomerIdType">Type of primary identifier of the journey customer (e.g. cookie)..</param>
    /// <param name="JourneyCustomerSessionId">Unique identifier of the journey session..</param>
    /// <param name="JourneyCustomerSessionIdType">Type or category of journey sessions (e.g. web, ticket, delivery, atm)..</param>
    /// <param name="KnowledgeBaseId">The unique identifier of the knowledge base used.</param>
    /// <param name="MediaCount">Count of any media (images, files, etc) included in this session.</param>
    /// <param name="MediaType">The session media type.</param>
    /// <param name="MessageType">Message type for messaging services. E.g.: sms, facebook, twitter, line.</param>
    /// <param name="OriginatingDirection">The original direction of the conversation.</param>
    /// <param name="OutboundCampaignId">(Dialer) Unique identifier of the outbound campaign.</param>
    /// <param name="OutboundContactId">(Dialer) Unique identifier of the contact.</param>
    /// <param name="OutboundContactListId">(Dialer) Unique identifier of the contact list that this contact belongs to.</param>
    /// <param name="ParticipantName">A human readable name identifying the participant.</param>
    /// <param name="PeerId">This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session..</param>
    /// <param name="Provider">The source provider for the communication..</param>
    /// <param name="Purpose">The participant&#39;s purpose.</param>
    /// <param name="QueueId">Queue identifier.</param>
    /// <param name="RecognitionFailureReason">The recognition failure reason causing to exit/disconnect.</param>
    /// <param name="Remote">Name, phone number, or email address of the remote party..</param>
    /// <param name="RemovedSkillIds">ID(s) of Skill(s) that have been removed by bullseye routing.</param>
    /// <param name="RequestedLanguageId">Unique identifier for the language requested for an interaction.</param>
    /// <param name="RequestedRoutingSkillIds">Unique identifier(s) for skill(s) requested for an interaction.</param>
    /// <param name="RequestedRoutings">Routing type(s) for requested/attempted routing methods..</param>
    /// <param name="RoomId">Unique identifier for the room.</param>
    /// <param name="RoutingPriority">Routing priority for the current interaction.</param>
    /// <param name="RoutingRing">Routing ring for bullseye or preferred agent routing.</param>
    /// <param name="RoutingRule">Routing rule for preferred, conditional and predictive routing type.</param>
    /// <param name="RoutingRuleType">Routing rule type.</param>
    /// <param name="SelectedAgentId">Selected agent ID.</param>
    /// <param name="SelectedAgentRank">Selected agent GPR rank.</param>
    /// <param name="SelfServed">Indicates whether the flow session was self serviced.</param>
    /// <param name="SessionDnis">Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred.</param>
    /// <param name="SessionId">The unique identifier of this session.</param>
    /// <param name="StartingLanguage">Flow starting language, e.g. en-us.</param>
    /// <param name="StationId">Unique identifier for a phone.</param>
    /// <param name="TeamId">The team ID the user is a member of.</param>
    /// <param name="TransferTargetAddress">The address of a flow transfer target, e.g. a phone number, an email address, or a queueId.</param>
    /// <param name="TransferTargetName">The name of a flow transfer target.</param>
    /// <param name="TransferType">The type of transfer for flows that ended with a transfer.</param>
    /// <param name="UsedRouting">Complete routing method.</param>
    /// <param name="UserId">Unique identifier for the user.</param>
    /// <param name="VideoPresent">Flag indicating if video is present.</param>
    /// <param name="WaitingInteractionCounts">Number of waiting interactions for each predictive routing attempt.</param>
    /// <param name="WrapUpCode">Wrap up code.</param>
    /// <param name="ProposedAgents">Proposed agents.</param>
    /// <param name="Outcomes">Flow outcomes.</param>
    /// <param name="ScoredAgents">Scored agents.</param>
    public FlowMetricsTopicFlowMetricRecord(MetricEnum? Metric = null, DateTime? MetricDate = null, long? Value = null, string RecordId = null, ActiveRoutingEnum? ActiveRouting = null, List<string> ActiveSkillIds = null, string AddressFrom = null, string AddressTo = null, string AgentAssistantId = null, long? AgentBullseyeRing = null, bool? AgentOwned = null, string Ani = null, string AssignerId = null, bool? Authenticated = null, string ConversationId = null, ConversationInitiatorEnum? ConversationInitiator = null, string ConvertedFrom = null, string ConvertedTo = null, bool? CustomerParticipation = null, DeliveryStatusEnum? DeliveryStatus = null, List<string> DestinationAddresses = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, List<string> DivisionIds = null, string Dnis = null, string EdgeId = null, List<long?> EligibleAgentCounts = null, string EndingLanguage = null, string EntryReason = null, EntryTypeEnum? EntryType = null, string ErrorCode = null, string ExitReason = null, string ExtendedDeliveryStatus = null, string ExternalContactId = null, long? ExternalMediaCount = null, string ExternalOrganizationId = null, string ExternalTag = null, bool? FirstQueue = null, FlaggedReasonEnum? FlaggedReason = null, string FlowId = null, string FlowInType = null, List<string> FlowMilestoneIds = null, string FlowName = null, string FlowOutType = null, FlowSubTypeEnum? FlowSubType = null, FlowTypeEnum? FlowType = null, string FlowVersion = null, string GroupId = null, string InteractionType = null, string JourneyActionId = null, string JourneyActionMapId = null, long? JourneyActionMapVersion = null, string JourneyCustomerId = null, string JourneyCustomerIdType = null, string JourneyCustomerSessionId = null, string JourneyCustomerSessionIdType = null, string KnowledgeBaseId = null, long? MediaCount = null, MediaTypeEnum? MediaType = null, string MessageType = null, OriginatingDirectionEnum? OriginatingDirection = null, string OutboundCampaignId = null, string OutboundContactId = null, string OutboundContactListId = null, string ParticipantName = null, string PeerId = null, string Provider = null, PurposeEnum? Purpose = null, string QueueId = null, string RecognitionFailureReason = null, string Remote = null, List<string> RemovedSkillIds = null, string RequestedLanguageId = null, List<string> RequestedRoutingSkillIds = null, List<RequestedRoutingsEnum> RequestedRoutings = null, string RoomId = null, long? RoutingPriority = null, long? RoutingRing = null, string RoutingRule = null, RoutingRuleTypeEnum? RoutingRuleType = null, string SelectedAgentId = null, long? SelectedAgentRank = null, bool? SelfServed = null, string SessionDnis = null, string SessionId = null, string StartingLanguage = null, string StationId = null, string TeamId = null, string TransferTargetAddress = null, string TransferTargetName = null, string TransferType = null, UsedRoutingEnum? UsedRouting = null, string UserId = null, bool? VideoPresent = null, List<long?> WaitingInteractionCounts = null, string WrapUpCode = null, List<FlowMetricsTopicFlowProposedAgent> ProposedAgents = null, List<FlowMetricsTopicFlowOutcome> Outcomes = null, List<FlowMetricsTopicFlowScoredAgent> ScoredAgents = null)
    {
        this.Metric = Metric;
        this.MetricDate = MetricDate;
        this.Value = Value;
        this.RecordId = RecordId;
        this.ActiveRouting = ActiveRouting;
        this.ActiveSkillIds = ActiveSkillIds;
        this.AddressFrom = AddressFrom;
        this.AddressTo = AddressTo;
        this.AgentAssistantId = AgentAssistantId;
        this.AgentBullseyeRing = AgentBullseyeRing;
        this.AgentOwned = AgentOwned;
        this.Ani = Ani;
        this.AssignerId = AssignerId;
        this.Authenticated = Authenticated;
        this.ConversationId = ConversationId;
        this.ConversationInitiator = ConversationInitiator;
        this.ConvertedFrom = ConvertedFrom;
        this.ConvertedTo = ConvertedTo;
        this.CustomerParticipation = CustomerParticipation;
        this.DeliveryStatus = DeliveryStatus;
        this.DestinationAddresses = DestinationAddresses;
        this.Direction = Direction;
        this.DisconnectType = DisconnectType;
        this.DivisionIds = DivisionIds;
        this.Dnis = Dnis;
        this.EdgeId = EdgeId;
        this.EligibleAgentCounts = EligibleAgentCounts;
        this.EndingLanguage = EndingLanguage;
        this.EntryReason = EntryReason;
        this.EntryType = EntryType;
        this.ErrorCode = ErrorCode;
        this.ExitReason = ExitReason;
        this.ExtendedDeliveryStatus = ExtendedDeliveryStatus;
        this.ExternalContactId = ExternalContactId;
        this.ExternalMediaCount = ExternalMediaCount;
        this.ExternalOrganizationId = ExternalOrganizationId;
        this.ExternalTag = ExternalTag;
        this.FirstQueue = FirstQueue;
        this.FlaggedReason = FlaggedReason;
        this.FlowId = FlowId;
        this.FlowInType = FlowInType;
        this.FlowMilestoneIds = FlowMilestoneIds;
        this.FlowName = FlowName;
        this.FlowOutType = FlowOutType;
        this.FlowSubType = FlowSubType;
        this.FlowType = FlowType;
        this.FlowVersion = FlowVersion;
        this.GroupId = GroupId;
        this.InteractionType = InteractionType;
        this.JourneyActionId = JourneyActionId;
        this.JourneyActionMapId = JourneyActionMapId;
        this.JourneyActionMapVersion = JourneyActionMapVersion;
        this.JourneyCustomerId = JourneyCustomerId;
        this.JourneyCustomerIdType = JourneyCustomerIdType;
        this.JourneyCustomerSessionId = JourneyCustomerSessionId;
        this.JourneyCustomerSessionIdType = JourneyCustomerSessionIdType;
        this.KnowledgeBaseId = KnowledgeBaseId;
        this.MediaCount = MediaCount;
        this.MediaType = MediaType;
        this.MessageType = MessageType;
        this.OriginatingDirection = OriginatingDirection;
        this.OutboundCampaignId = OutboundCampaignId;
        this.OutboundContactId = OutboundContactId;
        this.OutboundContactListId = OutboundContactListId;
        this.ParticipantName = ParticipantName;
        this.PeerId = PeerId;
        this.Provider = Provider;
        this.Purpose = Purpose;
        this.QueueId = QueueId;
        this.RecognitionFailureReason = RecognitionFailureReason;
        this.Remote = Remote;
        this.RemovedSkillIds = RemovedSkillIds;
        this.RequestedLanguageId = RequestedLanguageId;
        this.RequestedRoutingSkillIds = RequestedRoutingSkillIds;
        this.RequestedRoutings = RequestedRoutings;
        this.RoomId = RoomId;
        this.RoutingPriority = RoutingPriority;
        this.RoutingRing = RoutingRing;
        this.RoutingRule = RoutingRule;
        this.RoutingRuleType = RoutingRuleType;
        this.SelectedAgentId = SelectedAgentId;
        this.SelectedAgentRank = SelectedAgentRank;
        this.SelfServed = SelfServed;
        this.SessionDnis = SessionDnis;
        this.SessionId = SessionId;
        this.StartingLanguage = StartingLanguage;
        this.StationId = StationId;
        this.TeamId = TeamId;
        this.TransferTargetAddress = TransferTargetAddress;
        this.TransferTargetName = TransferTargetName;
        this.TransferType = TransferType;
        this.UsedRouting = UsedRouting;
        this.UserId = UserId;
        this.VideoPresent = VideoPresent;
        this.WaitingInteractionCounts = WaitingInteractionCounts;
        this.WrapUpCode = WrapUpCode;
        this.ProposedAgents = ProposedAgents;
        this.Outcomes = Outcomes;
        this.ScoredAgents = ScoredAgents;

    }





    /// <summary>
    /// The date and time of metric creation
    /// </summary>
    /// <value>The date and time of metric creation</value>
    [DataMember(Name = "metricDate", EmitDefaultValue = false)]
    public DateTime? MetricDate { get; set; }



    /// <summary>
    /// Metric value
    /// </summary>
    /// <value>Metric value</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public long? Value { get; set; }



    /// <summary>
    /// Record identifier
    /// </summary>
    /// <value>Record identifier</value>
    [DataMember(Name = "recordId", EmitDefaultValue = false)]
    public string RecordId { get; set; }





    /// <summary>
    /// ID(s) of Skill(s) that are active on the conversation
    /// </summary>
    /// <value>ID(s) of Skill(s) that are active on the conversation</value>
    [DataMember(Name = "activeSkillIds", EmitDefaultValue = false)]
    public List<string> ActiveSkillIds { get; set; }



    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    [DataMember(Name = "addressFrom", EmitDefaultValue = false)]
    public string AddressFrom { get; set; }



    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    [DataMember(Name = "addressTo", EmitDefaultValue = false)]
    public string AddressTo { get; set; }



    /// <summary>
    /// Unique identifier of the active virtual agent assistant
    /// </summary>
    /// <value>Unique identifier of the active virtual agent assistant</value>
    [DataMember(Name = "agentAssistantId", EmitDefaultValue = false)]
    public string AgentAssistantId { get; set; }



    /// <summary>
    /// Bullseye ring of the targeted agent
    /// </summary>
    /// <value>Bullseye ring of the targeted agent</value>
    [DataMember(Name = "agentBullseyeRing", EmitDefaultValue = false)]
    public long? AgentBullseyeRing { get; set; }



    /// <summary>
    /// Flag indicating an agent-owned callback
    /// </summary>
    /// <value>Flag indicating an agent-owned callback</value>
    [DataMember(Name = "agentOwned", EmitDefaultValue = false)]
    public bool? AgentOwned { get; set; }



    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    [DataMember(Name = "ani", EmitDefaultValue = false)]
    public string Ani { get; set; }



    /// <summary>
    /// ID of the user that manually assigned a conversation
    /// </summary>
    /// <value>ID of the user that manually assigned a conversation</value>
    [DataMember(Name = "assignerId", EmitDefaultValue = false)]
    public string AssignerId { get; set; }



    /// <summary>
    /// Flag that indicates that the identity of the customer has been asserted as verified by the provider.
    /// </summary>
    /// <value>Flag that indicates that the identity of the customer has been asserted as verified by the provider.</value>
    [DataMember(Name = "authenticated", EmitDefaultValue = false)]
    public bool? Authenticated { get; set; }



    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }





    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    [DataMember(Name = "convertedFrom", EmitDefaultValue = false)]
    public string ConvertedFrom { get; set; }



    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    [DataMember(Name = "convertedTo", EmitDefaultValue = false)]
    public string ConvertedTo { get; set; }



    /// <summary>
    /// Indicates a messaging conversation in which the customer participated by sending at least one message
    /// </summary>
    /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
    [DataMember(Name = "customerParticipation", EmitDefaultValue = false)]
    public bool? CustomerParticipation { get; set; }





    /// <summary>
    /// Destination address(es) of transfers or consults
    /// </summary>
    /// <value>Destination address(es) of transfers or consults</value>
    [DataMember(Name = "destinationAddresses", EmitDefaultValue = false)]
    public List<string> DestinationAddresses { get; set; }







    /// <summary>
    /// Identifier(s) of division(s) associated with a conversation
    /// </summary>
    /// <value>Identifier(s) of division(s) associated with a conversation</value>
    [DataMember(Name = "divisionIds", EmitDefaultValue = false)]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    [DataMember(Name = "dnis", EmitDefaultValue = false)]
    public string Dnis { get; set; }



    /// <summary>
    /// Unique identifier of the edge device
    /// </summary>
    /// <value>Unique identifier of the edge device</value>
    [DataMember(Name = "edgeId", EmitDefaultValue = false)]
    public string EdgeId { get; set; }



    /// <summary>
    /// Number of eligible agents for each predictive routing attempt
    /// </summary>
    /// <value>Number of eligible agents for each predictive routing attempt</value>
    [DataMember(Name = "eligibleAgentCounts", EmitDefaultValue = false)]
    public List<long?> EligibleAgentCounts { get; set; }



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
    /// A code corresponding to the error that occurred
    /// </summary>
    /// <value>A code corresponding to the error that occurred</value>
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }



    /// <summary>
    /// The exit reason for this flow, e.g. DISCONNECT
    /// </summary>
    /// <value>The exit reason for this flow, e.g. DISCONNECT</value>
    [DataMember(Name = "exitReason", EmitDefaultValue = false)]
    public string ExitReason { get; set; }



    /// <summary>
    /// Extended delivery status
    /// </summary>
    /// <value>Extended delivery status</value>
    [DataMember(Name = "extendedDeliveryStatus", EmitDefaultValue = false)]
    public string ExtendedDeliveryStatus { get; set; }



    /// <summary>
    /// External contact identifier
    /// </summary>
    /// <value>External contact identifier</value>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Count of any media (images, files, etc) included on the external session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included on the external session</value>
    [DataMember(Name = "externalMediaCount", EmitDefaultValue = false)]
    public long? ExternalMediaCount { get; set; }



    /// <summary>
    /// External organization identifier
    /// </summary>
    /// <value>External organization identifier</value>
    [DataMember(Name = "externalOrganizationId", EmitDefaultValue = false)]
    public string ExternalOrganizationId { get; set; }



    /// <summary>
    /// External tag for the conversation
    /// </summary>
    /// <value>External tag for the conversation</value>
    [DataMember(Name = "externalTag", EmitDefaultValue = false)]
    public string ExternalTag { get; set; }



    /// <summary>
    /// Marker that is set if the current queue is the first queue in a conversation
    /// </summary>
    /// <value>Marker that is set if the current queue is the first queue in a conversation</value>
    [DataMember(Name = "firstQueue", EmitDefaultValue = false)]
    public bool? FirstQueue { get; set; }





    /// <summary>
    /// The unique identifier of this flow
    /// </summary>
    /// <value>The unique identifier of this flow</value>
    [DataMember(Name = "flowId", EmitDefaultValue = false)]
    public string FlowId { get; set; }



    /// <summary>
    /// Type of flow in that occurred when entering ACD.
    /// </summary>
    /// <value>Type of flow in that occurred when entering ACD.</value>
    [DataMember(Name = "flowInType", EmitDefaultValue = false)]
    public string FlowInType { get; set; }



    /// <summary>
    /// The ID of a flow outcome milestone
    /// </summary>
    /// <value>The ID of a flow outcome milestone</value>
    [DataMember(Name = "flowMilestoneIds", EmitDefaultValue = false)]
    public List<string> FlowMilestoneIds { get; set; }



    /// <summary>
    /// The name of this flow at the time of flow execution
    /// </summary>
    /// <value>The name of this flow at the time of flow execution</value>
    [DataMember(Name = "flowName", EmitDefaultValue = false)]
    public string FlowName { get; set; }



    /// <summary>
    /// Type of flow out that occurred when emitting tFlowOut.
    /// </summary>
    /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
    [DataMember(Name = "flowOutType", EmitDefaultValue = false)]
    public string FlowOutType { get; set; }







    /// <summary>
    /// The version of this flow
    /// </summary>
    /// <value>The version of this flow</value>
    [DataMember(Name = "flowVersion", EmitDefaultValue = false)]
    public string FlowVersion { get; set; }



    /// <summary>
    /// Unique identifier for a Genesys Cloud group
    /// </summary>
    /// <value>Unique identifier for a Genesys Cloud group</value>
    [DataMember(Name = "groupId", EmitDefaultValue = false)]
    public string GroupId { get; set; }



    /// <summary>
    /// The interaction type (enterprise or contactCenter)
    /// </summary>
    /// <value>The interaction type (enterprise or contactCenter)</value>
    [DataMember(Name = "interactionType", EmitDefaultValue = false)]
    public string InteractionType { get; set; }



    /// <summary>
    /// Identifier of the journey action.
    /// </summary>
    /// <value>Identifier of the journey action.</value>
    [DataMember(Name = "journeyActionId", EmitDefaultValue = false)]
    public string JourneyActionId { get; set; }



    /// <summary>
    /// Identifier of the journey action map that triggered the action.
    /// </summary>
    /// <value>Identifier of the journey action map that triggered the action.</value>
    [DataMember(Name = "journeyActionMapId", EmitDefaultValue = false)]
    public string JourneyActionMapId { get; set; }



    /// <summary>
    /// Version of the journey action map that triggered the action.
    /// </summary>
    /// <value>Version of the journey action map that triggered the action.</value>
    [DataMember(Name = "journeyActionMapVersion", EmitDefaultValue = false)]
    public long? JourneyActionMapVersion { get; set; }



    /// <summary>
    /// Primary identifier of the journey customer in the source where the activities originate from.
    /// </summary>
    /// <value>Primary identifier of the journey customer in the source where the activities originate from.</value>
    [DataMember(Name = "journeyCustomerId", EmitDefaultValue = false)]
    public string JourneyCustomerId { get; set; }



    /// <summary>
    /// Type of primary identifier of the journey customer (e.g. cookie).
    /// </summary>
    /// <value>Type of primary identifier of the journey customer (e.g. cookie).</value>
    [DataMember(Name = "journeyCustomerIdType", EmitDefaultValue = false)]
    public string JourneyCustomerIdType { get; set; }



    /// <summary>
    /// Unique identifier of the journey session.
    /// </summary>
    /// <value>Unique identifier of the journey session.</value>
    [DataMember(Name = "journeyCustomerSessionId", EmitDefaultValue = false)]
    public string JourneyCustomerSessionId { get; set; }



    /// <summary>
    /// Type or category of journey sessions (e.g. web, ticket, delivery, atm).
    /// </summary>
    /// <value>Type or category of journey sessions (e.g. web, ticket, delivery, atm).</value>
    [DataMember(Name = "journeyCustomerSessionIdType", EmitDefaultValue = false)]
    public string JourneyCustomerSessionIdType { get; set; }



    /// <summary>
    /// The unique identifier of the knowledge base used
    /// </summary>
    /// <value>The unique identifier of the knowledge base used</value>
    [DataMember(Name = "knowledgeBaseId", EmitDefaultValue = false)]
    public string KnowledgeBaseId { get; set; }



    /// <summary>
    /// Count of any media (images, files, etc) included in this session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included in this session</value>
    [DataMember(Name = "mediaCount", EmitDefaultValue = false)]
    public long? MediaCount { get; set; }





    /// <summary>
    /// Message type for messaging services. E.g.: sms, facebook, twitter, line
    /// </summary>
    /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
    [DataMember(Name = "messageType", EmitDefaultValue = false)]
    public string MessageType { get; set; }





    /// <summary>
    /// (Dialer) Unique identifier of the outbound campaign
    /// </summary>
    /// <value>(Dialer) Unique identifier of the outbound campaign</value>
    [DataMember(Name = "outboundCampaignId", EmitDefaultValue = false)]
    public string OutboundCampaignId { get; set; }



    /// <summary>
    /// (Dialer) Unique identifier of the contact
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact</value>
    [DataMember(Name = "outboundContactId", EmitDefaultValue = false)]
    public string OutboundContactId { get; set; }



    /// <summary>
    /// (Dialer) Unique identifier of the contact list that this contact belongs to
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
    [DataMember(Name = "outboundContactListId", EmitDefaultValue = false)]
    public string OutboundContactListId { get; set; }



    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    [DataMember(Name = "participantName", EmitDefaultValue = false)]
    public string ParticipantName { get; set; }



    /// <summary>
    /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
    /// </summary>
    /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
    [DataMember(Name = "peerId", EmitDefaultValue = false)]
    public string PeerId { get; set; }



    /// <summary>
    /// The source provider for the communication.
    /// </summary>
    /// <value>The source provider for the communication.</value>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }





    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    [DataMember(Name = "queueId", EmitDefaultValue = false)]
    public string QueueId { get; set; }



    /// <summary>
    /// The recognition failure reason causing to exit/disconnect
    /// </summary>
    /// <value>The recognition failure reason causing to exit/disconnect</value>
    [DataMember(Name = "recognitionFailureReason", EmitDefaultValue = false)]
    public string RecognitionFailureReason { get; set; }



    /// <summary>
    /// Name, phone number, or email address of the remote party.
    /// </summary>
    /// <value>Name, phone number, or email address of the remote party.</value>
    [DataMember(Name = "remote", EmitDefaultValue = false)]
    public string Remote { get; set; }



    /// <summary>
    /// ID(s) of Skill(s) that have been removed by bullseye routing
    /// </summary>
    /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
    [DataMember(Name = "removedSkillIds", EmitDefaultValue = false)]
    public List<string> RemovedSkillIds { get; set; }



    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    [DataMember(Name = "requestedLanguageId", EmitDefaultValue = false)]
    public string RequestedLanguageId { get; set; }



    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    [DataMember(Name = "requestedRoutingSkillIds", EmitDefaultValue = false)]
    public List<string> RequestedRoutingSkillIds { get; set; }



    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    [DataMember(Name = "requestedRoutings", EmitDefaultValue = false)]
    public List<RequestedRoutingsEnum> RequestedRoutings { get; set; }



    /// <summary>
    /// Unique identifier for the room
    /// </summary>
    /// <value>Unique identifier for the room</value>
    [DataMember(Name = "roomId", EmitDefaultValue = false)]
    public string RoomId { get; set; }



    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    [DataMember(Name = "routingPriority", EmitDefaultValue = false)]
    public long? RoutingPriority { get; set; }



    /// <summary>
    /// Routing ring for bullseye or preferred agent routing
    /// </summary>
    /// <value>Routing ring for bullseye or preferred agent routing</value>
    [DataMember(Name = "routingRing", EmitDefaultValue = false)]
    public long? RoutingRing { get; set; }



    /// <summary>
    /// Routing rule for preferred, conditional and predictive routing type
    /// </summary>
    /// <value>Routing rule for preferred, conditional and predictive routing type</value>
    [DataMember(Name = "routingRule", EmitDefaultValue = false)]
    public string RoutingRule { get; set; }





    /// <summary>
    /// Selected agent ID
    /// </summary>
    /// <value>Selected agent ID</value>
    [DataMember(Name = "selectedAgentId", EmitDefaultValue = false)]
    public string SelectedAgentId { get; set; }



    /// <summary>
    /// Selected agent GPR rank
    /// </summary>
    /// <value>Selected agent GPR rank</value>
    [DataMember(Name = "selectedAgentRank", EmitDefaultValue = false)]
    public long? SelectedAgentRank { get; set; }



    /// <summary>
    /// Indicates whether the flow session was self serviced
    /// </summary>
    /// <value>Indicates whether the flow session was self serviced</value>
    [DataMember(Name = "selfServed", EmitDefaultValue = false)]
    public bool? SelfServed { get; set; }



    /// <summary>
    /// Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred
    /// </summary>
    /// <value>Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred</value>
    [DataMember(Name = "sessionDnis", EmitDefaultValue = false)]
    public string SessionDnis { get; set; }



    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Flow starting language, e.g. en-us
    /// </summary>
    /// <value>Flow starting language, e.g. en-us</value>
    [DataMember(Name = "startingLanguage", EmitDefaultValue = false)]
    public string StartingLanguage { get; set; }



    /// <summary>
    /// Unique identifier for a phone
    /// </summary>
    /// <value>Unique identifier for a phone</value>
    [DataMember(Name = "stationId", EmitDefaultValue = false)]
    public string StationId { get; set; }



    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }



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
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Flag indicating if video is present
    /// </summary>
    /// <value>Flag indicating if video is present</value>
    [DataMember(Name = "videoPresent", EmitDefaultValue = false)]
    public bool? VideoPresent { get; set; }



    /// <summary>
    /// Number of waiting interactions for each predictive routing attempt
    /// </summary>
    /// <value>Number of waiting interactions for each predictive routing attempt</value>
    [DataMember(Name = "waitingInteractionCounts", EmitDefaultValue = false)]
    public List<long?> WaitingInteractionCounts { get; set; }



    /// <summary>
    /// Wrap up code
    /// </summary>
    /// <value>Wrap up code</value>
    [DataMember(Name = "wrapUpCode", EmitDefaultValue = false)]
    public string WrapUpCode { get; set; }



    /// <summary>
    /// Proposed agents
    /// </summary>
    /// <value>Proposed agents</value>
    [DataMember(Name = "proposedAgents", EmitDefaultValue = false)]
    public List<FlowMetricsTopicFlowProposedAgent> ProposedAgents { get; set; }



    /// <summary>
    /// Flow outcomes
    /// </summary>
    /// <value>Flow outcomes</value>
    [DataMember(Name = "outcomes", EmitDefaultValue = false)]
    public List<FlowMetricsTopicFlowOutcome> Outcomes { get; set; }



    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    [DataMember(Name = "scoredAgents", EmitDefaultValue = false)]
    public List<FlowMetricsTopicFlowScoredAgent> ScoredAgents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowMetricsTopicFlowMetricRecord {\n");

        sb.Append("  Metric: ").Append(Metric).Append("\n");
        sb.Append("  MetricDate: ").Append(MetricDate).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  RecordId: ").Append(RecordId).Append("\n");
        sb.Append("  ActiveRouting: ").Append(ActiveRouting).Append("\n");
        sb.Append("  ActiveSkillIds: ").Append(ActiveSkillIds).Append("\n");
        sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
        sb.Append("  AddressTo: ").Append(AddressTo).Append("\n");
        sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
        sb.Append("  AgentBullseyeRing: ").Append(AgentBullseyeRing).Append("\n");
        sb.Append("  AgentOwned: ").Append(AgentOwned).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  AssignerId: ").Append(AssignerId).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConversationInitiator: ").Append(ConversationInitiator).Append("\n");
        sb.Append("  ConvertedFrom: ").Append(ConvertedFrom).Append("\n");
        sb.Append("  ConvertedTo: ").Append(ConvertedTo).Append("\n");
        sb.Append("  CustomerParticipation: ").Append(CustomerParticipation).Append("\n");
        sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
        sb.Append("  DestinationAddresses: ").Append(DestinationAddresses).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
        sb.Append("  EligibleAgentCounts: ").Append(EligibleAgentCounts).Append("\n");
        sb.Append("  EndingLanguage: ").Append(EndingLanguage).Append("\n");
        sb.Append("  EntryReason: ").Append(EntryReason).Append("\n");
        sb.Append("  EntryType: ").Append(EntryType).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ExitReason: ").Append(ExitReason).Append("\n");
        sb.Append("  ExtendedDeliveryStatus: ").Append(ExtendedDeliveryStatus).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ExternalMediaCount: ").Append(ExternalMediaCount).Append("\n");
        sb.Append("  ExternalOrganizationId: ").Append(ExternalOrganizationId).Append("\n");
        sb.Append("  ExternalTag: ").Append(ExternalTag).Append("\n");
        sb.Append("  FirstQueue: ").Append(FirstQueue).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  FlowId: ").Append(FlowId).Append("\n");
        sb.Append("  FlowInType: ").Append(FlowInType).Append("\n");
        sb.Append("  FlowMilestoneIds: ").Append(FlowMilestoneIds).Append("\n");
        sb.Append("  FlowName: ").Append(FlowName).Append("\n");
        sb.Append("  FlowOutType: ").Append(FlowOutType).Append("\n");
        sb.Append("  FlowSubType: ").Append(FlowSubType).Append("\n");
        sb.Append("  FlowType: ").Append(FlowType).Append("\n");
        sb.Append("  FlowVersion: ").Append(FlowVersion).Append("\n");
        sb.Append("  GroupId: ").Append(GroupId).Append("\n");
        sb.Append("  InteractionType: ").Append(InteractionType).Append("\n");
        sb.Append("  JourneyActionId: ").Append(JourneyActionId).Append("\n");
        sb.Append("  JourneyActionMapId: ").Append(JourneyActionMapId).Append("\n");
        sb.Append("  JourneyActionMapVersion: ").Append(JourneyActionMapVersion).Append("\n");
        sb.Append("  JourneyCustomerId: ").Append(JourneyCustomerId).Append("\n");
        sb.Append("  JourneyCustomerIdType: ").Append(JourneyCustomerIdType).Append("\n");
        sb.Append("  JourneyCustomerSessionId: ").Append(JourneyCustomerSessionId).Append("\n");
        sb.Append("  JourneyCustomerSessionIdType: ").Append(JourneyCustomerSessionIdType).Append("\n");
        sb.Append("  KnowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
        sb.Append("  MediaCount: ").Append(MediaCount).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
        sb.Append("  OriginatingDirection: ").Append(OriginatingDirection).Append("\n");
        sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
        sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
        sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
        sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  QueueId: ").Append(QueueId).Append("\n");
        sb.Append("  RecognitionFailureReason: ").Append(RecognitionFailureReason).Append("\n");
        sb.Append("  Remote: ").Append(Remote).Append("\n");
        sb.Append("  RemovedSkillIds: ").Append(RemovedSkillIds).Append("\n");
        sb.Append("  RequestedLanguageId: ").Append(RequestedLanguageId).Append("\n");
        sb.Append("  RequestedRoutingSkillIds: ").Append(RequestedRoutingSkillIds).Append("\n");
        sb.Append("  RequestedRoutings: ").Append(RequestedRoutings).Append("\n");
        sb.Append("  RoomId: ").Append(RoomId).Append("\n");
        sb.Append("  RoutingPriority: ").Append(RoutingPriority).Append("\n");
        sb.Append("  RoutingRing: ").Append(RoutingRing).Append("\n");
        sb.Append("  RoutingRule: ").Append(RoutingRule).Append("\n");
        sb.Append("  RoutingRuleType: ").Append(RoutingRuleType).Append("\n");
        sb.Append("  SelectedAgentId: ").Append(SelectedAgentId).Append("\n");
        sb.Append("  SelectedAgentRank: ").Append(SelectedAgentRank).Append("\n");
        sb.Append("  SelfServed: ").Append(SelfServed).Append("\n");
        sb.Append("  SessionDnis: ").Append(SessionDnis).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  StartingLanguage: ").Append(StartingLanguage).Append("\n");
        sb.Append("  StationId: ").Append(StationId).Append("\n");
        sb.Append("  TeamId: ").Append(TeamId).Append("\n");
        sb.Append("  TransferTargetAddress: ").Append(TransferTargetAddress).Append("\n");
        sb.Append("  TransferTargetName: ").Append(TransferTargetName).Append("\n");
        sb.Append("  TransferType: ").Append(TransferType).Append("\n");
        sb.Append("  UsedRouting: ").Append(UsedRouting).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  VideoPresent: ").Append(VideoPresent).Append("\n");
        sb.Append("  WaitingInteractionCounts: ").Append(WaitingInteractionCounts).Append("\n");
        sb.Append("  WrapUpCode: ").Append(WrapUpCode).Append("\n");
        sb.Append("  ProposedAgents: ").Append(ProposedAgents).Append("\n");
        sb.Append("  Outcomes: ").Append(Outcomes).Append("\n");
        sb.Append("  ScoredAgents: ").Append(ScoredAgents).Append("\n");
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
        return Equals(obj as FlowMetricsTopicFlowMetricRecord);
    }

    /// <summary>
    /// Returns true if FlowMetricsTopicFlowMetricRecord instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowMetricsTopicFlowMetricRecord to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowMetricsTopicFlowMetricRecord other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Metric == other.Metric ||
                Metric != null &&
                Metric.Equals(other.Metric)
            ) &&
            (
                MetricDate == other.MetricDate ||
                MetricDate != null &&
                MetricDate.Equals(other.MetricDate)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                RecordId == other.RecordId ||
                RecordId != null &&
                RecordId.Equals(other.RecordId)
            ) &&
            (
                ActiveRouting == other.ActiveRouting ||
                ActiveRouting != null &&
                ActiveRouting.Equals(other.ActiveRouting)
            ) &&
            (
                ActiveSkillIds == other.ActiveSkillIds ||
                ActiveSkillIds != null &&
                ActiveSkillIds.SequenceEqual(other.ActiveSkillIds)
            ) &&
            (
                AddressFrom == other.AddressFrom ||
                AddressFrom != null &&
                AddressFrom.Equals(other.AddressFrom)
            ) &&
            (
                AddressTo == other.AddressTo ||
                AddressTo != null &&
                AddressTo.Equals(other.AddressTo)
            ) &&
            (
                AgentAssistantId == other.AgentAssistantId ||
                AgentAssistantId != null &&
                AgentAssistantId.Equals(other.AgentAssistantId)
            ) &&
            (
                AgentBullseyeRing == other.AgentBullseyeRing ||
                AgentBullseyeRing != null &&
                AgentBullseyeRing.Equals(other.AgentBullseyeRing)
            ) &&
            (
                AgentOwned == other.AgentOwned ||
                AgentOwned != null &&
                AgentOwned.Equals(other.AgentOwned)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                AssignerId == other.AssignerId ||
                AssignerId != null &&
                AssignerId.Equals(other.AssignerId)
            ) &&
            (
                Authenticated == other.Authenticated ||
                Authenticated != null &&
                Authenticated.Equals(other.Authenticated)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConversationInitiator == other.ConversationInitiator ||
                ConversationInitiator != null &&
                ConversationInitiator.Equals(other.ConversationInitiator)
            ) &&
            (
                ConvertedFrom == other.ConvertedFrom ||
                ConvertedFrom != null &&
                ConvertedFrom.Equals(other.ConvertedFrom)
            ) &&
            (
                ConvertedTo == other.ConvertedTo ||
                ConvertedTo != null &&
                ConvertedTo.Equals(other.ConvertedTo)
            ) &&
            (
                CustomerParticipation == other.CustomerParticipation ||
                CustomerParticipation != null &&
                CustomerParticipation.Equals(other.CustomerParticipation)
            ) &&
            (
                DeliveryStatus == other.DeliveryStatus ||
                DeliveryStatus != null &&
                DeliveryStatus.Equals(other.DeliveryStatus)
            ) &&
            (
                DestinationAddresses == other.DestinationAddresses ||
                DestinationAddresses != null &&
                DestinationAddresses.SequenceEqual(other.DestinationAddresses)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                EdgeId == other.EdgeId ||
                EdgeId != null &&
                EdgeId.Equals(other.EdgeId)
            ) &&
            (
                EligibleAgentCounts == other.EligibleAgentCounts ||
                EligibleAgentCounts != null &&
                EligibleAgentCounts.SequenceEqual(other.EligibleAgentCounts)
            ) &&
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
                ErrorCode == other.ErrorCode ||
                ErrorCode != null &&
                ErrorCode.Equals(other.ErrorCode)
            ) &&
            (
                ExitReason == other.ExitReason ||
                ExitReason != null &&
                ExitReason.Equals(other.ExitReason)
            ) &&
            (
                ExtendedDeliveryStatus == other.ExtendedDeliveryStatus ||
                ExtendedDeliveryStatus != null &&
                ExtendedDeliveryStatus.Equals(other.ExtendedDeliveryStatus)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                ExternalMediaCount == other.ExternalMediaCount ||
                ExternalMediaCount != null &&
                ExternalMediaCount.Equals(other.ExternalMediaCount)
            ) &&
            (
                ExternalOrganizationId == other.ExternalOrganizationId ||
                ExternalOrganizationId != null &&
                ExternalOrganizationId.Equals(other.ExternalOrganizationId)
            ) &&
            (
                ExternalTag == other.ExternalTag ||
                ExternalTag != null &&
                ExternalTag.Equals(other.ExternalTag)
            ) &&
            (
                FirstQueue == other.FirstQueue ||
                FirstQueue != null &&
                FirstQueue.Equals(other.FirstQueue)
            ) &&
            (
                FlaggedReason == other.FlaggedReason ||
                FlaggedReason != null &&
                FlaggedReason.Equals(other.FlaggedReason)
            ) &&
            (
                FlowId == other.FlowId ||
                FlowId != null &&
                FlowId.Equals(other.FlowId)
            ) &&
            (
                FlowInType == other.FlowInType ||
                FlowInType != null &&
                FlowInType.Equals(other.FlowInType)
            ) &&
            (
                FlowMilestoneIds == other.FlowMilestoneIds ||
                FlowMilestoneIds != null &&
                FlowMilestoneIds.SequenceEqual(other.FlowMilestoneIds)
            ) &&
            (
                FlowName == other.FlowName ||
                FlowName != null &&
                FlowName.Equals(other.FlowName)
            ) &&
            (
                FlowOutType == other.FlowOutType ||
                FlowOutType != null &&
                FlowOutType.Equals(other.FlowOutType)
            ) &&
            (
                FlowSubType == other.FlowSubType ||
                FlowSubType != null &&
                FlowSubType.Equals(other.FlowSubType)
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
                GroupId == other.GroupId ||
                GroupId != null &&
                GroupId.Equals(other.GroupId)
            ) &&
            (
                InteractionType == other.InteractionType ||
                InteractionType != null &&
                InteractionType.Equals(other.InteractionType)
            ) &&
            (
                JourneyActionId == other.JourneyActionId ||
                JourneyActionId != null &&
                JourneyActionId.Equals(other.JourneyActionId)
            ) &&
            (
                JourneyActionMapId == other.JourneyActionMapId ||
                JourneyActionMapId != null &&
                JourneyActionMapId.Equals(other.JourneyActionMapId)
            ) &&
            (
                JourneyActionMapVersion == other.JourneyActionMapVersion ||
                JourneyActionMapVersion != null &&
                JourneyActionMapVersion.Equals(other.JourneyActionMapVersion)
            ) &&
            (
                JourneyCustomerId == other.JourneyCustomerId ||
                JourneyCustomerId != null &&
                JourneyCustomerId.Equals(other.JourneyCustomerId)
            ) &&
            (
                JourneyCustomerIdType == other.JourneyCustomerIdType ||
                JourneyCustomerIdType != null &&
                JourneyCustomerIdType.Equals(other.JourneyCustomerIdType)
            ) &&
            (
                JourneyCustomerSessionId == other.JourneyCustomerSessionId ||
                JourneyCustomerSessionId != null &&
                JourneyCustomerSessionId.Equals(other.JourneyCustomerSessionId)
            ) &&
            (
                JourneyCustomerSessionIdType == other.JourneyCustomerSessionIdType ||
                JourneyCustomerSessionIdType != null &&
                JourneyCustomerSessionIdType.Equals(other.JourneyCustomerSessionIdType)
            ) &&
            (
                KnowledgeBaseId == other.KnowledgeBaseId ||
                KnowledgeBaseId != null &&
                KnowledgeBaseId.Equals(other.KnowledgeBaseId)
            ) &&
            (
                MediaCount == other.MediaCount ||
                MediaCount != null &&
                MediaCount.Equals(other.MediaCount)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
            ) &&
            (
                OriginatingDirection == other.OriginatingDirection ||
                OriginatingDirection != null &&
                OriginatingDirection.Equals(other.OriginatingDirection)
            ) &&
            (
                OutboundCampaignId == other.OutboundCampaignId ||
                OutboundCampaignId != null &&
                OutboundCampaignId.Equals(other.OutboundCampaignId)
            ) &&
            (
                OutboundContactId == other.OutboundContactId ||
                OutboundContactId != null &&
                OutboundContactId.Equals(other.OutboundContactId)
            ) &&
            (
                OutboundContactListId == other.OutboundContactListId ||
                OutboundContactListId != null &&
                OutboundContactListId.Equals(other.OutboundContactListId)
            ) &&
            (
                ParticipantName == other.ParticipantName ||
                ParticipantName != null &&
                ParticipantName.Equals(other.ParticipantName)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                QueueId == other.QueueId ||
                QueueId != null &&
                QueueId.Equals(other.QueueId)
            ) &&
            (
                RecognitionFailureReason == other.RecognitionFailureReason ||
                RecognitionFailureReason != null &&
                RecognitionFailureReason.Equals(other.RecognitionFailureReason)
            ) &&
            (
                Remote == other.Remote ||
                Remote != null &&
                Remote.Equals(other.Remote)
            ) &&
            (
                RemovedSkillIds == other.RemovedSkillIds ||
                RemovedSkillIds != null &&
                RemovedSkillIds.SequenceEqual(other.RemovedSkillIds)
            ) &&
            (
                RequestedLanguageId == other.RequestedLanguageId ||
                RequestedLanguageId != null &&
                RequestedLanguageId.Equals(other.RequestedLanguageId)
            ) &&
            (
                RequestedRoutingSkillIds == other.RequestedRoutingSkillIds ||
                RequestedRoutingSkillIds != null &&
                RequestedRoutingSkillIds.SequenceEqual(other.RequestedRoutingSkillIds)
            ) &&
            (
                RequestedRoutings == other.RequestedRoutings ||
                RequestedRoutings != null &&
                RequestedRoutings.SequenceEqual(other.RequestedRoutings)
            ) &&
            (
                RoomId == other.RoomId ||
                RoomId != null &&
                RoomId.Equals(other.RoomId)
            ) &&
            (
                RoutingPriority == other.RoutingPriority ||
                RoutingPriority != null &&
                RoutingPriority.Equals(other.RoutingPriority)
            ) &&
            (
                RoutingRing == other.RoutingRing ||
                RoutingRing != null &&
                RoutingRing.Equals(other.RoutingRing)
            ) &&
            (
                RoutingRule == other.RoutingRule ||
                RoutingRule != null &&
                RoutingRule.Equals(other.RoutingRule)
            ) &&
            (
                RoutingRuleType == other.RoutingRuleType ||
                RoutingRuleType != null &&
                RoutingRuleType.Equals(other.RoutingRuleType)
            ) &&
            (
                SelectedAgentId == other.SelectedAgentId ||
                SelectedAgentId != null &&
                SelectedAgentId.Equals(other.SelectedAgentId)
            ) &&
            (
                SelectedAgentRank == other.SelectedAgentRank ||
                SelectedAgentRank != null &&
                SelectedAgentRank.Equals(other.SelectedAgentRank)
            ) &&
            (
                SelfServed == other.SelfServed ||
                SelfServed != null &&
                SelfServed.Equals(other.SelfServed)
            ) &&
            (
                SessionDnis == other.SessionDnis ||
                SessionDnis != null &&
                SessionDnis.Equals(other.SessionDnis)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                StartingLanguage == other.StartingLanguage ||
                StartingLanguage != null &&
                StartingLanguage.Equals(other.StartingLanguage)
            ) &&
            (
                StationId == other.StationId ||
                StationId != null &&
                StationId.Equals(other.StationId)
            ) &&
            (
                TeamId == other.TeamId ||
                TeamId != null &&
                TeamId.Equals(other.TeamId)
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
                UsedRouting == other.UsedRouting ||
                UsedRouting != null &&
                UsedRouting.Equals(other.UsedRouting)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                VideoPresent == other.VideoPresent ||
                VideoPresent != null &&
                VideoPresent.Equals(other.VideoPresent)
            ) &&
            (
                WaitingInteractionCounts == other.WaitingInteractionCounts ||
                WaitingInteractionCounts != null &&
                WaitingInteractionCounts.SequenceEqual(other.WaitingInteractionCounts)
            ) &&
            (
                WrapUpCode == other.WrapUpCode ||
                WrapUpCode != null &&
                WrapUpCode.Equals(other.WrapUpCode)
            ) &&
            (
                ProposedAgents == other.ProposedAgents ||
                ProposedAgents != null &&
                ProposedAgents.SequenceEqual(other.ProposedAgents)
            ) &&
            (
                Outcomes == other.Outcomes ||
                Outcomes != null &&
                Outcomes.SequenceEqual(other.Outcomes)
            ) &&
            (
                ScoredAgents == other.ScoredAgents ||
                ScoredAgents != null &&
                ScoredAgents.SequenceEqual(other.ScoredAgents)
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
            if (Metric != null)
            {
                hash = hash * 59 + Metric.GetHashCode();
            }

            if (MetricDate != null)
            {
                hash = hash * 59 + MetricDate.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (RecordId != null)
            {
                hash = hash * 59 + RecordId.GetHashCode();
            }

            if (ActiveRouting != null)
            {
                hash = hash * 59 + ActiveRouting.GetHashCode();
            }

            if (ActiveSkillIds != null)
            {
                hash = hash * 59 + ActiveSkillIds.GetHashCode();
            }

            if (AddressFrom != null)
            {
                hash = hash * 59 + AddressFrom.GetHashCode();
            }

            if (AddressTo != null)
            {
                hash = hash * 59 + AddressTo.GetHashCode();
            }

            if (AgentAssistantId != null)
            {
                hash = hash * 59 + AgentAssistantId.GetHashCode();
            }

            if (AgentBullseyeRing != null)
            {
                hash = hash * 59 + AgentBullseyeRing.GetHashCode();
            }

            if (AgentOwned != null)
            {
                hash = hash * 59 + AgentOwned.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (AssignerId != null)
            {
                hash = hash * 59 + AssignerId.GetHashCode();
            }

            if (Authenticated != null)
            {
                hash = hash * 59 + Authenticated.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConversationInitiator != null)
            {
                hash = hash * 59 + ConversationInitiator.GetHashCode();
            }

            if (ConvertedFrom != null)
            {
                hash = hash * 59 + ConvertedFrom.GetHashCode();
            }

            if (ConvertedTo != null)
            {
                hash = hash * 59 + ConvertedTo.GetHashCode();
            }

            if (CustomerParticipation != null)
            {
                hash = hash * 59 + CustomerParticipation.GetHashCode();
            }

            if (DeliveryStatus != null)
            {
                hash = hash * 59 + DeliveryStatus.GetHashCode();
            }

            if (DestinationAddresses != null)
            {
                hash = hash * 59 + DestinationAddresses.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (EdgeId != null)
            {
                hash = hash * 59 + EdgeId.GetHashCode();
            }

            if (EligibleAgentCounts != null)
            {
                hash = hash * 59 + EligibleAgentCounts.GetHashCode();
            }

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

            if (ErrorCode != null)
            {
                hash = hash * 59 + ErrorCode.GetHashCode();
            }

            if (ExitReason != null)
            {
                hash = hash * 59 + ExitReason.GetHashCode();
            }

            if (ExtendedDeliveryStatus != null)
            {
                hash = hash * 59 + ExtendedDeliveryStatus.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (ExternalMediaCount != null)
            {
                hash = hash * 59 + ExternalMediaCount.GetHashCode();
            }

            if (ExternalOrganizationId != null)
            {
                hash = hash * 59 + ExternalOrganizationId.GetHashCode();
            }

            if (ExternalTag != null)
            {
                hash = hash * 59 + ExternalTag.GetHashCode();
            }

            if (FirstQueue != null)
            {
                hash = hash * 59 + FirstQueue.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
            }

            if (FlowId != null)
            {
                hash = hash * 59 + FlowId.GetHashCode();
            }

            if (FlowInType != null)
            {
                hash = hash * 59 + FlowInType.GetHashCode();
            }

            if (FlowMilestoneIds != null)
            {
                hash = hash * 59 + FlowMilestoneIds.GetHashCode();
            }

            if (FlowName != null)
            {
                hash = hash * 59 + FlowName.GetHashCode();
            }

            if (FlowOutType != null)
            {
                hash = hash * 59 + FlowOutType.GetHashCode();
            }

            if (FlowSubType != null)
            {
                hash = hash * 59 + FlowSubType.GetHashCode();
            }

            if (FlowType != null)
            {
                hash = hash * 59 + FlowType.GetHashCode();
            }

            if (FlowVersion != null)
            {
                hash = hash * 59 + FlowVersion.GetHashCode();
            }

            if (GroupId != null)
            {
                hash = hash * 59 + GroupId.GetHashCode();
            }

            if (InteractionType != null)
            {
                hash = hash * 59 + InteractionType.GetHashCode();
            }

            if (JourneyActionId != null)
            {
                hash = hash * 59 + JourneyActionId.GetHashCode();
            }

            if (JourneyActionMapId != null)
            {
                hash = hash * 59 + JourneyActionMapId.GetHashCode();
            }

            if (JourneyActionMapVersion != null)
            {
                hash = hash * 59 + JourneyActionMapVersion.GetHashCode();
            }

            if (JourneyCustomerId != null)
            {
                hash = hash * 59 + JourneyCustomerId.GetHashCode();
            }

            if (JourneyCustomerIdType != null)
            {
                hash = hash * 59 + JourneyCustomerIdType.GetHashCode();
            }

            if (JourneyCustomerSessionId != null)
            {
                hash = hash * 59 + JourneyCustomerSessionId.GetHashCode();
            }

            if (JourneyCustomerSessionIdType != null)
            {
                hash = hash * 59 + JourneyCustomerSessionIdType.GetHashCode();
            }

            if (KnowledgeBaseId != null)
            {
                hash = hash * 59 + KnowledgeBaseId.GetHashCode();
            }

            if (MediaCount != null)
            {
                hash = hash * 59 + MediaCount.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            if (OriginatingDirection != null)
            {
                hash = hash * 59 + OriginatingDirection.GetHashCode();
            }

            if (OutboundCampaignId != null)
            {
                hash = hash * 59 + OutboundCampaignId.GetHashCode();
            }

            if (OutboundContactId != null)
            {
                hash = hash * 59 + OutboundContactId.GetHashCode();
            }

            if (OutboundContactListId != null)
            {
                hash = hash * 59 + OutboundContactListId.GetHashCode();
            }

            if (ParticipantName != null)
            {
                hash = hash * 59 + ParticipantName.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (QueueId != null)
            {
                hash = hash * 59 + QueueId.GetHashCode();
            }

            if (RecognitionFailureReason != null)
            {
                hash = hash * 59 + RecognitionFailureReason.GetHashCode();
            }

            if (Remote != null)
            {
                hash = hash * 59 + Remote.GetHashCode();
            }

            if (RemovedSkillIds != null)
            {
                hash = hash * 59 + RemovedSkillIds.GetHashCode();
            }

            if (RequestedLanguageId != null)
            {
                hash = hash * 59 + RequestedLanguageId.GetHashCode();
            }

            if (RequestedRoutingSkillIds != null)
            {
                hash = hash * 59 + RequestedRoutingSkillIds.GetHashCode();
            }

            if (RequestedRoutings != null)
            {
                hash = hash * 59 + RequestedRoutings.GetHashCode();
            }

            if (RoomId != null)
            {
                hash = hash * 59 + RoomId.GetHashCode();
            }

            if (RoutingPriority != null)
            {
                hash = hash * 59 + RoutingPriority.GetHashCode();
            }

            if (RoutingRing != null)
            {
                hash = hash * 59 + RoutingRing.GetHashCode();
            }

            if (RoutingRule != null)
            {
                hash = hash * 59 + RoutingRule.GetHashCode();
            }

            if (RoutingRuleType != null)
            {
                hash = hash * 59 + RoutingRuleType.GetHashCode();
            }

            if (SelectedAgentId != null)
            {
                hash = hash * 59 + SelectedAgentId.GetHashCode();
            }

            if (SelectedAgentRank != null)
            {
                hash = hash * 59 + SelectedAgentRank.GetHashCode();
            }

            if (SelfServed != null)
            {
                hash = hash * 59 + SelfServed.GetHashCode();
            }

            if (SessionDnis != null)
            {
                hash = hash * 59 + SessionDnis.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (StartingLanguage != null)
            {
                hash = hash * 59 + StartingLanguage.GetHashCode();
            }

            if (StationId != null)
            {
                hash = hash * 59 + StationId.GetHashCode();
            }

            if (TeamId != null)
            {
                hash = hash * 59 + TeamId.GetHashCode();
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

            if (UsedRouting != null)
            {
                hash = hash * 59 + UsedRouting.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (VideoPresent != null)
            {
                hash = hash * 59 + VideoPresent.GetHashCode();
            }

            if (WaitingInteractionCounts != null)
            {
                hash = hash * 59 + WaitingInteractionCounts.GetHashCode();
            }

            if (WrapUpCode != null)
            {
                hash = hash * 59 + WrapUpCode.GetHashCode();
            }

            if (ProposedAgents != null)
            {
                hash = hash * 59 + ProposedAgents.GetHashCode();
            }

            if (Outcomes != null)
            {
                hash = hash * 59 + Outcomes.GetHashCode();
            }

            if (ScoredAgents != null)
            {
                hash = hash * 59 + ScoredAgents.GetHashCode();
            }

            return hash;
        }
    }
}
