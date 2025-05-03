using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models.Topics;

public partial class ConversationMetricsTopicConversationMetricRecord
{
    /// <summary>
    /// Metric name
    /// </summary>
    /// <value>Metric name</value>

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
        /// Enum Nblindtransferred for "nBlindTransferred"
        /// </summary>
        [EnumMember(Value = "nBlindTransferred")]
        Nblindtransferred,

        /// <summary>
        /// Enum Nbotinteractions for "nBotInteractions"
        /// </summary>
        [EnumMember(Value = "nBotInteractions")]
        Nbotinteractions,

        /// <summary>
        /// Enum Ncobrowsesessions for "nCobrowseSessions"
        /// </summary>
        [EnumMember(Value = "nCobrowseSessions")]
        Ncobrowsesessions,

        /// <summary>
        /// Enum Nconnected for "nConnected"
        /// </summary>
        [EnumMember(Value = "nConnected")]
        Nconnected,

        /// <summary>
        /// Enum Nconsult for "nConsult"
        /// </summary>
        [EnumMember(Value = "nConsult")]
        Nconsult,

        /// <summary>
        /// Enum Nconsulttransferred for "nConsultTransferred"
        /// </summary>
        [EnumMember(Value = "nConsultTransferred")]
        Nconsulttransferred,

        /// <summary>
        /// Enum Nerror for "nError"
        /// </summary>
        [EnumMember(Value = "nError")]
        Nerror,

        /// <summary>
        /// Enum Noffered for "nOffered"
        /// </summary>
        [EnumMember(Value = "nOffered")]
        Noffered,

        /// <summary>
        /// Enum Noutbound for "nOutbound"
        /// </summary>
        [EnumMember(Value = "nOutbound")]
        Noutbound,

        /// <summary>
        /// Enum Noutboundabandoned for "nOutboundAbandoned"
        /// </summary>
        [EnumMember(Value = "nOutboundAbandoned")]
        Noutboundabandoned,

        /// <summary>
        /// Enum Noutboundattempted for "nOutboundAttempted"
        /// </summary>
        [EnumMember(Value = "nOutboundAttempted")]
        Noutboundattempted,

        /// <summary>
        /// Enum Noutboundconnected for "nOutboundConnected"
        /// </summary>
        [EnumMember(Value = "nOutboundConnected")]
        Noutboundconnected,

        /// <summary>
        /// Enum Noversla for "nOverSla"
        /// </summary>
        [EnumMember(Value = "nOverSla")]
        Noversla,

        /// <summary>
        /// Enum Ntransferred for "nTransferred"
        /// </summary>
        [EnumMember(Value = "nTransferred")]
        Ntransferred,

        /// <summary>
        /// Enum Oexternalmediacount for "oExternalMediaCount"
        /// </summary>
        [EnumMember(Value = "oExternalMediaCount")]
        Oexternalmediacount,

        /// <summary>
        /// Enum Omediacount for "oMediaCount"
        /// </summary>
        [EnumMember(Value = "oMediaCount")]
        Omediacount,

        /// <summary>
        /// Enum Omessagecount for "oMessageCount"
        /// </summary>
        [EnumMember(Value = "oMessageCount")]
        Omessagecount,

        /// <summary>
        /// Enum Omessagesegmentcount for "oMessageSegmentCount"
        /// </summary>
        [EnumMember(Value = "oMessageSegmentCount")]
        Omessagesegmentcount,

        /// <summary>
        /// Enum Omessageturn for "oMessageTurn"
        /// </summary>
        [EnumMember(Value = "oMessageTurn")]
        Omessageturn,

        /// <summary>
        /// Enum Tabandon for "tAbandon"
        /// </summary>
        [EnumMember(Value = "tAbandon")]
        Tabandon,

        /// <summary>
        /// Enum Tacd for "tAcd"
        /// </summary>
        [EnumMember(Value = "tAcd")]
        Tacd,

        /// <summary>
        /// Enum Tactivecallback for "tActiveCallback"
        /// </summary>
        [EnumMember(Value = "tActiveCallback")]
        Tactivecallback,

        /// <summary>
        /// Enum Tactivecallbackcomplete for "tActiveCallbackComplete"
        /// </summary>
        [EnumMember(Value = "tActiveCallbackComplete")]
        Tactivecallbackcomplete,

        /// <summary>
        /// Enum Tacw for "tAcw"
        /// </summary>
        [EnumMember(Value = "tAcw")]
        Tacw,

        /// <summary>
        /// Enum Tagentresponsetime for "tAgentResponseTime"
        /// </summary>
        [EnumMember(Value = "tAgentResponseTime")]
        Tagentresponsetime,

        /// <summary>
        /// Enum Talert for "tAlert"
        /// </summary>
        [EnumMember(Value = "tAlert")]
        Talert,

        /// <summary>
        /// Enum Tanswered for "tAnswered"
        /// </summary>
        [EnumMember(Value = "tAnswered")]
        Tanswered,

        /// <summary>
        /// Enum Taverageagentresponsetime for "tAverageAgentResponseTime"
        /// </summary>
        [EnumMember(Value = "tAverageAgentResponseTime")]
        Taverageagentresponsetime,

        /// <summary>
        /// Enum Taveragecustomerresponsetime for "tAverageCustomerResponseTime"
        /// </summary>
        [EnumMember(Value = "tAverageCustomerResponseTime")]
        Taveragecustomerresponsetime,

        /// <summary>
        /// Enum Tbarging for "tBarging"
        /// </summary>
        [EnumMember(Value = "tBarging")]
        Tbarging,

        /// <summary>
        /// Enum Tcoaching for "tCoaching"
        /// </summary>
        [EnumMember(Value = "tCoaching")]
        Tcoaching,

        /// <summary>
        /// Enum Tcoachingcomplete for "tCoachingComplete"
        /// </summary>
        [EnumMember(Value = "tCoachingComplete")]
        Tcoachingcomplete,

        /// <summary>
        /// Enum Tconnected for "tConnected"
        /// </summary>
        [EnumMember(Value = "tConnected")]
        Tconnected,

        /// <summary>
        /// Enum Tcontacting for "tContacting"
        /// </summary>
        [EnumMember(Value = "tContacting")]
        Tcontacting,

        /// <summary>
        /// Enum Tdialing for "tDialing"
        /// </summary>
        [EnumMember(Value = "tDialing")]
        Tdialing,

        /// <summary>
        /// Enum Tfirstconnect for "tFirstConnect"
        /// </summary>
        [EnumMember(Value = "tFirstConnect")]
        Tfirstconnect,

        /// <summary>
        /// Enum Tfirstdial for "tFirstDial"
        /// </summary>
        [EnumMember(Value = "tFirstDial")]
        Tfirstdial,

        /// <summary>
        /// Enum Tfirstengagement for "tFirstEngagement"
        /// </summary>
        [EnumMember(Value = "tFirstEngagement")]
        Tfirstengagement,

        /// <summary>
        /// Enum Tfirstresponse for "tFirstResponse"
        /// </summary>
        [EnumMember(Value = "tFirstResponse")]
        Tfirstresponse,

        /// <summary>
        /// Enum Tflowout for "tFlowOut"
        /// </summary>
        [EnumMember(Value = "tFlowOut")]
        Tflowout,

        /// <summary>
        /// Enum Thandle for "tHandle"
        /// </summary>
        [EnumMember(Value = "tHandle")]
        Thandle,

        /// <summary>
        /// Enum Theld for "tHeld"
        /// </summary>
        [EnumMember(Value = "tHeld")]
        Theld,

        /// <summary>
        /// Enum Theldcomplete for "tHeldComplete"
        /// </summary>
        [EnumMember(Value = "tHeldComplete")]
        Theldcomplete,

        /// <summary>
        /// Enum Tivr for "tIvr"
        /// </summary>
        [EnumMember(Value = "tIvr")]
        Tivr,

        /// <summary>
        /// Enum Tmonitoring for "tMonitoring"
        /// </summary>
        [EnumMember(Value = "tMonitoring")]
        Tmonitoring,

        /// <summary>
        /// Enum Tmonitoringcomplete for "tMonitoringComplete"
        /// </summary>
        [EnumMember(Value = "tMonitoringComplete")]
        Tmonitoringcomplete,

        /// <summary>
        /// Enum Tnotresponding for "tNotResponding"
        /// </summary>
        [EnumMember(Value = "tNotResponding")]
        Tnotresponding,

        /// <summary>
        /// Enum Tpark for "tPark"
        /// </summary>
        [EnumMember(Value = "tPark")]
        Tpark,

        /// <summary>
        /// Enum Tparkcomplete for "tParkComplete"
        /// </summary>
        [EnumMember(Value = "tParkComplete")]
        Tparkcomplete,

        /// <summary>
        /// Enum Ttalk for "tTalk"
        /// </summary>
        [EnumMember(Value = "tTalk")]
        Ttalk,

        /// <summary>
        /// Enum Ttalkcomplete for "tTalkComplete"
        /// </summary>
        [EnumMember(Value = "tTalkComplete")]
        Ttalkcomplete,

        /// <summary>
        /// Enum Tuserresponsetime for "tUserResponseTime"
        /// </summary>
        [EnumMember(Value = "tUserResponseTime")]
        Tuserresponsetime,

        /// <summary>
        /// Enum Tvoicemail for "tVoicemail"
        /// </summary>
        [EnumMember(Value = "tVoicemail")]
        Tvoicemail
    }
    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>

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
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>

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
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>

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
        Vip,
    }
    /// <summary>
    /// Metric name
    /// </summary>
    /// <value>Metric name</value>
    public MetricEnum? Metric { get; set; }

    /// <summary>
    /// Active routing method
    /// </summary>
    /// <value>Active routing method</value>
    public ActiveRoutingEnum? ActiveRouting { get; set; }

    /// <summary>
    /// Indicates the participant purpose of the participant initiating a message conversation
    /// </summary>
    /// <value>Indicates the participant purpose of the participant initiating a message conversation</value>
    public ConversationInitiatorEnum? ConversationInitiator { get; set; }

    /// <summary>
    /// The email or SMS delivery status
    /// </summary>
    /// <value>The email or SMS delivery status</value>
    public DeliveryStatusEnum? DeliveryStatus { get; set; }

    /// <summary>
    /// The direction of the communication
    /// </summary>
    /// <value>The direction of the communication</value>
    public DirectionEnum? Direction { get; set; }

    /// <summary>
    /// The session disconnect type
    /// </summary>
    /// <value>The session disconnect type</value>
    public DisconnectTypeEnum? DisconnectType { get; set; }

    /// <summary>
    /// Reason for which participant flagged conversation
    /// </summary>
    /// <value>Reason for which participant flagged conversation</value>
    public FlaggedReasonEnum? FlaggedReason { get; set; }

    /// <summary>
    /// The session media type
    /// </summary>
    /// <value>The session media type</value>
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// The original direction of the conversation
    /// </summary>
    /// <value>The original direction of the conversation</value>
    public OriginatingDirectionEnum? OriginatingDirection { get; set; }

    /// <summary>
    /// The participant's purpose
    /// </summary>
    /// <value>The participant's purpose</value>
    public PurposeEnum? Purpose { get; set; }
    /// <summary>
    /// Routing rule type
    /// </summary>
    /// <value>Routing rule type</value>
    public RoutingRuleTypeEnum? RoutingRuleType { get; set; }

    /// <summary>
    /// Complete routing method
    /// </summary>
    /// <value>Complete routing method</value>
    public UsedRoutingEnum? UsedRouting { get; set; }

    /// <summary>
    /// The date and time of metric creation
    /// </summary>
    /// <value>The date and time of metric creation</value>
    public DateTime? MetricDate { get; set; }

    /// <summary>
    /// Metric value
    /// </summary>
    /// <value>Metric value</value>
    public long? Value { get; set; }

    /// <summary>
    /// Record identifier
    /// </summary>
    /// <value>Record identifier</value>
    public string RecordId { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that are active on the conversation
    /// </summary>
    /// <value>ID(s) of Skill(s) that are active on the conversation</value>
    public IEnumerable<string> ActiveSkillIds { get; set; }

    /// <summary>
    /// The address that initiated an action
    /// </summary>
    /// <value>The address that initiated an action</value>
    public string AddressFrom { get; set; }

    /// <summary>
    /// The address receiving an action
    /// </summary>
    /// <value>The address receiving an action</value>
    public string AddressTo { get; set; }

    /// <summary>
    /// Unique identifier of the active virtual agent assistant
    /// </summary>
    /// <value>Unique identifier of the active virtual agent assistant</value>
    public string AgentAssistantId { get; set; }

    /// <summary>
    /// Bullseye ring of the targeted agent
    /// </summary>
    /// <value>Bullseye ring of the targeted agent</value>
    public long? AgentBullseyeRing { get; set; }

    /// <summary>
    /// Flag indicating an agent-owned callback
    /// </summary>
    /// <value>Flag indicating an agent-owned callback</value>
    public bool? AgentOwned { get; set; }

    /// <summary>
    /// Automatic Number Identification (caller&#39;s number)
    /// </summary>
    /// <value>Automatic Number Identification (caller&#39;s number)</value>
    public string Ani { get; set; }

    /// <summary>
    /// ID of the user that manually assigned a conversation
    /// </summary>
    /// <value>ID of the user that manually assigned a conversation</value>
    public string AssignerId { get; set; }

    /// <summary>
    /// Flag that indicates that the identity of the customer has been asserted as verified by the provider.
    /// </summary>
    /// <value>Flag that indicates that the identity of the customer has been asserted as verified by the provider.</value>
    public bool? Authenticated { get; set; }

    /// <summary>
    /// Unique identifier for the conversation
    /// </summary>
    /// <value>Unique identifier for the conversation</value>
    public string ConversationId { get; set; }

    /// <summary>
    /// Session media type that was converted from in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted from in case of a media type conversion</value>
    public string ConvertedFrom { get; set; }

    /// <summary>
    /// Session media type that was converted to in case of a media type conversion
    /// </summary>
    /// <value>Session media type that was converted to in case of a media type conversion</value>
    public string ConvertedTo { get; set; }

    /// <summary>
    /// Indicates a messaging conversation in which the customer participated by sending at least one message
    /// </summary>
    /// <value>Indicates a messaging conversation in which the customer participated by sending at least one message</value>
    public bool? CustomerParticipation { get; set; }

    /// <summary>
    /// Destination address(es) of transfers or consults
    /// </summary>
    /// <value>Destination address(es) of transfers or consults</value>
    public IEnumerable<string> DestinationAddresses { get; set; }

    /// <summary>
    /// Identifier(s) of division(s) associated with a conversation
    /// </summary>
    /// <value>Identifier(s) of division(s) associated with a conversation</value>
    public IEnumerable<string> DivisionIds { get; set; }

    /// <summary>
    /// Dialed number identification service (number dialed by the calling party)
    /// </summary>
    /// <value>Dialed number identification service (number dialed by the calling party)</value>
    public string Dnis { get; set; }

    /// <summary>
    /// Unique identifier of the edge device
    /// </summary>
    /// <value>Unique identifier of the edge device</value>
    public string EdgeId { get; set; }

    /// <summary>
    /// Number of eligible agents for each predictive routing attempt
    /// </summary>
    /// <value>Number of eligible agents for each predictive routing attempt</value>
    public IEnumerable<long?> EligibleAgentCounts { get; set; }

    /// <summary>
    /// A code corresponding to the error that occurred
    /// </summary>
    /// <value>A code corresponding to the error that occurred</value>
    public string ErrorCode { get; set; }

    /// <summary>
    /// Extended delivery status
    /// </summary>
    /// <value>Extended delivery status</value>
    public string ExtendedDeliveryStatus { get; set; }

    /// <summary>
    /// External contact identifier
    /// </summary>
    /// <value>External contact identifier</value>
    public string ExternalContactId { get; set; }

    /// <summary>
    /// Count of any media (images, files, etc) included on the external session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included on the external session</value>
    public long? ExternalMediaCount { get; set; }

    /// <summary>
    /// External organization identifier
    /// </summary>
    /// <value>External organization identifier</value>
    public string ExternalOrganizationId { get; set; }

    /// <summary>
    /// External tag for the conversation
    /// </summary>
    /// <value>External tag for the conversation</value>
    public string ExternalTag { get; set; }

    /// <summary>
    /// Marker that is set if the current queue is the first queue in a conversation
    /// </summary>
    /// <value>Marker that is set if the current queue is the first queue in a conversation</value>
    public bool? FirstQueue { get; set; }

    /// <summary>
    /// Type of flow in that occurred when entering ACD.
    /// </summary>
    /// <value>Type of flow in that occurred when entering ACD.</value>
    public string FlowInType { get; set; }

    /// <summary>
    /// Type of flow out that occurred when emitting tFlowOut.
    /// </summary>
    /// <value>Type of flow out that occurred when emitting tFlowOut.</value>
    public string FlowOutType { get; set; }

    /// <summary>
    /// Unique identifier for a Genesys Cloud group
    /// </summary>
    /// <value>Unique identifier for a Genesys Cloud group</value>
    public string GroupId { get; set; }

    /// <summary>
    /// The interaction type (enterprise or contactCenter)
    /// </summary>
    /// <value>The interaction type (enterprise or contactCenter)</value>
    public string InteractionType { get; set; }

    /// <summary>
    /// Identifier of the journey action.
    /// </summary>
    /// <value>Identifier of the journey action.</value>
    public string JourneyActionId { get; set; }

    /// <summary>
    /// Identifier of the journey action map that triggered the action.
    /// </summary>
    /// <value>Identifier of the journey action map that triggered the action.</value>
    public string JourneyActionMapId { get; set; }

    /// <summary>
    /// Version of the journey action map that triggered the action.
    /// </summary>
    /// <value>Version of the journey action map that triggered the action.</value>
    public long? JourneyActionMapVersion { get; set; }

    /// <summary>
    /// Primary identifier of the journey customer in the source where the activities originate from.
    /// </summary>
    /// <value>Primary identifier of the journey customer in the source where the activities originate from.</value>
    public string JourneyCustomerId { get; set; }

    /// <summary>
    /// Type of primary identifier of the journey customer (e.g. cookie).
    /// </summary>
    /// <value>Type of primary identifier of the journey customer (e.g. cookie).</value>
    public string JourneyCustomerIdType { get; set; }

    /// <summary>
    /// Unique identifier of the journey session.
    /// </summary>
    /// <value>Unique identifier of the journey session.</value>
    public string JourneyCustomerSessionId { get; set; }

    /// <summary>
    /// Type or category of journey sessions (e.g. web, ticket, delivery, atm).
    /// </summary>
    /// <value>Type or category of journey sessions (e.g. web, ticket, delivery, atm).</value>
    public string JourneyCustomerSessionIdType { get; set; }

    /// <summary>
    /// The unique identifier(s) of the knowledge base(s) used
    /// </summary>
    /// <value>The unique identifier(s) of the knowledge base(s) used</value>
    public IEnumerable<string> KnowledgeBaseIds { get; set; }

    /// <summary>
    /// Count of any media (images, files, etc) included in this session
    /// </summary>
    /// <value>Count of any media (images, files, etc) included in this session</value>
    public long? MediaCount { get; set; }

    /// <summary>
    /// Message type for messaging services. E.g.: sms, facebook, twitter, line
    /// </summary>
    /// <value>Message type for messaging services. E.g.: sms, facebook, twitter, line</value>
    public string MessageType { get; set; }

    /// <summary>
    /// Indicates that the conversation originated from a public message on social media
    /// </summary>
    /// <value>Indicates that the conversation originated from a public message on social media</value>
    public bool? OriginatingSocialMediaPublic { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the outbound campaign
    /// </summary>
    /// <value>(Dialer) Unique identifier of the outbound campaign</value>
    public string OutboundCampaignId { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the contact
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact</value>
    public string OutboundContactId { get; set; }

    /// <summary>
    /// (Dialer) Unique identifier of the contact list that this contact belongs to
    /// </summary>
    /// <value>(Dialer) Unique identifier of the contact list that this contact belongs to</value>
    public string OutboundContactListId { get; set; }

    /// <summary>
    /// A human readable name identifying the participant
    /// </summary>
    /// <value>A human readable name identifying the participant</value>
    [JsonPropertyName("participantName")]
    public string ParticipantName { get; set; }

    /// <summary>
    /// This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.
    /// </summary>
    /// <value>This identifies pairs of related sessions on a conversation. E.g. an external session’s peerId will be the session that the call originally connected to, e.g. if an IVR was dialed, the IVR session, which will also have the external session’s ID as its peer. After that point, any transfers of that session to other internal components (acd, agent, etc.) will all spawn new sessions whose peerIds point back to that original external session.</value>
    public string PeerId { get; set; }

    /// <summary>
    /// The source provider for the communication.
    /// </summary>
    /// <value>The source provider for the communication.</value>
    public string Provider { get; set; }

    /// <summary>
    /// Queue identifier
    /// </summary>
    /// <value>Queue identifier</value>
    public string QueueId { get; set; }

    /// <summary>
    /// Name, phone number, or email address of the remote party.
    /// </summary>
    /// <value>Name, phone number, or email address of the remote party.</value>
    public string Remote { get; set; }

    /// <summary>
    /// ID(s) of Skill(s) that have been removed by bullseye routing
    /// </summary>
    /// <value>ID(s) of Skill(s) that have been removed by bullseye routing</value>
    public IEnumerable<string> RemovedSkillIds { get; set; }

    /// <summary>
    /// Unique identifier for the language requested for an interaction
    /// </summary>
    /// <value>Unique identifier for the language requested for an interaction</value>
    public string RequestedLanguageId { get; set; }

    /// <summary>
    /// Unique identifier(s) for skill(s) requested for an interaction
    /// </summary>
    /// <value>Unique identifier(s) for skill(s) requested for an interaction</value>
    public IEnumerable<string> RequestedRoutingSkillIds { get; set; }

    /// <summary>
    /// Routing type(s) for requested/attempted routing methods.
    /// </summary>
    /// <value>Routing type(s) for requested/attempted routing methods.</value>
    public IEnumerable<RequestedRoutingsEnum> RequestedRoutings { get; set; }

    /// <summary>
    /// Unique identifier for the room
    /// </summary>
    /// <value>Unique identifier for the room</value>
    public string RoomId { get; set; }

    /// <summary>
    /// Routing priority for the current interaction
    /// </summary>
    /// <value>Routing priority for the current interaction</value>
    public long? RoutingPriority { get; set; }

    /// <summary>
    /// Routing ring for bullseye or preferred agent routing
    /// </summary>
    /// <value>Routing ring for bullseye or preferred agent routing</value>
    public long? RoutingRing { get; set; }

    /// <summary>
    /// Routing rule for preferred, conditional and predictive routing type
    /// </summary>
    /// <value>Routing rule for preferred, conditional and predictive routing type</value>
    public string RoutingRule { get; set; }

    /// <summary>
    /// Selected agent ID
    /// </summary>
    /// <value>Selected agent ID</value>
    public string SelectedAgentId { get; set; }

    /// <summary>
    /// Selected agent GPR rank
    /// </summary>
    /// <value>Selected agent GPR rank</value>
    public long? SelectedAgentRank { get; set; }

    /// <summary>
    /// Indicates whether all flow sessions were self serviced
    /// </summary>
    /// <value>Indicates whether all flow sessions were self serviced</value>
    public bool? SelfServed { get; set; }

    /// <summary>
    /// Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred
    /// </summary>
    /// <value>Dialed number for the current session; this can be different from dnis, e.g. if the call was transferred</value>
    public string SessionDnis { get; set; }

    /// <summary>
    /// The unique identifier of this session
    /// </summary>
    /// <value>The unique identifier of this session</value>
    public string SessionId { get; set; }

    /// <summary>
    /// Unique identifier for a phone
    /// </summary>
    /// <value>Unique identifier for a phone</value>
    public string StationId { get; set; }

    /// <summary>
    /// The team ID the user is a member of
    /// </summary>
    /// <value>The team ID the user is a member of</value>
    public string TeamId { get; set; }

    /// <summary>
    /// Unique identifier for the user
    /// </summary>
    /// <value>Unique identifier for the user</value>
    public string UserId { get; set; }

    /// <summary>
    /// Flag indicating if video is present
    /// </summary>
    /// <value>Flag indicating if video is present</value>
    public bool? VideoPresent { get; set; }

    /// <summary>
    /// Number of waiting interactions for each predictive routing attempt
    /// </summary>
    /// <value>Number of waiting interactions for each predictive routing attempt</value>
    public IEnumerable<long?> WaitingInteractionCounts { get; set; }

    /// <summary>
    /// Wrap up code
    /// </summary>
    /// <value>Wrap up code</value>
    public string WrapUpCode { get; set; }

    /// <summary>
    /// Proposed agents
    /// </summary>
    /// <value>Proposed agents</value>
    public IEnumerable<ConversationMetricsTopicConversationProposedAgent> ProposedAgents { get; set; }

    /// <summary>
    /// Scored agents
    /// </summary>
    /// <value>Scored agents</value>
    public IEnumerable<ConversationMetricsTopicConversationScoredAgent> ScoredAgents { get; set; }
}
