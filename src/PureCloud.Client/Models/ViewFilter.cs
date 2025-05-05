using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ViewFilter
/// </summary>

public partial class ViewFilter : IEquatable<ViewFilter>
{
    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    
    public enum MediaTypesEnum
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
    /// Gets or Sets Directions
    /// </summary>
    
    public enum DirectionsEnum
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
    /// Gets or Sets OriginatingDirections
    /// </summary>
    
    public enum OriginatingDirectionsEnum
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
    /// Gets or Sets MessageTypes
    /// </summary>
    
    public enum MessageTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

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
        /// Enum Line for "line"
        /// </summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>
        /// Enum Facebook for "facebook"
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

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
        Open,

        /// <summary>
        /// Enum Instagram for "instagram"
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// Enum Apple for "apple"
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple
    }
    /// <summary>
    /// Gets or Sets FlowOutcomeValues
    /// </summary>
    
    public enum FlowOutcomeValuesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Success for "SUCCESS"
        /// </summary>
        [EnumMember(Value = "SUCCESS")]
        Success,

        /// <summary>
        /// Enum Failure for "FAILURE"
        /// </summary>
        [EnumMember(Value = "FAILURE")]
        Failure
    }
    /// <summary>
    /// Gets or Sets FlowDestinationTypes
    /// </summary>
    
    public enum FlowDestinationTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Acd for "ACD"
        /// </summary>
        [EnumMember(Value = "ACD")]
        Acd,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group,

        /// <summary>
        /// Enum Number for "NUMBER"
        /// </summary>
        [EnumMember(Value = "NUMBER")]
        Number,

        /// <summary>
        /// Enum Flow for "FLOW"
        /// </summary>
        [EnumMember(Value = "FLOW")]
        Flow,

        /// <summary>
        /// Enum SecureFlow for "SECURE_FLOW"
        /// </summary>
        [EnumMember(Value = "SECURE_FLOW")]
        SecureFlow,

        /// <summary>
        /// Enum AcdVoicemail for "ACD_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "ACD_VOICEMAIL")]
        AcdVoicemail,

        /// <summary>
        /// Enum UserVoicemail for "USER_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "USER_VOICEMAIL")]
        UserVoicemail,

        /// <summary>
        /// Enum GroupVoicemail for "GROUP_VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "GROUP_VOICEMAIL")]
        GroupVoicemail,

        /// <summary>
        /// Enum ReturnToAgent for "RETURN_TO_AGENT"
        /// </summary>
        [EnumMember(Value = "RETURN_TO_AGENT")]
        ReturnToAgent
    }
    /// <summary>
    /// Gets or Sets FlowDisconnectReasons
    /// </summary>
    
    public enum FlowDisconnectReasonsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum FlowDisconnect for "FLOW_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_DISCONNECT")]
        FlowDisconnect,

        /// <summary>
        /// Enum FlowErrorDisconnect for "FLOW_ERROR_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_ERROR_DISCONNECT")]
        FlowErrorDisconnect,

        /// <summary>
        /// Enum Disconnect for "DISCONNECT"
        /// </summary>
        [EnumMember(Value = "DISCONNECT")]
        Disconnect
    }
    /// <summary>
    /// Gets or Sets FlowTypes
    /// </summary>
    
    public enum FlowTypesEnum
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
    /// Gets or Sets FlowEntryTypes
    /// </summary>
    
    public enum FlowEntryTypesEnum
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
    /// Gets or Sets UsedRoutingTypes
    /// </summary>
    
    public enum UsedRoutingTypesEnum
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
    /// Gets or Sets RequestedRoutingTypes
    /// </summary>
    
    public enum RequestedRoutingTypesEnum
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
    /// Gets or Sets ParticipantPurposes
    /// </summary>
    
    public enum ParticipantPurposesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Internal for "internal"
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal,

        /// <summary>
        /// Enum External for "external"
        /// </summary>
        [EnumMember(Value = "external")]
        External
    }
    /// <summary>
    /// Gets or Sets JourneyActionMapTypes
    /// </summary>
    
    public enum JourneyActionMapTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Webchat for "webchat"
        /// </summary>
        [EnumMember(Value = "webchat")]
        Webchat,

        /// <summary>
        /// Enum Webmessagingoffer for "webMessagingOffer"
        /// </summary>
        [EnumMember(Value = "webMessagingOffer")]
        Webmessagingoffer,

        /// <summary>
        /// Enum Contentoffer for "contentOffer"
        /// </summary>
        [EnumMember(Value = "contentOffer")]
        Contentoffer,

        /// <summary>
        /// Enum Integrationaction for "integrationAction"
        /// </summary>
        [EnumMember(Value = "integrationAction")]
        Integrationaction,

        /// <summary>
        /// Enum Architectflow for "architectFlow"
        /// </summary>
        [EnumMember(Value = "architectFlow")]
        Architectflow,

        /// <summary>
        /// Enum Openaction for "openAction"
        /// </summary>
        [EnumMember(Value = "openAction")]
        Openaction
    }
    /// <summary>
    /// Gets or Sets DevelopmentRoleList
    /// </summary>
    
    public enum DevelopmentRoleListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Creator for "Creator"
        /// </summary>
        [EnumMember(Value = "Creator")]
        Creator,

        /// <summary>
        /// Enum Facilitator for "Facilitator"
        /// </summary>
        [EnumMember(Value = "Facilitator")]
        Facilitator,

        /// <summary>
        /// Enum Attendee for "Attendee"
        /// </summary>
        [EnumMember(Value = "Attendee")]
        Attendee
    }
    /// <summary>
    /// Gets or Sets DevelopmentTypeList
    /// </summary>
    
    public enum DevelopmentTypeListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Informational for "Informational"
        /// </summary>
        [EnumMember(Value = "Informational")]
        Informational,

        /// <summary>
        /// Enum Coaching for "Coaching"
        /// </summary>
        [EnumMember(Value = "Coaching")]
        Coaching,

        /// <summary>
        /// Enum Assessment for "Assessment"
        /// </summary>
        [EnumMember(Value = "Assessment")]
        Assessment,

        /// <summary>
        /// Enum Assessedcontent for "AssessedContent"
        /// </summary>
        [EnumMember(Value = "AssessedContent")]
        Assessedcontent,

        /// <summary>
        /// Enum External for "External"
        /// </summary>
        [EnumMember(Value = "External")]
        External,

        /// <summary>
        /// Enum Native for "Native"
        /// </summary>
        [EnumMember(Value = "Native")]
        Native
    }
    /// <summary>
    /// Gets or Sets DevelopmentStatusList
    /// </summary>
    
    public enum DevelopmentStatusListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Planned for "Planned"
        /// </summary>
        [EnumMember(Value = "Planned")]
        Planned,

        /// <summary>
        /// Enum Scheduled for "Scheduled"
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Invalidschedule for "InvalidSchedule"
        /// </summary>
        [EnumMember(Value = "InvalidSchedule")]
        Invalidschedule,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Notcompleted for "NotCompleted"
        /// </summary>
        [EnumMember(Value = "NotCompleted")]
        Notcompleted
    }
    /// <summary>
    /// Gets or Sets BotMessageTypes
    /// </summary>
    
    public enum BotMessageTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Phone for "Phone"
        /// </summary>
        [EnumMember(Value = "Phone")]
        Phone,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms,

        /// <summary>
        /// Enum Genesyschatwidget for "GenesysChatWidget"
        /// </summary>
        [EnumMember(Value = "GenesysChatWidget")]
        Genesyschatwidget,

        /// <summary>
        /// Enum Facebookmessenger for "FacebookMessenger"
        /// </summary>
        [EnumMember(Value = "FacebookMessenger")]
        Facebookmessenger,

        /// <summary>
        /// Enum Wechat for "WeChat"
        /// </summary>
        [EnumMember(Value = "WeChat")]
        Wechat,

        /// <summary>
        /// Enum Whatsapp for "Whatsapp"
        /// </summary>
        [EnumMember(Value = "Whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Applebusinesschat for "AppleBusinessChat"
        /// </summary>
        [EnumMember(Value = "AppleBusinessChat")]
        Applebusinesschat,

        /// <summary>
        /// Enum Telegram for "Telegram"
        /// </summary>
        [EnumMember(Value = "Telegram")]
        Telegram,

        /// <summary>
        /// Enum Slack for "Slack"
        /// </summary>
        [EnumMember(Value = "Slack")]
        Slack,

        /// <summary>
        /// Enum Signal for "Signal"
        /// </summary>
        [EnumMember(Value = "Signal")]
        Signal,

        /// <summary>
        /// Enum Line for "Line"
        /// </summary>
        [EnumMember(Value = "Line")]
        Line,

        /// <summary>
        /// Enum Discord for "Discord"
        /// </summary>
        [EnumMember(Value = "Discord")]
        Discord,

        /// <summary>
        /// Enum Twitterdirectmessage for "TwitterDirectMessage"
        /// </summary>
        [EnumMember(Value = "TwitterDirectMessage")]
        Twitterdirectmessage,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open,

        /// <summary>
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram,

        /// <summary>
        /// Enum Apple for "Apple"
        /// </summary>
        [EnumMember(Value = "Apple")]
        Apple,

        /// <summary>
        /// Enum Other for "Other"
        /// </summary>
        [EnumMember(Value = "Other")]
        Other
    }
    /// <summary>
    /// Gets or Sets BotProviderList
    /// </summary>
    
    public enum BotProviderListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Genesys for "Genesys"
        /// </summary>
        [EnumMember(Value = "Genesys")]
        Genesys,

        /// <summary>
        /// Enum Amazon for "Amazon"
        /// </summary>
        [EnumMember(Value = "Amazon")]
        Amazon,

        /// <summary>
        /// Enum Google for "Google"
        /// </summary>
        [EnumMember(Value = "Google")]
        Google,

        /// <summary>
        /// Enum Nuance for "Nuance"
        /// </summary>
        [EnumMember(Value = "Nuance")]
        Nuance
    }
    /// <summary>
    /// Gets or Sets BotProductList
    /// </summary>
    
    public enum BotProductListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Genesysdialogengine for "GenesysDialogEngine"
        /// </summary>
        [EnumMember(Value = "GenesysDialogEngine")]
        Genesysdialogengine,

        /// <summary>
        /// Enum Amazonlex for "AmazonLex"
        /// </summary>
        [EnumMember(Value = "AmazonLex")]
        Amazonlex,

        /// <summary>
        /// Enum Googledialogflow for "GoogleDialogFlow"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlow")]
        Googledialogflow,

        /// <summary>
        /// Enum Googledialogflowresell for "GoogleDialogFlowResell"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlowResell")]
        Googledialogflowresell,

        /// <summary>
        /// Enum Genesysbotflow for "GenesysBotFlow"
        /// </summary>
        [EnumMember(Value = "GenesysBotFlow")]
        Genesysbotflow,

        /// <summary>
        /// Enum Nuancedlg for "NuanceDlg"
        /// </summary>
        [EnumMember(Value = "NuanceDlg")]
        Nuancedlg,

        /// <summary>
        /// Enum Googledialogflowcx for "GoogleDialogFlowCx"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlowCx")]
        Googledialogflowcx,

        /// <summary>
        /// Enum Genesysbyob for "GenesysByob"
        /// </summary>
        [EnumMember(Value = "GenesysByob")]
        Genesysbyob,

        /// <summary>
        /// Enum Amazonlexv2 for "AmazonLexV2"
        /// </summary>
        [EnumMember(Value = "AmazonLexV2")]
        Amazonlexv2,

        /// <summary>
        /// Enum Googledialogflowcxresell for "GoogleDialogFlowCxResell"
        /// </summary>
        [EnumMember(Value = "GoogleDialogFlowCxResell")]
        Googledialogflowcxresell,

        /// <summary>
        /// Enum Googlesttbotflow for "GoogleSttBotFlow"
        /// </summary>
        [EnumMember(Value = "GoogleSttBotFlow")]
        Googlesttbotflow,

        /// <summary>
        /// Enum Microsoftsttbotflow for "MicrosoftSttBotFlow"
        /// </summary>
        [EnumMember(Value = "MicrosoftSttBotFlow")]
        Microsoftsttbotflow,

        /// <summary>
        /// Enum Audioconnector for "AudioConnector"
        /// </summary>
        [EnumMember(Value = "AudioConnector")]
        Audioconnector,

        /// <summary>
        /// Enum Botconnector for "BotConnector"
        /// </summary>
        [EnumMember(Value = "BotConnector")]
        Botconnector
    }
    /// <summary>
    /// Gets or Sets BotRecognitionFailureReasonList
    /// </summary>
    
    public enum BotRecognitionFailureReasonListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Noinputcollection for "NoInputCollection"
        /// </summary>
        [EnumMember(Value = "NoInputCollection")]
        Noinputcollection,

        /// <summary>
        /// Enum Noinputconfirmation for "NoInputConfirmation"
        /// </summary>
        [EnumMember(Value = "NoInputConfirmation")]
        Noinputconfirmation,

        /// <summary>
        /// Enum Noinputdisambiguation for "NoInputDisambiguation"
        /// </summary>
        [EnumMember(Value = "NoInputDisambiguation")]
        Noinputdisambiguation,

        /// <summary>
        /// Enum Nomatchcollection for "NoMatchCollection"
        /// </summary>
        [EnumMember(Value = "NoMatchCollection")]
        Nomatchcollection,

        /// <summary>
        /// Enum Nomatchconfirmation for "NoMatchConfirmation"
        /// </summary>
        [EnumMember(Value = "NoMatchConfirmation")]
        Nomatchconfirmation,

        /// <summary>
        /// Enum Nomatchdisambiguation for "NoMatchDisambiguation"
        /// </summary>
        [EnumMember(Value = "NoMatchDisambiguation")]
        Nomatchdisambiguation,

        /// <summary>
        /// Enum Maxwrongmatch for "MaxWrongMatch"
        /// </summary>
        [EnumMember(Value = "MaxWrongMatch")]
        Maxwrongmatch,

        /// <summary>
        /// Enum Alloptionsrejected for "AllOptionsRejected"
        /// </summary>
        [EnumMember(Value = "AllOptionsRejected")]
        Alloptionsrejected
    }
    /// <summary>
    /// Gets or Sets BotResultList
    /// </summary>
    
    public enum BotResultListEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Exitrequestedbyuser for "ExitRequestedByUser"
        /// </summary>
        [EnumMember(Value = "ExitRequestedByUser")]
        Exitrequestedbyuser,

        /// <summary>
        /// Enum Exitrequestedbybot for "ExitRequestedByBot"
        /// </summary>
        [EnumMember(Value = "ExitRequestedByBot")]
        Exitrequestedbybot,

        /// <summary>
        /// Enum Exiterror for "ExitError"
        /// </summary>
        [EnumMember(Value = "ExitError")]
        Exiterror,

        /// <summary>
        /// Enum Exitrecognitionfailure for "ExitRecognitionFailure"
        /// </summary>
        [EnumMember(Value = "ExitRecognitionFailure")]
        Exitrecognitionfailure,

        /// <summary>
        /// Enum Disconnectrequestedbyuser for "DisconnectRequestedByUser"
        /// </summary>
        [EnumMember(Value = "DisconnectRequestedByUser")]
        Disconnectrequestedbyuser,

        /// <summary>
        /// Enum Disconnectrequestedbybot for "DisconnectRequestedByBot"
        /// </summary>
        [EnumMember(Value = "DisconnectRequestedByBot")]
        Disconnectrequestedbybot,

        /// <summary>
        /// Enum Disconnectsessionexpired for "DisconnectSessionExpired"
        /// </summary>
        [EnumMember(Value = "DisconnectSessionExpired")]
        Disconnectsessionexpired,

        /// <summary>
        /// Enum Disconnecterror for "DisconnectError"
        /// </summary>
        [EnumMember(Value = "DisconnectError")]
        Disconnecterror,

        /// <summary>
        /// Enum Disconnectrecognitionfailure for "DisconnectRecognitionFailure"
        /// </summary>
        [EnumMember(Value = "DisconnectRecognitionFailure")]
        Disconnectrecognitionfailure,

        /// <summary>
        /// Enum Transfertoacd for "TransferToACD"
        /// </summary>
        [EnumMember(Value = "TransferToACD")]
        Transfertoacd
    }
    /// <summary>
    /// Gets or Sets BlockedReasons
    /// </summary>
    
    public enum BlockedReasonsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pageurlconditionsnotmatching for "PageUrlConditionsNotMatching"
        /// </summary>
        [EnumMember(Value = "PageUrlConditionsNotMatching")]
        Pageurlconditionsnotmatching,

        /// <summary>
        /// Enum Alreadyexistingoffer for "AlreadyExistingOffer"
        /// </summary>
        [EnumMember(Value = "AlreadyExistingOffer")]
        Alreadyexistingoffer,

        /// <summary>
        /// Enum Triggerdateinfuture for "TriggerDateInFuture"
        /// </summary>
        [EnumMember(Value = "TriggerDateInFuture")]
        Triggerdateinfuture,

        /// <summary>
        /// Enum Multiplesimultaneousoffers for "MultipleSimultaneousOffers"
        /// </summary>
        [EnumMember(Value = "MultipleSimultaneousOffers")]
        Multiplesimultaneousoffers,

        /// <summary>
        /// Enum Frequencycapping for "FrequencyCapping"
        /// </summary>
        [EnumMember(Value = "FrequencyCapping")]
        Frequencycapping,

        /// <summary>
        /// Enum Offeredoutsideschedule for "OfferedOutsideSchedule"
        /// </summary>
        [EnumMember(Value = "OfferedOutsideSchedule")]
        Offeredoutsideschedule,

        /// <summary>
        /// Enum Servicelevelthrottling for "ServiceLevelThrottling"
        /// </summary>
        [EnumMember(Value = "ServiceLevelThrottling")]
        Servicelevelthrottling,

        /// <summary>
        /// Enum Noavailableagents for "NoAvailableAgents"
        /// </summary>
        [EnumMember(Value = "NoAvailableAgents")]
        Noavailableagents
    }
    /// <summary>
    /// Gets or Sets EmailDeliveryStatusList
    /// </summary>
    
    public enum EmailDeliveryStatusListEnum
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
    /// Filter to indicate the availability of the dashboard is public or private.
    /// </summary>
    /// <value>Filter to indicate the availability of the dashboard is public or private.</value>
    
    public enum AvailableDashboardEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum Private for "Private"
        /// </summary>
        [EnumMember(Value = "Private")]
        Private
    }
    /// <summary>
    /// Gets or Sets EvaluationStatuses
    /// </summary>
    
    public enum EvaluationStatusesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Inreview for "InReview"
        /// </summary>
        [EnumMember(Value = "InReview")]
        Inreview,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Retracted for "Retracted"
        /// </summary>
        [EnumMember(Value = "Retracted")]
        Retracted
    }
    /// <summary>
    /// The user supplied state value in the view
    /// </summary>
    /// <value>The user supplied state value in the view</value>
    
    public enum UserStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Activeandinactive for "ActiveAndInactive"
        /// </summary>
        [EnumMember(Value = "ActiveAndInactive")]
        Activeandinactive,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// Gets or Sets SurveyTypes
    /// </summary>
    
    public enum SurveyTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Web for "Web"
        /// </summary>
        [EnumMember(Value = "Web")]
        Web,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// Gets or Sets SurveyResponseStatuses
    /// </summary>
    
    public enum SurveyResponseStatusesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Fullresponse for "FullResponse"
        /// </summary>
        [EnumMember(Value = "FullResponse")]
        Fullresponse,

        /// <summary>
        /// Enum Partialresponse for "PartialResponse"
        /// </summary>
        [EnumMember(Value = "PartialResponse")]
        Partialresponse
    }
    /// <summary>
    /// Gets or Sets BotFlowTypes
    /// </summary>
    
    public enum BotFlowTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown,

        /// <summary>
        /// Enum Bot for "Bot"
        /// </summary>
        [EnumMember(Value = "Bot")]
        Bot,

        /// <summary>
        /// Enum Digitalbot for "DigitalBot"
        /// </summary>
        [EnumMember(Value = "DigitalBot")]
        Digitalbot,

        /// <summary>
        /// Enum Voicesurvey for "VoiceSurvey"
        /// </summary>
        [EnumMember(Value = "VoiceSurvey")]
        Voicesurvey
    }
    /// <summary>
    /// The state of dashboard being filtered
    /// </summary>
    /// <value>The state of dashboard being filtered</value>
    
    public enum DashboardStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// The type of dashboard being filtered
    /// </summary>
    /// <value>The type of dashboard being filtered</value>
    
    public enum DashboardTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum Private for "Private"
        /// </summary>
        [EnumMember(Value = "Private")]
        Private,

        /// <summary>
        /// Enum Shared for "Shared"
        /// </summary>
        [EnumMember(Value = "Shared")]
        Shared,

        /// <summary>
        /// Enum Favorites for "Favorites"
        /// </summary>
        [EnumMember(Value = "Favorites")]
        Favorites
    }
    /// <summary>
    /// The type of dashboard access being filtered
    /// </summary>
    /// <value>The type of dashboard access being filtered</value>
    
    public enum DashboardAccessFilterEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Ownedbyme for "OwnedByMe"
        /// </summary>
        [EnumMember(Value = "OwnedByMe")]
        Ownedbyme,

        /// <summary>
        /// Enum Ownedbyanyone for "OwnedByAnyone"
        /// </summary>
        [EnumMember(Value = "OwnedByAnyone")]
        Ownedbyanyone,

        /// <summary>
        /// Enum Notownedbyme for "NotOwnedByMe"
        /// </summary>
        [EnumMember(Value = "NotOwnedByMe")]
        Notownedbyme
    }
    /// <summary>
    /// Gets or Sets SocialChannels
    /// </summary>
    
    public enum SocialChannelsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Twitter for "Twitter"
        /// </summary>
        [EnumMember(Value = "Twitter")]
        Twitter,

        /// <summary>
        /// Enum Facebook for "Facebook"
        /// </summary>
        [EnumMember(Value = "Facebook")]
        Facebook,

        /// <summary>
        /// Enum Instagram for "Instagram"
        /// </summary>
        [EnumMember(Value = "Instagram")]
        Instagram,

        /// <summary>
        /// Enum Open for "Open"
        /// </summary>
        [EnumMember(Value = "Open")]
        Open
    }
    /// <summary>
    /// Gets or Sets SocialSentimentCategory
    /// </summary>
    
    public enum SocialSentimentCategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Neutral for "Neutral"
        /// </summary>
        [EnumMember(Value = "Neutral")]
        Neutral,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// Gets or Sets SocialContentType
    /// </summary>
    
    public enum SocialContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Image for "Image"
        /// </summary>
        [EnumMember(Value = "Image")]
        Image,

        /// <summary>
        /// Enum Video for "Video"
        /// </summary>
        [EnumMember(Value = "Video")]
        Video
    }
    /// <summary>
    /// Gets or Sets SocialClassifications
    /// </summary>
    
    public enum SocialClassificationsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Public for "Public"
        /// </summary>
        [EnumMember(Value = "Public")]
        Public,

        /// <summary>
        /// Enum Private for "Private"
        /// </summary>
        [EnumMember(Value = "Private")]
        Private
    }
    /// <summary>
    /// Gets or Sets RecommendationSources
    /// </summary>
    
    public enum RecommendationSourcesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Knowledgesearch for "KnowledgeSearch"
        /// </summary>
        [EnumMember(Value = "KnowledgeSearch")]
        Knowledgesearch,

        /// <summary>
        /// Enum Rulesengine for "RulesEngine"
        /// </summary>
        [EnumMember(Value = "RulesEngine")]
        Rulesengine,

        /// <summary>
        /// Enum Manualsearch for "ManualSearch"
        /// </summary>
        [EnumMember(Value = "ManualSearch")]
        Manualsearch
    }
    /// <summary>
    /// Sets the role when viewing agent evaluations
    /// </summary>
    /// <value>Sets the role when viewing agent evaluations</value>
    
    public enum EvaluationRoleEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Evaluator for "Evaluator"
        /// </summary>
        [EnumMember(Value = "Evaluator")]
        Evaluator,

        /// <summary>
        /// Enum Supervisor for "Supervisor"
        /// </summary>
        [EnumMember(Value = "Supervisor")]
        Supervisor
    }
    /// <summary>
    /// Gets or Sets ViewMetrics
    /// </summary>
    
    public enum ViewMetricsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum AvgTalkTime for "AVG_TALK_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_TALK_TIME")]
        AvgTalkTime,

        /// <summary>
        /// Enum AvgHoldTime for "AVG_HOLD_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_HOLD_TIME")]
        AvgHoldTime,

        /// <summary>
        /// Enum AvgAcwTime for "AVG_ACW_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_ACW_TIME")]
        AvgAcwTime,

        /// <summary>
        /// Enum AvgWaitTime for "AVG_WAIT_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_WAIT_TIME")]
        AvgWaitTime,

        /// <summary>
        /// Enum AvgHandleTime for "AVG_HANDLE_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_HANDLE_TIME")]
        AvgHandleTime,

        /// <summary>
        /// Enum AvgAlertTime for "AVG_ALERT_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_ALERT_TIME")]
        AvgAlertTime,

        /// <summary>
        /// Enum AvgAnswerTime for "AVG_ANSWER_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_ANSWER_TIME")]
        AvgAnswerTime,

        /// <summary>
        /// Enum AvgAbandonTime for "AVG_ABANDON_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_ABANDON_TIME")]
        AvgAbandonTime,

        /// <summary>
        /// Enum TotalTalkTime for "TOTAL_TALK_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_TALK_TIME")]
        TotalTalkTime,

        /// <summary>
        /// Enum TotalHandleTime for "TOTAL_HANDLE_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_HANDLE_TIME")]
        TotalHandleTime,

        /// <summary>
        /// Enum TotalHoldTime for "TOTAL_HOLD_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_HOLD_TIME")]
        TotalHoldTime,

        /// <summary>
        /// Enum TotalAcwTime for "TOTAL_ACW_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_ACW_TIME")]
        TotalAcwTime,

        /// <summary>
        /// Enum TotalAlertTime for "TOTAL_ALERT_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_ALERT_TIME")]
        TotalAlertTime,

        /// <summary>
        /// Enum MaxAbandonTime for "MAX_ABANDON_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_ABANDON_TIME")]
        MaxAbandonTime,

        /// <summary>
        /// Enum MaxWaitTime for "MAX_WAIT_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_WAIT_TIME")]
        MaxWaitTime,

        /// <summary>
        /// Enum MaxTalkTime for "MAX_TALK_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_TALK_TIME")]
        MaxTalkTime,

        /// <summary>
        /// Enum MaxHoldTime for "MAX_HOLD_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_HOLD_TIME")]
        MaxHoldTime,

        /// <summary>
        /// Enum MaxAcwTime for "MAX_ACW_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_ACW_TIME")]
        MaxAcwTime,

        /// <summary>
        /// Enum MinAbandonTime for "MIN_ABANDON_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_ABANDON_TIME")]
        MinAbandonTime,

        /// <summary>
        /// Enum MinWaitTime for "MIN_WAIT_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_WAIT_TIME")]
        MinWaitTime,

        /// <summary>
        /// Enum MinTalkTime for "MIN_TALK_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_TALK_TIME")]
        MinTalkTime,

        /// <summary>
        /// Enum MinHoldTime for "MIN_HOLD_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_HOLD_TIME")]
        MinHoldTime,

        /// <summary>
        /// Enum MinAcwTime for "MIN_ACW_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_ACW_TIME")]
        MinAcwTime,

        /// <summary>
        /// Enum AlertCount for "ALERT_COUNT"
        /// </summary>
        [EnumMember(Value = "ALERT_COUNT")]
        AlertCount,

        /// <summary>
        /// Enum OfferedCount for "OFFERED_COUNT"
        /// </summary>
        [EnumMember(Value = "OFFERED_COUNT")]
        OfferedCount,

        /// <summary>
        /// Enum AbandonedCount for "ABANDONED_COUNT"
        /// </summary>
        [EnumMember(Value = "ABANDONED_COUNT")]
        AbandonedCount,

        /// <summary>
        /// Enum AbandonedPercent for "ABANDONED_PERCENT"
        /// </summary>
        [EnumMember(Value = "ABANDONED_PERCENT")]
        AbandonedPercent,

        /// <summary>
        /// Enum ShortAbandonedCount for "SHORT_ABANDONED_COUNT"
        /// </summary>
        [EnumMember(Value = "SHORT_ABANDONED_COUNT")]
        ShortAbandonedCount,

        /// <summary>
        /// Enum ShortAbandonedPercent for "SHORT_ABANDONED_PERCENT"
        /// </summary>
        [EnumMember(Value = "SHORT_ABANDONED_PERCENT")]
        ShortAbandonedPercent,

        /// <summary>
        /// Enum AbandonedNoShortCount for "ABANDONED_NO_SHORT_COUNT"
        /// </summary>
        [EnumMember(Value = "ABANDONED_NO_SHORT_COUNT")]
        AbandonedNoShortCount,

        /// <summary>
        /// Enum AbandonedNoShortPercent for "ABANDONED_NO_SHORT_PERCENT"
        /// </summary>
        [EnumMember(Value = "ABANDONED_NO_SHORT_PERCENT")]
        AbandonedNoShortPercent,

        /// <summary>
        /// Enum AnsweredCount for "ANSWERED_COUNT"
        /// </summary>
        [EnumMember(Value = "ANSWERED_COUNT")]
        AnsweredCount,

        /// <summary>
        /// Enum AnsweredPercent for "ANSWERED_PERCENT"
        /// </summary>
        [EnumMember(Value = "ANSWERED_PERCENT")]
        AnsweredPercent,

        /// <summary>
        /// Enum FlowoutCount for "FLOWOUT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOWOUT_COUNT")]
        FlowoutCount,

        /// <summary>
        /// Enum FlowoutPercent for "FLOWOUT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOWOUT_PERCENT")]
        FlowoutPercent,

        /// <summary>
        /// Enum OutboundCount for "OUTBOUND_COUNT"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_COUNT")]
        OutboundCount,

        /// <summary>
        /// Enum OutboundAttemptedCount for "OUTBOUND_ATTEMPTED_COUNT"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_ATTEMPTED_COUNT")]
        OutboundAttemptedCount,

        /// <summary>
        /// Enum VoicemailCount for "VOICEMAIL_COUNT"
        /// </summary>
        [EnumMember(Value = "VOICEMAIL_COUNT")]
        VoicemailCount,

        /// <summary>
        /// Enum HandledCount for "HANDLED_COUNT"
        /// </summary>
        [EnumMember(Value = "HANDLED_COUNT")]
        HandledCount,

        /// <summary>
        /// Enum HeldCount for "HELD_COUNT"
        /// </summary>
        [EnumMember(Value = "HELD_COUNT")]
        HeldCount,

        /// <summary>
        /// Enum TransferredCount for "TRANSFERRED_COUNT"
        /// </summary>
        [EnumMember(Value = "TRANSFERRED_COUNT")]
        TransferredCount,

        /// <summary>
        /// Enum TransferredPercent for "TRANSFERRED_PERCENT"
        /// </summary>
        [EnumMember(Value = "TRANSFERRED_PERCENT")]
        TransferredPercent,

        /// <summary>
        /// Enum WaitingCurrent for "WAITING_CURRENT"
        /// </summary>
        [EnumMember(Value = "WAITING_CURRENT")]
        WaitingCurrent,

        /// <summary>
        /// Enum InteractingCurrent for "INTERACTING_CURRENT"
        /// </summary>
        [EnumMember(Value = "INTERACTING_CURRENT")]
        InteractingCurrent,

        /// <summary>
        /// Enum HeldCurrent for "HELD_CURRENT"
        /// </summary>
        [EnumMember(Value = "HELD_CURRENT")]
        HeldCurrent,

        /// <summary>
        /// Enum AlertingCurrent for "ALERTING_CURRENT"
        /// </summary>
        [EnumMember(Value = "ALERTING_CURRENT")]
        AlertingCurrent,

        /// <summary>
        /// Enum ServiceLevel for "SERVICE_LEVEL"
        /// </summary>
        [EnumMember(Value = "SERVICE_LEVEL")]
        ServiceLevel,

        /// <summary>
        /// Enum OverServiceLevel for "OVER_SERVICE_LEVEL"
        /// </summary>
        [EnumMember(Value = "OVER_SERVICE_LEVEL")]
        OverServiceLevel,

        /// <summary>
        /// Enum OnlineAgents for "ONLINE_AGENTS"
        /// </summary>
        [EnumMember(Value = "ONLINE_AGENTS")]
        OnlineAgents,

        /// <summary>
        /// Enum AvailableAgents for "AVAILABLE_AGENTS"
        /// </summary>
        [EnumMember(Value = "AVAILABLE_AGENTS")]
        AvailableAgents,

        /// <summary>
        /// Enum AwayAgents for "AWAY_AGENTS"
        /// </summary>
        [EnumMember(Value = "AWAY_AGENTS")]
        AwayAgents,

        /// <summary>
        /// Enum BreakAgents for "BREAK_AGENTS"
        /// </summary>
        [EnumMember(Value = "BREAK_AGENTS")]
        BreakAgents,

        /// <summary>
        /// Enum MealAgents for "MEAL_AGENTS"
        /// </summary>
        [EnumMember(Value = "MEAL_AGENTS")]
        MealAgents,

        /// <summary>
        /// Enum TrainingAgents for "TRAINING_AGENTS"
        /// </summary>
        [EnumMember(Value = "TRAINING_AGENTS")]
        TrainingAgents,

        /// <summary>
        /// Enum BusyAgents for "BUSY_AGENTS"
        /// </summary>
        [EnumMember(Value = "BUSY_AGENTS")]
        BusyAgents,

        /// <summary>
        /// Enum MeetingAgents for "MEETING_AGENTS"
        /// </summary>
        [EnumMember(Value = "MEETING_AGENTS")]
        MeetingAgents,

        /// <summary>
        /// Enum SystemAwayAgents for "SYSTEM_AWAY_AGENTS"
        /// </summary>
        [EnumMember(Value = "SYSTEM_AWAY_AGENTS")]
        SystemAwayAgents,

        /// <summary>
        /// Enum OfflineAgents for "OFFLINE_AGENTS"
        /// </summary>
        [EnumMember(Value = "OFFLINE_AGENTS")]
        OfflineAgents,

        /// <summary>
        /// Enum OnQueueAgents for "ON_QUEUE_AGENTS"
        /// </summary>
        [EnumMember(Value = "ON_QUEUE_AGENTS")]
        OnQueueAgents,

        /// <summary>
        /// Enum OffQueueAgents for "OFF_QUEUE_AGENTS"
        /// </summary>
        [EnumMember(Value = "OFF_QUEUE_AGENTS")]
        OffQueueAgents,

        /// <summary>
        /// Enum InteractingAgents for "INTERACTING_AGENTS"
        /// </summary>
        [EnumMember(Value = "INTERACTING_AGENTS")]
        InteractingAgents,

        /// <summary>
        /// Enum AcwAgents for "ACW_AGENTS"
        /// </summary>
        [EnumMember(Value = "ACW_AGENTS")]
        AcwAgents,

        /// <summary>
        /// Enum CommunicatingAgents for "COMMUNICATING_AGENTS"
        /// </summary>
        [EnumMember(Value = "COMMUNICATING_AGENTS")]
        CommunicatingAgents,

        /// <summary>
        /// Enum IdleAgents for "IDLE_AGENTS"
        /// </summary>
        [EnumMember(Value = "IDLE_AGENTS")]
        IdleAgents,

        /// <summary>
        /// Enum NotRespondingAgents for "NOT_RESPONDING_AGENTS"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING_AGENTS")]
        NotRespondingAgents,

        /// <summary>
        /// Enum LongestWaiting for "LONGEST_WAITING"
        /// </summary>
        [EnumMember(Value = "LONGEST_WAITING")]
        LongestWaiting,

        /// <summary>
        /// Enum LongestInteracting for "LONGEST_INTERACTING"
        /// </summary>
        [EnumMember(Value = "LONGEST_INTERACTING")]
        LongestInteracting,

        /// <summary>
        /// Enum FlowActiveLongest for "FLOW_ACTIVE_LONGEST"
        /// </summary>
        [EnumMember(Value = "FLOW_ACTIVE_LONGEST")]
        FlowActiveLongest,

        /// <summary>
        /// Enum FlowActiveCurrent for "FLOW_ACTIVE_CURRENT"
        /// </summary>
        [EnumMember(Value = "FLOW_ACTIVE_CURRENT")]
        FlowActiveCurrent,

        /// <summary>
        /// Enum FlowEntriesCount for "FLOW_ENTRIES_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_ENTRIES_COUNT")]
        FlowEntriesCount,

        /// <summary>
        /// Enum FlowTotalDuration for "FLOW_TOTAL_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_TOTAL_DURATION")]
        FlowTotalDuration,

        /// <summary>
        /// Enum FlowMaxDuration for "FLOW_MAX_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_MAX_DURATION")]
        FlowMaxDuration,

        /// <summary>
        /// Enum FlowAvgDuration for "FLOW_AVG_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_AVG_DURATION")]
        FlowAvgDuration,

        /// <summary>
        /// Enum FlowDisconnectCount for "FLOW_DISCONNECT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_DISCONNECT_COUNT")]
        FlowDisconnectCount,

        /// <summary>
        /// Enum FlowDisconnectPercent for "FLOW_DISCONNECT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_DISCONNECT_PERCENT")]
        FlowDisconnectPercent,

        /// <summary>
        /// Enum FlowTotalDisconnectDuration for "FLOW_TOTAL_DISCONNECT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_TOTAL_DISCONNECT_DURATION")]
        FlowTotalDisconnectDuration,

        /// <summary>
        /// Enum FlowAvgDisconnectDuration for "FLOW_AVG_DISCONNECT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_AVG_DISCONNECT_DURATION")]
        FlowAvgDisconnectDuration,

        /// <summary>
        /// Enum FlowMaxDisconnectDuration for "FLOW_MAX_DISCONNECT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_MAX_DISCONNECT_DURATION")]
        FlowMaxDisconnectDuration,

        /// <summary>
        /// Enum FlowFlowDisconnect for "FLOW_FLOW_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_FLOW_DISCONNECT")]
        FlowFlowDisconnect,

        /// <summary>
        /// Enum FlowFlowDisconnectPercent for "FLOW_FLOW_DISCONNECT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_FLOW_DISCONNECT_PERCENT")]
        FlowFlowDisconnectPercent,

        /// <summary>
        /// Enum FlowSystemErrorDisconnect for "FLOW_SYSTEM_ERROR_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT")]
        FlowSystemErrorDisconnect,

        /// <summary>
        /// Enum FlowSystemErrorDisconnectPercent for "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_SYSTEM_ERROR_DISCONNECT_PERCENT")]
        FlowSystemErrorDisconnectPercent,

        /// <summary>
        /// Enum FlowCustomerDisconnect for "FLOW_CUSTOMER_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT")]
        FlowCustomerDisconnect,

        /// <summary>
        /// Enum FlowCustomerDisconnectPercent for "FLOW_CUSTOMER_DISCONNECT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_CUSTOMER_DISCONNECT_PERCENT")]
        FlowCustomerDisconnectPercent,

        /// <summary>
        /// Enum FlowShortDisconnect for "FLOW_SHORT_DISCONNECT"
        /// </summary>
        [EnumMember(Value = "FLOW_SHORT_DISCONNECT")]
        FlowShortDisconnect,

        /// <summary>
        /// Enum FlowShortDisconnectPercent for "FLOW_SHORT_DISCONNECT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_SHORT_DISCONNECT_PERCENT")]
        FlowShortDisconnectPercent,

        /// <summary>
        /// Enum FlowExitCount for "FLOW_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_EXIT_COUNT")]
        FlowExitCount,

        /// <summary>
        /// Enum FlowExitPercent for "FLOW_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_EXIT_PERCENT")]
        FlowExitPercent,

        /// <summary>
        /// Enum FlowTotalExitDuration for "FLOW_TOTAL_EXIT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_TOTAL_EXIT_DURATION")]
        FlowTotalExitDuration,

        /// <summary>
        /// Enum FlowMaxExitDuration for "FLOW_MAX_EXIT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_MAX_EXIT_DURATION")]
        FlowMaxExitDuration,

        /// <summary>
        /// Enum FlowAvgExitDuration for "FLOW_AVG_EXIT_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_AVG_EXIT_DURATION")]
        FlowAvgExitDuration,

        /// <summary>
        /// Enum FlowAcdExitCount for "FLOW_ACD_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_ACD_EXIT_COUNT")]
        FlowAcdExitCount,

        /// <summary>
        /// Enum FlowAcdExitPercent for "FLOW_ACD_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_ACD_EXIT_PERCENT")]
        FlowAcdExitPercent,

        /// <summary>
        /// Enum FlowGroupExitCount for "FLOW_GROUP_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_GROUP_EXIT_COUNT")]
        FlowGroupExitCount,

        /// <summary>
        /// Enum FlowGroupExitPercent for "FLOW_GROUP_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_GROUP_EXIT_PERCENT")]
        FlowGroupExitPercent,

        /// <summary>
        /// Enum FlowNumberExitCount for "FLOW_NUMBER_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_NUMBER_EXIT_COUNT")]
        FlowNumberExitCount,

        /// <summary>
        /// Enum FlowNumberExitPercent for "FLOW_NUMBER_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_NUMBER_EXIT_PERCENT")]
        FlowNumberExitPercent,

        /// <summary>
        /// Enum FlowUserExitCount for "FLOW_USER_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_USER_EXIT_COUNT")]
        FlowUserExitCount,

        /// <summary>
        /// Enum FlowUserExitPercent for "FLOW_USER_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_USER_EXIT_PERCENT")]
        FlowUserExitPercent,

        /// <summary>
        /// Enum FlowFlowExitCount for "FLOW_FLOW_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_FLOW_EXIT_COUNT")]
        FlowFlowExitCount,

        /// <summary>
        /// Enum FlowFlowExitPercent for "FLOW_FLOW_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_FLOW_EXIT_PERCENT")]
        FlowFlowExitPercent,

        /// <summary>
        /// Enum FlowSecureFlowExitCount for "FLOW_SECURE_FLOW_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_COUNT")]
        FlowSecureFlowExitCount,

        /// <summary>
        /// Enum FlowSecureFlowExitPercent for "FLOW_SECURE_FLOW_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_SECURE_FLOW_EXIT_PERCENT")]
        FlowSecureFlowExitPercent,

        /// <summary>
        /// Enum FlowAcdVoicemailExitCount for "FLOW_ACD_VOICEMAIL_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_COUNT")]
        FlowAcdVoicemailExitCount,

        /// <summary>
        /// Enum FlowAcdVoicemailExitPercent for "FLOW_ACD_VOICEMAIL_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_ACD_VOICEMAIL_EXIT_PERCENT")]
        FlowAcdVoicemailExitPercent,

        /// <summary>
        /// Enum FlowUserVoicemailExitCount for "FLOW_USER_VOICEMAIL_EXIT_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_COUNT")]
        FlowUserVoicemailExitCount,

        /// <summary>
        /// Enum FlowUserVoicemailExitPercent for "FLOW_USER_VOICEMAIL_EXIT_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_USER_VOICEMAIL_EXIT_PERCENT")]
        FlowUserVoicemailExitPercent,

        /// <summary>
        /// Enum FlowOutcomeCount for "FLOW_OUTCOME_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_COUNT")]
        FlowOutcomeCount,

        /// <summary>
        /// Enum FlowAvgOutcomeDecimal for "FLOW_AVG_OUTCOME_DECIMAL"
        /// </summary>
        [EnumMember(Value = "FLOW_AVG_OUTCOME_DECIMAL")]
        FlowAvgOutcomeDecimal,

        /// <summary>
        /// Enum FlowOutcomeFailureCount for "FLOW_OUTCOME_FAILURE_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_FAILURE_COUNT")]
        FlowOutcomeFailureCount,

        /// <summary>
        /// Enum FlowOutcomeFailurePercent for "FLOW_OUTCOME_FAILURE_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_FAILURE_PERCENT")]
        FlowOutcomeFailurePercent,

        /// <summary>
        /// Enum FlowOutcomeSuccessCount for "FLOW_OUTCOME_SUCCESS_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_COUNT")]
        FlowOutcomeSuccessCount,

        /// <summary>
        /// Enum FlowOutcomeSuccessPercent for "FLOW_OUTCOME_SUCCESS_PERCENT"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_SUCCESS_PERCENT")]
        FlowOutcomeSuccessPercent,

        /// <summary>
        /// Enum FlowOutcomeTotalDuration for "FLOW_OUTCOME_TOTAL_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_TOTAL_DURATION")]
        FlowOutcomeTotalDuration,

        /// <summary>
        /// Enum FlowOutcomeMaxDuration for "FLOW_OUTCOME_MAX_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_MAX_DURATION")]
        FlowOutcomeMaxDuration,

        /// <summary>
        /// Enum FlowOutcomeAvgDuration for "FLOW_OUTCOME_AVG_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_AVG_DURATION")]
        FlowOutcomeAvgDuration,

        /// <summary>
        /// Enum FlowOutcomeMinDuration for "FLOW_OUTCOME_MIN_DURATION"
        /// </summary>
        [EnumMember(Value = "FLOW_OUTCOME_MIN_DURATION")]
        FlowOutcomeMinDuration,

        /// <summary>
        /// Enum OffQueueTime for "OFF_QUEUE_TIME"
        /// </summary>
        [EnumMember(Value = "OFF_QUEUE_TIME")]
        OffQueueTime,

        /// <summary>
        /// Enum OffQueuePercent for "OFF_QUEUE_PERCENT"
        /// </summary>
        [EnumMember(Value = "OFF_QUEUE_PERCENT")]
        OffQueuePercent,

        /// <summary>
        /// Enum AvailableTime for "AVAILABLE_TIME"
        /// </summary>
        [EnumMember(Value = "AVAILABLE_TIME")]
        AvailableTime,

        /// <summary>
        /// Enum AvailablePercent for "AVAILABLE_PERCENT"
        /// </summary>
        [EnumMember(Value = "AVAILABLE_PERCENT")]
        AvailablePercent,

        /// <summary>
        /// Enum BusyTime for "BUSY_TIME"
        /// </summary>
        [EnumMember(Value = "BUSY_TIME")]
        BusyTime,

        /// <summary>
        /// Enum BusyPercent for "BUSY_PERCENT"
        /// </summary>
        [EnumMember(Value = "BUSY_PERCENT")]
        BusyPercent,

        /// <summary>
        /// Enum AwayTime for "AWAY_TIME"
        /// </summary>
        [EnumMember(Value = "AWAY_TIME")]
        AwayTime,

        /// <summary>
        /// Enum AwayPercent for "AWAY_PERCENT"
        /// </summary>
        [EnumMember(Value = "AWAY_PERCENT")]
        AwayPercent,

        /// <summary>
        /// Enum BreakTime for "BREAK_TIME"
        /// </summary>
        [EnumMember(Value = "BREAK_TIME")]
        BreakTime,

        /// <summary>
        /// Enum BreakPercent for "BREAK_PERCENT"
        /// </summary>
        [EnumMember(Value = "BREAK_PERCENT")]
        BreakPercent,

        /// <summary>
        /// Enum MealTime for "MEAL_TIME"
        /// </summary>
        [EnumMember(Value = "MEAL_TIME")]
        MealTime,

        /// <summary>
        /// Enum MealPercent for "MEAL_PERCENT"
        /// </summary>
        [EnumMember(Value = "MEAL_PERCENT")]
        MealPercent,

        /// <summary>
        /// Enum MeetingTime for "MEETING_TIME"
        /// </summary>
        [EnumMember(Value = "MEETING_TIME")]
        MeetingTime,

        /// <summary>
        /// Enum MeetingPercent for "MEETING_PERCENT"
        /// </summary>
        [EnumMember(Value = "MEETING_PERCENT")]
        MeetingPercent,

        /// <summary>
        /// Enum TrainingTime for "TRAINING_TIME"
        /// </summary>
        [EnumMember(Value = "TRAINING_TIME")]
        TrainingTime,

        /// <summary>
        /// Enum TrainingPercent for "TRAINING_PERCENT"
        /// </summary>
        [EnumMember(Value = "TRAINING_PERCENT")]
        TrainingPercent,

        /// <summary>
        /// Enum InteractingTime for "INTERACTING_TIME"
        /// </summary>
        [EnumMember(Value = "INTERACTING_TIME")]
        InteractingTime,

        /// <summary>
        /// Enum InteractingPercent for "INTERACTING_PERCENT"
        /// </summary>
        [EnumMember(Value = "INTERACTING_PERCENT")]
        InteractingPercent,

        /// <summary>
        /// Enum CommunicatingTime for "COMMUNICATING_TIME"
        /// </summary>
        [EnumMember(Value = "COMMUNICATING_TIME")]
        CommunicatingTime,

        /// <summary>
        /// Enum CommunicatingPercent for "COMMUNICATING_PERCENT"
        /// </summary>
        [EnumMember(Value = "COMMUNICATING_PERCENT")]
        CommunicatingPercent,

        /// <summary>
        /// Enum SystemAwayTime for "SYSTEM_AWAY_TIME"
        /// </summary>
        [EnumMember(Value = "SYSTEM_AWAY_TIME")]
        SystemAwayTime,

        /// <summary>
        /// Enum SystemAwayPercent for "SYSTEM_AWAY_PERCENT"
        /// </summary>
        [EnumMember(Value = "SYSTEM_AWAY_PERCENT")]
        SystemAwayPercent,

        /// <summary>
        /// Enum OnQueueTime for "ON_QUEUE_TIME"
        /// </summary>
        [EnumMember(Value = "ON_QUEUE_TIME")]
        OnQueueTime,

        /// <summary>
        /// Enum OnQueuePercent for "ON_QUEUE_PERCENT"
        /// </summary>
        [EnumMember(Value = "ON_QUEUE_PERCENT")]
        OnQueuePercent,

        /// <summary>
        /// Enum IdleTime for "IDLE_TIME"
        /// </summary>
        [EnumMember(Value = "IDLE_TIME")]
        IdleTime,

        /// <summary>
        /// Enum IdlePercent for "IDLE_PERCENT"
        /// </summary>
        [EnumMember(Value = "IDLE_PERCENT")]
        IdlePercent,

        /// <summary>
        /// Enum NotRespondingTime for "NOT_RESPONDING_TIME"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING_TIME")]
        NotRespondingTime,

        /// <summary>
        /// Enum NotRespondingPercent for "NOT_RESPONDING_PERCENT"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING_PERCENT")]
        NotRespondingPercent,

        /// <summary>
        /// Enum LoggedInTime for "LOGGED_IN_TIME"
        /// </summary>
        [EnumMember(Value = "LOGGED_IN_TIME")]
        LoggedInTime,

        /// <summary>
        /// Enum OccupancyPercent for "OCCUPANCY_PERCENT"
        /// </summary>
        [EnumMember(Value = "OCCUPANCY_PERCENT")]
        OccupancyPercent,

        /// <summary>
        /// Enum MinAlertTime for "MIN_ALERT_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_ALERT_TIME")]
        MinAlertTime,

        /// <summary>
        /// Enum MaxAlertTime for "MAX_ALERT_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_ALERT_TIME")]
        MaxAlertTime,

        /// <summary>
        /// Enum MinHandleTime for "MIN_HANDLE_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_HANDLE_TIME")]
        MinHandleTime,

        /// <summary>
        /// Enum MaxHandleTime for "MAX_HANDLE_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_HANDLE_TIME")]
        MaxHandleTime,

        /// <summary>
        /// Enum MinAnsweredTime for "MIN_ANSWERED_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_ANSWERED_TIME")]
        MinAnsweredTime,

        /// <summary>
        /// Enum MaxAnsweredTime for "MAX_ANSWERED_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_ANSWERED_TIME")]
        MaxAnsweredTime,

        /// <summary>
        /// Enum MinNotRespondingTime for "MIN_NOT_RESPONDING_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_NOT_RESPONDING_TIME")]
        MinNotRespondingTime,

        /// <summary>
        /// Enum MaxNotRespondingTime for "MAX_NOT_RESPONDING_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_NOT_RESPONDING_TIME")]
        MaxNotRespondingTime,

        /// <summary>
        /// Enum MetServiceLevel for "MET_SERVICE_LEVEL"
        /// </summary>
        [EnumMember(Value = "MET_SERVICE_LEVEL")]
        MetServiceLevel,

        /// <summary>
        /// Enum WfmAdherenceStatus for "WFM_ADHERENCE_STATUS"
        /// </summary>
        [EnumMember(Value = "WFM_ADHERENCE_STATUS")]
        WfmAdherenceStatus,

        /// <summary>
        /// Enum WfmScheduledActivity for "WFM_SCHEDULED_ACTIVITY"
        /// </summary>
        [EnumMember(Value = "WFM_SCHEDULED_ACTIVITY")]
        WfmScheduledActivity,

        /// <summary>
        /// Enum WfmAdherenceDuration for "WFM_ADHERENCE_DURATION"
        /// </summary>
        [EnumMember(Value = "WFM_ADHERENCE_DURATION")]
        WfmAdherenceDuration,

        /// <summary>
        /// Enum AgentTitle for "AGENT_TITLE"
        /// </summary>
        [EnumMember(Value = "AGENT_TITLE")]
        AgentTitle,

        /// <summary>
        /// Enum AgentDepartment for "AGENT_DEPARTMENT"
        /// </summary>
        [EnumMember(Value = "AGENT_DEPARTMENT")]
        AgentDepartment,

        /// <summary>
        /// Enum AgentExtension for "AGENT_EXTENSION"
        /// </summary>
        [EnumMember(Value = "AGENT_EXTENSION")]
        AgentExtension,

        /// <summary>
        /// Enum AgentSkills for "AGENT_SKILLS"
        /// </summary>
        [EnumMember(Value = "AGENT_SKILLS")]
        AgentSkills,

        /// <summary>
        /// Enum AgentLocation for "AGENT_LOCATION"
        /// </summary>
        [EnumMember(Value = "AGENT_LOCATION")]
        AgentLocation,

        /// <summary>
        /// Enum AgentReportsTo for "AGENT_REPORTS_TO"
        /// </summary>
        [EnumMember(Value = "AGENT_REPORTS_TO")]
        AgentReportsTo,

        /// <summary>
        /// Enum AgentEmail for "AGENT_EMAIL"
        /// </summary>
        [EnumMember(Value = "AGENT_EMAIL")]
        AgentEmail,

        /// <summary>
        /// Enum AgentRole for "AGENT_ROLE"
        /// </summary>
        [EnumMember(Value = "AGENT_ROLE")]
        AgentRole,

        /// <summary>
        /// Enum AgentGroup for "AGENT_GROUP"
        /// </summary>
        [EnumMember(Value = "AGENT_GROUP")]
        AgentGroup,

        /// <summary>
        /// Enum AgentTimeInStatus for "AGENT_TIME_IN_STATUS"
        /// </summary>
        [EnumMember(Value = "AGENT_TIME_IN_STATUS")]
        AgentTimeInStatus,

        /// <summary>
        /// Enum AgentTimeInRoutingStatus for "AGENT_TIME_IN_ROUTING_STATUS"
        /// </summary>
        [EnumMember(Value = "AGENT_TIME_IN_ROUTING_STATUS")]
        AgentTimeInRoutingStatus,

        /// <summary>
        /// Enum AgentStatus for "AGENT_STATUS"
        /// </summary>
        [EnumMember(Value = "AGENT_STATUS")]
        AgentStatus,

        /// <summary>
        /// Enum AgentSecondaryStatus for "AGENT_SECONDARY_STATUS"
        /// </summary>
        [EnumMember(Value = "AGENT_SECONDARY_STATUS")]
        AgentSecondaryStatus,

        /// <summary>
        /// Enum AgentRoutingStatus for "AGENT_ROUTING_STATUS"
        /// </summary>
        [EnumMember(Value = "AGENT_ROUTING_STATUS")]
        AgentRoutingStatus,

        /// <summary>
        /// Enum AgentMediaTypes for "AGENT_MEDIA_TYPES"
        /// </summary>
        [EnumMember(Value = "AGENT_MEDIA_TYPES")]
        AgentMediaTypes,

        /// <summary>
        /// Enum AcwCount for "ACW_COUNT"
        /// </summary>
        [EnumMember(Value = "ACW_COUNT")]
        AcwCount,

        /// <summary>
        /// Enum AnswerTransferredPercent for "ANSWER_TRANSFERRED_PERCENT"
        /// </summary>
        [EnumMember(Value = "ANSWER_TRANSFERRED_PERCENT")]
        AnswerTransferredPercent,

        /// <summary>
        /// Enum FlowAvgMilestoneDecimal for "FLOW_AVG_MILESTONE_DECIMAL"
        /// </summary>
        [EnumMember(Value = "FLOW_AVG_MILESTONE_DECIMAL")]
        FlowAvgMilestoneDecimal,

        /// <summary>
        /// Enum NotRespondingCount for "NOT_RESPONDING_COUNT"
        /// </summary>
        [EnumMember(Value = "NOT_RESPONDING_COUNT")]
        NotRespondingCount,

        /// <summary>
        /// Enum AvgAcwHandled for "AVG_ACW_HANDLED"
        /// </summary>
        [EnumMember(Value = "AVG_ACW_HANDLED")]
        AvgAcwHandled,

        /// <summary>
        /// Enum AvgContactingTime for "AVG_CONTACTING_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_CONTACTING_TIME")]
        AvgContactingTime,

        /// <summary>
        /// Enum AvgDialingTime for "AVG_DIALING_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_DIALING_TIME")]
        AvgDialingTime,

        /// <summary>
        /// Enum AvgFlowoutTime for "AVG_FLOWOUT_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_FLOWOUT_TIME")]
        AvgFlowoutTime,

        /// <summary>
        /// Enum AvgHoldHandled for "AVG_HOLD_HANDLED"
        /// </summary>
        [EnumMember(Value = "AVG_HOLD_HANDLED")]
        AvgHoldHandled,

        /// <summary>
        /// Enum AvgMonitor for "AVG_MONITOR"
        /// </summary>
        [EnumMember(Value = "AVG_MONITOR")]
        AvgMonitor,

        /// <summary>
        /// Enum BlindTransferCount for "BLIND_TRANSFER_COUNT"
        /// </summary>
        [EnumMember(Value = "BLIND_TRANSFER_COUNT")]
        BlindTransferCount,

        /// <summary>
        /// Enum BlindTransferPercent for "BLIND_TRANSFER_PERCENT"
        /// </summary>
        [EnumMember(Value = "BLIND_TRANSFER_PERCENT")]
        BlindTransferPercent,

        /// <summary>
        /// Enum ConnectedCount for "CONNECTED_COUNT"
        /// </summary>
        [EnumMember(Value = "CONNECTED_COUNT")]
        ConnectedCount,

        /// <summary>
        /// Enum ConsultCount for "CONSULT_COUNT"
        /// </summary>
        [EnumMember(Value = "CONSULT_COUNT")]
        ConsultCount,

        /// <summary>
        /// Enum ConsultTransferCount for "CONSULT_TRANSFER_COUNT"
        /// </summary>
        [EnumMember(Value = "CONSULT_TRANSFER_COUNT")]
        ConsultTransferCount,

        /// <summary>
        /// Enum ConsultTransferPercent for "CONSULT_TRANSFER_PERCENT"
        /// </summary>
        [EnumMember(Value = "CONSULT_TRANSFER_PERCENT")]
        ConsultTransferPercent,

        /// <summary>
        /// Enum ContactingCount for "CONTACTING_COUNT"
        /// </summary>
        [EnumMember(Value = "CONTACTING_COUNT")]
        ContactingCount,

        /// <summary>
        /// Enum DialingCount for "DIALING_COUNT"
        /// </summary>
        [EnumMember(Value = "DIALING_COUNT")]
        DialingCount,

        /// <summary>
        /// Enum ErrorCount for "ERROR_COUNT"
        /// </summary>
        [EnumMember(Value = "ERROR_COUNT")]
        ErrorCount,

        /// <summary>
        /// Enum ExternalMediaCount for "EXTERNAL_MEDIA_COUNT"
        /// </summary>
        [EnumMember(Value = "EXTERNAL_MEDIA_COUNT")]
        ExternalMediaCount,

        /// <summary>
        /// Enum MaxContactingTime for "MAX_CONTACTING_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_CONTACTING_TIME")]
        MaxContactingTime,

        /// <summary>
        /// Enum MaxDialingTime for "MAX_DIALING_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_DIALING_TIME")]
        MaxDialingTime,

        /// <summary>
        /// Enum MaxFlowoutTime for "MAX_FLOWOUT_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_FLOWOUT_TIME")]
        MaxFlowoutTime,

        /// <summary>
        /// Enum FlowMilestoneCount for "FLOW_MILESTONE_COUNT"
        /// </summary>
        [EnumMember(Value = "FLOW_MILESTONE_COUNT")]
        FlowMilestoneCount,

        /// <summary>
        /// Enum MinFlowoutTime for "MIN_FLOWOUT_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_FLOWOUT_TIME")]
        MinFlowoutTime,

        /// <summary>
        /// Enum MaxMonitor for "MAX_MONITOR"
        /// </summary>
        [EnumMember(Value = "MAX_MONITOR")]
        MaxMonitor,

        /// <summary>
        /// Enum MinContactingTime for "MIN_CONTACTING_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_CONTACTING_TIME")]
        MinContactingTime,

        /// <summary>
        /// Enum MinDialingTime for "MIN_DIALING_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_DIALING_TIME")]
        MinDialingTime,

        /// <summary>
        /// Enum MinMonitor for "MIN_MONITOR"
        /// </summary>
        [EnumMember(Value = "MIN_MONITOR")]
        MinMonitor,

        /// <summary>
        /// Enum MonitorCount for "MONITOR_COUNT"
        /// </summary>
        [EnumMember(Value = "MONITOR_COUNT")]
        MonitorCount,

        /// <summary>
        /// Enum MediaCount for "MEDIA_COUNT"
        /// </summary>
        [EnumMember(Value = "MEDIA_COUNT")]
        MediaCount,

        /// <summary>
        /// Enum ServiceLevelTarget for "SERVICE_LEVEL_TARGET"
        /// </summary>
        [EnumMember(Value = "SERVICE_LEVEL_TARGET")]
        ServiceLevelTarget,

        /// <summary>
        /// Enum ServiceLevelTargetCurrent for "SERVICE_LEVEL_TARGET_CURRENT"
        /// </summary>
        [EnumMember(Value = "SERVICE_LEVEL_TARGET_CURRENT")]
        ServiceLevelTargetCurrent,

        /// <summary>
        /// Enum TalkCount for "TALK_COUNT"
        /// </summary>
        [EnumMember(Value = "TALK_COUNT")]
        TalkCount,

        /// <summary>
        /// Enum TotalAbandonTime for "TOTAL_ABANDON_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_ABANDON_TIME")]
        TotalAbandonTime,

        /// <summary>
        /// Enum TotalNotRespondingTime for "TOTAL_NOT_RESPONDING_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_NOT_RESPONDING_TIME")]
        TotalNotRespondingTime,

        /// <summary>
        /// Enum TotalContacting for "TOTAL_CONTACTING"
        /// </summary>
        [EnumMember(Value = "TOTAL_CONTACTING")]
        TotalContacting,

        /// <summary>
        /// Enum TotalDialing for "TOTAL_DIALING"
        /// </summary>
        [EnumMember(Value = "TOTAL_DIALING")]
        TotalDialing,

        /// <summary>
        /// Enum TotalMonitor for "TOTAL_MONITOR"
        /// </summary>
        [EnumMember(Value = "TOTAL_MONITOR")]
        TotalMonitor,

        /// <summary>
        /// Enum TotalWaitTime for "TOTAL_WAIT_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_WAIT_TIME")]
        TotalWaitTime,

        /// <summary>
        /// Enum WaitCount for "WAIT_COUNT"
        /// </summary>
        [EnumMember(Value = "WAIT_COUNT")]
        WaitCount,

        /// <summary>
        /// Enum ParkCount for "PARK_COUNT"
        /// </summary>
        [EnumMember(Value = "PARK_COUNT")]
        ParkCount,

        /// <summary>
        /// Enum AvgParkTime for "AVG_PARK_TIME"
        /// </summary>
        [EnumMember(Value = "AVG_PARK_TIME")]
        AvgParkTime,

        /// <summary>
        /// Enum TotalParkTime for "TOTAL_PARK_TIME"
        /// </summary>
        [EnumMember(Value = "TOTAL_PARK_TIME")]
        TotalParkTime,

        /// <summary>
        /// Enum MinParkTime for "MIN_PARK_TIME"
        /// </summary>
        [EnumMember(Value = "MIN_PARK_TIME")]
        MinParkTime,

        /// <summary>
        /// Enum MaxParkTime for "MAX_PARK_TIME"
        /// </summary>
        [EnumMember(Value = "MAX_PARK_TIME")]
        MaxParkTime
    }
    /// <summary>
    /// Gets or Sets SegmentTypes
    /// </summary>
    
    public enum SegmentTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alert for "alert"
        /// </summary>
        [EnumMember(Value = "alert")]
        Alert,

        /// <summary>
        /// Enum Barging for "barging"
        /// </summary>
        [EnumMember(Value = "barging")]
        Barging,

        /// <summary>
        /// Enum Callback for "callback"
        /// </summary>
        [EnumMember(Value = "callback")]
        Callback,

        /// <summary>
        /// Enum Coaching for "coaching"
        /// </summary>
        [EnumMember(Value = "coaching")]
        Coaching,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Delay for "delay"
        /// </summary>
        [EnumMember(Value = "delay")]
        Delay,

        /// <summary>
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Hold for "hold"
        /// </summary>
        [EnumMember(Value = "hold")]
        Hold,

        /// <summary>
        /// Enum Interact for "interact"
        /// </summary>
        [EnumMember(Value = "interact")]
        Interact,

        /// <summary>
        /// Enum Ivr for "ivr"
        /// </summary>
        [EnumMember(Value = "ivr")]
        Ivr,

        /// <summary>
        /// Enum Monitoring for "monitoring"
        /// </summary>
        [EnumMember(Value = "monitoring")]
        Monitoring,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked,

        /// <summary>
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Sharing for "sharing"
        /// </summary>
        [EnumMember(Value = "sharing")]
        Sharing,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Voicemail for "voicemail"
        /// </summary>
        [EnumMember(Value = "voicemail")]
        Voicemail,

        /// <summary>
        /// Enum Wrapup for "wrapup"
        /// </summary>
        [EnumMember(Value = "wrapup")]
        Wrapup
    }
    /// <summary>
    /// Filter to indicate the availability of the dashboard is public or private.
    /// </summary>
    /// <value>Filter to indicate the availability of the dashboard is public or private.</value>
    [JsonPropertyName("availableDashboard")]
    public AvailableDashboardEnum? AvailableDashboard { get; set; }
    /// <summary>
    /// The user supplied state value in the view
    /// </summary>
    /// <value>The user supplied state value in the view</value>
    [JsonPropertyName("userState")]
    public UserStateEnum? UserState { get; set; }
    /// <summary>
    /// The state of dashboard being filtered
    /// </summary>
    /// <value>The state of dashboard being filtered</value>
    [JsonPropertyName("dashboardState")]
    public DashboardStateEnum? DashboardState { get; set; }
    /// <summary>
    /// The type of dashboard being filtered
    /// </summary>
    /// <value>The type of dashboard being filtered</value>
    [JsonPropertyName("dashboardType")]
    public DashboardTypeEnum? DashboardType { get; set; }
    /// <summary>
    /// The type of dashboard access being filtered
    /// </summary>
    /// <value>The type of dashboard access being filtered</value>
    [JsonPropertyName("dashboardAccessFilter")]
    public DashboardAccessFilterEnum? DashboardAccessFilter { get; set; }
    /// <summary>
    /// Sets the role when viewing agent evaluations
    /// </summary>
    /// <value>Sets the role when viewing agent evaluations</value>
    [JsonPropertyName("evaluationRole")]
    public EvaluationRoleEnum? EvaluationRole { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ViewFilter" /> class.
    /// </summary>
    /// <param name="MediaTypes">The media types are used to filter the view.</param>
    /// <param name="QueueIds">The queue ids are used to filter the view.</param>
    /// <param name="SkillIds">The skill ids are used to filter the view.</param>
    /// <param name="AssignedSkillIds">The assigned user skill ids are used to filter the view.</param>
    /// <param name="SkillGroups">The skill groups used to filter the view.</param>
    /// <param name="LanguageIds">The language ids are used to filter the view.</param>
    /// <param name="AssignedLanguageIds">The assigned user language ids are used to filter the view.</param>
    /// <param name="LanguageGroups">The language groups used to filter the view.</param>
    /// <param name="Directions">The directions are used to filter the view.</param>
    /// <param name="OriginatingDirections">The list of orginating directions used to filter the view.</param>
    /// <param name="WrapUpCodes">The wrap up codes are used to filter the view.</param>
    /// <param name="DnisList">The dnis list is used to filter the view.</param>
    /// <param name="SessionDnisList">The list of session dnis used to filter the view.</param>
    /// <param name="FilterQueuesByUserIds">The user ids are used to fetch associated queues for the view.</param>
    /// <param name="FilterUsersByQueueIds">The queue ids are used to fetch associated users for the view.</param>
    /// <param name="UserIds">The user ids are used to filter the view.</param>
    /// <param name="ManagementUnitIds">The management unit ids are used to filter the view.</param>
    /// <param name="AddressTos">The address To values are used to filter the view.</param>
    /// <param name="AddressFroms">The address from values are used to filter the view.</param>
    /// <param name="OutboundCampaignIds">The outbound campaign ids are used to filter the view.</param>
    /// <param name="OutboundContactListIds">The outbound contact list ids are used to filter the view.</param>
    /// <param name="ContactIds">The contact ids are used to filter the view.</param>
    /// <param name="ExternalContactIds">The external contact ids are used to filter the view.</param>
    /// <param name="ExternalOrgIds">The external org ids are used to filter the view.</param>
    /// <param name="AniList">The ani list ids are used to filter the view.</param>
    /// <param name="DurationsMilliseconds">The durations in milliseconds used to filter the view.</param>
    /// <param name="AcdDurationsMilliseconds">The acd durations in milliseconds used to filter the view.</param>
    /// <param name="TalkDurationsMilliseconds">The talk durations in milliseconds used to filter the view.</param>
    /// <param name="AcwDurationsMilliseconds">The acw durations in milliseconds used to filter the view.</param>
    /// <param name="HandleDurationsMilliseconds">The handle durations in milliseconds used to filter the view.</param>
    /// <param name="HoldDurationsMilliseconds">The hold durations in milliseconds used to filter the view.</param>
    /// <param name="AbandonDurationsMilliseconds">The abandon durations in milliseconds used to filter the view.</param>
    /// <param name="EvaluationScore">The evaluationScore is used to filter the view.</param>
    /// <param name="EvaluationCriticalScore">The evaluationCriticalScore is used to filter the view.</param>
    /// <param name="EvaluationFormIds">The evaluation form ids are used to filter the view.</param>
    /// <param name="EvaluatedAgentIds">The evaluated agent ids are used to filter the view.</param>
    /// <param name="EvaluatorIds">The evaluator ids are used to filter the view.</param>
    /// <param name="Transferred">Indicates filtering for transfers.</param>
    /// <param name="Abandoned">Indicates filtering for abandons.</param>
    /// <param name="Answered">Indicates filtering for answered interactions.</param>
    /// <param name="MessageTypes">The message media types used to filter the view.</param>
    /// <param name="DivisionIds">The divison Ids used to filter the view.</param>
    /// <param name="SurveyFormIds">The survey form ids used to filter the view.</param>
    /// <param name="SurveyTotalScore">The survey total score used to filter the view.</param>
    /// <param name="SurveyNpsScore">The survey NPS score used to filter the view.</param>
    /// <param name="Mos">The desired range for mos values.</param>
    /// <param name="SurveyQuestionGroupScore">The survey question group score used to filter the view.</param>
    /// <param name="SurveyPromoterScore">The survey promoter score used to filter the view.</param>
    /// <param name="SurveyFormContextIds">The list of survey form context ids used to filter the view.</param>
    /// <param name="ConversationIds">The list of conversation ids used to filter the view.</param>
    /// <param name="SipCallIds">The list of SIP call ids used to filter the view.</param>
    /// <param name="IsEnded">Indicates filtering for ended.</param>
    /// <param name="IsSurveyed">Indicates filtering for survey.</param>
    /// <param name="SurveyScores">The list of survey score ranges used to filter the view.</param>
    /// <param name="PromoterScores">The list of promoter score ranges used to filter the view.</param>
    /// <param name="IsCampaign">Indicates filtering for campaign.</param>
    /// <param name="SurveyStatuses">The list of survey statuses used to filter the view.</param>
    /// <param name="ConversationProperties">A grouping of conversation level filters.</param>
    /// <param name="IsBlindTransferred">Indicates filtering for blind transferred.</param>
    /// <param name="IsConsulted">Indicates filtering for consulted.</param>
    /// <param name="IsConsultTransferred">Indicates filtering for consult transferred.</param>
    /// <param name="RemoteParticipants">The list of remote participants used to filter the view.</param>
    /// <param name="FlowIds">The list of flow Ids.</param>
    /// <param name="FlowOutcomeIds">A list of outcome ids of the flow.</param>
    /// <param name="FlowOutcomeValues">A list of outcome values of the flow.</param>
    /// <param name="FlowDestinationTypes">The list of destination types of the flow.</param>
    /// <param name="FlowDisconnectReasons">The list of reasons for the flow to disconnect.</param>
    /// <param name="FlowTypes">A list of types of the flow.</param>
    /// <param name="FlowEntryTypes">A list of types of the flow entry.</param>
    /// <param name="FlowEntryReasons">A list of reasons of flow entry.</param>
    /// <param name="FlowVersions">A list of versions of a flow.</param>
    /// <param name="GroupIds">A list of directory group ids.</param>
    /// <param name="HasJourneyCustomerId">Indicates filtering for journey customer id.</param>
    /// <param name="HasJourneyActionMapId">Indicates filtering for Journey action map id.</param>
    /// <param name="HasJourneyVisitId">Indicates filtering for Journey visit id.</param>
    /// <param name="HasMedia">Indicates filtering for presence of MMS media.</param>
    /// <param name="RoleIds">The role Ids used to filter the view.</param>
    /// <param name="ReportsTos">The report to user IDs used to filter the view.</param>
    /// <param name="LocationIds">The location Ids used to filter the view.</param>
    /// <param name="FlowOutTypes">A list of flow out types.</param>
    /// <param name="ProviderList">A list of providers.</param>
    /// <param name="CallbackNumberList">A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;]).</param>
    /// <param name="CallbackInterval">An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss.</param>
    /// <param name="UsedRoutingTypes">A list of routing types used.</param>
    /// <param name="RequestedRoutingTypes">A list of routing types requested.</param>
    /// <param name="HasAgentAssistId">Indicates filtering for agent assist id.</param>
    /// <param name="Transcripts">A list of transcript contents requested.</param>
    /// <param name="TranscriptLanguages">A list of transcript languages requested.</param>
    /// <param name="ParticipantPurposes">A list of participant purpose requested.</param>
    /// <param name="ShowFirstQueue">Indicates filtering for first queue data.</param>
    /// <param name="TeamIds">The team ids used to filter the view data.</param>
    /// <param name="FilterUsersByTeamIds">The team ids are used to fetch associated users for the view.</param>
    /// <param name="JourneyActionMapIds">The journey action map ids are used to fetch action maps for the associated view.</param>
    /// <param name="JourneyOutcomeIds">The journey outcome ids are used to fetch outcomes for the associated view.</param>
    /// <param name="JourneySegmentIds">The journey segment ids are used to fetch segments for the associated view.</param>
    /// <param name="JourneyActionMapTypes">The journey action map types are used to filter action map data for the associated view.</param>
    /// <param name="DevelopmentRoleList">The list of development roles used to filter agent development view.</param>
    /// <param name="DevelopmentTypeList">The list of development types used to filter agent development view.</param>
    /// <param name="DevelopmentStatusList">The list of development status used to filter agent development view.</param>
    /// <param name="DevelopmentModuleIds">The list of development moduleIds used to filter agent development view.</param>
    /// <param name="DevelopmentActivityOverdue">Indicates filtering for development activities.</param>
    /// <param name="CustomerSentimentScore">The customer sentiment score used to filter the view.</param>
    /// <param name="CustomerSentimentTrend">The customer sentiment trend used to filter the view.</param>
    /// <param name="FlowTransferTargets">The list of transfer targets used to filter flow data.</param>
    /// <param name="DevelopmentName">Filter for development name.</param>
    /// <param name="TopicIds">Represents the topics detected in the transcript.</param>
    /// <param name="ExternalTags">The list of external Tags used to filter conversation data.</param>
    /// <param name="IsNotResponding">Indicates filtering for not responding users.</param>
    /// <param name="IsAuthenticated">Indicates filtering for the authenticated chat.</param>
    /// <param name="BotIds">The list of bot IDs used to filter bot views.</param>
    /// <param name="BotVersions">The list of bot versions used to filter bot views.</param>
    /// <param name="BotMessageTypes">The list of bot message types used to filter bot views.</param>
    /// <param name="BotProviderList">The list of bot providers used to filter bot views.</param>
    /// <param name="BotProductList">The list of bot products used to filter bot views.</param>
    /// <param name="BotRecognitionFailureReasonList">The list of bot recognition failure reasons used to filter bot views.</param>
    /// <param name="BotIntentList">The list of bot intents used to filter bot views.</param>
    /// <param name="BotFinalIntentList">The list of bot final intents used to filter bot views.</param>
    /// <param name="BotSlotList">The list of bot slots used to filter bot views.</param>
    /// <param name="BotResultList">The list of bot results used to filter bot views.</param>
    /// <param name="BlockedReasons">The list of blocked reason used to filter action map constraints views.</param>
    /// <param name="IsRecorded">Indicates filtering for recorded.</param>
    /// <param name="HasEvaluation">Indicates filtering for evaluation.</param>
    /// <param name="HasScoredEvaluation">Indicates filtering for scored evaluation.</param>
    /// <param name="EmailDeliveryStatusList">The list of email delivery statuses used to filter views.</param>
    /// <param name="IsAgentOwnedCallback">Indicates filtering for agent owned callback interactions.</param>
    /// <param name="AgentCallbackOwnerIds">The list of callback owners used to filter interactions.</param>
    /// <param name="TranscriptTopics">The list of transcript topics requested in filter.</param>
    /// <param name="JourneyFrequencyCapReasons">The list of frequency cap reasons to filter offer constraints.</param>
    /// <param name="JourneyBlockingActionMapIds">The list of blocking action maps to filter offer constraints.</param>
    /// <param name="JourneyActionTargetIds">The list of action targets to filter offer constraints.</param>
    /// <param name="JourneyBlockingScheduleGroupIds">The list of blocking schedule groups to filter offer constraints.</param>
    /// <param name="JourneyBlockingEmergencyScheduleGroupIds">The list of emergency schedule groups to filter offer constraints.</param>
    /// <param name="JourneyUrlEqualConditions">The list of url equal conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlNotEqualConditions">The list of url not equal conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlStartsWithConditions">The list of url starts with conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlEndsWithConditions">The list of url ends with conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlContainsAnyConditions">The list of url contains any conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlNotContainsAnyConditions">The list of url not contains any conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlContainsAllConditions">The list of url contains all conditions to filter offer constraints.</param>
    /// <param name="JourneyUrlNotContainsAllConditions">The list of url not contains all conditions to filter offer constraints.</param>
    /// <param name="FlowMilestoneIds">The list of flow milestones to filter exports.</param>
    /// <param name="IsAssessmentPassed">Filter to indicate if Agent passed assessment or not.</param>
    /// <param name="ConversationInitiators">The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation.</param>
    /// <param name="HasCustomerParticipated">Indicates if the customer has participated in an initiated conversation.</param>
    /// <param name="IsAcdInteraction">Filter to indicate if interaction was ACD or non-ACD.</param>
    /// <param name="HasFax">Filters to indicate if interaction has FAX.</param>
    /// <param name="DataActionIds">The list of Data Action IDs .</param>
    /// <param name="ActionCategoryName">Deprecated - Please use integrationIds instead.</param>
    /// <param name="IntegrationIds">The list of integration IDs for Data Action.</param>
    /// <param name="ResponseStatuses">The list of Response codes for Data Action.</param>
    /// <param name="AvailableDashboard">Filter to indicate the availability of the dashboard is public or private..</param>
    /// <param name="FavouriteDashboard">Filter to indicate whether the dashboard is favorite or unfavorite..</param>
    /// <param name="MyDashboard">Filter to indicate the dashboard owned by the user..</param>
    /// <param name="StationErrors">The list of agent errors that are related to station.</param>
    /// <param name="CanonicalContactIds">The canonical contact ids are used to filter the view.</param>
    /// <param name="AlertRuleIds">The list of Alert Rule IDs.</param>
    /// <param name="EvaluationFormContextIds">The list of Evaluation Form Context IDs.</param>
    /// <param name="EvaluationStatuses">The evaluation statuses that are used to filter the view.</param>
    /// <param name="WorkbinIds">The list of Workbin IDs.</param>
    /// <param name="WorktypeIds">The list of Worktype IDs.</param>
    /// <param name="WorkitemIds">The list of Workitem IDs.</param>
    /// <param name="WorkitemAssigneeIds">The list of Workitem Assignee IDs.</param>
    /// <param name="WorkitemStatuses">The list of Workitem Statuses IDs.</param>
    /// <param name="IsAnalyzedForSensitiveData">Deprecated - Use hasPciData or hasPiiData instead..</param>
    /// <param name="HasSensitiveData">Deprecated. Use hasPciData or hasPiiData instead..</param>
    /// <param name="HasPciData">Filter to indicate the transcript contains Pci data..</param>
    /// <param name="HasPiiData">Filter to indicate the transcript contains Pii data..</param>
    /// <param name="SubPath">Filter for Sub Path.</param>
    /// <param name="UserState">The user supplied state value in the view.</param>
    /// <param name="IsClearedByCustomer">Filter to indicate if the customer cleared the conversation..</param>
    /// <param name="EvaluationAssigneeIds">The evaluation assignee ids that are used to filter the view..</param>
    /// <param name="EvaluationAssigned">Filter to indicate that the user has no assigned evaluation..</param>
    /// <param name="AssistantIds">The assistant ids that are used to filter the view..</param>
    /// <param name="KnowledgeBaseIds">The knowledge base ids that are used to filter the view..</param>
    /// <param name="IsParked">Filter to indicate if the interactions are parked..</param>
    /// <param name="AgentEmpathyScore">The agentEmpathyScore is used to filter the view.</param>
    /// <param name="SurveyTypes">The surveyTypes is used to filter the view.</param>
    /// <param name="SurveyResponseStatuses">The list of Survey Response Status.</param>
    /// <param name="BotFlowTypes">The botFlowTypes is used to filter the view.</param>
    /// <param name="AgentTalkDurationMilliseconds">The agent talk durations in milliseconds used to filter the view.</param>
    /// <param name="CustomerTalkDurationMilliseconds">The customer talk durations in milliseconds used to filter the view.</param>
    /// <param name="OvertalkDurationMilliseconds">The overtalk durations in milliseconds used to filter the view.</param>
    /// <param name="SilenceDurationMilliseconds">The silence durations in milliseconds used to filter the view.</param>
    /// <param name="AcdDurationMilliseconds">The acd durations in milliseconds used to filter the view.</param>
    /// <param name="IvrDurationMilliseconds">The ivr durations in milliseconds used to filter the view.</param>
    /// <param name="OtherDurationMilliseconds">The other (hold/music) durations in milliseconds used to filter the view.</param>
    /// <param name="AgentTalkPercentage">The agent talk percentage used to filter the view.</param>
    /// <param name="CustomerTalkPercentage">The customer talk percentage used to filter the view.</param>
    /// <param name="OvertalkPercentage">The overtalk percentage used to filter the view.</param>
    /// <param name="SilencePercentage">The silence percentage used to filter the view.</param>
    /// <param name="AcdPercentage">The acd percentage used to filter the view.</param>
    /// <param name="IvrPercentage">The ivr percentage used to filter the view.</param>
    /// <param name="OtherPercentage">The other (hold/music percentage used to filter the view.</param>
    /// <param name="OvertalkInstances">The overtalk instance range used to filter the view.</param>
    /// <param name="IsScreenRecorded">Filter to indicate if the screen is recorded.</param>
    /// <param name="ScreenMonitorUserIds">The list of Screen Monitor User Ids.</param>
    /// <param name="DashboardState">The state of dashboard being filtered.</param>
    /// <param name="DashboardType">The type of dashboard being filtered.</param>
    /// <param name="DashboardAccessFilter">The type of dashboard access being filtered.</param>
    /// <param name="TranscriptDurationMilliseconds">The transcript durations in milliseconds used to filter the view.</param>
    /// <param name="WorkitemsStatuses">The list of workitem status with worktype.</param>
    /// <param name="SocialCountries">List of countries for social filtering.</param>
    /// <param name="SocialLanguages">List of languages for social filtering.</param>
    /// <param name="SocialChannels">List of channels for social filtering.</param>
    /// <param name="SocialSentimentCategory">The sentiment of the social post.</param>
    /// <param name="SocialTopicIds">The list of topicIds for social filtering.</param>
    /// <param name="SocialIngestionRuleIds">The list of ingestion ruleIds for social filtering.</param>
    /// <param name="SocialConversationCreated">Filter to indicate if the post has created a conversation.</param>
    /// <param name="SocialContentType">The list of content Type for social filtering.</param>
    /// <param name="SocialKeywords">The list of keywords for social filtering.</param>
    /// <param name="SocialPostEscalated">Filter to indicate if the post is escalated.</param>
    /// <param name="SocialClassifications">Indicates if a social message was public or private.</param>
    /// <param name="FilterUsersByManagerIds">The manager ids used to fetch associated users for the view.</param>
    /// <param name="SlideshowIds">List of Dashboard slideshowIds to be filtered.</param>
    /// <param name="Conferenced">Filter to indicate if the conversation has conference.</param>
    /// <param name="Video">Filter to indicate if the conversation has video.</param>
    /// <param name="LinkedInteraction">Filter to indicate if the conversation has linked interaction.</param>
    /// <param name="RecommendationSources">List of recommendation sources for filtering recommendation details pane.</param>
    /// <param name="EvaluationRole">Sets the role when viewing agent evaluations.</param>
    /// <param name="ComparisonQueueIds">The queue ids are used to for comparison to the primary queue filter in reporting.</param>
    /// <param name="ViewMetrics">A list of metrics selected for the view.</param>
    /// <param name="TimelineCategories">A list of timeline categories.</param>
    /// <param name="Acw">Filter to indicate for acw state.</param>
    /// <param name="SegmentTypes">A list of filtered segment types.</param>
    /// <param name="ProgramIds">A list of program ids for filtering.</param>
    /// <param name="CategoryIds">A list of category ids for filtering.</param>
    public ViewFilter(List<MediaTypesEnum> MediaTypes = null, List<string> QueueIds = null, List<string> SkillIds = null, List<string> AssignedSkillIds = null, List<string> SkillGroups = null, List<string> LanguageIds = null, List<string> AssignedLanguageIds = null, List<string> LanguageGroups = null, List<DirectionsEnum> Directions = null, List<OriginatingDirectionsEnum> OriginatingDirections = null, List<string> WrapUpCodes = null, List<string> DnisList = null, List<string> SessionDnisList = null, List<string> FilterQueuesByUserIds = null, List<string> FilterUsersByQueueIds = null, List<string> UserIds = null, List<string> ManagementUnitIds = null, List<string> AddressTos = null, List<string> AddressFroms = null, List<string> OutboundCampaignIds = null, List<string> OutboundContactListIds = null, List<string> ContactIds = null, List<string> ExternalContactIds = null, List<string> ExternalOrgIds = null, List<string> AniList = null, List<NumericRange> DurationsMilliseconds = null, List<NumericRange> AcdDurationsMilliseconds = null, List<NumericRange> TalkDurationsMilliseconds = null, List<NumericRange> AcwDurationsMilliseconds = null, List<NumericRange> HandleDurationsMilliseconds = null, List<NumericRange> HoldDurationsMilliseconds = null, List<NumericRange> AbandonDurationsMilliseconds = null, NumericRange EvaluationScore = null, NumericRange EvaluationCriticalScore = null, List<string> EvaluationFormIds = null, List<string> EvaluatedAgentIds = null, List<string> EvaluatorIds = null, bool? Transferred = null, bool? Abandoned = null, bool? Answered = null, List<MessageTypesEnum> MessageTypes = null, List<string> DivisionIds = null, List<string> SurveyFormIds = null, NumericRange SurveyTotalScore = null, NumericRange SurveyNpsScore = null, NumericRange Mos = null, NumericRange SurveyQuestionGroupScore = null, NumericRange SurveyPromoterScore = null, List<string> SurveyFormContextIds = null, List<string> ConversationIds = null, List<string> SipCallIds = null, bool? IsEnded = null, bool? IsSurveyed = null, List<NumericRange> SurveyScores = null, List<NumericRange> PromoterScores = null, bool? IsCampaign = null, List<string> SurveyStatuses = null, ConversationProperties ConversationProperties = null, bool? IsBlindTransferred = null, bool? IsConsulted = null, bool? IsConsultTransferred = null, List<string> RemoteParticipants = null, List<string> FlowIds = null, List<string> FlowOutcomeIds = null, List<FlowOutcomeValuesEnum> FlowOutcomeValues = null, List<FlowDestinationTypesEnum> FlowDestinationTypes = null, List<FlowDisconnectReasonsEnum> FlowDisconnectReasons = null, List<FlowTypesEnum> FlowTypes = null, List<FlowEntryTypesEnum> FlowEntryTypes = null, List<string> FlowEntryReasons = null, List<string> FlowVersions = null, List<string> GroupIds = null, bool? HasJourneyCustomerId = null, bool? HasJourneyActionMapId = null, bool? HasJourneyVisitId = null, bool? HasMedia = null, List<string> RoleIds = null, List<string> ReportsTos = null, List<string> LocationIds = null, List<string> FlowOutTypes = null, List<string> ProviderList = null, List<string> CallbackNumberList = null, string CallbackInterval = null, List<UsedRoutingTypesEnum> UsedRoutingTypes = null, List<RequestedRoutingTypesEnum> RequestedRoutingTypes = null, bool? HasAgentAssistId = null, List<Transcripts> Transcripts = null, List<string> TranscriptLanguages = null, List<ParticipantPurposesEnum> ParticipantPurposes = null, bool? ShowFirstQueue = null, List<string> TeamIds = null, List<string> FilterUsersByTeamIds = null, List<string> JourneyActionMapIds = null, List<string> JourneyOutcomeIds = null, List<string> JourneySegmentIds = null, List<JourneyActionMapTypesEnum> JourneyActionMapTypes = null, List<DevelopmentRoleListEnum> DevelopmentRoleList = null, List<DevelopmentTypeListEnum> DevelopmentTypeList = null, List<DevelopmentStatusListEnum> DevelopmentStatusList = null, List<string> DevelopmentModuleIds = null, bool? DevelopmentActivityOverdue = null, NumericRange CustomerSentimentScore = null, NumericRange CustomerSentimentTrend = null, List<string> FlowTransferTargets = null, string DevelopmentName = null, List<string> TopicIds = null, List<string> ExternalTags = null, bool? IsNotResponding = null, bool? IsAuthenticated = null, List<string> BotIds = null, List<string> BotVersions = null, List<BotMessageTypesEnum> BotMessageTypes = null, List<BotProviderListEnum> BotProviderList = null, List<BotProductListEnum> BotProductList = null, List<BotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList = null, List<string> BotIntentList = null, List<string> BotFinalIntentList = null, List<string> BotSlotList = null, List<BotResultListEnum> BotResultList = null, List<BlockedReasonsEnum> BlockedReasons = null, bool? IsRecorded = null, bool? HasEvaluation = null, bool? HasScoredEvaluation = null, List<EmailDeliveryStatusListEnum> EmailDeliveryStatusList = null, bool? IsAgentOwnedCallback = null, List<string> AgentCallbackOwnerIds = null, List<TranscriptTopics> TranscriptTopics = null, List<string> JourneyFrequencyCapReasons = null, List<string> JourneyBlockingActionMapIds = null, List<string> JourneyActionTargetIds = null, List<string> JourneyBlockingScheduleGroupIds = null, List<string> JourneyBlockingEmergencyScheduleGroupIds = null, List<string> JourneyUrlEqualConditions = null, List<string> JourneyUrlNotEqualConditions = null, List<string> JourneyUrlStartsWithConditions = null, List<string> JourneyUrlEndsWithConditions = null, List<string> JourneyUrlContainsAnyConditions = null, List<string> JourneyUrlNotContainsAnyConditions = null, List<string> JourneyUrlContainsAllConditions = null, List<string> JourneyUrlNotContainsAllConditions = null, List<string> FlowMilestoneIds = null, bool? IsAssessmentPassed = null, List<string> ConversationInitiators = null, bool? HasCustomerParticipated = null, bool? IsAcdInteraction = null, bool? HasFax = null, List<string> DataActionIds = null, string ActionCategoryName = null, List<string> IntegrationIds = null, List<string> ResponseStatuses = null, AvailableDashboardEnum? AvailableDashboard = null, bool? FavouriteDashboard = null, bool? MyDashboard = null, List<string> StationErrors = null, List<string> CanonicalContactIds = null, List<string> AlertRuleIds = null, List<string> EvaluationFormContextIds = null, List<EvaluationStatusesEnum> EvaluationStatuses = null, List<string> WorkbinIds = null, List<string> WorktypeIds = null, List<string> WorkitemIds = null, List<string> WorkitemAssigneeIds = null, List<string> WorkitemStatuses = null, bool? IsAnalyzedForSensitiveData = null, bool? HasSensitiveData = null, bool? HasPciData = null, bool? HasPiiData = null, string SubPath = null, UserStateEnum? UserState = null, bool? IsClearedByCustomer = null, List<string> EvaluationAssigneeIds = null, bool? EvaluationAssigned = null, List<string> AssistantIds = null, List<string> KnowledgeBaseIds = null, bool? IsParked = null, NumericRange AgentEmpathyScore = null, List<SurveyTypesEnum> SurveyTypes = null, List<SurveyResponseStatusesEnum> SurveyResponseStatuses = null, List<BotFlowTypesEnum> BotFlowTypes = null, List<NumericRange> AgentTalkDurationMilliseconds = null, List<NumericRange> CustomerTalkDurationMilliseconds = null, List<NumericRange> OvertalkDurationMilliseconds = null, List<NumericRange> SilenceDurationMilliseconds = null, List<NumericRange> AcdDurationMilliseconds = null, List<NumericRange> IvrDurationMilliseconds = null, List<NumericRange> OtherDurationMilliseconds = null, NumericRange AgentTalkPercentage = null, NumericRange CustomerTalkPercentage = null, NumericRange OvertalkPercentage = null, NumericRange SilencePercentage = null, NumericRange AcdPercentage = null, NumericRange IvrPercentage = null, NumericRange OtherPercentage = null, NumericRange OvertalkInstances = null, bool? IsScreenRecorded = null, List<string> ScreenMonitorUserIds = null, DashboardStateEnum? DashboardState = null, DashboardTypeEnum? DashboardType = null, DashboardAccessFilterEnum? DashboardAccessFilter = null, List<NumericRange> TranscriptDurationMilliseconds = null, List<WorkitemStatusFilter> WorkitemsStatuses = null, List<string> SocialCountries = null, List<string> SocialLanguages = null, List<SocialChannelsEnum> SocialChannels = null, List<SocialSentimentCategoryEnum> SocialSentimentCategory = null, List<string> SocialTopicIds = null, List<string> SocialIngestionRuleIds = null, bool? SocialConversationCreated = null, List<SocialContentTypeEnum> SocialContentType = null, List<SocialKeyword> SocialKeywords = null, bool? SocialPostEscalated = null, List<SocialClassificationsEnum> SocialClassifications = null, List<string> FilterUsersByManagerIds = null, List<string> SlideshowIds = null, bool? Conferenced = null, bool? Video = null, bool? LinkedInteraction = null, List<RecommendationSourcesEnum> RecommendationSources = null, EvaluationRoleEnum? EvaluationRole = null, List<string> ComparisonQueueIds = null, List<ViewMetricsEnum> ViewMetrics = null, List<string> TimelineCategories = null, bool? Acw = null, List<SegmentTypesEnum> SegmentTypes = null, List<string> ProgramIds = null, List<string> CategoryIds = null)
    {
        this.MediaTypes = MediaTypes;
        this.QueueIds = QueueIds;
        this.SkillIds = SkillIds;
        this.AssignedSkillIds = AssignedSkillIds;
        this.SkillGroups = SkillGroups;
        this.LanguageIds = LanguageIds;
        this.AssignedLanguageIds = AssignedLanguageIds;
        this.LanguageGroups = LanguageGroups;
        this.Directions = Directions;
        this.OriginatingDirections = OriginatingDirections;
        this.WrapUpCodes = WrapUpCodes;
        this.DnisList = DnisList;
        this.SessionDnisList = SessionDnisList;
        this.FilterQueuesByUserIds = FilterQueuesByUserIds;
        this.FilterUsersByQueueIds = FilterUsersByQueueIds;
        this.UserIds = UserIds;
        this.ManagementUnitIds = ManagementUnitIds;
        this.AddressTos = AddressTos;
        this.AddressFroms = AddressFroms;
        this.OutboundCampaignIds = OutboundCampaignIds;
        this.OutboundContactListIds = OutboundContactListIds;
        this.ContactIds = ContactIds;
        this.ExternalContactIds = ExternalContactIds;
        this.ExternalOrgIds = ExternalOrgIds;
        this.AniList = AniList;
        this.DurationsMilliseconds = DurationsMilliseconds;
        this.AcdDurationsMilliseconds = AcdDurationsMilliseconds;
        this.TalkDurationsMilliseconds = TalkDurationsMilliseconds;
        this.AcwDurationsMilliseconds = AcwDurationsMilliseconds;
        this.HandleDurationsMilliseconds = HandleDurationsMilliseconds;
        this.HoldDurationsMilliseconds = HoldDurationsMilliseconds;
        this.AbandonDurationsMilliseconds = AbandonDurationsMilliseconds;
        this.EvaluationScore = EvaluationScore;
        this.EvaluationCriticalScore = EvaluationCriticalScore;
        this.EvaluationFormIds = EvaluationFormIds;
        this.EvaluatedAgentIds = EvaluatedAgentIds;
        this.EvaluatorIds = EvaluatorIds;
        this.Transferred = Transferred;
        this.Abandoned = Abandoned;
        this.Answered = Answered;
        this.MessageTypes = MessageTypes;
        this.DivisionIds = DivisionIds;
        this.SurveyFormIds = SurveyFormIds;
        this.SurveyTotalScore = SurveyTotalScore;
        this.SurveyNpsScore = SurveyNpsScore;
        this.Mos = Mos;
        this.SurveyQuestionGroupScore = SurveyQuestionGroupScore;
        this.SurveyPromoterScore = SurveyPromoterScore;
        this.SurveyFormContextIds = SurveyFormContextIds;
        this.ConversationIds = ConversationIds;
        this.SipCallIds = SipCallIds;
        this.IsEnded = IsEnded;
        this.IsSurveyed = IsSurveyed;
        this.SurveyScores = SurveyScores;
        this.PromoterScores = PromoterScores;
        this.IsCampaign = IsCampaign;
        this.SurveyStatuses = SurveyStatuses;
        this.ConversationProperties = ConversationProperties;
        this.IsBlindTransferred = IsBlindTransferred;
        this.IsConsulted = IsConsulted;
        this.IsConsultTransferred = IsConsultTransferred;
        this.RemoteParticipants = RemoteParticipants;
        this.FlowIds = FlowIds;
        this.FlowOutcomeIds = FlowOutcomeIds;
        this.FlowOutcomeValues = FlowOutcomeValues;
        this.FlowDestinationTypes = FlowDestinationTypes;
        this.FlowDisconnectReasons = FlowDisconnectReasons;
        this.FlowTypes = FlowTypes;
        this.FlowEntryTypes = FlowEntryTypes;
        this.FlowEntryReasons = FlowEntryReasons;
        this.FlowVersions = FlowVersions;
        this.GroupIds = GroupIds;
        this.HasJourneyCustomerId = HasJourneyCustomerId;
        this.HasJourneyActionMapId = HasJourneyActionMapId;
        this.HasJourneyVisitId = HasJourneyVisitId;
        this.HasMedia = HasMedia;
        this.RoleIds = RoleIds;
        this.ReportsTos = ReportsTos;
        this.LocationIds = LocationIds;
        this.FlowOutTypes = FlowOutTypes;
        this.ProviderList = ProviderList;
        this.CallbackNumberList = CallbackNumberList;
        this.CallbackInterval = CallbackInterval;
        this.UsedRoutingTypes = UsedRoutingTypes;
        this.RequestedRoutingTypes = RequestedRoutingTypes;
        this.HasAgentAssistId = HasAgentAssistId;
        this.Transcripts = Transcripts;
        this.TranscriptLanguages = TranscriptLanguages;
        this.ParticipantPurposes = ParticipantPurposes;
        this.ShowFirstQueue = ShowFirstQueue;
        this.TeamIds = TeamIds;
        this.FilterUsersByTeamIds = FilterUsersByTeamIds;
        this.JourneyActionMapIds = JourneyActionMapIds;
        this.JourneyOutcomeIds = JourneyOutcomeIds;
        this.JourneySegmentIds = JourneySegmentIds;
        this.JourneyActionMapTypes = JourneyActionMapTypes;
        this.DevelopmentRoleList = DevelopmentRoleList;
        this.DevelopmentTypeList = DevelopmentTypeList;
        this.DevelopmentStatusList = DevelopmentStatusList;
        this.DevelopmentModuleIds = DevelopmentModuleIds;
        this.DevelopmentActivityOverdue = DevelopmentActivityOverdue;
        this.CustomerSentimentScore = CustomerSentimentScore;
        this.CustomerSentimentTrend = CustomerSentimentTrend;
        this.FlowTransferTargets = FlowTransferTargets;
        this.DevelopmentName = DevelopmentName;
        this.TopicIds = TopicIds;
        this.ExternalTags = ExternalTags;
        this.IsNotResponding = IsNotResponding;
        this.IsAuthenticated = IsAuthenticated;
        this.BotIds = BotIds;
        this.BotVersions = BotVersions;
        this.BotMessageTypes = BotMessageTypes;
        this.BotProviderList = BotProviderList;
        this.BotProductList = BotProductList;
        this.BotRecognitionFailureReasonList = BotRecognitionFailureReasonList;
        this.BotIntentList = BotIntentList;
        this.BotFinalIntentList = BotFinalIntentList;
        this.BotSlotList = BotSlotList;
        this.BotResultList = BotResultList;
        this.BlockedReasons = BlockedReasons;
        this.IsRecorded = IsRecorded;
        this.HasEvaluation = HasEvaluation;
        this.HasScoredEvaluation = HasScoredEvaluation;
        this.EmailDeliveryStatusList = EmailDeliveryStatusList;
        this.IsAgentOwnedCallback = IsAgentOwnedCallback;
        this.AgentCallbackOwnerIds = AgentCallbackOwnerIds;
        this.TranscriptTopics = TranscriptTopics;
        this.JourneyFrequencyCapReasons = JourneyFrequencyCapReasons;
        this.JourneyBlockingActionMapIds = JourneyBlockingActionMapIds;
        this.JourneyActionTargetIds = JourneyActionTargetIds;
        this.JourneyBlockingScheduleGroupIds = JourneyBlockingScheduleGroupIds;
        this.JourneyBlockingEmergencyScheduleGroupIds = JourneyBlockingEmergencyScheduleGroupIds;
        this.JourneyUrlEqualConditions = JourneyUrlEqualConditions;
        this.JourneyUrlNotEqualConditions = JourneyUrlNotEqualConditions;
        this.JourneyUrlStartsWithConditions = JourneyUrlStartsWithConditions;
        this.JourneyUrlEndsWithConditions = JourneyUrlEndsWithConditions;
        this.JourneyUrlContainsAnyConditions = JourneyUrlContainsAnyConditions;
        this.JourneyUrlNotContainsAnyConditions = JourneyUrlNotContainsAnyConditions;
        this.JourneyUrlContainsAllConditions = JourneyUrlContainsAllConditions;
        this.JourneyUrlNotContainsAllConditions = JourneyUrlNotContainsAllConditions;
        this.FlowMilestoneIds = FlowMilestoneIds;
        this.IsAssessmentPassed = IsAssessmentPassed;
        this.ConversationInitiators = ConversationInitiators;
        this.HasCustomerParticipated = HasCustomerParticipated;
        this.IsAcdInteraction = IsAcdInteraction;
        this.HasFax = HasFax;
        this.DataActionIds = DataActionIds;
        this.ActionCategoryName = ActionCategoryName;
        this.IntegrationIds = IntegrationIds;
        this.ResponseStatuses = ResponseStatuses;
        this.AvailableDashboard = AvailableDashboard;
        this.FavouriteDashboard = FavouriteDashboard;
        this.MyDashboard = MyDashboard;
        this.StationErrors = StationErrors;
        this.CanonicalContactIds = CanonicalContactIds;
        this.AlertRuleIds = AlertRuleIds;
        this.EvaluationFormContextIds = EvaluationFormContextIds;
        this.EvaluationStatuses = EvaluationStatuses;
        this.WorkbinIds = WorkbinIds;
        this.WorktypeIds = WorktypeIds;
        this.WorkitemIds = WorkitemIds;
        this.WorkitemAssigneeIds = WorkitemAssigneeIds;
        this.WorkitemStatuses = WorkitemStatuses;
        this.IsAnalyzedForSensitiveData = IsAnalyzedForSensitiveData;
        this.HasSensitiveData = HasSensitiveData;
        this.HasPciData = HasPciData;
        this.HasPiiData = HasPiiData;
        this.SubPath = SubPath;
        this.UserState = UserState;
        this.IsClearedByCustomer = IsClearedByCustomer;
        this.EvaluationAssigneeIds = EvaluationAssigneeIds;
        this.EvaluationAssigned = EvaluationAssigned;
        this.AssistantIds = AssistantIds;
        this.KnowledgeBaseIds = KnowledgeBaseIds;
        this.IsParked = IsParked;
        this.AgentEmpathyScore = AgentEmpathyScore;
        this.SurveyTypes = SurveyTypes;
        this.SurveyResponseStatuses = SurveyResponseStatuses;
        this.BotFlowTypes = BotFlowTypes;
        this.AgentTalkDurationMilliseconds = AgentTalkDurationMilliseconds;
        this.CustomerTalkDurationMilliseconds = CustomerTalkDurationMilliseconds;
        this.OvertalkDurationMilliseconds = OvertalkDurationMilliseconds;
        this.SilenceDurationMilliseconds = SilenceDurationMilliseconds;
        this.AcdDurationMilliseconds = AcdDurationMilliseconds;
        this.IvrDurationMilliseconds = IvrDurationMilliseconds;
        this.OtherDurationMilliseconds = OtherDurationMilliseconds;
        this.AgentTalkPercentage = AgentTalkPercentage;
        this.CustomerTalkPercentage = CustomerTalkPercentage;
        this.OvertalkPercentage = OvertalkPercentage;
        this.SilencePercentage = SilencePercentage;
        this.AcdPercentage = AcdPercentage;
        this.IvrPercentage = IvrPercentage;
        this.OtherPercentage = OtherPercentage;
        this.OvertalkInstances = OvertalkInstances;
        this.IsScreenRecorded = IsScreenRecorded;
        this.ScreenMonitorUserIds = ScreenMonitorUserIds;
        this.DashboardState = DashboardState;
        this.DashboardType = DashboardType;
        this.DashboardAccessFilter = DashboardAccessFilter;
        this.TranscriptDurationMilliseconds = TranscriptDurationMilliseconds;
        this.WorkitemsStatuses = WorkitemsStatuses;
        this.SocialCountries = SocialCountries;
        this.SocialLanguages = SocialLanguages;
        this.SocialChannels = SocialChannels;
        this.SocialSentimentCategory = SocialSentimentCategory;
        this.SocialTopicIds = SocialTopicIds;
        this.SocialIngestionRuleIds = SocialIngestionRuleIds;
        this.SocialConversationCreated = SocialConversationCreated;
        this.SocialContentType = SocialContentType;
        this.SocialKeywords = SocialKeywords;
        this.SocialPostEscalated = SocialPostEscalated;
        this.SocialClassifications = SocialClassifications;
        this.FilterUsersByManagerIds = FilterUsersByManagerIds;
        this.SlideshowIds = SlideshowIds;
        this.Conferenced = Conferenced;
        this.Video = Video;
        this.LinkedInteraction = LinkedInteraction;
        this.RecommendationSources = RecommendationSources;
        this.EvaluationRole = EvaluationRole;
        this.ComparisonQueueIds = ComparisonQueueIds;
        this.ViewMetrics = ViewMetrics;
        this.TimelineCategories = TimelineCategories;
        this.Acw = Acw;
        this.SegmentTypes = SegmentTypes;
        this.ProgramIds = ProgramIds;
        this.CategoryIds = CategoryIds;

    }



    /// <summary>
    /// The media types are used to filter the view
    /// </summary>
    /// <value>The media types are used to filter the view</value>
    [JsonPropertyName("mediaTypes")]
    public List<MediaTypesEnum> MediaTypes { get; set; }



    /// <summary>
    /// The queue ids are used to filter the view
    /// </summary>
    /// <value>The queue ids are used to filter the view</value>
    [JsonPropertyName("queueIds")]
    public List<string> QueueIds { get; set; }



    /// <summary>
    /// The skill ids are used to filter the view
    /// </summary>
    /// <value>The skill ids are used to filter the view</value>
    [JsonPropertyName("skillIds")]
    public List<string> SkillIds { get; set; }



    /// <summary>
    /// The assigned user skill ids are used to filter the view
    /// </summary>
    /// <value>The assigned user skill ids are used to filter the view</value>
    [JsonPropertyName("assignedSkillIds")]
    public List<string> AssignedSkillIds { get; set; }



    /// <summary>
    /// The skill groups used to filter the view
    /// </summary>
    /// <value>The skill groups used to filter the view</value>
    [JsonPropertyName("skillGroups")]
    public List<string> SkillGroups { get; set; }



    /// <summary>
    /// The language ids are used to filter the view
    /// </summary>
    /// <value>The language ids are used to filter the view</value>
    [JsonPropertyName("languageIds")]
    public List<string> LanguageIds { get; set; }



    /// <summary>
    /// The assigned user language ids are used to filter the view
    /// </summary>
    /// <value>The assigned user language ids are used to filter the view</value>
    [JsonPropertyName("assignedLanguageIds")]
    public List<string> AssignedLanguageIds { get; set; }



    /// <summary>
    /// The language groups used to filter the view
    /// </summary>
    /// <value>The language groups used to filter the view</value>
    [JsonPropertyName("languageGroups")]
    public List<string> LanguageGroups { get; set; }



    /// <summary>
    /// The directions are used to filter the view
    /// </summary>
    /// <value>The directions are used to filter the view</value>
    [JsonPropertyName("directions")]
    public List<DirectionsEnum> Directions { get; set; }



    /// <summary>
    /// The list of orginating directions used to filter the view
    /// </summary>
    /// <value>The list of orginating directions used to filter the view</value>
    [JsonPropertyName("originatingDirections")]
    public List<OriginatingDirectionsEnum> OriginatingDirections { get; set; }



    /// <summary>
    /// The wrap up codes are used to filter the view
    /// </summary>
    /// <value>The wrap up codes are used to filter the view</value>
    [JsonPropertyName("wrapUpCodes")]
    public List<string> WrapUpCodes { get; set; }



    /// <summary>
    /// The dnis list is used to filter the view
    /// </summary>
    /// <value>The dnis list is used to filter the view</value>
    [JsonPropertyName("dnisList")]
    public List<string> DnisList { get; set; }



    /// <summary>
    /// The list of session dnis used to filter the view
    /// </summary>
    /// <value>The list of session dnis used to filter the view</value>
    [JsonPropertyName("sessionDnisList")]
    public List<string> SessionDnisList { get; set; }



    /// <summary>
    /// The user ids are used to fetch associated queues for the view
    /// </summary>
    /// <value>The user ids are used to fetch associated queues for the view</value>
    [JsonPropertyName("filterQueuesByUserIds")]
    public List<string> FilterQueuesByUserIds { get; set; }



    /// <summary>
    /// The queue ids are used to fetch associated users for the view
    /// </summary>
    /// <value>The queue ids are used to fetch associated users for the view</value>
    [JsonPropertyName("filterUsersByQueueIds")]
    public List<string> FilterUsersByQueueIds { get; set; }



    /// <summary>
    /// The user ids are used to filter the view
    /// </summary>
    /// <value>The user ids are used to filter the view</value>
    [JsonPropertyName("userIds")]
    public List<string> UserIds { get; set; }



    /// <summary>
    /// The management unit ids are used to filter the view
    /// </summary>
    /// <value>The management unit ids are used to filter the view</value>
    [JsonPropertyName("managementUnitIds")]
    public List<string> ManagementUnitIds { get; set; }



    /// <summary>
    /// The address To values are used to filter the view
    /// </summary>
    /// <value>The address To values are used to filter the view</value>
    [JsonPropertyName("addressTos")]
    public List<string> AddressTos { get; set; }



    /// <summary>
    /// The address from values are used to filter the view
    /// </summary>
    /// <value>The address from values are used to filter the view</value>
    [JsonPropertyName("addressFroms")]
    public List<string> AddressFroms { get; set; }



    /// <summary>
    /// The outbound campaign ids are used to filter the view
    /// </summary>
    /// <value>The outbound campaign ids are used to filter the view</value>
    [JsonPropertyName("outboundCampaignIds")]
    public List<string> OutboundCampaignIds { get; set; }



    /// <summary>
    /// The outbound contact list ids are used to filter the view
    /// </summary>
    /// <value>The outbound contact list ids are used to filter the view</value>
    [JsonPropertyName("outboundContactListIds")]
    public List<string> OutboundContactListIds { get; set; }



    /// <summary>
    /// The contact ids are used to filter the view
    /// </summary>
    /// <value>The contact ids are used to filter the view</value>
    [JsonPropertyName("contactIds")]
    public List<string> ContactIds { get; set; }



    /// <summary>
    /// The external contact ids are used to filter the view
    /// </summary>
    /// <value>The external contact ids are used to filter the view</value>
    [JsonPropertyName("externalContactIds")]
    public List<string> ExternalContactIds { get; set; }



    /// <summary>
    /// The external org ids are used to filter the view
    /// </summary>
    /// <value>The external org ids are used to filter the view</value>
    [JsonPropertyName("externalOrgIds")]
    public List<string> ExternalOrgIds { get; set; }



    /// <summary>
    /// The ani list ids are used to filter the view
    /// </summary>
    /// <value>The ani list ids are used to filter the view</value>
    [JsonPropertyName("aniList")]
    public List<string> AniList { get; set; }



    /// <summary>
    /// The durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The durations in milliseconds used to filter the view</value>
    [JsonPropertyName("durationsMilliseconds")]
    public List<NumericRange> DurationsMilliseconds { get; set; }



    /// <summary>
    /// The acd durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acd durations in milliseconds used to filter the view</value>
    [JsonPropertyName("acdDurationsMilliseconds")]
    public List<NumericRange> AcdDurationsMilliseconds { get; set; }



    /// <summary>
    /// The talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The talk durations in milliseconds used to filter the view</value>
    [JsonPropertyName("talkDurationsMilliseconds")]
    public List<NumericRange> TalkDurationsMilliseconds { get; set; }



    /// <summary>
    /// The acw durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acw durations in milliseconds used to filter the view</value>
    [JsonPropertyName("acwDurationsMilliseconds")]
    public List<NumericRange> AcwDurationsMilliseconds { get; set; }



    /// <summary>
    /// The handle durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The handle durations in milliseconds used to filter the view</value>
    [JsonPropertyName("handleDurationsMilliseconds")]
    public List<NumericRange> HandleDurationsMilliseconds { get; set; }



    /// <summary>
    /// The hold durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The hold durations in milliseconds used to filter the view</value>
    [JsonPropertyName("holdDurationsMilliseconds")]
    public List<NumericRange> HoldDurationsMilliseconds { get; set; }



    /// <summary>
    /// The abandon durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The abandon durations in milliseconds used to filter the view</value>
    [JsonPropertyName("abandonDurationsMilliseconds")]
    public List<NumericRange> AbandonDurationsMilliseconds { get; set; }



    /// <summary>
    /// The evaluationScore is used to filter the view
    /// </summary>
    /// <value>The evaluationScore is used to filter the view</value>
    [JsonPropertyName("evaluationScore")]
    public NumericRange EvaluationScore { get; set; }



    /// <summary>
    /// The evaluationCriticalScore is used to filter the view
    /// </summary>
    /// <value>The evaluationCriticalScore is used to filter the view</value>
    [JsonPropertyName("evaluationCriticalScore")]
    public NumericRange EvaluationCriticalScore { get; set; }



    /// <summary>
    /// The evaluation form ids are used to filter the view
    /// </summary>
    /// <value>The evaluation form ids are used to filter the view</value>
    [JsonPropertyName("evaluationFormIds")]
    public List<string> EvaluationFormIds { get; set; }



    /// <summary>
    /// The evaluated agent ids are used to filter the view
    /// </summary>
    /// <value>The evaluated agent ids are used to filter the view</value>
    [JsonPropertyName("evaluatedAgentIds")]
    public List<string> EvaluatedAgentIds { get; set; }



    /// <summary>
    /// The evaluator ids are used to filter the view
    /// </summary>
    /// <value>The evaluator ids are used to filter the view</value>
    [JsonPropertyName("evaluatorIds")]
    public List<string> EvaluatorIds { get; set; }



    /// <summary>
    /// Indicates filtering for transfers
    /// </summary>
    /// <value>Indicates filtering for transfers</value>
    [JsonPropertyName("transferred")]
    public bool? Transferred { get; set; }



    /// <summary>
    /// Indicates filtering for abandons
    /// </summary>
    /// <value>Indicates filtering for abandons</value>
    [JsonPropertyName("abandoned")]
    public bool? Abandoned { get; set; }



    /// <summary>
    /// Indicates filtering for answered interactions
    /// </summary>
    /// <value>Indicates filtering for answered interactions</value>
    [JsonPropertyName("answered")]
    public bool? Answered { get; set; }



    /// <summary>
    /// The message media types used to filter the view
    /// </summary>
    /// <value>The message media types used to filter the view</value>
    [JsonPropertyName("messageTypes")]
    public List<MessageTypesEnum> MessageTypes { get; set; }



    /// <summary>
    /// The divison Ids used to filter the view
    /// </summary>
    /// <value>The divison Ids used to filter the view</value>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// The survey form ids used to filter the view
    /// </summary>
    /// <value>The survey form ids used to filter the view</value>
    [JsonPropertyName("surveyFormIds")]
    public List<string> SurveyFormIds { get; set; }



    /// <summary>
    /// The survey total score used to filter the view
    /// </summary>
    /// <value>The survey total score used to filter the view</value>
    [JsonPropertyName("surveyTotalScore")]
    public NumericRange SurveyTotalScore { get; set; }



    /// <summary>
    /// The survey NPS score used to filter the view
    /// </summary>
    /// <value>The survey NPS score used to filter the view</value>
    [JsonPropertyName("surveyNpsScore")]
    public NumericRange SurveyNpsScore { get; set; }



    /// <summary>
    /// The desired range for mos values
    /// </summary>
    /// <value>The desired range for mos values</value>
    [JsonPropertyName("mos")]
    public NumericRange Mos { get; set; }



    /// <summary>
    /// The survey question group score used to filter the view
    /// </summary>
    /// <value>The survey question group score used to filter the view</value>
    [JsonPropertyName("surveyQuestionGroupScore")]
    public NumericRange SurveyQuestionGroupScore { get; set; }



    /// <summary>
    /// The survey promoter score used to filter the view
    /// </summary>
    /// <value>The survey promoter score used to filter the view</value>
    [JsonPropertyName("surveyPromoterScore")]
    public NumericRange SurveyPromoterScore { get; set; }



    /// <summary>
    /// The list of survey form context ids used to filter the view
    /// </summary>
    /// <value>The list of survey form context ids used to filter the view</value>
    [JsonPropertyName("surveyFormContextIds")]
    public List<string> SurveyFormContextIds { get; set; }



    /// <summary>
    /// The list of conversation ids used to filter the view
    /// </summary>
    /// <value>The list of conversation ids used to filter the view</value>
    [JsonPropertyName("conversationIds")]
    public List<string> ConversationIds { get; set; }



    /// <summary>
    /// The list of SIP call ids used to filter the view
    /// </summary>
    /// <value>The list of SIP call ids used to filter the view</value>
    [JsonPropertyName("sipCallIds")]
    public List<string> SipCallIds { get; set; }



    /// <summary>
    /// Indicates filtering for ended
    /// </summary>
    /// <value>Indicates filtering for ended</value>
    [JsonPropertyName("isEnded")]
    public bool? IsEnded { get; set; }



    /// <summary>
    /// Indicates filtering for survey
    /// </summary>
    /// <value>Indicates filtering for survey</value>
    [JsonPropertyName("isSurveyed")]
    public bool? IsSurveyed { get; set; }



    /// <summary>
    /// The list of survey score ranges used to filter the view
    /// </summary>
    /// <value>The list of survey score ranges used to filter the view</value>
    [JsonPropertyName("surveyScores")]
    public List<NumericRange> SurveyScores { get; set; }



    /// <summary>
    /// The list of promoter score ranges used to filter the view
    /// </summary>
    /// <value>The list of promoter score ranges used to filter the view</value>
    [JsonPropertyName("promoterScores")]
    public List<NumericRange> PromoterScores { get; set; }



    /// <summary>
    /// Indicates filtering for campaign
    /// </summary>
    /// <value>Indicates filtering for campaign</value>
    [JsonPropertyName("isCampaign")]
    public bool? IsCampaign { get; set; }



    /// <summary>
    /// The list of survey statuses used to filter the view
    /// </summary>
    /// <value>The list of survey statuses used to filter the view</value>
    [JsonPropertyName("surveyStatuses")]
    public List<string> SurveyStatuses { get; set; }



    /// <summary>
    /// A grouping of conversation level filters
    /// </summary>
    /// <value>A grouping of conversation level filters</value>
    [JsonPropertyName("conversationProperties")]
    public ConversationProperties ConversationProperties { get; set; }



    /// <summary>
    /// Indicates filtering for blind transferred
    /// </summary>
    /// <value>Indicates filtering for blind transferred</value>
    [JsonPropertyName("isBlindTransferred")]
    public bool? IsBlindTransferred { get; set; }



    /// <summary>
    /// Indicates filtering for consulted
    /// </summary>
    /// <value>Indicates filtering for consulted</value>
    [JsonPropertyName("isConsulted")]
    public bool? IsConsulted { get; set; }



    /// <summary>
    /// Indicates filtering for consult transferred
    /// </summary>
    /// <value>Indicates filtering for consult transferred</value>
    [JsonPropertyName("isConsultTransferred")]
    public bool? IsConsultTransferred { get; set; }



    /// <summary>
    /// The list of remote participants used to filter the view
    /// </summary>
    /// <value>The list of remote participants used to filter the view</value>
    [JsonPropertyName("remoteParticipants")]
    public List<string> RemoteParticipants { get; set; }



    /// <summary>
    /// The list of flow Ids
    /// </summary>
    /// <value>The list of flow Ids</value>
    [JsonPropertyName("flowIds")]
    public List<string> FlowIds { get; set; }



    /// <summary>
    /// A list of outcome ids of the flow
    /// </summary>
    /// <value>A list of outcome ids of the flow</value>
    [JsonPropertyName("flowOutcomeIds")]
    public List<string> FlowOutcomeIds { get; set; }



    /// <summary>
    /// A list of outcome values of the flow
    /// </summary>
    /// <value>A list of outcome values of the flow</value>
    [JsonPropertyName("flowOutcomeValues")]
    public List<FlowOutcomeValuesEnum> FlowOutcomeValues { get; set; }



    /// <summary>
    /// The list of destination types of the flow
    /// </summary>
    /// <value>The list of destination types of the flow</value>
    [JsonPropertyName("flowDestinationTypes")]
    public List<FlowDestinationTypesEnum> FlowDestinationTypes { get; set; }



    /// <summary>
    /// The list of reasons for the flow to disconnect
    /// </summary>
    /// <value>The list of reasons for the flow to disconnect</value>
    [JsonPropertyName("flowDisconnectReasons")]
    public List<FlowDisconnectReasonsEnum> FlowDisconnectReasons { get; set; }



    /// <summary>
    /// A list of types of the flow
    /// </summary>
    /// <value>A list of types of the flow</value>
    [JsonPropertyName("flowTypes")]
    public List<FlowTypesEnum> FlowTypes { get; set; }



    /// <summary>
    /// A list of types of the flow entry
    /// </summary>
    /// <value>A list of types of the flow entry</value>
    [JsonPropertyName("flowEntryTypes")]
    public List<FlowEntryTypesEnum> FlowEntryTypes { get; set; }



    /// <summary>
    /// A list of reasons of flow entry
    /// </summary>
    /// <value>A list of reasons of flow entry</value>
    [JsonPropertyName("flowEntryReasons")]
    public List<string> FlowEntryReasons { get; set; }



    /// <summary>
    /// A list of versions of a flow
    /// </summary>
    /// <value>A list of versions of a flow</value>
    [JsonPropertyName("flowVersions")]
    public List<string> FlowVersions { get; set; }



    /// <summary>
    /// A list of directory group ids
    /// </summary>
    /// <value>A list of directory group ids</value>
    [JsonPropertyName("groupIds")]
    public List<string> GroupIds { get; set; }



    /// <summary>
    /// Indicates filtering for journey customer id
    /// </summary>
    /// <value>Indicates filtering for journey customer id</value>
    [JsonPropertyName("hasJourneyCustomerId")]
    public bool? HasJourneyCustomerId { get; set; }



    /// <summary>
    /// Indicates filtering for Journey action map id
    /// </summary>
    /// <value>Indicates filtering for Journey action map id</value>
    [JsonPropertyName("hasJourneyActionMapId")]
    public bool? HasJourneyActionMapId { get; set; }



    /// <summary>
    /// Indicates filtering for Journey visit id
    /// </summary>
    /// <value>Indicates filtering for Journey visit id</value>
    [JsonPropertyName("hasJourneyVisitId")]
    public bool? HasJourneyVisitId { get; set; }



    /// <summary>
    /// Indicates filtering for presence of MMS media
    /// </summary>
    /// <value>Indicates filtering for presence of MMS media</value>
    [JsonPropertyName("hasMedia")]
    public bool? HasMedia { get; set; }



    /// <summary>
    /// The role Ids used to filter the view
    /// </summary>
    /// <value>The role Ids used to filter the view</value>
    [JsonPropertyName("roleIds")]
    public List<string> RoleIds { get; set; }



    /// <summary>
    /// The report to user IDs used to filter the view
    /// </summary>
    /// <value>The report to user IDs used to filter the view</value>
    [JsonPropertyName("reportsTos")]
    public List<string> ReportsTos { get; set; }



    /// <summary>
    /// The location Ids used to filter the view
    /// </summary>
    /// <value>The location Ids used to filter the view</value>
    [JsonPropertyName("locationIds")]
    public List<string> LocationIds { get; set; }



    /// <summary>
    /// A list of flow out types
    /// </summary>
    /// <value>A list of flow out types</value>
    [JsonPropertyName("flowOutTypes")]
    public List<string> FlowOutTypes { get; set; }



    /// <summary>
    /// A list of providers
    /// </summary>
    /// <value>A list of providers</value>
    [JsonPropertyName("providerList")]
    public List<string> ProviderList { get; set; }



    /// <summary>
    /// A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])
    /// </summary>
    /// <value>A list of callback numbers or substrings of numbers (ex: [\&quot;317\&quot;, \&quot;13172222222\&quot;])</value>
    [JsonPropertyName("callbackNumberList")]
    public List<string> CallbackNumberList { get; set; }



    /// <summary>
    /// An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss
    /// </summary>
    /// <value>An interval of time to filter for scheduled callbacks. Intervals are represented as an ISO-8601 string. For example: YYYY-MM-DDThh:mm:ss/YYYY-MM-DDThh:mm:ss</value>
    [JsonPropertyName("callbackInterval")]
    public string CallbackInterval { get; set; }



    /// <summary>
    /// A list of routing types used
    /// </summary>
    /// <value>A list of routing types used</value>
    [JsonPropertyName("usedRoutingTypes")]
    public List<UsedRoutingTypesEnum> UsedRoutingTypes { get; set; }



    /// <summary>
    /// A list of routing types requested
    /// </summary>
    /// <value>A list of routing types requested</value>
    [JsonPropertyName("requestedRoutingTypes")]
    public List<RequestedRoutingTypesEnum> RequestedRoutingTypes { get; set; }



    /// <summary>
    /// Indicates filtering for agent assist id
    /// </summary>
    /// <value>Indicates filtering for agent assist id</value>
    [JsonPropertyName("hasAgentAssistId")]
    public bool? HasAgentAssistId { get; set; }



    /// <summary>
    /// A list of transcript contents requested
    /// </summary>
    /// <value>A list of transcript contents requested</value>
    [JsonPropertyName("transcripts")]
    public List<Transcripts> Transcripts { get; set; }



    /// <summary>
    /// A list of transcript languages requested
    /// </summary>
    /// <value>A list of transcript languages requested</value>
    [JsonPropertyName("transcriptLanguages")]
    public List<string> TranscriptLanguages { get; set; }



    /// <summary>
    /// A list of participant purpose requested
    /// </summary>
    /// <value>A list of participant purpose requested</value>
    [JsonPropertyName("participantPurposes")]
    public List<ParticipantPurposesEnum> ParticipantPurposes { get; set; }



    /// <summary>
    /// Indicates filtering for first queue data
    /// </summary>
    /// <value>Indicates filtering for first queue data</value>
    [JsonPropertyName("showFirstQueue")]
    public bool? ShowFirstQueue { get; set; }



    /// <summary>
    /// The team ids used to filter the view data
    /// </summary>
    /// <value>The team ids used to filter the view data</value>
    [JsonPropertyName("teamIds")]
    public List<string> TeamIds { get; set; }



    /// <summary>
    /// The team ids are used to fetch associated users for the view
    /// </summary>
    /// <value>The team ids are used to fetch associated users for the view</value>
    [JsonPropertyName("filterUsersByTeamIds")]
    public List<string> FilterUsersByTeamIds { get; set; }



    /// <summary>
    /// The journey action map ids are used to fetch action maps for the associated view
    /// </summary>
    /// <value>The journey action map ids are used to fetch action maps for the associated view</value>
    [JsonPropertyName("journeyActionMapIds")]
    public List<string> JourneyActionMapIds { get; set; }



    /// <summary>
    /// The journey outcome ids are used to fetch outcomes for the associated view
    /// </summary>
    /// <value>The journey outcome ids are used to fetch outcomes for the associated view</value>
    [JsonPropertyName("journeyOutcomeIds")]
    public List<string> JourneyOutcomeIds { get; set; }



    /// <summary>
    /// The journey segment ids are used to fetch segments for the associated view
    /// </summary>
    /// <value>The journey segment ids are used to fetch segments for the associated view</value>
    [JsonPropertyName("journeySegmentIds")]
    public List<string> JourneySegmentIds { get; set; }



    /// <summary>
    /// The journey action map types are used to filter action map data for the associated view
    /// </summary>
    /// <value>The journey action map types are used to filter action map data for the associated view</value>
    [JsonPropertyName("journeyActionMapTypes")]
    public List<JourneyActionMapTypesEnum> JourneyActionMapTypes { get; set; }



    /// <summary>
    /// The list of development roles used to filter agent development view
    /// </summary>
    /// <value>The list of development roles used to filter agent development view</value>
    [JsonPropertyName("developmentRoleList")]
    public List<DevelopmentRoleListEnum> DevelopmentRoleList { get; set; }



    /// <summary>
    /// The list of development types used to filter agent development view
    /// </summary>
    /// <value>The list of development types used to filter agent development view</value>
    [JsonPropertyName("developmentTypeList")]
    public List<DevelopmentTypeListEnum> DevelopmentTypeList { get; set; }



    /// <summary>
    /// The list of development status used to filter agent development view
    /// </summary>
    /// <value>The list of development status used to filter agent development view</value>
    [JsonPropertyName("developmentStatusList")]
    public List<DevelopmentStatusListEnum> DevelopmentStatusList { get; set; }



    /// <summary>
    /// The list of development moduleIds used to filter agent development view
    /// </summary>
    /// <value>The list of development moduleIds used to filter agent development view</value>
    [JsonPropertyName("developmentModuleIds")]
    public List<string> DevelopmentModuleIds { get; set; }



    /// <summary>
    /// Indicates filtering for development activities
    /// </summary>
    /// <value>Indicates filtering for development activities</value>
    [JsonPropertyName("developmentActivityOverdue")]
    public bool? DevelopmentActivityOverdue { get; set; }



    /// <summary>
    /// The customer sentiment score used to filter the view
    /// </summary>
    /// <value>The customer sentiment score used to filter the view</value>
    [JsonPropertyName("customerSentimentScore")]
    public NumericRange CustomerSentimentScore { get; set; }



    /// <summary>
    /// The customer sentiment trend used to filter the view
    /// </summary>
    /// <value>The customer sentiment trend used to filter the view</value>
    [JsonPropertyName("customerSentimentTrend")]
    public NumericRange CustomerSentimentTrend { get; set; }



    /// <summary>
    /// The list of transfer targets used to filter flow data
    /// </summary>
    /// <value>The list of transfer targets used to filter flow data</value>
    [JsonPropertyName("flowTransferTargets")]
    public List<string> FlowTransferTargets { get; set; }



    /// <summary>
    /// Filter for development name
    /// </summary>
    /// <value>Filter for development name</value>
    [JsonPropertyName("developmentName")]
    public string DevelopmentName { get; set; }



    /// <summary>
    /// Represents the topics detected in the transcript
    /// </summary>
    /// <value>Represents the topics detected in the transcript</value>
    [JsonPropertyName("topicIds")]
    public List<string> TopicIds { get; set; }



    /// <summary>
    /// The list of external Tags used to filter conversation data
    /// </summary>
    /// <value>The list of external Tags used to filter conversation data</value>
    [JsonPropertyName("externalTags")]
    public List<string> ExternalTags { get; set; }



    /// <summary>
    /// Indicates filtering for not responding users
    /// </summary>
    /// <value>Indicates filtering for not responding users</value>
    [JsonPropertyName("isNotResponding")]
    public bool? IsNotResponding { get; set; }



    /// <summary>
    /// Indicates filtering for the authenticated chat
    /// </summary>
    /// <value>Indicates filtering for the authenticated chat</value>
    [JsonPropertyName("isAuthenticated")]
    public bool? IsAuthenticated { get; set; }



    /// <summary>
    /// The list of bot IDs used to filter bot views
    /// </summary>
    /// <value>The list of bot IDs used to filter bot views</value>
    [JsonPropertyName("botIds")]
    public List<string> BotIds { get; set; }



    /// <summary>
    /// The list of bot versions used to filter bot views
    /// </summary>
    /// <value>The list of bot versions used to filter bot views</value>
    [JsonPropertyName("botVersions")]
    public List<string> BotVersions { get; set; }



    /// <summary>
    /// The list of bot message types used to filter bot views
    /// </summary>
    /// <value>The list of bot message types used to filter bot views</value>
    [JsonPropertyName("botMessageTypes")]
    public List<BotMessageTypesEnum> BotMessageTypes { get; set; }



    /// <summary>
    /// The list of bot providers used to filter bot views
    /// </summary>
    /// <value>The list of bot providers used to filter bot views</value>
    [JsonPropertyName("botProviderList")]
    public List<BotProviderListEnum> BotProviderList { get; set; }



    /// <summary>
    /// The list of bot products used to filter bot views
    /// </summary>
    /// <value>The list of bot products used to filter bot views</value>
    [JsonPropertyName("botProductList")]
    public List<BotProductListEnum> BotProductList { get; set; }



    /// <summary>
    /// The list of bot recognition failure reasons used to filter bot views
    /// </summary>
    /// <value>The list of bot recognition failure reasons used to filter bot views</value>
    [JsonPropertyName("botRecognitionFailureReasonList")]
    public List<BotRecognitionFailureReasonListEnum> BotRecognitionFailureReasonList { get; set; }



    /// <summary>
    /// The list of bot intents used to filter bot views
    /// </summary>
    /// <value>The list of bot intents used to filter bot views</value>
    [JsonPropertyName("botIntentList")]
    public List<string> BotIntentList { get; set; }



    /// <summary>
    /// The list of bot final intents used to filter bot views
    /// </summary>
    /// <value>The list of bot final intents used to filter bot views</value>
    [JsonPropertyName("botFinalIntentList")]
    public List<string> BotFinalIntentList { get; set; }



    /// <summary>
    /// The list of bot slots used to filter bot views
    /// </summary>
    /// <value>The list of bot slots used to filter bot views</value>
    [JsonPropertyName("botSlotList")]
    public List<string> BotSlotList { get; set; }



    /// <summary>
    /// The list of bot results used to filter bot views
    /// </summary>
    /// <value>The list of bot results used to filter bot views</value>
    [JsonPropertyName("botResultList")]
    public List<BotResultListEnum> BotResultList { get; set; }



    /// <summary>
    /// The list of blocked reason used to filter action map constraints views
    /// </summary>
    /// <value>The list of blocked reason used to filter action map constraints views</value>
    [JsonPropertyName("blockedReasons")]
    public List<BlockedReasonsEnum> BlockedReasons { get; set; }



    /// <summary>
    /// Indicates filtering for recorded
    /// </summary>
    /// <value>Indicates filtering for recorded</value>
    [JsonPropertyName("isRecorded")]
    public bool? IsRecorded { get; set; }



    /// <summary>
    /// Indicates filtering for evaluation
    /// </summary>
    /// <value>Indicates filtering for evaluation</value>
    [JsonPropertyName("hasEvaluation")]
    public bool? HasEvaluation { get; set; }



    /// <summary>
    /// Indicates filtering for scored evaluation
    /// </summary>
    /// <value>Indicates filtering for scored evaluation</value>
    [JsonPropertyName("hasScoredEvaluation")]
    public bool? HasScoredEvaluation { get; set; }



    /// <summary>
    /// The list of email delivery statuses used to filter views
    /// </summary>
    /// <value>The list of email delivery statuses used to filter views</value>
    [JsonPropertyName("emailDeliveryStatusList")]
    public List<EmailDeliveryStatusListEnum> EmailDeliveryStatusList { get; set; }



    /// <summary>
    /// Indicates filtering for agent owned callback interactions
    /// </summary>
    /// <value>Indicates filtering for agent owned callback interactions</value>
    [JsonPropertyName("isAgentOwnedCallback")]
    public bool? IsAgentOwnedCallback { get; set; }



    /// <summary>
    /// The list of callback owners used to filter interactions
    /// </summary>
    /// <value>The list of callback owners used to filter interactions</value>
    [JsonPropertyName("agentCallbackOwnerIds")]
    public List<string> AgentCallbackOwnerIds { get; set; }



    /// <summary>
    /// The list of transcript topics requested in filter
    /// </summary>
    /// <value>The list of transcript topics requested in filter</value>
    [JsonPropertyName("transcriptTopics")]
    public List<TranscriptTopics> TranscriptTopics { get; set; }



    /// <summary>
    /// The list of frequency cap reasons to filter offer constraints
    /// </summary>
    /// <value>The list of frequency cap reasons to filter offer constraints</value>
    [JsonPropertyName("journeyFrequencyCapReasons")]
    public List<string> JourneyFrequencyCapReasons { get; set; }



    /// <summary>
    /// The list of blocking action maps to filter offer constraints
    /// </summary>
    /// <value>The list of blocking action maps to filter offer constraints</value>
    [JsonPropertyName("journeyBlockingActionMapIds")]
    public List<string> JourneyBlockingActionMapIds { get; set; }



    /// <summary>
    /// The list of action targets to filter offer constraints
    /// </summary>
    /// <value>The list of action targets to filter offer constraints</value>
    [JsonPropertyName("journeyActionTargetIds")]
    public List<string> JourneyActionTargetIds { get; set; }



    /// <summary>
    /// The list of blocking schedule groups to filter offer constraints
    /// </summary>
    /// <value>The list of blocking schedule groups to filter offer constraints</value>
    [JsonPropertyName("journeyBlockingScheduleGroupIds")]
    public List<string> JourneyBlockingScheduleGroupIds { get; set; }



    /// <summary>
    /// The list of emergency schedule groups to filter offer constraints
    /// </summary>
    /// <value>The list of emergency schedule groups to filter offer constraints</value>
    [JsonPropertyName("journeyBlockingEmergencyScheduleGroupIds")]
    public List<string> JourneyBlockingEmergencyScheduleGroupIds { get; set; }



    /// <summary>
    /// The list of url equal conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url equal conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlEqualConditions")]
    public List<string> JourneyUrlEqualConditions { get; set; }



    /// <summary>
    /// The list of url not equal conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not equal conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlNotEqualConditions")]
    public List<string> JourneyUrlNotEqualConditions { get; set; }



    /// <summary>
    /// The list of url starts with conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url starts with conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlStartsWithConditions")]
    public List<string> JourneyUrlStartsWithConditions { get; set; }



    /// <summary>
    /// The list of url ends with conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url ends with conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlEndsWithConditions")]
    public List<string> JourneyUrlEndsWithConditions { get; set; }



    /// <summary>
    /// The list of url contains any conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url contains any conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlContainsAnyConditions")]
    public List<string> JourneyUrlContainsAnyConditions { get; set; }



    /// <summary>
    /// The list of url not contains any conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not contains any conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlNotContainsAnyConditions")]
    public List<string> JourneyUrlNotContainsAnyConditions { get; set; }



    /// <summary>
    /// The list of url contains all conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url contains all conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlContainsAllConditions")]
    public List<string> JourneyUrlContainsAllConditions { get; set; }



    /// <summary>
    /// The list of url not contains all conditions to filter offer constraints
    /// </summary>
    /// <value>The list of url not contains all conditions to filter offer constraints</value>
    [JsonPropertyName("journeyUrlNotContainsAllConditions")]
    public List<string> JourneyUrlNotContainsAllConditions { get; set; }



    /// <summary>
    /// The list of flow milestones to filter exports
    /// </summary>
    /// <value>The list of flow milestones to filter exports</value>
    [JsonPropertyName("flowMilestoneIds")]
    public List<string> FlowMilestoneIds { get; set; }



    /// <summary>
    /// Filter to indicate if Agent passed assessment or not
    /// </summary>
    /// <value>Filter to indicate if Agent passed assessment or not</value>
    [JsonPropertyName("isAssessmentPassed")]
    public bool? IsAssessmentPassed { get; set; }



    /// <summary>
    /// The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation
    /// </summary>
    /// <value>The list to filter based on Brands (Bot/User/Agent) or End User who initiated the first message in the conversation</value>
    [JsonPropertyName("conversationInitiators")]
    public List<string> ConversationInitiators { get; set; }



    /// <summary>
    /// Indicates if the customer has participated in an initiated conversation
    /// </summary>
    /// <value>Indicates if the customer has participated in an initiated conversation</value>
    [JsonPropertyName("hasCustomerParticipated")]
    public bool? HasCustomerParticipated { get; set; }



    /// <summary>
    /// Filter to indicate if interaction was ACD or non-ACD
    /// </summary>
    /// <value>Filter to indicate if interaction was ACD or non-ACD</value>
    [JsonPropertyName("isAcdInteraction")]
    public bool? IsAcdInteraction { get; set; }



    /// <summary>
    /// Filters to indicate if interaction has FAX
    /// </summary>
    /// <value>Filters to indicate if interaction has FAX</value>
    [JsonPropertyName("hasFax")]
    public bool? HasFax { get; set; }



    /// <summary>
    /// The list of Data Action IDs 
    /// </summary>
    /// <value>The list of Data Action IDs </value>
    [JsonPropertyName("dataActionIds")]
    public List<string> DataActionIds { get; set; }



    /// <summary>
    /// Deprecated - Please use integrationIds instead
    /// </summary>
    /// <value>Deprecated - Please use integrationIds instead</value>
    [JsonPropertyName("actionCategoryName")]
    public string ActionCategoryName { get; set; }



    /// <summary>
    /// The list of integration IDs for Data Action
    /// </summary>
    /// <value>The list of integration IDs for Data Action</value>
    [JsonPropertyName("integrationIds")]
    public List<string> IntegrationIds { get; set; }



    /// <summary>
    /// The list of Response codes for Data Action
    /// </summary>
    /// <value>The list of Response codes for Data Action</value>
    [JsonPropertyName("responseStatuses")]
    public List<string> ResponseStatuses { get; set; }





    /// <summary>
    /// Filter to indicate whether the dashboard is favorite or unfavorite.
    /// </summary>
    /// <value>Filter to indicate whether the dashboard is favorite or unfavorite.</value>
    [JsonPropertyName("favouriteDashboard")]
    public bool? FavouriteDashboard { get; set; }



    /// <summary>
    /// Filter to indicate the dashboard owned by the user.
    /// </summary>
    /// <value>Filter to indicate the dashboard owned by the user.</value>
    [JsonPropertyName("myDashboard")]
    public bool? MyDashboard { get; set; }



    /// <summary>
    /// The list of agent errors that are related to station
    /// </summary>
    /// <value>The list of agent errors that are related to station</value>
    [JsonPropertyName("stationErrors")]
    public List<string> StationErrors { get; set; }



    /// <summary>
    /// The canonical contact ids are used to filter the view
    /// </summary>
    /// <value>The canonical contact ids are used to filter the view</value>
    [JsonPropertyName("canonicalContactIds")]
    public List<string> CanonicalContactIds { get; set; }



    /// <summary>
    /// The list of Alert Rule IDs
    /// </summary>
    /// <value>The list of Alert Rule IDs</value>
    [JsonPropertyName("alertRuleIds")]
    public List<string> AlertRuleIds { get; set; }



    /// <summary>
    /// The list of Evaluation Form Context IDs
    /// </summary>
    /// <value>The list of Evaluation Form Context IDs</value>
    [JsonPropertyName("evaluationFormContextIds")]
    public List<string> EvaluationFormContextIds { get; set; }



    /// <summary>
    /// The evaluation statuses that are used to filter the view
    /// </summary>
    /// <value>The evaluation statuses that are used to filter the view</value>
    [JsonPropertyName("evaluationStatuses")]
    public List<EvaluationStatusesEnum> EvaluationStatuses { get; set; }



    /// <summary>
    /// The list of Workbin IDs
    /// </summary>
    /// <value>The list of Workbin IDs</value>
    [JsonPropertyName("workbinIds")]
    public List<string> WorkbinIds { get; set; }



    /// <summary>
    /// The list of Worktype IDs
    /// </summary>
    /// <value>The list of Worktype IDs</value>
    [JsonPropertyName("worktypeIds")]
    public List<string> WorktypeIds { get; set; }



    /// <summary>
    /// The list of Workitem IDs
    /// </summary>
    /// <value>The list of Workitem IDs</value>
    [JsonPropertyName("workitemIds")]
    public List<string> WorkitemIds { get; set; }



    /// <summary>
    /// The list of Workitem Assignee IDs
    /// </summary>
    /// <value>The list of Workitem Assignee IDs</value>
    [JsonPropertyName("workitemAssigneeIds")]
    public List<string> WorkitemAssigneeIds { get; set; }



    /// <summary>
    /// The list of Workitem Statuses IDs
    /// </summary>
    /// <value>The list of Workitem Statuses IDs</value>
    [JsonPropertyName("workitemStatuses")]
    public List<string> WorkitemStatuses { get; set; }



    /// <summary>
    /// Deprecated - Use hasPciData or hasPiiData instead.
    /// </summary>
    /// <value>Deprecated - Use hasPciData or hasPiiData instead.</value>
    [JsonPropertyName("isAnalyzedForSensitiveData")]
    public bool? IsAnalyzedForSensitiveData { get; set; }



    /// <summary>
    /// Deprecated. Use hasPciData or hasPiiData instead.
    /// </summary>
    /// <value>Deprecated. Use hasPciData or hasPiiData instead.</value>
    [JsonPropertyName("hasSensitiveData")]
    public bool? HasSensitiveData { get; set; }



    /// <summary>
    /// Filter to indicate the transcript contains Pci data.
    /// </summary>
    /// <value>Filter to indicate the transcript contains Pci data.</value>
    [JsonPropertyName("hasPciData")]
    public bool? HasPciData { get; set; }



    /// <summary>
    /// Filter to indicate the transcript contains Pii data.
    /// </summary>
    /// <value>Filter to indicate the transcript contains Pii data.</value>
    [JsonPropertyName("hasPiiData")]
    public bool? HasPiiData { get; set; }



    /// <summary>
    /// Filter for Sub Path
    /// </summary>
    /// <value>Filter for Sub Path</value>
    [JsonPropertyName("subPath")]
    public string SubPath { get; set; }





    /// <summary>
    /// Filter to indicate if the customer cleared the conversation.
    /// </summary>
    /// <value>Filter to indicate if the customer cleared the conversation.</value>
    [JsonPropertyName("isClearedByCustomer")]
    public bool? IsClearedByCustomer { get; set; }



    /// <summary>
    /// The evaluation assignee ids that are used to filter the view.
    /// </summary>
    /// <value>The evaluation assignee ids that are used to filter the view.</value>
    [JsonPropertyName("evaluationAssigneeIds")]
    public List<string> EvaluationAssigneeIds { get; set; }



    /// <summary>
    /// Filter to indicate that the user has no assigned evaluation.
    /// </summary>
    /// <value>Filter to indicate that the user has no assigned evaluation.</value>
    [JsonPropertyName("evaluationAssigned")]
    public bool? EvaluationAssigned { get; set; }



    /// <summary>
    /// The assistant ids that are used to filter the view.
    /// </summary>
    /// <value>The assistant ids that are used to filter the view.</value>
    [JsonPropertyName("assistantIds")]
    public List<string> AssistantIds { get; set; }



    /// <summary>
    /// The knowledge base ids that are used to filter the view.
    /// </summary>
    /// <value>The knowledge base ids that are used to filter the view.</value>
    [JsonPropertyName("knowledgeBaseIds")]
    public List<string> KnowledgeBaseIds { get; set; }



    /// <summary>
    /// Filter to indicate if the interactions are parked.
    /// </summary>
    /// <value>Filter to indicate if the interactions are parked.</value>
    [JsonPropertyName("isParked")]
    public bool? IsParked { get; set; }



    /// <summary>
    /// The agentEmpathyScore is used to filter the view
    /// </summary>
    /// <value>The agentEmpathyScore is used to filter the view</value>
    [JsonPropertyName("agentEmpathyScore")]
    public NumericRange AgentEmpathyScore { get; set; }



    /// <summary>
    /// The surveyTypes is used to filter the view
    /// </summary>
    /// <value>The surveyTypes is used to filter the view</value>
    [JsonPropertyName("surveyTypes")]
    public List<SurveyTypesEnum> SurveyTypes { get; set; }



    /// <summary>
    /// The list of Survey Response Status
    /// </summary>
    /// <value>The list of Survey Response Status</value>
    [JsonPropertyName("surveyResponseStatuses")]
    public List<SurveyResponseStatusesEnum> SurveyResponseStatuses { get; set; }



    /// <summary>
    /// The botFlowTypes is used to filter the view
    /// </summary>
    /// <value>The botFlowTypes is used to filter the view</value>
    [JsonPropertyName("botFlowTypes")]
    public List<BotFlowTypesEnum> BotFlowTypes { get; set; }



    /// <summary>
    /// The agent talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The agent talk durations in milliseconds used to filter the view</value>
    [JsonPropertyName("agentTalkDurationMilliseconds")]
    public List<NumericRange> AgentTalkDurationMilliseconds { get; set; }



    /// <summary>
    /// The customer talk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The customer talk durations in milliseconds used to filter the view</value>
    [JsonPropertyName("customerTalkDurationMilliseconds")]
    public List<NumericRange> CustomerTalkDurationMilliseconds { get; set; }



    /// <summary>
    /// The overtalk durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The overtalk durations in milliseconds used to filter the view</value>
    [JsonPropertyName("overtalkDurationMilliseconds")]
    public List<NumericRange> OvertalkDurationMilliseconds { get; set; }



    /// <summary>
    /// The silence durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The silence durations in milliseconds used to filter the view</value>
    [JsonPropertyName("silenceDurationMilliseconds")]
    public List<NumericRange> SilenceDurationMilliseconds { get; set; }



    /// <summary>
    /// The acd durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The acd durations in milliseconds used to filter the view</value>
    [JsonPropertyName("acdDurationMilliseconds")]
    public List<NumericRange> AcdDurationMilliseconds { get; set; }



    /// <summary>
    /// The ivr durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The ivr durations in milliseconds used to filter the view</value>
    [JsonPropertyName("ivrDurationMilliseconds")]
    public List<NumericRange> IvrDurationMilliseconds { get; set; }



    /// <summary>
    /// The other (hold/music) durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The other (hold/music) durations in milliseconds used to filter the view</value>
    [JsonPropertyName("otherDurationMilliseconds")]
    public List<NumericRange> OtherDurationMilliseconds { get; set; }



    /// <summary>
    /// The agent talk percentage used to filter the view
    /// </summary>
    /// <value>The agent talk percentage used to filter the view</value>
    [JsonPropertyName("agentTalkPercentage")]
    public NumericRange AgentTalkPercentage { get; set; }



    /// <summary>
    /// The customer talk percentage used to filter the view
    /// </summary>
    /// <value>The customer talk percentage used to filter the view</value>
    [JsonPropertyName("customerTalkPercentage")]
    public NumericRange CustomerTalkPercentage { get; set; }



    /// <summary>
    /// The overtalk percentage used to filter the view
    /// </summary>
    /// <value>The overtalk percentage used to filter the view</value>
    [JsonPropertyName("overtalkPercentage")]
    public NumericRange OvertalkPercentage { get; set; }



    /// <summary>
    /// The silence percentage used to filter the view
    /// </summary>
    /// <value>The silence percentage used to filter the view</value>
    [JsonPropertyName("silencePercentage")]
    public NumericRange SilencePercentage { get; set; }



    /// <summary>
    /// The acd percentage used to filter the view
    /// </summary>
    /// <value>The acd percentage used to filter the view</value>
    [JsonPropertyName("acdPercentage")]
    public NumericRange AcdPercentage { get; set; }



    /// <summary>
    /// The ivr percentage used to filter the view
    /// </summary>
    /// <value>The ivr percentage used to filter the view</value>
    [JsonPropertyName("ivrPercentage")]
    public NumericRange IvrPercentage { get; set; }



    /// <summary>
    /// The other (hold/music percentage used to filter the view
    /// </summary>
    /// <value>The other (hold/music percentage used to filter the view</value>
    [JsonPropertyName("otherPercentage")]
    public NumericRange OtherPercentage { get; set; }



    /// <summary>
    /// The overtalk instance range used to filter the view
    /// </summary>
    /// <value>The overtalk instance range used to filter the view</value>
    [JsonPropertyName("overtalkInstances")]
    public NumericRange OvertalkInstances { get; set; }



    /// <summary>
    /// Filter to indicate if the screen is recorded
    /// </summary>
    /// <value>Filter to indicate if the screen is recorded</value>
    [JsonPropertyName("isScreenRecorded")]
    public bool? IsScreenRecorded { get; set; }



    /// <summary>
    /// The list of Screen Monitor User Ids
    /// </summary>
    /// <value>The list of Screen Monitor User Ids</value>
    [JsonPropertyName("screenMonitorUserIds")]
    public List<string> ScreenMonitorUserIds { get; set; }









    /// <summary>
    /// The transcript durations in milliseconds used to filter the view
    /// </summary>
    /// <value>The transcript durations in milliseconds used to filter the view</value>
    [JsonPropertyName("transcriptDurationMilliseconds")]
    public List<NumericRange> TranscriptDurationMilliseconds { get; set; }



    /// <summary>
    /// The list of workitem status with worktype
    /// </summary>
    /// <value>The list of workitem status with worktype</value>
    [JsonPropertyName("workitemsStatuses")]
    public List<WorkitemStatusFilter> WorkitemsStatuses { get; set; }



    /// <summary>
    /// List of countries for social filtering
    /// </summary>
    /// <value>List of countries for social filtering</value>
    [JsonPropertyName("socialCountries")]
    public List<string> SocialCountries { get; set; }



    /// <summary>
    /// List of languages for social filtering
    /// </summary>
    /// <value>List of languages for social filtering</value>
    [JsonPropertyName("socialLanguages")]
    public List<string> SocialLanguages { get; set; }



    /// <summary>
    /// List of channels for social filtering
    /// </summary>
    /// <value>List of channels for social filtering</value>
    [JsonPropertyName("socialChannels")]
    public List<SocialChannelsEnum> SocialChannels { get; set; }



    /// <summary>
    /// The sentiment of the social post
    /// </summary>
    /// <value>The sentiment of the social post</value>
    [JsonPropertyName("socialSentimentCategory")]
    public List<SocialSentimentCategoryEnum> SocialSentimentCategory { get; set; }



    /// <summary>
    /// The list of topicIds for social filtering
    /// </summary>
    /// <value>The list of topicIds for social filtering</value>
    [JsonPropertyName("socialTopicIds")]
    public List<string> SocialTopicIds { get; set; }



    /// <summary>
    /// The list of ingestion ruleIds for social filtering
    /// </summary>
    /// <value>The list of ingestion ruleIds for social filtering</value>
    [JsonPropertyName("socialIngestionRuleIds")]
    public List<string> SocialIngestionRuleIds { get; set; }



    /// <summary>
    /// Filter to indicate if the post has created a conversation
    /// </summary>
    /// <value>Filter to indicate if the post has created a conversation</value>
    [JsonPropertyName("socialConversationCreated")]
    public bool? SocialConversationCreated { get; set; }



    /// <summary>
    /// The list of content Type for social filtering
    /// </summary>
    /// <value>The list of content Type for social filtering</value>
    [JsonPropertyName("socialContentType")]
    public List<SocialContentTypeEnum> SocialContentType { get; set; }



    /// <summary>
    /// The list of keywords for social filtering
    /// </summary>
    /// <value>The list of keywords for social filtering</value>
    [JsonPropertyName("socialKeywords")]
    public List<SocialKeyword> SocialKeywords { get; set; }



    /// <summary>
    /// Filter to indicate if the post is escalated
    /// </summary>
    /// <value>Filter to indicate if the post is escalated</value>
    [JsonPropertyName("socialPostEscalated")]
    public bool? SocialPostEscalated { get; set; }



    /// <summary>
    /// Indicates if a social message was public or private
    /// </summary>
    /// <value>Indicates if a social message was public or private</value>
    [JsonPropertyName("socialClassifications")]
    public List<SocialClassificationsEnum> SocialClassifications { get; set; }



    /// <summary>
    /// The manager ids used to fetch associated users for the view
    /// </summary>
    /// <value>The manager ids used to fetch associated users for the view</value>
    [JsonPropertyName("filterUsersByManagerIds")]
    public List<string> FilterUsersByManagerIds { get; set; }



    /// <summary>
    /// List of Dashboard slideshowIds to be filtered
    /// </summary>
    /// <value>List of Dashboard slideshowIds to be filtered</value>
    [JsonPropertyName("slideshowIds")]
    public List<string> SlideshowIds { get; set; }



    /// <summary>
    /// Filter to indicate if the conversation has conference
    /// </summary>
    /// <value>Filter to indicate if the conversation has conference</value>
    [JsonPropertyName("conferenced")]
    public bool? Conferenced { get; set; }



    /// <summary>
    /// Filter to indicate if the conversation has video
    /// </summary>
    /// <value>Filter to indicate if the conversation has video</value>
    [JsonPropertyName("video")]
    public bool? Video { get; set; }



    /// <summary>
    /// Filter to indicate if the conversation has linked interaction
    /// </summary>
    /// <value>Filter to indicate if the conversation has linked interaction</value>
    [JsonPropertyName("linkedInteraction")]
    public bool? LinkedInteraction { get; set; }



    /// <summary>
    /// List of recommendation sources for filtering recommendation details pane
    /// </summary>
    /// <value>List of recommendation sources for filtering recommendation details pane</value>
    [JsonPropertyName("recommendationSources")]
    public List<RecommendationSourcesEnum> RecommendationSources { get; set; }





    /// <summary>
    /// The queue ids are used to for comparison to the primary queue filter in reporting
    /// </summary>
    /// <value>The queue ids are used to for comparison to the primary queue filter in reporting</value>
    [JsonPropertyName("comparisonQueueIds")]
    public List<string> ComparisonQueueIds { get; set; }



    /// <summary>
    /// A list of metrics selected for the view
    /// </summary>
    /// <value>A list of metrics selected for the view</value>
    [JsonPropertyName("viewMetrics")]
    public List<ViewMetricsEnum> ViewMetrics { get; set; }



    /// <summary>
    /// A list of timeline categories
    /// </summary>
    /// <value>A list of timeline categories</value>
    [JsonPropertyName("timelineCategories")]
    public List<string> TimelineCategories { get; set; }



    /// <summary>
    /// Filter to indicate for acw state
    /// </summary>
    /// <value>Filter to indicate for acw state</value>
    [JsonPropertyName("acw")]
    public bool? Acw { get; set; }



    /// <summary>
    /// A list of filtered segment types
    /// </summary>
    /// <value>A list of filtered segment types</value>
    [JsonPropertyName("segmentTypes")]
    public List<SegmentTypesEnum> SegmentTypes { get; set; }



    /// <summary>
    /// A list of program ids for filtering
    /// </summary>
    /// <value>A list of program ids for filtering</value>
    [JsonPropertyName("programIds")]
    public List<string> ProgramIds { get; set; }



    /// <summary>
    /// A list of category ids for filtering
    /// </summary>
    /// <value>A list of category ids for filtering</value>
    [JsonPropertyName("categoryIds")]
    public List<string> CategoryIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ViewFilter {\n");

        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
        sb.Append("  SkillIds: ").Append(SkillIds).Append("\n");
        sb.Append("  AssignedSkillIds: ").Append(AssignedSkillIds).Append("\n");
        sb.Append("  SkillGroups: ").Append(SkillGroups).Append("\n");
        sb.Append("  LanguageIds: ").Append(LanguageIds).Append("\n");
        sb.Append("  AssignedLanguageIds: ").Append(AssignedLanguageIds).Append("\n");
        sb.Append("  LanguageGroups: ").Append(LanguageGroups).Append("\n");
        sb.Append("  Directions: ").Append(Directions).Append("\n");
        sb.Append("  OriginatingDirections: ").Append(OriginatingDirections).Append("\n");
        sb.Append("  WrapUpCodes: ").Append(WrapUpCodes).Append("\n");
        sb.Append("  DnisList: ").Append(DnisList).Append("\n");
        sb.Append("  SessionDnisList: ").Append(SessionDnisList).Append("\n");
        sb.Append("  FilterQueuesByUserIds: ").Append(FilterQueuesByUserIds).Append("\n");
        sb.Append("  FilterUsersByQueueIds: ").Append(FilterUsersByQueueIds).Append("\n");
        sb.Append("  UserIds: ").Append(UserIds).Append("\n");
        sb.Append("  ManagementUnitIds: ").Append(ManagementUnitIds).Append("\n");
        sb.Append("  AddressTos: ").Append(AddressTos).Append("\n");
        sb.Append("  AddressFroms: ").Append(AddressFroms).Append("\n");
        sb.Append("  OutboundCampaignIds: ").Append(OutboundCampaignIds).Append("\n");
        sb.Append("  OutboundContactListIds: ").Append(OutboundContactListIds).Append("\n");
        sb.Append("  ContactIds: ").Append(ContactIds).Append("\n");
        sb.Append("  ExternalContactIds: ").Append(ExternalContactIds).Append("\n");
        sb.Append("  ExternalOrgIds: ").Append(ExternalOrgIds).Append("\n");
        sb.Append("  AniList: ").Append(AniList).Append("\n");
        sb.Append("  DurationsMilliseconds: ").Append(DurationsMilliseconds).Append("\n");
        sb.Append("  AcdDurationsMilliseconds: ").Append(AcdDurationsMilliseconds).Append("\n");
        sb.Append("  TalkDurationsMilliseconds: ").Append(TalkDurationsMilliseconds).Append("\n");
        sb.Append("  AcwDurationsMilliseconds: ").Append(AcwDurationsMilliseconds).Append("\n");
        sb.Append("  HandleDurationsMilliseconds: ").Append(HandleDurationsMilliseconds).Append("\n");
        sb.Append("  HoldDurationsMilliseconds: ").Append(HoldDurationsMilliseconds).Append("\n");
        sb.Append("  AbandonDurationsMilliseconds: ").Append(AbandonDurationsMilliseconds).Append("\n");
        sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
        sb.Append("  EvaluationCriticalScore: ").Append(EvaluationCriticalScore).Append("\n");
        sb.Append("  EvaluationFormIds: ").Append(EvaluationFormIds).Append("\n");
        sb.Append("  EvaluatedAgentIds: ").Append(EvaluatedAgentIds).Append("\n");
        sb.Append("  EvaluatorIds: ").Append(EvaluatorIds).Append("\n");
        sb.Append("  Transferred: ").Append(Transferred).Append("\n");
        sb.Append("  Abandoned: ").Append(Abandoned).Append("\n");
        sb.Append("  Answered: ").Append(Answered).Append("\n");
        sb.Append("  MessageTypes: ").Append(MessageTypes).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  SurveyFormIds: ").Append(SurveyFormIds).Append("\n");
        sb.Append("  SurveyTotalScore: ").Append(SurveyTotalScore).Append("\n");
        sb.Append("  SurveyNpsScore: ").Append(SurveyNpsScore).Append("\n");
        sb.Append("  Mos: ").Append(Mos).Append("\n");
        sb.Append("  SurveyQuestionGroupScore: ").Append(SurveyQuestionGroupScore).Append("\n");
        sb.Append("  SurveyPromoterScore: ").Append(SurveyPromoterScore).Append("\n");
        sb.Append("  SurveyFormContextIds: ").Append(SurveyFormContextIds).Append("\n");
        sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
        sb.Append("  SipCallIds: ").Append(SipCallIds).Append("\n");
        sb.Append("  IsEnded: ").Append(IsEnded).Append("\n");
        sb.Append("  IsSurveyed: ").Append(IsSurveyed).Append("\n");
        sb.Append("  SurveyScores: ").Append(SurveyScores).Append("\n");
        sb.Append("  PromoterScores: ").Append(PromoterScores).Append("\n");
        sb.Append("  IsCampaign: ").Append(IsCampaign).Append("\n");
        sb.Append("  SurveyStatuses: ").Append(SurveyStatuses).Append("\n");
        sb.Append("  ConversationProperties: ").Append(ConversationProperties).Append("\n");
        sb.Append("  IsBlindTransferred: ").Append(IsBlindTransferred).Append("\n");
        sb.Append("  IsConsulted: ").Append(IsConsulted).Append("\n");
        sb.Append("  IsConsultTransferred: ").Append(IsConsultTransferred).Append("\n");
        sb.Append("  RemoteParticipants: ").Append(RemoteParticipants).Append("\n");
        sb.Append("  FlowIds: ").Append(FlowIds).Append("\n");
        sb.Append("  FlowOutcomeIds: ").Append(FlowOutcomeIds).Append("\n");
        sb.Append("  FlowOutcomeValues: ").Append(FlowOutcomeValues).Append("\n");
        sb.Append("  FlowDestinationTypes: ").Append(FlowDestinationTypes).Append("\n");
        sb.Append("  FlowDisconnectReasons: ").Append(FlowDisconnectReasons).Append("\n");
        sb.Append("  FlowTypes: ").Append(FlowTypes).Append("\n");
        sb.Append("  FlowEntryTypes: ").Append(FlowEntryTypes).Append("\n");
        sb.Append("  FlowEntryReasons: ").Append(FlowEntryReasons).Append("\n");
        sb.Append("  FlowVersions: ").Append(FlowVersions).Append("\n");
        sb.Append("  GroupIds: ").Append(GroupIds).Append("\n");
        sb.Append("  HasJourneyCustomerId: ").Append(HasJourneyCustomerId).Append("\n");
        sb.Append("  HasJourneyActionMapId: ").Append(HasJourneyActionMapId).Append("\n");
        sb.Append("  HasJourneyVisitId: ").Append(HasJourneyVisitId).Append("\n");
        sb.Append("  HasMedia: ").Append(HasMedia).Append("\n");
        sb.Append("  RoleIds: ").Append(RoleIds).Append("\n");
        sb.Append("  ReportsTos: ").Append(ReportsTos).Append("\n");
        sb.Append("  LocationIds: ").Append(LocationIds).Append("\n");
        sb.Append("  FlowOutTypes: ").Append(FlowOutTypes).Append("\n");
        sb.Append("  ProviderList: ").Append(ProviderList).Append("\n");
        sb.Append("  CallbackNumberList: ").Append(CallbackNumberList).Append("\n");
        sb.Append("  CallbackInterval: ").Append(CallbackInterval).Append("\n");
        sb.Append("  UsedRoutingTypes: ").Append(UsedRoutingTypes).Append("\n");
        sb.Append("  RequestedRoutingTypes: ").Append(RequestedRoutingTypes).Append("\n");
        sb.Append("  HasAgentAssistId: ").Append(HasAgentAssistId).Append("\n");
        sb.Append("  Transcripts: ").Append(Transcripts).Append("\n");
        sb.Append("  TranscriptLanguages: ").Append(TranscriptLanguages).Append("\n");
        sb.Append("  ParticipantPurposes: ").Append(ParticipantPurposes).Append("\n");
        sb.Append("  ShowFirstQueue: ").Append(ShowFirstQueue).Append("\n");
        sb.Append("  TeamIds: ").Append(TeamIds).Append("\n");
        sb.Append("  FilterUsersByTeamIds: ").Append(FilterUsersByTeamIds).Append("\n");
        sb.Append("  JourneyActionMapIds: ").Append(JourneyActionMapIds).Append("\n");
        sb.Append("  JourneyOutcomeIds: ").Append(JourneyOutcomeIds).Append("\n");
        sb.Append("  JourneySegmentIds: ").Append(JourneySegmentIds).Append("\n");
        sb.Append("  JourneyActionMapTypes: ").Append(JourneyActionMapTypes).Append("\n");
        sb.Append("  DevelopmentRoleList: ").Append(DevelopmentRoleList).Append("\n");
        sb.Append("  DevelopmentTypeList: ").Append(DevelopmentTypeList).Append("\n");
        sb.Append("  DevelopmentStatusList: ").Append(DevelopmentStatusList).Append("\n");
        sb.Append("  DevelopmentModuleIds: ").Append(DevelopmentModuleIds).Append("\n");
        sb.Append("  DevelopmentActivityOverdue: ").Append(DevelopmentActivityOverdue).Append("\n");
        sb.Append("  CustomerSentimentScore: ").Append(CustomerSentimentScore).Append("\n");
        sb.Append("  CustomerSentimentTrend: ").Append(CustomerSentimentTrend).Append("\n");
        sb.Append("  FlowTransferTargets: ").Append(FlowTransferTargets).Append("\n");
        sb.Append("  DevelopmentName: ").Append(DevelopmentName).Append("\n");
        sb.Append("  TopicIds: ").Append(TopicIds).Append("\n");
        sb.Append("  ExternalTags: ").Append(ExternalTags).Append("\n");
        sb.Append("  IsNotResponding: ").Append(IsNotResponding).Append("\n");
        sb.Append("  IsAuthenticated: ").Append(IsAuthenticated).Append("\n");
        sb.Append("  BotIds: ").Append(BotIds).Append("\n");
        sb.Append("  BotVersions: ").Append(BotVersions).Append("\n");
        sb.Append("  BotMessageTypes: ").Append(BotMessageTypes).Append("\n");
        sb.Append("  BotProviderList: ").Append(BotProviderList).Append("\n");
        sb.Append("  BotProductList: ").Append(BotProductList).Append("\n");
        sb.Append("  BotRecognitionFailureReasonList: ").Append(BotRecognitionFailureReasonList).Append("\n");
        sb.Append("  BotIntentList: ").Append(BotIntentList).Append("\n");
        sb.Append("  BotFinalIntentList: ").Append(BotFinalIntentList).Append("\n");
        sb.Append("  BotSlotList: ").Append(BotSlotList).Append("\n");
        sb.Append("  BotResultList: ").Append(BotResultList).Append("\n");
        sb.Append("  BlockedReasons: ").Append(BlockedReasons).Append("\n");
        sb.Append("  IsRecorded: ").Append(IsRecorded).Append("\n");
        sb.Append("  HasEvaluation: ").Append(HasEvaluation).Append("\n");
        sb.Append("  HasScoredEvaluation: ").Append(HasScoredEvaluation).Append("\n");
        sb.Append("  EmailDeliveryStatusList: ").Append(EmailDeliveryStatusList).Append("\n");
        sb.Append("  IsAgentOwnedCallback: ").Append(IsAgentOwnedCallback).Append("\n");
        sb.Append("  AgentCallbackOwnerIds: ").Append(AgentCallbackOwnerIds).Append("\n");
        sb.Append("  TranscriptTopics: ").Append(TranscriptTopics).Append("\n");
        sb.Append("  JourneyFrequencyCapReasons: ").Append(JourneyFrequencyCapReasons).Append("\n");
        sb.Append("  JourneyBlockingActionMapIds: ").Append(JourneyBlockingActionMapIds).Append("\n");
        sb.Append("  JourneyActionTargetIds: ").Append(JourneyActionTargetIds).Append("\n");
        sb.Append("  JourneyBlockingScheduleGroupIds: ").Append(JourneyBlockingScheduleGroupIds).Append("\n");
        sb.Append("  JourneyBlockingEmergencyScheduleGroupIds: ").Append(JourneyBlockingEmergencyScheduleGroupIds).Append("\n");
        sb.Append("  JourneyUrlEqualConditions: ").Append(JourneyUrlEqualConditions).Append("\n");
        sb.Append("  JourneyUrlNotEqualConditions: ").Append(JourneyUrlNotEqualConditions).Append("\n");
        sb.Append("  JourneyUrlStartsWithConditions: ").Append(JourneyUrlStartsWithConditions).Append("\n");
        sb.Append("  JourneyUrlEndsWithConditions: ").Append(JourneyUrlEndsWithConditions).Append("\n");
        sb.Append("  JourneyUrlContainsAnyConditions: ").Append(JourneyUrlContainsAnyConditions).Append("\n");
        sb.Append("  JourneyUrlNotContainsAnyConditions: ").Append(JourneyUrlNotContainsAnyConditions).Append("\n");
        sb.Append("  JourneyUrlContainsAllConditions: ").Append(JourneyUrlContainsAllConditions).Append("\n");
        sb.Append("  JourneyUrlNotContainsAllConditions: ").Append(JourneyUrlNotContainsAllConditions).Append("\n");
        sb.Append("  FlowMilestoneIds: ").Append(FlowMilestoneIds).Append("\n");
        sb.Append("  IsAssessmentPassed: ").Append(IsAssessmentPassed).Append("\n");
        sb.Append("  ConversationInitiators: ").Append(ConversationInitiators).Append("\n");
        sb.Append("  HasCustomerParticipated: ").Append(HasCustomerParticipated).Append("\n");
        sb.Append("  IsAcdInteraction: ").Append(IsAcdInteraction).Append("\n");
        sb.Append("  HasFax: ").Append(HasFax).Append("\n");
        sb.Append("  DataActionIds: ").Append(DataActionIds).Append("\n");
        sb.Append("  ActionCategoryName: ").Append(ActionCategoryName).Append("\n");
        sb.Append("  IntegrationIds: ").Append(IntegrationIds).Append("\n");
        sb.Append("  ResponseStatuses: ").Append(ResponseStatuses).Append("\n");
        sb.Append("  AvailableDashboard: ").Append(AvailableDashboard).Append("\n");
        sb.Append("  FavouriteDashboard: ").Append(FavouriteDashboard).Append("\n");
        sb.Append("  MyDashboard: ").Append(MyDashboard).Append("\n");
        sb.Append("  StationErrors: ").Append(StationErrors).Append("\n");
        sb.Append("  CanonicalContactIds: ").Append(CanonicalContactIds).Append("\n");
        sb.Append("  AlertRuleIds: ").Append(AlertRuleIds).Append("\n");
        sb.Append("  EvaluationFormContextIds: ").Append(EvaluationFormContextIds).Append("\n");
        sb.Append("  EvaluationStatuses: ").Append(EvaluationStatuses).Append("\n");
        sb.Append("  WorkbinIds: ").Append(WorkbinIds).Append("\n");
        sb.Append("  WorktypeIds: ").Append(WorktypeIds).Append("\n");
        sb.Append("  WorkitemIds: ").Append(WorkitemIds).Append("\n");
        sb.Append("  WorkitemAssigneeIds: ").Append(WorkitemAssigneeIds).Append("\n");
        sb.Append("  WorkitemStatuses: ").Append(WorkitemStatuses).Append("\n");
        sb.Append("  IsAnalyzedForSensitiveData: ").Append(IsAnalyzedForSensitiveData).Append("\n");
        sb.Append("  HasSensitiveData: ").Append(HasSensitiveData).Append("\n");
        sb.Append("  HasPciData: ").Append(HasPciData).Append("\n");
        sb.Append("  HasPiiData: ").Append(HasPiiData).Append("\n");
        sb.Append("  SubPath: ").Append(SubPath).Append("\n");
        sb.Append("  UserState: ").Append(UserState).Append("\n");
        sb.Append("  IsClearedByCustomer: ").Append(IsClearedByCustomer).Append("\n");
        sb.Append("  EvaluationAssigneeIds: ").Append(EvaluationAssigneeIds).Append("\n");
        sb.Append("  EvaluationAssigned: ").Append(EvaluationAssigned).Append("\n");
        sb.Append("  AssistantIds: ").Append(AssistantIds).Append("\n");
        sb.Append("  KnowledgeBaseIds: ").Append(KnowledgeBaseIds).Append("\n");
        sb.Append("  IsParked: ").Append(IsParked).Append("\n");
        sb.Append("  AgentEmpathyScore: ").Append(AgentEmpathyScore).Append("\n");
        sb.Append("  SurveyTypes: ").Append(SurveyTypes).Append("\n");
        sb.Append("  SurveyResponseStatuses: ").Append(SurveyResponseStatuses).Append("\n");
        sb.Append("  BotFlowTypes: ").Append(BotFlowTypes).Append("\n");
        sb.Append("  AgentTalkDurationMilliseconds: ").Append(AgentTalkDurationMilliseconds).Append("\n");
        sb.Append("  CustomerTalkDurationMilliseconds: ").Append(CustomerTalkDurationMilliseconds).Append("\n");
        sb.Append("  OvertalkDurationMilliseconds: ").Append(OvertalkDurationMilliseconds).Append("\n");
        sb.Append("  SilenceDurationMilliseconds: ").Append(SilenceDurationMilliseconds).Append("\n");
        sb.Append("  AcdDurationMilliseconds: ").Append(AcdDurationMilliseconds).Append("\n");
        sb.Append("  IvrDurationMilliseconds: ").Append(IvrDurationMilliseconds).Append("\n");
        sb.Append("  OtherDurationMilliseconds: ").Append(OtherDurationMilliseconds).Append("\n");
        sb.Append("  AgentTalkPercentage: ").Append(AgentTalkPercentage).Append("\n");
        sb.Append("  CustomerTalkPercentage: ").Append(CustomerTalkPercentage).Append("\n");
        sb.Append("  OvertalkPercentage: ").Append(OvertalkPercentage).Append("\n");
        sb.Append("  SilencePercentage: ").Append(SilencePercentage).Append("\n");
        sb.Append("  AcdPercentage: ").Append(AcdPercentage).Append("\n");
        sb.Append("  IvrPercentage: ").Append(IvrPercentage).Append("\n");
        sb.Append("  OtherPercentage: ").Append(OtherPercentage).Append("\n");
        sb.Append("  OvertalkInstances: ").Append(OvertalkInstances).Append("\n");
        sb.Append("  IsScreenRecorded: ").Append(IsScreenRecorded).Append("\n");
        sb.Append("  ScreenMonitorUserIds: ").Append(ScreenMonitorUserIds).Append("\n");
        sb.Append("  DashboardState: ").Append(DashboardState).Append("\n");
        sb.Append("  DashboardType: ").Append(DashboardType).Append("\n");
        sb.Append("  DashboardAccessFilter: ").Append(DashboardAccessFilter).Append("\n");
        sb.Append("  TranscriptDurationMilliseconds: ").Append(TranscriptDurationMilliseconds).Append("\n");
        sb.Append("  WorkitemsStatuses: ").Append(WorkitemsStatuses).Append("\n");
        sb.Append("  SocialCountries: ").Append(SocialCountries).Append("\n");
        sb.Append("  SocialLanguages: ").Append(SocialLanguages).Append("\n");
        sb.Append("  SocialChannels: ").Append(SocialChannels).Append("\n");
        sb.Append("  SocialSentimentCategory: ").Append(SocialSentimentCategory).Append("\n");
        sb.Append("  SocialTopicIds: ").Append(SocialTopicIds).Append("\n");
        sb.Append("  SocialIngestionRuleIds: ").Append(SocialIngestionRuleIds).Append("\n");
        sb.Append("  SocialConversationCreated: ").Append(SocialConversationCreated).Append("\n");
        sb.Append("  SocialContentType: ").Append(SocialContentType).Append("\n");
        sb.Append("  SocialKeywords: ").Append(SocialKeywords).Append("\n");
        sb.Append("  SocialPostEscalated: ").Append(SocialPostEscalated).Append("\n");
        sb.Append("  SocialClassifications: ").Append(SocialClassifications).Append("\n");
        sb.Append("  FilterUsersByManagerIds: ").Append(FilterUsersByManagerIds).Append("\n");
        sb.Append("  SlideshowIds: ").Append(SlideshowIds).Append("\n");
        sb.Append("  Conferenced: ").Append(Conferenced).Append("\n");
        sb.Append("  Video: ").Append(Video).Append("\n");
        sb.Append("  LinkedInteraction: ").Append(LinkedInteraction).Append("\n");
        sb.Append("  RecommendationSources: ").Append(RecommendationSources).Append("\n");
        sb.Append("  EvaluationRole: ").Append(EvaluationRole).Append("\n");
        sb.Append("  ComparisonQueueIds: ").Append(ComparisonQueueIds).Append("\n");
        sb.Append("  ViewMetrics: ").Append(ViewMetrics).Append("\n");
        sb.Append("  TimelineCategories: ").Append(TimelineCategories).Append("\n");
        sb.Append("  Acw: ").Append(Acw).Append("\n");
        sb.Append("  SegmentTypes: ").Append(SegmentTypes).Append("\n");
        sb.Append("  ProgramIds: ").Append(ProgramIds).Append("\n");
        sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
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
        return Equals(obj as ViewFilter);
    }

    /// <summary>
    /// Returns true if ViewFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ViewFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ViewFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
            ) &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
            ) &&
            (
                SkillIds == other.SkillIds ||
                SkillIds != null &&
                SkillIds.SequenceEqual(other.SkillIds)
            ) &&
            (
                AssignedSkillIds == other.AssignedSkillIds ||
                AssignedSkillIds != null &&
                AssignedSkillIds.SequenceEqual(other.AssignedSkillIds)
            ) &&
            (
                SkillGroups == other.SkillGroups ||
                SkillGroups != null &&
                SkillGroups.SequenceEqual(other.SkillGroups)
            ) &&
            (
                LanguageIds == other.LanguageIds ||
                LanguageIds != null &&
                LanguageIds.SequenceEqual(other.LanguageIds)
            ) &&
            (
                AssignedLanguageIds == other.AssignedLanguageIds ||
                AssignedLanguageIds != null &&
                AssignedLanguageIds.SequenceEqual(other.AssignedLanguageIds)
            ) &&
            (
                LanguageGroups == other.LanguageGroups ||
                LanguageGroups != null &&
                LanguageGroups.SequenceEqual(other.LanguageGroups)
            ) &&
            (
                Directions == other.Directions ||
                Directions != null &&
                Directions.SequenceEqual(other.Directions)
            ) &&
            (
                OriginatingDirections == other.OriginatingDirections ||
                OriginatingDirections != null &&
                OriginatingDirections.SequenceEqual(other.OriginatingDirections)
            ) &&
            (
                WrapUpCodes == other.WrapUpCodes ||
                WrapUpCodes != null &&
                WrapUpCodes.SequenceEqual(other.WrapUpCodes)
            ) &&
            (
                DnisList == other.DnisList ||
                DnisList != null &&
                DnisList.SequenceEqual(other.DnisList)
            ) &&
            (
                SessionDnisList == other.SessionDnisList ||
                SessionDnisList != null &&
                SessionDnisList.SequenceEqual(other.SessionDnisList)
            ) &&
            (
                FilterQueuesByUserIds == other.FilterQueuesByUserIds ||
                FilterQueuesByUserIds != null &&
                FilterQueuesByUserIds.SequenceEqual(other.FilterQueuesByUserIds)
            ) &&
            (
                FilterUsersByQueueIds == other.FilterUsersByQueueIds ||
                FilterUsersByQueueIds != null &&
                FilterUsersByQueueIds.SequenceEqual(other.FilterUsersByQueueIds)
            ) &&
            (
                UserIds == other.UserIds ||
                UserIds != null &&
                UserIds.SequenceEqual(other.UserIds)
            ) &&
            (
                ManagementUnitIds == other.ManagementUnitIds ||
                ManagementUnitIds != null &&
                ManagementUnitIds.SequenceEqual(other.ManagementUnitIds)
            ) &&
            (
                AddressTos == other.AddressTos ||
                AddressTos != null &&
                AddressTos.SequenceEqual(other.AddressTos)
            ) &&
            (
                AddressFroms == other.AddressFroms ||
                AddressFroms != null &&
                AddressFroms.SequenceEqual(other.AddressFroms)
            ) &&
            (
                OutboundCampaignIds == other.OutboundCampaignIds ||
                OutboundCampaignIds != null &&
                OutboundCampaignIds.SequenceEqual(other.OutboundCampaignIds)
            ) &&
            (
                OutboundContactListIds == other.OutboundContactListIds ||
                OutboundContactListIds != null &&
                OutboundContactListIds.SequenceEqual(other.OutboundContactListIds)
            ) &&
            (
                ContactIds == other.ContactIds ||
                ContactIds != null &&
                ContactIds.SequenceEqual(other.ContactIds)
            ) &&
            (
                ExternalContactIds == other.ExternalContactIds ||
                ExternalContactIds != null &&
                ExternalContactIds.SequenceEqual(other.ExternalContactIds)
            ) &&
            (
                ExternalOrgIds == other.ExternalOrgIds ||
                ExternalOrgIds != null &&
                ExternalOrgIds.SequenceEqual(other.ExternalOrgIds)
            ) &&
            (
                AniList == other.AniList ||
                AniList != null &&
                AniList.SequenceEqual(other.AniList)
            ) &&
            (
                DurationsMilliseconds == other.DurationsMilliseconds ||
                DurationsMilliseconds != null &&
                DurationsMilliseconds.SequenceEqual(other.DurationsMilliseconds)
            ) &&
            (
                AcdDurationsMilliseconds == other.AcdDurationsMilliseconds ||
                AcdDurationsMilliseconds != null &&
                AcdDurationsMilliseconds.SequenceEqual(other.AcdDurationsMilliseconds)
            ) &&
            (
                TalkDurationsMilliseconds == other.TalkDurationsMilliseconds ||
                TalkDurationsMilliseconds != null &&
                TalkDurationsMilliseconds.SequenceEqual(other.TalkDurationsMilliseconds)
            ) &&
            (
                AcwDurationsMilliseconds == other.AcwDurationsMilliseconds ||
                AcwDurationsMilliseconds != null &&
                AcwDurationsMilliseconds.SequenceEqual(other.AcwDurationsMilliseconds)
            ) &&
            (
                HandleDurationsMilliseconds == other.HandleDurationsMilliseconds ||
                HandleDurationsMilliseconds != null &&
                HandleDurationsMilliseconds.SequenceEqual(other.HandleDurationsMilliseconds)
            ) &&
            (
                HoldDurationsMilliseconds == other.HoldDurationsMilliseconds ||
                HoldDurationsMilliseconds != null &&
                HoldDurationsMilliseconds.SequenceEqual(other.HoldDurationsMilliseconds)
            ) &&
            (
                AbandonDurationsMilliseconds == other.AbandonDurationsMilliseconds ||
                AbandonDurationsMilliseconds != null &&
                AbandonDurationsMilliseconds.SequenceEqual(other.AbandonDurationsMilliseconds)
            ) &&
            (
                EvaluationScore == other.EvaluationScore ||
                EvaluationScore != null &&
                EvaluationScore.Equals(other.EvaluationScore)
            ) &&
            (
                EvaluationCriticalScore == other.EvaluationCriticalScore ||
                EvaluationCriticalScore != null &&
                EvaluationCriticalScore.Equals(other.EvaluationCriticalScore)
            ) &&
            (
                EvaluationFormIds == other.EvaluationFormIds ||
                EvaluationFormIds != null &&
                EvaluationFormIds.SequenceEqual(other.EvaluationFormIds)
            ) &&
            (
                EvaluatedAgentIds == other.EvaluatedAgentIds ||
                EvaluatedAgentIds != null &&
                EvaluatedAgentIds.SequenceEqual(other.EvaluatedAgentIds)
            ) &&
            (
                EvaluatorIds == other.EvaluatorIds ||
                EvaluatorIds != null &&
                EvaluatorIds.SequenceEqual(other.EvaluatorIds)
            ) &&
            (
                Transferred == other.Transferred ||
                Transferred != null &&
                Transferred.Equals(other.Transferred)
            ) &&
            (
                Abandoned == other.Abandoned ||
                Abandoned != null &&
                Abandoned.Equals(other.Abandoned)
            ) &&
            (
                Answered == other.Answered ||
                Answered != null &&
                Answered.Equals(other.Answered)
            ) &&
            (
                MessageTypes == other.MessageTypes ||
                MessageTypes != null &&
                MessageTypes.SequenceEqual(other.MessageTypes)
            ) &&
            (
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                SurveyFormIds == other.SurveyFormIds ||
                SurveyFormIds != null &&
                SurveyFormIds.SequenceEqual(other.SurveyFormIds)
            ) &&
            (
                SurveyTotalScore == other.SurveyTotalScore ||
                SurveyTotalScore != null &&
                SurveyTotalScore.Equals(other.SurveyTotalScore)
            ) &&
            (
                SurveyNpsScore == other.SurveyNpsScore ||
                SurveyNpsScore != null &&
                SurveyNpsScore.Equals(other.SurveyNpsScore)
            ) &&
            (
                Mos == other.Mos ||
                Mos != null &&
                Mos.Equals(other.Mos)
            ) &&
            (
                SurveyQuestionGroupScore == other.SurveyQuestionGroupScore ||
                SurveyQuestionGroupScore != null &&
                SurveyQuestionGroupScore.Equals(other.SurveyQuestionGroupScore)
            ) &&
            (
                SurveyPromoterScore == other.SurveyPromoterScore ||
                SurveyPromoterScore != null &&
                SurveyPromoterScore.Equals(other.SurveyPromoterScore)
            ) &&
            (
                SurveyFormContextIds == other.SurveyFormContextIds ||
                SurveyFormContextIds != null &&
                SurveyFormContextIds.SequenceEqual(other.SurveyFormContextIds)
            ) &&
            (
                ConversationIds == other.ConversationIds ||
                ConversationIds != null &&
                ConversationIds.SequenceEqual(other.ConversationIds)
            ) &&
            (
                SipCallIds == other.SipCallIds ||
                SipCallIds != null &&
                SipCallIds.SequenceEqual(other.SipCallIds)
            ) &&
            (
                IsEnded == other.IsEnded ||
                IsEnded != null &&
                IsEnded.Equals(other.IsEnded)
            ) &&
            (
                IsSurveyed == other.IsSurveyed ||
                IsSurveyed != null &&
                IsSurveyed.Equals(other.IsSurveyed)
            ) &&
            (
                SurveyScores == other.SurveyScores ||
                SurveyScores != null &&
                SurveyScores.SequenceEqual(other.SurveyScores)
            ) &&
            (
                PromoterScores == other.PromoterScores ||
                PromoterScores != null &&
                PromoterScores.SequenceEqual(other.PromoterScores)
            ) &&
            (
                IsCampaign == other.IsCampaign ||
                IsCampaign != null &&
                IsCampaign.Equals(other.IsCampaign)
            ) &&
            (
                SurveyStatuses == other.SurveyStatuses ||
                SurveyStatuses != null &&
                SurveyStatuses.SequenceEqual(other.SurveyStatuses)
            ) &&
            (
                ConversationProperties == other.ConversationProperties ||
                ConversationProperties != null &&
                ConversationProperties.Equals(other.ConversationProperties)
            ) &&
            (
                IsBlindTransferred == other.IsBlindTransferred ||
                IsBlindTransferred != null &&
                IsBlindTransferred.Equals(other.IsBlindTransferred)
            ) &&
            (
                IsConsulted == other.IsConsulted ||
                IsConsulted != null &&
                IsConsulted.Equals(other.IsConsulted)
            ) &&
            (
                IsConsultTransferred == other.IsConsultTransferred ||
                IsConsultTransferred != null &&
                IsConsultTransferred.Equals(other.IsConsultTransferred)
            ) &&
            (
                RemoteParticipants == other.RemoteParticipants ||
                RemoteParticipants != null &&
                RemoteParticipants.SequenceEqual(other.RemoteParticipants)
            ) &&
            (
                FlowIds == other.FlowIds ||
                FlowIds != null &&
                FlowIds.SequenceEqual(other.FlowIds)
            ) &&
            (
                FlowOutcomeIds == other.FlowOutcomeIds ||
                FlowOutcomeIds != null &&
                FlowOutcomeIds.SequenceEqual(other.FlowOutcomeIds)
            ) &&
            (
                FlowOutcomeValues == other.FlowOutcomeValues ||
                FlowOutcomeValues != null &&
                FlowOutcomeValues.SequenceEqual(other.FlowOutcomeValues)
            ) &&
            (
                FlowDestinationTypes == other.FlowDestinationTypes ||
                FlowDestinationTypes != null &&
                FlowDestinationTypes.SequenceEqual(other.FlowDestinationTypes)
            ) &&
            (
                FlowDisconnectReasons == other.FlowDisconnectReasons ||
                FlowDisconnectReasons != null &&
                FlowDisconnectReasons.SequenceEqual(other.FlowDisconnectReasons)
            ) &&
            (
                FlowTypes == other.FlowTypes ||
                FlowTypes != null &&
                FlowTypes.SequenceEqual(other.FlowTypes)
            ) &&
            (
                FlowEntryTypes == other.FlowEntryTypes ||
                FlowEntryTypes != null &&
                FlowEntryTypes.SequenceEqual(other.FlowEntryTypes)
            ) &&
            (
                FlowEntryReasons == other.FlowEntryReasons ||
                FlowEntryReasons != null &&
                FlowEntryReasons.SequenceEqual(other.FlowEntryReasons)
            ) &&
            (
                FlowVersions == other.FlowVersions ||
                FlowVersions != null &&
                FlowVersions.SequenceEqual(other.FlowVersions)
            ) &&
            (
                GroupIds == other.GroupIds ||
                GroupIds != null &&
                GroupIds.SequenceEqual(other.GroupIds)
            ) &&
            (
                HasJourneyCustomerId == other.HasJourneyCustomerId ||
                HasJourneyCustomerId != null &&
                HasJourneyCustomerId.Equals(other.HasJourneyCustomerId)
            ) &&
            (
                HasJourneyActionMapId == other.HasJourneyActionMapId ||
                HasJourneyActionMapId != null &&
                HasJourneyActionMapId.Equals(other.HasJourneyActionMapId)
            ) &&
            (
                HasJourneyVisitId == other.HasJourneyVisitId ||
                HasJourneyVisitId != null &&
                HasJourneyVisitId.Equals(other.HasJourneyVisitId)
            ) &&
            (
                HasMedia == other.HasMedia ||
                HasMedia != null &&
                HasMedia.Equals(other.HasMedia)
            ) &&
            (
                RoleIds == other.RoleIds ||
                RoleIds != null &&
                RoleIds.SequenceEqual(other.RoleIds)
            ) &&
            (
                ReportsTos == other.ReportsTos ||
                ReportsTos != null &&
                ReportsTos.SequenceEqual(other.ReportsTos)
            ) &&
            (
                LocationIds == other.LocationIds ||
                LocationIds != null &&
                LocationIds.SequenceEqual(other.LocationIds)
            ) &&
            (
                FlowOutTypes == other.FlowOutTypes ||
                FlowOutTypes != null &&
                FlowOutTypes.SequenceEqual(other.FlowOutTypes)
            ) &&
            (
                ProviderList == other.ProviderList ||
                ProviderList != null &&
                ProviderList.SequenceEqual(other.ProviderList)
            ) &&
            (
                CallbackNumberList == other.CallbackNumberList ||
                CallbackNumberList != null &&
                CallbackNumberList.SequenceEqual(other.CallbackNumberList)
            ) &&
            (
                CallbackInterval == other.CallbackInterval ||
                CallbackInterval != null &&
                CallbackInterval.Equals(other.CallbackInterval)
            ) &&
            (
                UsedRoutingTypes == other.UsedRoutingTypes ||
                UsedRoutingTypes != null &&
                UsedRoutingTypes.SequenceEqual(other.UsedRoutingTypes)
            ) &&
            (
                RequestedRoutingTypes == other.RequestedRoutingTypes ||
                RequestedRoutingTypes != null &&
                RequestedRoutingTypes.SequenceEqual(other.RequestedRoutingTypes)
            ) &&
            (
                HasAgentAssistId == other.HasAgentAssistId ||
                HasAgentAssistId != null &&
                HasAgentAssistId.Equals(other.HasAgentAssistId)
            ) &&
            (
                Transcripts == other.Transcripts ||
                Transcripts != null &&
                Transcripts.SequenceEqual(other.Transcripts)
            ) &&
            (
                TranscriptLanguages == other.TranscriptLanguages ||
                TranscriptLanguages != null &&
                TranscriptLanguages.SequenceEqual(other.TranscriptLanguages)
            ) &&
            (
                ParticipantPurposes == other.ParticipantPurposes ||
                ParticipantPurposes != null &&
                ParticipantPurposes.SequenceEqual(other.ParticipantPurposes)
            ) &&
            (
                ShowFirstQueue == other.ShowFirstQueue ||
                ShowFirstQueue != null &&
                ShowFirstQueue.Equals(other.ShowFirstQueue)
            ) &&
            (
                TeamIds == other.TeamIds ||
                TeamIds != null &&
                TeamIds.SequenceEqual(other.TeamIds)
            ) &&
            (
                FilterUsersByTeamIds == other.FilterUsersByTeamIds ||
                FilterUsersByTeamIds != null &&
                FilterUsersByTeamIds.SequenceEqual(other.FilterUsersByTeamIds)
            ) &&
            (
                JourneyActionMapIds == other.JourneyActionMapIds ||
                JourneyActionMapIds != null &&
                JourneyActionMapIds.SequenceEqual(other.JourneyActionMapIds)
            ) &&
            (
                JourneyOutcomeIds == other.JourneyOutcomeIds ||
                JourneyOutcomeIds != null &&
                JourneyOutcomeIds.SequenceEqual(other.JourneyOutcomeIds)
            ) &&
            (
                JourneySegmentIds == other.JourneySegmentIds ||
                JourneySegmentIds != null &&
                JourneySegmentIds.SequenceEqual(other.JourneySegmentIds)
            ) &&
            (
                JourneyActionMapTypes == other.JourneyActionMapTypes ||
                JourneyActionMapTypes != null &&
                JourneyActionMapTypes.SequenceEqual(other.JourneyActionMapTypes)
            ) &&
            (
                DevelopmentRoleList == other.DevelopmentRoleList ||
                DevelopmentRoleList != null &&
                DevelopmentRoleList.SequenceEqual(other.DevelopmentRoleList)
            ) &&
            (
                DevelopmentTypeList == other.DevelopmentTypeList ||
                DevelopmentTypeList != null &&
                DevelopmentTypeList.SequenceEqual(other.DevelopmentTypeList)
            ) &&
            (
                DevelopmentStatusList == other.DevelopmentStatusList ||
                DevelopmentStatusList != null &&
                DevelopmentStatusList.SequenceEqual(other.DevelopmentStatusList)
            ) &&
            (
                DevelopmentModuleIds == other.DevelopmentModuleIds ||
                DevelopmentModuleIds != null &&
                DevelopmentModuleIds.SequenceEqual(other.DevelopmentModuleIds)
            ) &&
            (
                DevelopmentActivityOverdue == other.DevelopmentActivityOverdue ||
                DevelopmentActivityOverdue != null &&
                DevelopmentActivityOverdue.Equals(other.DevelopmentActivityOverdue)
            ) &&
            (
                CustomerSentimentScore == other.CustomerSentimentScore ||
                CustomerSentimentScore != null &&
                CustomerSentimentScore.Equals(other.CustomerSentimentScore)
            ) &&
            (
                CustomerSentimentTrend == other.CustomerSentimentTrend ||
                CustomerSentimentTrend != null &&
                CustomerSentimentTrend.Equals(other.CustomerSentimentTrend)
            ) &&
            (
                FlowTransferTargets == other.FlowTransferTargets ||
                FlowTransferTargets != null &&
                FlowTransferTargets.SequenceEqual(other.FlowTransferTargets)
            ) &&
            (
                DevelopmentName == other.DevelopmentName ||
                DevelopmentName != null &&
                DevelopmentName.Equals(other.DevelopmentName)
            ) &&
            (
                TopicIds == other.TopicIds ||
                TopicIds != null &&
                TopicIds.SequenceEqual(other.TopicIds)
            ) &&
            (
                ExternalTags == other.ExternalTags ||
                ExternalTags != null &&
                ExternalTags.SequenceEqual(other.ExternalTags)
            ) &&
            (
                IsNotResponding == other.IsNotResponding ||
                IsNotResponding != null &&
                IsNotResponding.Equals(other.IsNotResponding)
            ) &&
            (
                IsAuthenticated == other.IsAuthenticated ||
                IsAuthenticated != null &&
                IsAuthenticated.Equals(other.IsAuthenticated)
            ) &&
            (
                BotIds == other.BotIds ||
                BotIds != null &&
                BotIds.SequenceEqual(other.BotIds)
            ) &&
            (
                BotVersions == other.BotVersions ||
                BotVersions != null &&
                BotVersions.SequenceEqual(other.BotVersions)
            ) &&
            (
                BotMessageTypes == other.BotMessageTypes ||
                BotMessageTypes != null &&
                BotMessageTypes.SequenceEqual(other.BotMessageTypes)
            ) &&
            (
                BotProviderList == other.BotProviderList ||
                BotProviderList != null &&
                BotProviderList.SequenceEqual(other.BotProviderList)
            ) &&
            (
                BotProductList == other.BotProductList ||
                BotProductList != null &&
                BotProductList.SequenceEqual(other.BotProductList)
            ) &&
            (
                BotRecognitionFailureReasonList == other.BotRecognitionFailureReasonList ||
                BotRecognitionFailureReasonList != null &&
                BotRecognitionFailureReasonList.SequenceEqual(other.BotRecognitionFailureReasonList)
            ) &&
            (
                BotIntentList == other.BotIntentList ||
                BotIntentList != null &&
                BotIntentList.SequenceEqual(other.BotIntentList)
            ) &&
            (
                BotFinalIntentList == other.BotFinalIntentList ||
                BotFinalIntentList != null &&
                BotFinalIntentList.SequenceEqual(other.BotFinalIntentList)
            ) &&
            (
                BotSlotList == other.BotSlotList ||
                BotSlotList != null &&
                BotSlotList.SequenceEqual(other.BotSlotList)
            ) &&
            (
                BotResultList == other.BotResultList ||
                BotResultList != null &&
                BotResultList.SequenceEqual(other.BotResultList)
            ) &&
            (
                BlockedReasons == other.BlockedReasons ||
                BlockedReasons != null &&
                BlockedReasons.SequenceEqual(other.BlockedReasons)
            ) &&
            (
                IsRecorded == other.IsRecorded ||
                IsRecorded != null &&
                IsRecorded.Equals(other.IsRecorded)
            ) &&
            (
                HasEvaluation == other.HasEvaluation ||
                HasEvaluation != null &&
                HasEvaluation.Equals(other.HasEvaluation)
            ) &&
            (
                HasScoredEvaluation == other.HasScoredEvaluation ||
                HasScoredEvaluation != null &&
                HasScoredEvaluation.Equals(other.HasScoredEvaluation)
            ) &&
            (
                EmailDeliveryStatusList == other.EmailDeliveryStatusList ||
                EmailDeliveryStatusList != null &&
                EmailDeliveryStatusList.SequenceEqual(other.EmailDeliveryStatusList)
            ) &&
            (
                IsAgentOwnedCallback == other.IsAgentOwnedCallback ||
                IsAgentOwnedCallback != null &&
                IsAgentOwnedCallback.Equals(other.IsAgentOwnedCallback)
            ) &&
            (
                AgentCallbackOwnerIds == other.AgentCallbackOwnerIds ||
                AgentCallbackOwnerIds != null &&
                AgentCallbackOwnerIds.SequenceEqual(other.AgentCallbackOwnerIds)
            ) &&
            (
                TranscriptTopics == other.TranscriptTopics ||
                TranscriptTopics != null &&
                TranscriptTopics.SequenceEqual(other.TranscriptTopics)
            ) &&
            (
                JourneyFrequencyCapReasons == other.JourneyFrequencyCapReasons ||
                JourneyFrequencyCapReasons != null &&
                JourneyFrequencyCapReasons.SequenceEqual(other.JourneyFrequencyCapReasons)
            ) &&
            (
                JourneyBlockingActionMapIds == other.JourneyBlockingActionMapIds ||
                JourneyBlockingActionMapIds != null &&
                JourneyBlockingActionMapIds.SequenceEqual(other.JourneyBlockingActionMapIds)
            ) &&
            (
                JourneyActionTargetIds == other.JourneyActionTargetIds ||
                JourneyActionTargetIds != null &&
                JourneyActionTargetIds.SequenceEqual(other.JourneyActionTargetIds)
            ) &&
            (
                JourneyBlockingScheduleGroupIds == other.JourneyBlockingScheduleGroupIds ||
                JourneyBlockingScheduleGroupIds != null &&
                JourneyBlockingScheduleGroupIds.SequenceEqual(other.JourneyBlockingScheduleGroupIds)
            ) &&
            (
                JourneyBlockingEmergencyScheduleGroupIds == other.JourneyBlockingEmergencyScheduleGroupIds ||
                JourneyBlockingEmergencyScheduleGroupIds != null &&
                JourneyBlockingEmergencyScheduleGroupIds.SequenceEqual(other.JourneyBlockingEmergencyScheduleGroupIds)
            ) &&
            (
                JourneyUrlEqualConditions == other.JourneyUrlEqualConditions ||
                JourneyUrlEqualConditions != null &&
                JourneyUrlEqualConditions.SequenceEqual(other.JourneyUrlEqualConditions)
            ) &&
            (
                JourneyUrlNotEqualConditions == other.JourneyUrlNotEqualConditions ||
                JourneyUrlNotEqualConditions != null &&
                JourneyUrlNotEqualConditions.SequenceEqual(other.JourneyUrlNotEqualConditions)
            ) &&
            (
                JourneyUrlStartsWithConditions == other.JourneyUrlStartsWithConditions ||
                JourneyUrlStartsWithConditions != null &&
                JourneyUrlStartsWithConditions.SequenceEqual(other.JourneyUrlStartsWithConditions)
            ) &&
            (
                JourneyUrlEndsWithConditions == other.JourneyUrlEndsWithConditions ||
                JourneyUrlEndsWithConditions != null &&
                JourneyUrlEndsWithConditions.SequenceEqual(other.JourneyUrlEndsWithConditions)
            ) &&
            (
                JourneyUrlContainsAnyConditions == other.JourneyUrlContainsAnyConditions ||
                JourneyUrlContainsAnyConditions != null &&
                JourneyUrlContainsAnyConditions.SequenceEqual(other.JourneyUrlContainsAnyConditions)
            ) &&
            (
                JourneyUrlNotContainsAnyConditions == other.JourneyUrlNotContainsAnyConditions ||
                JourneyUrlNotContainsAnyConditions != null &&
                JourneyUrlNotContainsAnyConditions.SequenceEqual(other.JourneyUrlNotContainsAnyConditions)
            ) &&
            (
                JourneyUrlContainsAllConditions == other.JourneyUrlContainsAllConditions ||
                JourneyUrlContainsAllConditions != null &&
                JourneyUrlContainsAllConditions.SequenceEqual(other.JourneyUrlContainsAllConditions)
            ) &&
            (
                JourneyUrlNotContainsAllConditions == other.JourneyUrlNotContainsAllConditions ||
                JourneyUrlNotContainsAllConditions != null &&
                JourneyUrlNotContainsAllConditions.SequenceEqual(other.JourneyUrlNotContainsAllConditions)
            ) &&
            (
                FlowMilestoneIds == other.FlowMilestoneIds ||
                FlowMilestoneIds != null &&
                FlowMilestoneIds.SequenceEqual(other.FlowMilestoneIds)
            ) &&
            (
                IsAssessmentPassed == other.IsAssessmentPassed ||
                IsAssessmentPassed != null &&
                IsAssessmentPassed.Equals(other.IsAssessmentPassed)
            ) &&
            (
                ConversationInitiators == other.ConversationInitiators ||
                ConversationInitiators != null &&
                ConversationInitiators.SequenceEqual(other.ConversationInitiators)
            ) &&
            (
                HasCustomerParticipated == other.HasCustomerParticipated ||
                HasCustomerParticipated != null &&
                HasCustomerParticipated.Equals(other.HasCustomerParticipated)
            ) &&
            (
                IsAcdInteraction == other.IsAcdInteraction ||
                IsAcdInteraction != null &&
                IsAcdInteraction.Equals(other.IsAcdInteraction)
            ) &&
            (
                HasFax == other.HasFax ||
                HasFax != null &&
                HasFax.Equals(other.HasFax)
            ) &&
            (
                DataActionIds == other.DataActionIds ||
                DataActionIds != null &&
                DataActionIds.SequenceEqual(other.DataActionIds)
            ) &&
            (
                ActionCategoryName == other.ActionCategoryName ||
                ActionCategoryName != null &&
                ActionCategoryName.Equals(other.ActionCategoryName)
            ) &&
            (
                IntegrationIds == other.IntegrationIds ||
                IntegrationIds != null &&
                IntegrationIds.SequenceEqual(other.IntegrationIds)
            ) &&
            (
                ResponseStatuses == other.ResponseStatuses ||
                ResponseStatuses != null &&
                ResponseStatuses.SequenceEqual(other.ResponseStatuses)
            ) &&
            (
                AvailableDashboard == other.AvailableDashboard ||
                AvailableDashboard != null &&
                AvailableDashboard.Equals(other.AvailableDashboard)
            ) &&
            (
                FavouriteDashboard == other.FavouriteDashboard ||
                FavouriteDashboard != null &&
                FavouriteDashboard.Equals(other.FavouriteDashboard)
            ) &&
            (
                MyDashboard == other.MyDashboard ||
                MyDashboard != null &&
                MyDashboard.Equals(other.MyDashboard)
            ) &&
            (
                StationErrors == other.StationErrors ||
                StationErrors != null &&
                StationErrors.SequenceEqual(other.StationErrors)
            ) &&
            (
                CanonicalContactIds == other.CanonicalContactIds ||
                CanonicalContactIds != null &&
                CanonicalContactIds.SequenceEqual(other.CanonicalContactIds)
            ) &&
            (
                AlertRuleIds == other.AlertRuleIds ||
                AlertRuleIds != null &&
                AlertRuleIds.SequenceEqual(other.AlertRuleIds)
            ) &&
            (
                EvaluationFormContextIds == other.EvaluationFormContextIds ||
                EvaluationFormContextIds != null &&
                EvaluationFormContextIds.SequenceEqual(other.EvaluationFormContextIds)
            ) &&
            (
                EvaluationStatuses == other.EvaluationStatuses ||
                EvaluationStatuses != null &&
                EvaluationStatuses.SequenceEqual(other.EvaluationStatuses)
            ) &&
            (
                WorkbinIds == other.WorkbinIds ||
                WorkbinIds != null &&
                WorkbinIds.SequenceEqual(other.WorkbinIds)
            ) &&
            (
                WorktypeIds == other.WorktypeIds ||
                WorktypeIds != null &&
                WorktypeIds.SequenceEqual(other.WorktypeIds)
            ) &&
            (
                WorkitemIds == other.WorkitemIds ||
                WorkitemIds != null &&
                WorkitemIds.SequenceEqual(other.WorkitemIds)
            ) &&
            (
                WorkitemAssigneeIds == other.WorkitemAssigneeIds ||
                WorkitemAssigneeIds != null &&
                WorkitemAssigneeIds.SequenceEqual(other.WorkitemAssigneeIds)
            ) &&
            (
                WorkitemStatuses == other.WorkitemStatuses ||
                WorkitemStatuses != null &&
                WorkitemStatuses.SequenceEqual(other.WorkitemStatuses)
            ) &&
            (
                IsAnalyzedForSensitiveData == other.IsAnalyzedForSensitiveData ||
                IsAnalyzedForSensitiveData != null &&
                IsAnalyzedForSensitiveData.Equals(other.IsAnalyzedForSensitiveData)
            ) &&
            (
                HasSensitiveData == other.HasSensitiveData ||
                HasSensitiveData != null &&
                HasSensitiveData.Equals(other.HasSensitiveData)
            ) &&
            (
                HasPciData == other.HasPciData ||
                HasPciData != null &&
                HasPciData.Equals(other.HasPciData)
            ) &&
            (
                HasPiiData == other.HasPiiData ||
                HasPiiData != null &&
                HasPiiData.Equals(other.HasPiiData)
            ) &&
            (
                SubPath == other.SubPath ||
                SubPath != null &&
                SubPath.Equals(other.SubPath)
            ) &&
            (
                UserState == other.UserState ||
                UserState != null &&
                UserState.Equals(other.UserState)
            ) &&
            (
                IsClearedByCustomer == other.IsClearedByCustomer ||
                IsClearedByCustomer != null &&
                IsClearedByCustomer.Equals(other.IsClearedByCustomer)
            ) &&
            (
                EvaluationAssigneeIds == other.EvaluationAssigneeIds ||
                EvaluationAssigneeIds != null &&
                EvaluationAssigneeIds.SequenceEqual(other.EvaluationAssigneeIds)
            ) &&
            (
                EvaluationAssigned == other.EvaluationAssigned ||
                EvaluationAssigned != null &&
                EvaluationAssigned.Equals(other.EvaluationAssigned)
            ) &&
            (
                AssistantIds == other.AssistantIds ||
                AssistantIds != null &&
                AssistantIds.SequenceEqual(other.AssistantIds)
            ) &&
            (
                KnowledgeBaseIds == other.KnowledgeBaseIds ||
                KnowledgeBaseIds != null &&
                KnowledgeBaseIds.SequenceEqual(other.KnowledgeBaseIds)
            ) &&
            (
                IsParked == other.IsParked ||
                IsParked != null &&
                IsParked.Equals(other.IsParked)
            ) &&
            (
                AgentEmpathyScore == other.AgentEmpathyScore ||
                AgentEmpathyScore != null &&
                AgentEmpathyScore.Equals(other.AgentEmpathyScore)
            ) &&
            (
                SurveyTypes == other.SurveyTypes ||
                SurveyTypes != null &&
                SurveyTypes.SequenceEqual(other.SurveyTypes)
            ) &&
            (
                SurveyResponseStatuses == other.SurveyResponseStatuses ||
                SurveyResponseStatuses != null &&
                SurveyResponseStatuses.SequenceEqual(other.SurveyResponseStatuses)
            ) &&
            (
                BotFlowTypes == other.BotFlowTypes ||
                BotFlowTypes != null &&
                BotFlowTypes.SequenceEqual(other.BotFlowTypes)
            ) &&
            (
                AgentTalkDurationMilliseconds == other.AgentTalkDurationMilliseconds ||
                AgentTalkDurationMilliseconds != null &&
                AgentTalkDurationMilliseconds.SequenceEqual(other.AgentTalkDurationMilliseconds)
            ) &&
            (
                CustomerTalkDurationMilliseconds == other.CustomerTalkDurationMilliseconds ||
                CustomerTalkDurationMilliseconds != null &&
                CustomerTalkDurationMilliseconds.SequenceEqual(other.CustomerTalkDurationMilliseconds)
            ) &&
            (
                OvertalkDurationMilliseconds == other.OvertalkDurationMilliseconds ||
                OvertalkDurationMilliseconds != null &&
                OvertalkDurationMilliseconds.SequenceEqual(other.OvertalkDurationMilliseconds)
            ) &&
            (
                SilenceDurationMilliseconds == other.SilenceDurationMilliseconds ||
                SilenceDurationMilliseconds != null &&
                SilenceDurationMilliseconds.SequenceEqual(other.SilenceDurationMilliseconds)
            ) &&
            (
                AcdDurationMilliseconds == other.AcdDurationMilliseconds ||
                AcdDurationMilliseconds != null &&
                AcdDurationMilliseconds.SequenceEqual(other.AcdDurationMilliseconds)
            ) &&
            (
                IvrDurationMilliseconds == other.IvrDurationMilliseconds ||
                IvrDurationMilliseconds != null &&
                IvrDurationMilliseconds.SequenceEqual(other.IvrDurationMilliseconds)
            ) &&
            (
                OtherDurationMilliseconds == other.OtherDurationMilliseconds ||
                OtherDurationMilliseconds != null &&
                OtherDurationMilliseconds.SequenceEqual(other.OtherDurationMilliseconds)
            ) &&
            (
                AgentTalkPercentage == other.AgentTalkPercentage ||
                AgentTalkPercentage != null &&
                AgentTalkPercentage.Equals(other.AgentTalkPercentage)
            ) &&
            (
                CustomerTalkPercentage == other.CustomerTalkPercentage ||
                CustomerTalkPercentage != null &&
                CustomerTalkPercentage.Equals(other.CustomerTalkPercentage)
            ) &&
            (
                OvertalkPercentage == other.OvertalkPercentage ||
                OvertalkPercentage != null &&
                OvertalkPercentage.Equals(other.OvertalkPercentage)
            ) &&
            (
                SilencePercentage == other.SilencePercentage ||
                SilencePercentage != null &&
                SilencePercentage.Equals(other.SilencePercentage)
            ) &&
            (
                AcdPercentage == other.AcdPercentage ||
                AcdPercentage != null &&
                AcdPercentage.Equals(other.AcdPercentage)
            ) &&
            (
                IvrPercentage == other.IvrPercentage ||
                IvrPercentage != null &&
                IvrPercentage.Equals(other.IvrPercentage)
            ) &&
            (
                OtherPercentage == other.OtherPercentage ||
                OtherPercentage != null &&
                OtherPercentage.Equals(other.OtherPercentage)
            ) &&
            (
                OvertalkInstances == other.OvertalkInstances ||
                OvertalkInstances != null &&
                OvertalkInstances.Equals(other.OvertalkInstances)
            ) &&
            (
                IsScreenRecorded == other.IsScreenRecorded ||
                IsScreenRecorded != null &&
                IsScreenRecorded.Equals(other.IsScreenRecorded)
            ) &&
            (
                ScreenMonitorUserIds == other.ScreenMonitorUserIds ||
                ScreenMonitorUserIds != null &&
                ScreenMonitorUserIds.SequenceEqual(other.ScreenMonitorUserIds)
            ) &&
            (
                DashboardState == other.DashboardState ||
                DashboardState != null &&
                DashboardState.Equals(other.DashboardState)
            ) &&
            (
                DashboardType == other.DashboardType ||
                DashboardType != null &&
                DashboardType.Equals(other.DashboardType)
            ) &&
            (
                DashboardAccessFilter == other.DashboardAccessFilter ||
                DashboardAccessFilter != null &&
                DashboardAccessFilter.Equals(other.DashboardAccessFilter)
            ) &&
            (
                TranscriptDurationMilliseconds == other.TranscriptDurationMilliseconds ||
                TranscriptDurationMilliseconds != null &&
                TranscriptDurationMilliseconds.SequenceEqual(other.TranscriptDurationMilliseconds)
            ) &&
            (
                WorkitemsStatuses == other.WorkitemsStatuses ||
                WorkitemsStatuses != null &&
                WorkitemsStatuses.SequenceEqual(other.WorkitemsStatuses)
            ) &&
            (
                SocialCountries == other.SocialCountries ||
                SocialCountries != null &&
                SocialCountries.SequenceEqual(other.SocialCountries)
            ) &&
            (
                SocialLanguages == other.SocialLanguages ||
                SocialLanguages != null &&
                SocialLanguages.SequenceEqual(other.SocialLanguages)
            ) &&
            (
                SocialChannels == other.SocialChannels ||
                SocialChannels != null &&
                SocialChannels.SequenceEqual(other.SocialChannels)
            ) &&
            (
                SocialSentimentCategory == other.SocialSentimentCategory ||
                SocialSentimentCategory != null &&
                SocialSentimentCategory.SequenceEqual(other.SocialSentimentCategory)
            ) &&
            (
                SocialTopicIds == other.SocialTopicIds ||
                SocialTopicIds != null &&
                SocialTopicIds.SequenceEqual(other.SocialTopicIds)
            ) &&
            (
                SocialIngestionRuleIds == other.SocialIngestionRuleIds ||
                SocialIngestionRuleIds != null &&
                SocialIngestionRuleIds.SequenceEqual(other.SocialIngestionRuleIds)
            ) &&
            (
                SocialConversationCreated == other.SocialConversationCreated ||
                SocialConversationCreated != null &&
                SocialConversationCreated.Equals(other.SocialConversationCreated)
            ) &&
            (
                SocialContentType == other.SocialContentType ||
                SocialContentType != null &&
                SocialContentType.SequenceEqual(other.SocialContentType)
            ) &&
            (
                SocialKeywords == other.SocialKeywords ||
                SocialKeywords != null &&
                SocialKeywords.SequenceEqual(other.SocialKeywords)
            ) &&
            (
                SocialPostEscalated == other.SocialPostEscalated ||
                SocialPostEscalated != null &&
                SocialPostEscalated.Equals(other.SocialPostEscalated)
            ) &&
            (
                SocialClassifications == other.SocialClassifications ||
                SocialClassifications != null &&
                SocialClassifications.SequenceEqual(other.SocialClassifications)
            ) &&
            (
                FilterUsersByManagerIds == other.FilterUsersByManagerIds ||
                FilterUsersByManagerIds != null &&
                FilterUsersByManagerIds.SequenceEqual(other.FilterUsersByManagerIds)
            ) &&
            (
                SlideshowIds == other.SlideshowIds ||
                SlideshowIds != null &&
                SlideshowIds.SequenceEqual(other.SlideshowIds)
            ) &&
            (
                Conferenced == other.Conferenced ||
                Conferenced != null &&
                Conferenced.Equals(other.Conferenced)
            ) &&
            (
                Video == other.Video ||
                Video != null &&
                Video.Equals(other.Video)
            ) &&
            (
                LinkedInteraction == other.LinkedInteraction ||
                LinkedInteraction != null &&
                LinkedInteraction.Equals(other.LinkedInteraction)
            ) &&
            (
                RecommendationSources == other.RecommendationSources ||
                RecommendationSources != null &&
                RecommendationSources.SequenceEqual(other.RecommendationSources)
            ) &&
            (
                EvaluationRole == other.EvaluationRole ||
                EvaluationRole != null &&
                EvaluationRole.Equals(other.EvaluationRole)
            ) &&
            (
                ComparisonQueueIds == other.ComparisonQueueIds ||
                ComparisonQueueIds != null &&
                ComparisonQueueIds.SequenceEqual(other.ComparisonQueueIds)
            ) &&
            (
                ViewMetrics == other.ViewMetrics ||
                ViewMetrics != null &&
                ViewMetrics.SequenceEqual(other.ViewMetrics)
            ) &&
            (
                TimelineCategories == other.TimelineCategories ||
                TimelineCategories != null &&
                TimelineCategories.SequenceEqual(other.TimelineCategories)
            ) &&
            (
                Acw == other.Acw ||
                Acw != null &&
                Acw.Equals(other.Acw)
            ) &&
            (
                SegmentTypes == other.SegmentTypes ||
                SegmentTypes != null &&
                SegmentTypes.SequenceEqual(other.SegmentTypes)
            ) &&
            (
                ProgramIds == other.ProgramIds ||
                ProgramIds != null &&
                ProgramIds.SequenceEqual(other.ProgramIds)
            ) &&
            (
                CategoryIds == other.CategoryIds ||
                CategoryIds != null &&
                CategoryIds.SequenceEqual(other.CategoryIds)
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
            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            if (SkillIds != null)
            {
                hash = hash * 59 + SkillIds.GetHashCode();
            }

            if (AssignedSkillIds != null)
            {
                hash = hash * 59 + AssignedSkillIds.GetHashCode();
            }

            if (SkillGroups != null)
            {
                hash = hash * 59 + SkillGroups.GetHashCode();
            }

            if (LanguageIds != null)
            {
                hash = hash * 59 + LanguageIds.GetHashCode();
            }

            if (AssignedLanguageIds != null)
            {
                hash = hash * 59 + AssignedLanguageIds.GetHashCode();
            }

            if (LanguageGroups != null)
            {
                hash = hash * 59 + LanguageGroups.GetHashCode();
            }

            if (Directions != null)
            {
                hash = hash * 59 + Directions.GetHashCode();
            }

            if (OriginatingDirections != null)
            {
                hash = hash * 59 + OriginatingDirections.GetHashCode();
            }

            if (WrapUpCodes != null)
            {
                hash = hash * 59 + WrapUpCodes.GetHashCode();
            }

            if (DnisList != null)
            {
                hash = hash * 59 + DnisList.GetHashCode();
            }

            if (SessionDnisList != null)
            {
                hash = hash * 59 + SessionDnisList.GetHashCode();
            }

            if (FilterQueuesByUserIds != null)
            {
                hash = hash * 59 + FilterQueuesByUserIds.GetHashCode();
            }

            if (FilterUsersByQueueIds != null)
            {
                hash = hash * 59 + FilterUsersByQueueIds.GetHashCode();
            }

            if (UserIds != null)
            {
                hash = hash * 59 + UserIds.GetHashCode();
            }

            if (ManagementUnitIds != null)
            {
                hash = hash * 59 + ManagementUnitIds.GetHashCode();
            }

            if (AddressTos != null)
            {
                hash = hash * 59 + AddressTos.GetHashCode();
            }

            if (AddressFroms != null)
            {
                hash = hash * 59 + AddressFroms.GetHashCode();
            }

            if (OutboundCampaignIds != null)
            {
                hash = hash * 59 + OutboundCampaignIds.GetHashCode();
            }

            if (OutboundContactListIds != null)
            {
                hash = hash * 59 + OutboundContactListIds.GetHashCode();
            }

            if (ContactIds != null)
            {
                hash = hash * 59 + ContactIds.GetHashCode();
            }

            if (ExternalContactIds != null)
            {
                hash = hash * 59 + ExternalContactIds.GetHashCode();
            }

            if (ExternalOrgIds != null)
            {
                hash = hash * 59 + ExternalOrgIds.GetHashCode();
            }

            if (AniList != null)
            {
                hash = hash * 59 + AniList.GetHashCode();
            }

            if (DurationsMilliseconds != null)
            {
                hash = hash * 59 + DurationsMilliseconds.GetHashCode();
            }

            if (AcdDurationsMilliseconds != null)
            {
                hash = hash * 59 + AcdDurationsMilliseconds.GetHashCode();
            }

            if (TalkDurationsMilliseconds != null)
            {
                hash = hash * 59 + TalkDurationsMilliseconds.GetHashCode();
            }

            if (AcwDurationsMilliseconds != null)
            {
                hash = hash * 59 + AcwDurationsMilliseconds.GetHashCode();
            }

            if (HandleDurationsMilliseconds != null)
            {
                hash = hash * 59 + HandleDurationsMilliseconds.GetHashCode();
            }

            if (HoldDurationsMilliseconds != null)
            {
                hash = hash * 59 + HoldDurationsMilliseconds.GetHashCode();
            }

            if (AbandonDurationsMilliseconds != null)
            {
                hash = hash * 59 + AbandonDurationsMilliseconds.GetHashCode();
            }

            if (EvaluationScore != null)
            {
                hash = hash * 59 + EvaluationScore.GetHashCode();
            }

            if (EvaluationCriticalScore != null)
            {
                hash = hash * 59 + EvaluationCriticalScore.GetHashCode();
            }

            if (EvaluationFormIds != null)
            {
                hash = hash * 59 + EvaluationFormIds.GetHashCode();
            }

            if (EvaluatedAgentIds != null)
            {
                hash = hash * 59 + EvaluatedAgentIds.GetHashCode();
            }

            if (EvaluatorIds != null)
            {
                hash = hash * 59 + EvaluatorIds.GetHashCode();
            }

            if (Transferred != null)
            {
                hash = hash * 59 + Transferred.GetHashCode();
            }

            if (Abandoned != null)
            {
                hash = hash * 59 + Abandoned.GetHashCode();
            }

            if (Answered != null)
            {
                hash = hash * 59 + Answered.GetHashCode();
            }

            if (MessageTypes != null)
            {
                hash = hash * 59 + MessageTypes.GetHashCode();
            }

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (SurveyFormIds != null)
            {
                hash = hash * 59 + SurveyFormIds.GetHashCode();
            }

            if (SurveyTotalScore != null)
            {
                hash = hash * 59 + SurveyTotalScore.GetHashCode();
            }

            if (SurveyNpsScore != null)
            {
                hash = hash * 59 + SurveyNpsScore.GetHashCode();
            }

            if (Mos != null)
            {
                hash = hash * 59 + Mos.GetHashCode();
            }

            if (SurveyQuestionGroupScore != null)
            {
                hash = hash * 59 + SurveyQuestionGroupScore.GetHashCode();
            }

            if (SurveyPromoterScore != null)
            {
                hash = hash * 59 + SurveyPromoterScore.GetHashCode();
            }

            if (SurveyFormContextIds != null)
            {
                hash = hash * 59 + SurveyFormContextIds.GetHashCode();
            }

            if (ConversationIds != null)
            {
                hash = hash * 59 + ConversationIds.GetHashCode();
            }

            if (SipCallIds != null)
            {
                hash = hash * 59 + SipCallIds.GetHashCode();
            }

            if (IsEnded != null)
            {
                hash = hash * 59 + IsEnded.GetHashCode();
            }

            if (IsSurveyed != null)
            {
                hash = hash * 59 + IsSurveyed.GetHashCode();
            }

            if (SurveyScores != null)
            {
                hash = hash * 59 + SurveyScores.GetHashCode();
            }

            if (PromoterScores != null)
            {
                hash = hash * 59 + PromoterScores.GetHashCode();
            }

            if (IsCampaign != null)
            {
                hash = hash * 59 + IsCampaign.GetHashCode();
            }

            if (SurveyStatuses != null)
            {
                hash = hash * 59 + SurveyStatuses.GetHashCode();
            }

            if (ConversationProperties != null)
            {
                hash = hash * 59 + ConversationProperties.GetHashCode();
            }

            if (IsBlindTransferred != null)
            {
                hash = hash * 59 + IsBlindTransferred.GetHashCode();
            }

            if (IsConsulted != null)
            {
                hash = hash * 59 + IsConsulted.GetHashCode();
            }

            if (IsConsultTransferred != null)
            {
                hash = hash * 59 + IsConsultTransferred.GetHashCode();
            }

            if (RemoteParticipants != null)
            {
                hash = hash * 59 + RemoteParticipants.GetHashCode();
            }

            if (FlowIds != null)
            {
                hash = hash * 59 + FlowIds.GetHashCode();
            }

            if (FlowOutcomeIds != null)
            {
                hash = hash * 59 + FlowOutcomeIds.GetHashCode();
            }

            if (FlowOutcomeValues != null)
            {
                hash = hash * 59 + FlowOutcomeValues.GetHashCode();
            }

            if (FlowDestinationTypes != null)
            {
                hash = hash * 59 + FlowDestinationTypes.GetHashCode();
            }

            if (FlowDisconnectReasons != null)
            {
                hash = hash * 59 + FlowDisconnectReasons.GetHashCode();
            }

            if (FlowTypes != null)
            {
                hash = hash * 59 + FlowTypes.GetHashCode();
            }

            if (FlowEntryTypes != null)
            {
                hash = hash * 59 + FlowEntryTypes.GetHashCode();
            }

            if (FlowEntryReasons != null)
            {
                hash = hash * 59 + FlowEntryReasons.GetHashCode();
            }

            if (FlowVersions != null)
            {
                hash = hash * 59 + FlowVersions.GetHashCode();
            }

            if (GroupIds != null)
            {
                hash = hash * 59 + GroupIds.GetHashCode();
            }

            if (HasJourneyCustomerId != null)
            {
                hash = hash * 59 + HasJourneyCustomerId.GetHashCode();
            }

            if (HasJourneyActionMapId != null)
            {
                hash = hash * 59 + HasJourneyActionMapId.GetHashCode();
            }

            if (HasJourneyVisitId != null)
            {
                hash = hash * 59 + HasJourneyVisitId.GetHashCode();
            }

            if (HasMedia != null)
            {
                hash = hash * 59 + HasMedia.GetHashCode();
            }

            if (RoleIds != null)
            {
                hash = hash * 59 + RoleIds.GetHashCode();
            }

            if (ReportsTos != null)
            {
                hash = hash * 59 + ReportsTos.GetHashCode();
            }

            if (LocationIds != null)
            {
                hash = hash * 59 + LocationIds.GetHashCode();
            }

            if (FlowOutTypes != null)
            {
                hash = hash * 59 + FlowOutTypes.GetHashCode();
            }

            if (ProviderList != null)
            {
                hash = hash * 59 + ProviderList.GetHashCode();
            }

            if (CallbackNumberList != null)
            {
                hash = hash * 59 + CallbackNumberList.GetHashCode();
            }

            if (CallbackInterval != null)
            {
                hash = hash * 59 + CallbackInterval.GetHashCode();
            }

            if (UsedRoutingTypes != null)
            {
                hash = hash * 59 + UsedRoutingTypes.GetHashCode();
            }

            if (RequestedRoutingTypes != null)
            {
                hash = hash * 59 + RequestedRoutingTypes.GetHashCode();
            }

            if (HasAgentAssistId != null)
            {
                hash = hash * 59 + HasAgentAssistId.GetHashCode();
            }

            if (Transcripts != null)
            {
                hash = hash * 59 + Transcripts.GetHashCode();
            }

            if (TranscriptLanguages != null)
            {
                hash = hash * 59 + TranscriptLanguages.GetHashCode();
            }

            if (ParticipantPurposes != null)
            {
                hash = hash * 59 + ParticipantPurposes.GetHashCode();
            }

            if (ShowFirstQueue != null)
            {
                hash = hash * 59 + ShowFirstQueue.GetHashCode();
            }

            if (TeamIds != null)
            {
                hash = hash * 59 + TeamIds.GetHashCode();
            }

            if (FilterUsersByTeamIds != null)
            {
                hash = hash * 59 + FilterUsersByTeamIds.GetHashCode();
            }

            if (JourneyActionMapIds != null)
            {
                hash = hash * 59 + JourneyActionMapIds.GetHashCode();
            }

            if (JourneyOutcomeIds != null)
            {
                hash = hash * 59 + JourneyOutcomeIds.GetHashCode();
            }

            if (JourneySegmentIds != null)
            {
                hash = hash * 59 + JourneySegmentIds.GetHashCode();
            }

            if (JourneyActionMapTypes != null)
            {
                hash = hash * 59 + JourneyActionMapTypes.GetHashCode();
            }

            if (DevelopmentRoleList != null)
            {
                hash = hash * 59 + DevelopmentRoleList.GetHashCode();
            }

            if (DevelopmentTypeList != null)
            {
                hash = hash * 59 + DevelopmentTypeList.GetHashCode();
            }

            if (DevelopmentStatusList != null)
            {
                hash = hash * 59 + DevelopmentStatusList.GetHashCode();
            }

            if (DevelopmentModuleIds != null)
            {
                hash = hash * 59 + DevelopmentModuleIds.GetHashCode();
            }

            if (DevelopmentActivityOverdue != null)
            {
                hash = hash * 59 + DevelopmentActivityOverdue.GetHashCode();
            }

            if (CustomerSentimentScore != null)
            {
                hash = hash * 59 + CustomerSentimentScore.GetHashCode();
            }

            if (CustomerSentimentTrend != null)
            {
                hash = hash * 59 + CustomerSentimentTrend.GetHashCode();
            }

            if (FlowTransferTargets != null)
            {
                hash = hash * 59 + FlowTransferTargets.GetHashCode();
            }

            if (DevelopmentName != null)
            {
                hash = hash * 59 + DevelopmentName.GetHashCode();
            }

            if (TopicIds != null)
            {
                hash = hash * 59 + TopicIds.GetHashCode();
            }

            if (ExternalTags != null)
            {
                hash = hash * 59 + ExternalTags.GetHashCode();
            }

            if (IsNotResponding != null)
            {
                hash = hash * 59 + IsNotResponding.GetHashCode();
            }

            if (IsAuthenticated != null)
            {
                hash = hash * 59 + IsAuthenticated.GetHashCode();
            }

            if (BotIds != null)
            {
                hash = hash * 59 + BotIds.GetHashCode();
            }

            if (BotVersions != null)
            {
                hash = hash * 59 + BotVersions.GetHashCode();
            }

            if (BotMessageTypes != null)
            {
                hash = hash * 59 + BotMessageTypes.GetHashCode();
            }

            if (BotProviderList != null)
            {
                hash = hash * 59 + BotProviderList.GetHashCode();
            }

            if (BotProductList != null)
            {
                hash = hash * 59 + BotProductList.GetHashCode();
            }

            if (BotRecognitionFailureReasonList != null)
            {
                hash = hash * 59 + BotRecognitionFailureReasonList.GetHashCode();
            }

            if (BotIntentList != null)
            {
                hash = hash * 59 + BotIntentList.GetHashCode();
            }

            if (BotFinalIntentList != null)
            {
                hash = hash * 59 + BotFinalIntentList.GetHashCode();
            }

            if (BotSlotList != null)
            {
                hash = hash * 59 + BotSlotList.GetHashCode();
            }

            if (BotResultList != null)
            {
                hash = hash * 59 + BotResultList.GetHashCode();
            }

            if (BlockedReasons != null)
            {
                hash = hash * 59 + BlockedReasons.GetHashCode();
            }

            if (IsRecorded != null)
            {
                hash = hash * 59 + IsRecorded.GetHashCode();
            }

            if (HasEvaluation != null)
            {
                hash = hash * 59 + HasEvaluation.GetHashCode();
            }

            if (HasScoredEvaluation != null)
            {
                hash = hash * 59 + HasScoredEvaluation.GetHashCode();
            }

            if (EmailDeliveryStatusList != null)
            {
                hash = hash * 59 + EmailDeliveryStatusList.GetHashCode();
            }

            if (IsAgentOwnedCallback != null)
            {
                hash = hash * 59 + IsAgentOwnedCallback.GetHashCode();
            }

            if (AgentCallbackOwnerIds != null)
            {
                hash = hash * 59 + AgentCallbackOwnerIds.GetHashCode();
            }

            if (TranscriptTopics != null)
            {
                hash = hash * 59 + TranscriptTopics.GetHashCode();
            }

            if (JourneyFrequencyCapReasons != null)
            {
                hash = hash * 59 + JourneyFrequencyCapReasons.GetHashCode();
            }

            if (JourneyBlockingActionMapIds != null)
            {
                hash = hash * 59 + JourneyBlockingActionMapIds.GetHashCode();
            }

            if (JourneyActionTargetIds != null)
            {
                hash = hash * 59 + JourneyActionTargetIds.GetHashCode();
            }

            if (JourneyBlockingScheduleGroupIds != null)
            {
                hash = hash * 59 + JourneyBlockingScheduleGroupIds.GetHashCode();
            }

            if (JourneyBlockingEmergencyScheduleGroupIds != null)
            {
                hash = hash * 59 + JourneyBlockingEmergencyScheduleGroupIds.GetHashCode();
            }

            if (JourneyUrlEqualConditions != null)
            {
                hash = hash * 59 + JourneyUrlEqualConditions.GetHashCode();
            }

            if (JourneyUrlNotEqualConditions != null)
            {
                hash = hash * 59 + JourneyUrlNotEqualConditions.GetHashCode();
            }

            if (JourneyUrlStartsWithConditions != null)
            {
                hash = hash * 59 + JourneyUrlStartsWithConditions.GetHashCode();
            }

            if (JourneyUrlEndsWithConditions != null)
            {
                hash = hash * 59 + JourneyUrlEndsWithConditions.GetHashCode();
            }

            if (JourneyUrlContainsAnyConditions != null)
            {
                hash = hash * 59 + JourneyUrlContainsAnyConditions.GetHashCode();
            }

            if (JourneyUrlNotContainsAnyConditions != null)
            {
                hash = hash * 59 + JourneyUrlNotContainsAnyConditions.GetHashCode();
            }

            if (JourneyUrlContainsAllConditions != null)
            {
                hash = hash * 59 + JourneyUrlContainsAllConditions.GetHashCode();
            }

            if (JourneyUrlNotContainsAllConditions != null)
            {
                hash = hash * 59 + JourneyUrlNotContainsAllConditions.GetHashCode();
            }

            if (FlowMilestoneIds != null)
            {
                hash = hash * 59 + FlowMilestoneIds.GetHashCode();
            }

            if (IsAssessmentPassed != null)
            {
                hash = hash * 59 + IsAssessmentPassed.GetHashCode();
            }

            if (ConversationInitiators != null)
            {
                hash = hash * 59 + ConversationInitiators.GetHashCode();
            }

            if (HasCustomerParticipated != null)
            {
                hash = hash * 59 + HasCustomerParticipated.GetHashCode();
            }

            if (IsAcdInteraction != null)
            {
                hash = hash * 59 + IsAcdInteraction.GetHashCode();
            }

            if (HasFax != null)
            {
                hash = hash * 59 + HasFax.GetHashCode();
            }

            if (DataActionIds != null)
            {
                hash = hash * 59 + DataActionIds.GetHashCode();
            }

            if (ActionCategoryName != null)
            {
                hash = hash * 59 + ActionCategoryName.GetHashCode();
            }

            if (IntegrationIds != null)
            {
                hash = hash * 59 + IntegrationIds.GetHashCode();
            }

            if (ResponseStatuses != null)
            {
                hash = hash * 59 + ResponseStatuses.GetHashCode();
            }

            if (AvailableDashboard != null)
            {
                hash = hash * 59 + AvailableDashboard.GetHashCode();
            }

            if (FavouriteDashboard != null)
            {
                hash = hash * 59 + FavouriteDashboard.GetHashCode();
            }

            if (MyDashboard != null)
            {
                hash = hash * 59 + MyDashboard.GetHashCode();
            }

            if (StationErrors != null)
            {
                hash = hash * 59 + StationErrors.GetHashCode();
            }

            if (CanonicalContactIds != null)
            {
                hash = hash * 59 + CanonicalContactIds.GetHashCode();
            }

            if (AlertRuleIds != null)
            {
                hash = hash * 59 + AlertRuleIds.GetHashCode();
            }

            if (EvaluationFormContextIds != null)
            {
                hash = hash * 59 + EvaluationFormContextIds.GetHashCode();
            }

            if (EvaluationStatuses != null)
            {
                hash = hash * 59 + EvaluationStatuses.GetHashCode();
            }

            if (WorkbinIds != null)
            {
                hash = hash * 59 + WorkbinIds.GetHashCode();
            }

            if (WorktypeIds != null)
            {
                hash = hash * 59 + WorktypeIds.GetHashCode();
            }

            if (WorkitemIds != null)
            {
                hash = hash * 59 + WorkitemIds.GetHashCode();
            }

            if (WorkitemAssigneeIds != null)
            {
                hash = hash * 59 + WorkitemAssigneeIds.GetHashCode();
            }

            if (WorkitemStatuses != null)
            {
                hash = hash * 59 + WorkitemStatuses.GetHashCode();
            }

            if (IsAnalyzedForSensitiveData != null)
            {
                hash = hash * 59 + IsAnalyzedForSensitiveData.GetHashCode();
            }

            if (HasSensitiveData != null)
            {
                hash = hash * 59 + HasSensitiveData.GetHashCode();
            }

            if (HasPciData != null)
            {
                hash = hash * 59 + HasPciData.GetHashCode();
            }

            if (HasPiiData != null)
            {
                hash = hash * 59 + HasPiiData.GetHashCode();
            }

            if (SubPath != null)
            {
                hash = hash * 59 + SubPath.GetHashCode();
            }

            if (UserState != null)
            {
                hash = hash * 59 + UserState.GetHashCode();
            }

            if (IsClearedByCustomer != null)
            {
                hash = hash * 59 + IsClearedByCustomer.GetHashCode();
            }

            if (EvaluationAssigneeIds != null)
            {
                hash = hash * 59 + EvaluationAssigneeIds.GetHashCode();
            }

            if (EvaluationAssigned != null)
            {
                hash = hash * 59 + EvaluationAssigned.GetHashCode();
            }

            if (AssistantIds != null)
            {
                hash = hash * 59 + AssistantIds.GetHashCode();
            }

            if (KnowledgeBaseIds != null)
            {
                hash = hash * 59 + KnowledgeBaseIds.GetHashCode();
            }

            if (IsParked != null)
            {
                hash = hash * 59 + IsParked.GetHashCode();
            }

            if (AgentEmpathyScore != null)
            {
                hash = hash * 59 + AgentEmpathyScore.GetHashCode();
            }

            if (SurveyTypes != null)
            {
                hash = hash * 59 + SurveyTypes.GetHashCode();
            }

            if (SurveyResponseStatuses != null)
            {
                hash = hash * 59 + SurveyResponseStatuses.GetHashCode();
            }

            if (BotFlowTypes != null)
            {
                hash = hash * 59 + BotFlowTypes.GetHashCode();
            }

            if (AgentTalkDurationMilliseconds != null)
            {
                hash = hash * 59 + AgentTalkDurationMilliseconds.GetHashCode();
            }

            if (CustomerTalkDurationMilliseconds != null)
            {
                hash = hash * 59 + CustomerTalkDurationMilliseconds.GetHashCode();
            }

            if (OvertalkDurationMilliseconds != null)
            {
                hash = hash * 59 + OvertalkDurationMilliseconds.GetHashCode();
            }

            if (SilenceDurationMilliseconds != null)
            {
                hash = hash * 59 + SilenceDurationMilliseconds.GetHashCode();
            }

            if (AcdDurationMilliseconds != null)
            {
                hash = hash * 59 + AcdDurationMilliseconds.GetHashCode();
            }

            if (IvrDurationMilliseconds != null)
            {
                hash = hash * 59 + IvrDurationMilliseconds.GetHashCode();
            }

            if (OtherDurationMilliseconds != null)
            {
                hash = hash * 59 + OtherDurationMilliseconds.GetHashCode();
            }

            if (AgentTalkPercentage != null)
            {
                hash = hash * 59 + AgentTalkPercentage.GetHashCode();
            }

            if (CustomerTalkPercentage != null)
            {
                hash = hash * 59 + CustomerTalkPercentage.GetHashCode();
            }

            if (OvertalkPercentage != null)
            {
                hash = hash * 59 + OvertalkPercentage.GetHashCode();
            }

            if (SilencePercentage != null)
            {
                hash = hash * 59 + SilencePercentage.GetHashCode();
            }

            if (AcdPercentage != null)
            {
                hash = hash * 59 + AcdPercentage.GetHashCode();
            }

            if (IvrPercentage != null)
            {
                hash = hash * 59 + IvrPercentage.GetHashCode();
            }

            if (OtherPercentage != null)
            {
                hash = hash * 59 + OtherPercentage.GetHashCode();
            }

            if (OvertalkInstances != null)
            {
                hash = hash * 59 + OvertalkInstances.GetHashCode();
            }

            if (IsScreenRecorded != null)
            {
                hash = hash * 59 + IsScreenRecorded.GetHashCode();
            }

            if (ScreenMonitorUserIds != null)
            {
                hash = hash * 59 + ScreenMonitorUserIds.GetHashCode();
            }

            if (DashboardState != null)
            {
                hash = hash * 59 + DashboardState.GetHashCode();
            }

            if (DashboardType != null)
            {
                hash = hash * 59 + DashboardType.GetHashCode();
            }

            if (DashboardAccessFilter != null)
            {
                hash = hash * 59 + DashboardAccessFilter.GetHashCode();
            }

            if (TranscriptDurationMilliseconds != null)
            {
                hash = hash * 59 + TranscriptDurationMilliseconds.GetHashCode();
            }

            if (WorkitemsStatuses != null)
            {
                hash = hash * 59 + WorkitemsStatuses.GetHashCode();
            }

            if (SocialCountries != null)
            {
                hash = hash * 59 + SocialCountries.GetHashCode();
            }

            if (SocialLanguages != null)
            {
                hash = hash * 59 + SocialLanguages.GetHashCode();
            }

            if (SocialChannels != null)
            {
                hash = hash * 59 + SocialChannels.GetHashCode();
            }

            if (SocialSentimentCategory != null)
            {
                hash = hash * 59 + SocialSentimentCategory.GetHashCode();
            }

            if (SocialTopicIds != null)
            {
                hash = hash * 59 + SocialTopicIds.GetHashCode();
            }

            if (SocialIngestionRuleIds != null)
            {
                hash = hash * 59 + SocialIngestionRuleIds.GetHashCode();
            }

            if (SocialConversationCreated != null)
            {
                hash = hash * 59 + SocialConversationCreated.GetHashCode();
            }

            if (SocialContentType != null)
            {
                hash = hash * 59 + SocialContentType.GetHashCode();
            }

            if (SocialKeywords != null)
            {
                hash = hash * 59 + SocialKeywords.GetHashCode();
            }

            if (SocialPostEscalated != null)
            {
                hash = hash * 59 + SocialPostEscalated.GetHashCode();
            }

            if (SocialClassifications != null)
            {
                hash = hash * 59 + SocialClassifications.GetHashCode();
            }

            if (FilterUsersByManagerIds != null)
            {
                hash = hash * 59 + FilterUsersByManagerIds.GetHashCode();
            }

            if (SlideshowIds != null)
            {
                hash = hash * 59 + SlideshowIds.GetHashCode();
            }

            if (Conferenced != null)
            {
                hash = hash * 59 + Conferenced.GetHashCode();
            }

            if (Video != null)
            {
                hash = hash * 59 + Video.GetHashCode();
            }

            if (LinkedInteraction != null)
            {
                hash = hash * 59 + LinkedInteraction.GetHashCode();
            }

            if (RecommendationSources != null)
            {
                hash = hash * 59 + RecommendationSources.GetHashCode();
            }

            if (EvaluationRole != null)
            {
                hash = hash * 59 + EvaluationRole.GetHashCode();
            }

            if (ComparisonQueueIds != null)
            {
                hash = hash * 59 + ComparisonQueueIds.GetHashCode();
            }

            if (ViewMetrics != null)
            {
                hash = hash * 59 + ViewMetrics.GetHashCode();
            }

            if (TimelineCategories != null)
            {
                hash = hash * 59 + TimelineCategories.GetHashCode();
            }

            if (Acw != null)
            {
                hash = hash * 59 + Acw.GetHashCode();
            }

            if (SegmentTypes != null)
            {
                hash = hash * 59 + SegmentTypes.GetHashCode();
            }

            if (ProgramIds != null)
            {
                hash = hash * 59 + ProgramIds.GetHashCode();
            }

            if (CategoryIds != null)
            {
                hash = hash * 59 + CategoryIds.GetHashCode();
            }

            return hash;
        }
    }
}
