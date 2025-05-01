using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationCallbackEventTopicCallbackMediaParticipant
/// </summary>
[DataContract]
public partial class ConversationCallbackEventTopicCallbackMediaParticipant : IEquatable<ConversationCallbackEventTopicCallbackMediaParticipant>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Offering for "offering"
        /// </summary>
        [EnumMember(Value = "offering")]
        Offering,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Terminated for "terminated"
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InitialStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Alerting for "alerting"
        /// </summary>
        [EnumMember(Value = "alerting")]
        Alerting,

        /// <summary>
        /// Enum Dialing for "dialing"
        /// </summary>
        [EnumMember(Value = "dialing")]
        Dialing,

        /// <summary>
        /// Enum Contacting for "contacting"
        /// </summary>
        [EnumMember(Value = "contacting")]
        Contacting,

        /// <summary>
        /// Enum Offering for "offering"
        /// </summary>
        [EnumMember(Value = "offering")]
        Offering,

        /// <summary>
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,

        /// <summary>
        /// Enum Terminated for "terminated"
        /// </summary>
        [EnumMember(Value = "terminated")]
        Terminated,

        /// <summary>
        /// Enum Converting for "converting"
        /// </summary>
        [EnumMember(Value = "converting")]
        Converting,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

        /// <summary>
        /// Enum Transmitting for "transmitting"
        /// </summary>
        [EnumMember(Value = "transmitting")]
        Transmitting,

        /// <summary>
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Parked for "parked"
        /// </summary>
        [EnumMember(Value = "parked")]
        Parked,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
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
    /// Gets or Sets DisconnectType
    /// </summary>
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
        /// Enum Endpoint for "endpoint"
        /// </summary>
        [EnumMember(Value = "endpoint")]
        Endpoint,

        /// <summary>
        /// Enum Endpointdnd for "endpoint.dnd"
        /// </summary>
        [EnumMember(Value = "endpoint.dnd")]
        Endpointdnd,

        /// <summary>
        /// Enum Client for "client"
        /// </summary>
        [EnumMember(Value = "client")]
        Client,

        /// <summary>
        /// Enum System for "system"
        /// </summary>
        [EnumMember(Value = "system")]
        System,

        /// <summary>
        /// Enum Transfer for "transfer"
        /// </summary>
        [EnumMember(Value = "transfer")]
        Transfer,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum Transferconference for "transfer.conference"
        /// </summary>
        [EnumMember(Value = "transfer.conference")]
        Transferconference,

        /// <summary>
        /// Enum Transferconsult for "transfer.consult"
        /// </summary>
        [EnumMember(Value = "transfer.consult")]
        Transferconsult,

        /// <summary>
        /// Enum Transferforward for "transfer.forward"
        /// </summary>
        [EnumMember(Value = "transfer.forward")]
        Transferforward,

        /// <summary>
        /// Enum Transfernoanswer for "transfer.noanswer"
        /// </summary>
        [EnumMember(Value = "transfer.noanswer")]
        Transfernoanswer,

        /// <summary>
        /// Enum Transfernotavailable for "transfer.notavailable"
        /// </summary>
        [EnumMember(Value = "transfer.notavailable")]
        Transfernotavailable,

        /// <summary>
        /// Enum Transferdnd for "transfer.dnd"
        /// </summary>
        [EnumMember(Value = "transfer.dnd")]
        Transferdnd,

        /// <summary>
        /// Enum Transportfailure for "transport.failure"
        /// </summary>
        [EnumMember(Value = "transport.failure")]
        Transportfailure,

        /// <summary>
        /// Enum Error for "error"
        /// </summary>
        [EnumMember(Value = "error")]
        Error,

        /// <summary>
        /// Enum Peer for "peer"
        /// </summary>
        [EnumMember(Value = "peer")]
        Peer,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other,

        /// <summary>
        /// Enum Spam for "spam"
        /// </summary>
        [EnumMember(Value = "spam")]
        Spam,

        /// <summary>
        /// Enum Uncallable for "uncallable"
        /// </summary>
        [EnumMember(Value = "uncallable")]
        Uncallable
    }
    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
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
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [DataMember(Name = "initialState", EmitDefaultValue = false)]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
    [DataMember(Name = "flaggedReason", EmitDefaultValue = false)]
    public FlaggedReasonEnum? FlaggedReason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationCallbackEventTopicCallbackMediaParticipant" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Address">Address.</param>
    /// <param name="StartTime">StartTime.</param>
    /// <param name="ConnectedTime">ConnectedTime.</param>
    /// <param name="EndTime">EndTime.</param>
    /// <param name="StartHoldTime">StartHoldTime.</param>
    /// <param name="Purpose">Purpose.</param>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Direction">Direction.</param>
    /// <param name="DisconnectType">DisconnectType.</param>
    /// <param name="Held">Held.</param>
    /// <param name="WrapupRequired">WrapupRequired.</param>
    /// <param name="WrapupPrompt">WrapupPrompt.</param>
    /// <param name="User">User.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="Team">Team.</param>
    /// <param name="Attributes">Attributes.</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    /// <param name="Script">Script.</param>
    /// <param name="WrapupTimeoutMs">WrapupTimeoutMs.</param>
    /// <param name="WrapupSkipped">WrapupSkipped.</param>
    /// <param name="AlertingTimeoutMs">AlertingTimeoutMs.</param>
    /// <param name="Provider">Provider.</param>
    /// <param name="ExternalContact">ExternalContact.</param>
    /// <param name="ExternalContactInitialDivisionId">ExternalContactInitialDivisionId.</param>
    /// <param name="ExternalOrganization">ExternalOrganization.</param>
    /// <param name="Wrapup">Wrapup.</param>
    /// <param name="ConversationRoutingData">ConversationRoutingData.</param>
    /// <param name="Peer">Peer.</param>
    /// <param name="ScreenRecordingState">ScreenRecordingState.</param>
    /// <param name="FlaggedReason">FlaggedReason.</param>
    /// <param name="JourneyContext">JourneyContext.</param>
    /// <param name="StartAcwTime">StartAcwTime.</param>
    /// <param name="EndAcwTime">EndAcwTime.</param>
    /// <param name="ResumeTime">ResumeTime.</param>
    /// <param name="ParkTime">ParkTime.</param>
    /// <param name="MediaRoles">MediaRoles.</param>
    /// <param name="QueueMediaSettings">QueueMediaSettings.</param>
    /// <param name="OutboundPreview">OutboundPreview.</param>
    /// <param name="Voicemail">Voicemail.</param>
    /// <param name="CallbackNumbers">CallbackNumbers.</param>
    /// <param name="CallbackUserName">CallbackUserName.</param>
    /// <param name="SkipEnabled">SkipEnabled.</param>
    /// <param name="ExternalCampaign">ExternalCampaign.</param>
    /// <param name="TimeoutSeconds">TimeoutSeconds.</param>
    /// <param name="CallbackScheduledTime">CallbackScheduledTime.</param>
    /// <param name="AutomatedCallbackConfigId">AutomatedCallbackConfigId.</param>
    public ConversationCallbackEventTopicCallbackMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, InitialStateEnum? InitialState = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, ConversationCallbackEventTopicUriReference User = null, ConversationCallbackEventTopicUriReference Queue = null, ConversationCallbackEventTopicUriReference Team = null, Dictionary<string, string> Attributes = null, ConversationCallbackEventTopicErrorBody ErrorInfo = null, ConversationCallbackEventTopicUriReference Script = null, long? WrapupTimeoutMs = null, bool? WrapupSkipped = null, long? AlertingTimeoutMs = null, string Provider = null, ConversationCallbackEventTopicUriReference ExternalContact = null, string ExternalContactInitialDivisionId = null, ConversationCallbackEventTopicUriReference ExternalOrganization = null, ConversationCallbackEventTopicWrapup Wrapup = null, ConversationCallbackEventTopicConversationRoutingData ConversationRoutingData = null, string Peer = null, string ScreenRecordingState = null, FlaggedReasonEnum? FlaggedReason = null, ConversationCallbackEventTopicJourneyContext JourneyContext = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, DateTime? ResumeTime = null, DateTime? ParkTime = null, List<string> MediaRoles = null, ConversationCallbackEventTopicQueueMediaSettings QueueMediaSettings = null, ConversationCallbackEventTopicDialerPreview OutboundPreview = null, ConversationCallbackEventTopicVoicemail Voicemail = null, List<string> CallbackNumbers = null, string CallbackUserName = null, bool? SkipEnabled = null, bool? ExternalCampaign = null, long? TimeoutSeconds = null, DateTime? CallbackScheduledTime = null, string AutomatedCallbackConfigId = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Address = Address;
        this.StartTime = StartTime;
        this.ConnectedTime = ConnectedTime;
        this.EndTime = EndTime;
        this.StartHoldTime = StartHoldTime;
        this.Purpose = Purpose;
        this.State = State;
        this.InitialState = InitialState;
        this.Direction = Direction;
        this.DisconnectType = DisconnectType;
        this.Held = Held;
        this.WrapupRequired = WrapupRequired;
        this.WrapupPrompt = WrapupPrompt;
        this.User = User;
        this.Queue = Queue;
        this.Team = Team;
        this.Attributes = Attributes;
        this.ErrorInfo = ErrorInfo;
        this.Script = Script;
        this.WrapupTimeoutMs = WrapupTimeoutMs;
        this.WrapupSkipped = WrapupSkipped;
        this.AlertingTimeoutMs = AlertingTimeoutMs;
        this.Provider = Provider;
        this.ExternalContact = ExternalContact;
        this.ExternalContactInitialDivisionId = ExternalContactInitialDivisionId;
        this.ExternalOrganization = ExternalOrganization;
        this.Wrapup = Wrapup;
        this.ConversationRoutingData = ConversationRoutingData;
        this.Peer = Peer;
        this.ScreenRecordingState = ScreenRecordingState;
        this.FlaggedReason = FlaggedReason;
        this.JourneyContext = JourneyContext;
        this.StartAcwTime = StartAcwTime;
        this.EndAcwTime = EndAcwTime;
        this.ResumeTime = ResumeTime;
        this.ParkTime = ParkTime;
        this.MediaRoles = MediaRoles;
        this.QueueMediaSettings = QueueMediaSettings;
        this.OutboundPreview = OutboundPreview;
        this.Voicemail = Voicemail;
        this.CallbackNumbers = CallbackNumbers;
        this.CallbackUserName = CallbackUserName;
        this.SkipEnabled = SkipEnabled;
        this.ExternalCampaign = ExternalCampaign;
        this.TimeoutSeconds = TimeoutSeconds;
        this.CallbackScheduledTime = CallbackScheduledTime;
        this.AutomatedCallbackConfigId = AutomatedCallbackConfigId;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name = "startTime", EmitDefaultValue = false)]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedTime
    /// </summary>
    [DataMember(Name = "connectedTime", EmitDefaultValue = false)]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// Gets or Sets StartHoldTime
    /// </summary>
    [DataMember(Name = "startHoldTime", EmitDefaultValue = false)]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    [DataMember(Name = "purpose", EmitDefaultValue = false)]
    public string Purpose { get; set; }











    /// <summary>
    /// Gets or Sets Held
    /// </summary>
    [DataMember(Name = "held", EmitDefaultValue = false)]
    public bool? Held { get; set; }



    /// <summary>
    /// Gets or Sets WrapupRequired
    /// </summary>
    [DataMember(Name = "wrapupRequired", EmitDefaultValue = false)]
    public bool? WrapupRequired { get; set; }



    /// <summary>
    /// Gets or Sets WrapupPrompt
    /// </summary>
    [DataMember(Name = "wrapupPrompt", EmitDefaultValue = false)]
    public string WrapupPrompt { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference User { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference Queue { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [DataMember(Name = "team", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference Team { get; set; }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [DataMember(Name = "errorInfo", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicErrorBody ErrorInfo { get; set; }



    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    [DataMember(Name = "script", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference Script { get; set; }



    /// <summary>
    /// Gets or Sets WrapupTimeoutMs
    /// </summary>
    [DataMember(Name = "wrapupTimeoutMs", EmitDefaultValue = false)]
    public long? WrapupTimeoutMs { get; set; }



    /// <summary>
    /// Gets or Sets WrapupSkipped
    /// </summary>
    [DataMember(Name = "wrapupSkipped", EmitDefaultValue = false)]
    public bool? WrapupSkipped { get; set; }



    /// <summary>
    /// Gets or Sets AlertingTimeoutMs
    /// </summary>
    [DataMember(Name = "alertingTimeoutMs", EmitDefaultValue = false)]
    public long? AlertingTimeoutMs { get; set; }



    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    [DataMember(Name = "externalContact", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference ExternalContact { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactInitialDivisionId
    /// </summary>
    [DataMember(Name = "externalContactInitialDivisionId", EmitDefaultValue = false)]
    public string ExternalContactInitialDivisionId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    [DataMember(Name = "externalOrganization", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicUriReference ExternalOrganization { get; set; }



    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    [DataMember(Name = "conversationRoutingData", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicConversationRoutingData ConversationRoutingData { get; set; }



    /// <summary>
    /// Gets or Sets Peer
    /// </summary>
    [DataMember(Name = "peer", EmitDefaultValue = false)]
    public string Peer { get; set; }



    /// <summary>
    /// Gets or Sets ScreenRecordingState
    /// </summary>
    [DataMember(Name = "screenRecordingState", EmitDefaultValue = false)]
    public string ScreenRecordingState { get; set; }





    /// <summary>
    /// Gets or Sets JourneyContext
    /// </summary>
    [DataMember(Name = "journeyContext", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicJourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Gets or Sets StartAcwTime
    /// </summary>
    [DataMember(Name = "startAcwTime", EmitDefaultValue = false)]
    public DateTime? StartAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets EndAcwTime
    /// </summary>
    [DataMember(Name = "endAcwTime", EmitDefaultValue = false)]
    public DateTime? EndAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets ResumeTime
    /// </summary>
    [DataMember(Name = "resumeTime", EmitDefaultValue = false)]
    public DateTime? ResumeTime { get; set; }



    /// <summary>
    /// Gets or Sets ParkTime
    /// </summary>
    [DataMember(Name = "parkTime", EmitDefaultValue = false)]
    public DateTime? ParkTime { get; set; }



    /// <summary>
    /// Gets or Sets MediaRoles
    /// </summary>
    [DataMember(Name = "mediaRoles", EmitDefaultValue = false)]
    public List<string> MediaRoles { get; set; }



    /// <summary>
    /// Gets or Sets QueueMediaSettings
    /// </summary>
    [DataMember(Name = "queueMediaSettings", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicQueueMediaSettings QueueMediaSettings { get; set; }



    /// <summary>
    /// Gets or Sets OutboundPreview
    /// </summary>
    [DataMember(Name = "outboundPreview", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicDialerPreview OutboundPreview { get; set; }



    /// <summary>
    /// Gets or Sets Voicemail
    /// </summary>
    [DataMember(Name = "voicemail", EmitDefaultValue = false)]
    public ConversationCallbackEventTopicVoicemail Voicemail { get; set; }



    /// <summary>
    /// Gets or Sets CallbackNumbers
    /// </summary>
    [DataMember(Name = "callbackNumbers", EmitDefaultValue = false)]
    public List<string> CallbackNumbers { get; set; }



    /// <summary>
    /// Gets or Sets CallbackUserName
    /// </summary>
    [DataMember(Name = "callbackUserName", EmitDefaultValue = false)]
    public string CallbackUserName { get; set; }



    /// <summary>
    /// Gets or Sets SkipEnabled
    /// </summary>
    [DataMember(Name = "skipEnabled", EmitDefaultValue = false)]
    public bool? SkipEnabled { get; set; }



    /// <summary>
    /// Gets or Sets ExternalCampaign
    /// </summary>
    [DataMember(Name = "externalCampaign", EmitDefaultValue = false)]
    public bool? ExternalCampaign { get; set; }



    /// <summary>
    /// Gets or Sets TimeoutSeconds
    /// </summary>
    [DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
    public long? TimeoutSeconds { get; set; }



    /// <summary>
    /// Gets or Sets CallbackScheduledTime
    /// </summary>
    [DataMember(Name = "callbackScheduledTime", EmitDefaultValue = false)]
    public DateTime? CallbackScheduledTime { get; set; }



    /// <summary>
    /// Gets or Sets AutomatedCallbackConfigId
    /// </summary>
    [DataMember(Name = "automatedCallbackConfigId", EmitDefaultValue = false)]
    public string AutomatedCallbackConfigId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationCallbackEventTopicCallbackMediaParticipant {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  Purpose: ").Append(Purpose).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
        sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Team: ").Append(Team).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  Script: ").Append(Script).Append("\n");
        sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
        sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
        sb.Append("  AlertingTimeoutMs: ").Append(AlertingTimeoutMs).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  ExternalContactInitialDivisionId: ").Append(ExternalContactInitialDivisionId).Append("\n");
        sb.Append("  ExternalOrganization: ").Append(ExternalOrganization).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  ConversationRoutingData: ").Append(ConversationRoutingData).Append("\n");
        sb.Append("  Peer: ").Append(Peer).Append("\n");
        sb.Append("  ScreenRecordingState: ").Append(ScreenRecordingState).Append("\n");
        sb.Append("  FlaggedReason: ").Append(FlaggedReason).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
        sb.Append("  StartAcwTime: ").Append(StartAcwTime).Append("\n");
        sb.Append("  EndAcwTime: ").Append(EndAcwTime).Append("\n");
        sb.Append("  ResumeTime: ").Append(ResumeTime).Append("\n");
        sb.Append("  ParkTime: ").Append(ParkTime).Append("\n");
        sb.Append("  MediaRoles: ").Append(MediaRoles).Append("\n");
        sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
        sb.Append("  OutboundPreview: ").Append(OutboundPreview).Append("\n");
        sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
        sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
        sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
        sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
        sb.Append("  ExternalCampaign: ").Append(ExternalCampaign).Append("\n");
        sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
        sb.Append("  AutomatedCallbackConfigId: ").Append(AutomatedCallbackConfigId).Append("\n");
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
        return Equals(obj as ConversationCallbackEventTopicCallbackMediaParticipant);
    }

    /// <summary>
    /// Returns true if ConversationCallbackEventTopicCallbackMediaParticipant instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationCallbackEventTopicCallbackMediaParticipant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationCallbackEventTopicCallbackMediaParticipant other)
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
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
            ) &&
            (
                StartHoldTime == other.StartHoldTime ||
                StartHoldTime != null &&
                StartHoldTime.Equals(other.StartHoldTime)
            ) &&
            (
                Purpose == other.Purpose ||
                Purpose != null &&
                Purpose.Equals(other.Purpose)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                InitialState == other.InitialState ||
                InitialState != null &&
                InitialState.Equals(other.InitialState)
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
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                WrapupRequired == other.WrapupRequired ||
                WrapupRequired != null &&
                WrapupRequired.Equals(other.WrapupRequired)
            ) &&
            (
                WrapupPrompt == other.WrapupPrompt ||
                WrapupPrompt != null &&
                WrapupPrompt.Equals(other.WrapupPrompt)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Team == other.Team ||
                Team != null &&
                Team.Equals(other.Team)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                Script == other.Script ||
                Script != null &&
                Script.Equals(other.Script)
            ) &&
            (
                WrapupTimeoutMs == other.WrapupTimeoutMs ||
                WrapupTimeoutMs != null &&
                WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
            ) &&
            (
                WrapupSkipped == other.WrapupSkipped ||
                WrapupSkipped != null &&
                WrapupSkipped.Equals(other.WrapupSkipped)
            ) &&
            (
                AlertingTimeoutMs == other.AlertingTimeoutMs ||
                AlertingTimeoutMs != null &&
                AlertingTimeoutMs.Equals(other.AlertingTimeoutMs)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                ExternalContactInitialDivisionId == other.ExternalContactInitialDivisionId ||
                ExternalContactInitialDivisionId != null &&
                ExternalContactInitialDivisionId.Equals(other.ExternalContactInitialDivisionId)
            ) &&
            (
                ExternalOrganization == other.ExternalOrganization ||
                ExternalOrganization != null &&
                ExternalOrganization.Equals(other.ExternalOrganization)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                ConversationRoutingData == other.ConversationRoutingData ||
                ConversationRoutingData != null &&
                ConversationRoutingData.Equals(other.ConversationRoutingData)
            ) &&
            (
                Peer == other.Peer ||
                Peer != null &&
                Peer.Equals(other.Peer)
            ) &&
            (
                ScreenRecordingState == other.ScreenRecordingState ||
                ScreenRecordingState != null &&
                ScreenRecordingState.Equals(other.ScreenRecordingState)
            ) &&
            (
                FlaggedReason == other.FlaggedReason ||
                FlaggedReason != null &&
                FlaggedReason.Equals(other.FlaggedReason)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
            ) &&
            (
                StartAcwTime == other.StartAcwTime ||
                StartAcwTime != null &&
                StartAcwTime.Equals(other.StartAcwTime)
            ) &&
            (
                EndAcwTime == other.EndAcwTime ||
                EndAcwTime != null &&
                EndAcwTime.Equals(other.EndAcwTime)
            ) &&
            (
                ResumeTime == other.ResumeTime ||
                ResumeTime != null &&
                ResumeTime.Equals(other.ResumeTime)
            ) &&
            (
                ParkTime == other.ParkTime ||
                ParkTime != null &&
                ParkTime.Equals(other.ParkTime)
            ) &&
            (
                MediaRoles == other.MediaRoles ||
                MediaRoles != null &&
                MediaRoles.SequenceEqual(other.MediaRoles)
            ) &&
            (
                QueueMediaSettings == other.QueueMediaSettings ||
                QueueMediaSettings != null &&
                QueueMediaSettings.Equals(other.QueueMediaSettings)
            ) &&
            (
                OutboundPreview == other.OutboundPreview ||
                OutboundPreview != null &&
                OutboundPreview.Equals(other.OutboundPreview)
            ) &&
            (
                Voicemail == other.Voicemail ||
                Voicemail != null &&
                Voicemail.Equals(other.Voicemail)
            ) &&
            (
                CallbackNumbers == other.CallbackNumbers ||
                CallbackNumbers != null &&
                CallbackNumbers.SequenceEqual(other.CallbackNumbers)
            ) &&
            (
                CallbackUserName == other.CallbackUserName ||
                CallbackUserName != null &&
                CallbackUserName.Equals(other.CallbackUserName)
            ) &&
            (
                SkipEnabled == other.SkipEnabled ||
                SkipEnabled != null &&
                SkipEnabled.Equals(other.SkipEnabled)
            ) &&
            (
                ExternalCampaign == other.ExternalCampaign ||
                ExternalCampaign != null &&
                ExternalCampaign.Equals(other.ExternalCampaign)
            ) &&
            (
                TimeoutSeconds == other.TimeoutSeconds ||
                TimeoutSeconds != null &&
                TimeoutSeconds.Equals(other.TimeoutSeconds)
            ) &&
            (
                CallbackScheduledTime == other.CallbackScheduledTime ||
                CallbackScheduledTime != null &&
                CallbackScheduledTime.Equals(other.CallbackScheduledTime)
            ) &&
            (
                AutomatedCallbackConfigId == other.AutomatedCallbackConfigId ||
                AutomatedCallbackConfigId != null &&
                AutomatedCallbackConfigId.Equals(other.AutomatedCallbackConfigId)
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

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (Purpose != null)
            {
                hash = hash * 59 + Purpose.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (InitialState != null)
            {
                hash = hash * 59 + InitialState.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (WrapupRequired != null)
            {
                hash = hash * 59 + WrapupRequired.GetHashCode();
            }

            if (WrapupPrompt != null)
            {
                hash = hash * 59 + WrapupPrompt.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Team != null)
            {
                hash = hash * 59 + Team.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (Script != null)
            {
                hash = hash * 59 + Script.GetHashCode();
            }

            if (WrapupTimeoutMs != null)
            {
                hash = hash * 59 + WrapupTimeoutMs.GetHashCode();
            }

            if (WrapupSkipped != null)
            {
                hash = hash * 59 + WrapupSkipped.GetHashCode();
            }

            if (AlertingTimeoutMs != null)
            {
                hash = hash * 59 + AlertingTimeoutMs.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (ExternalContactInitialDivisionId != null)
            {
                hash = hash * 59 + ExternalContactInitialDivisionId.GetHashCode();
            }

            if (ExternalOrganization != null)
            {
                hash = hash * 59 + ExternalOrganization.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (ConversationRoutingData != null)
            {
                hash = hash * 59 + ConversationRoutingData.GetHashCode();
            }

            if (Peer != null)
            {
                hash = hash * 59 + Peer.GetHashCode();
            }

            if (ScreenRecordingState != null)
            {
                hash = hash * 59 + ScreenRecordingState.GetHashCode();
            }

            if (FlaggedReason != null)
            {
                hash = hash * 59 + FlaggedReason.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
            }

            if (StartAcwTime != null)
            {
                hash = hash * 59 + StartAcwTime.GetHashCode();
            }

            if (EndAcwTime != null)
            {
                hash = hash * 59 + EndAcwTime.GetHashCode();
            }

            if (ResumeTime != null)
            {
                hash = hash * 59 + ResumeTime.GetHashCode();
            }

            if (ParkTime != null)
            {
                hash = hash * 59 + ParkTime.GetHashCode();
            }

            if (MediaRoles != null)
            {
                hash = hash * 59 + MediaRoles.GetHashCode();
            }

            if (QueueMediaSettings != null)
            {
                hash = hash * 59 + QueueMediaSettings.GetHashCode();
            }

            if (OutboundPreview != null)
            {
                hash = hash * 59 + OutboundPreview.GetHashCode();
            }

            if (Voicemail != null)
            {
                hash = hash * 59 + Voicemail.GetHashCode();
            }

            if (CallbackNumbers != null)
            {
                hash = hash * 59 + CallbackNumbers.GetHashCode();
            }

            if (CallbackUserName != null)
            {
                hash = hash * 59 + CallbackUserName.GetHashCode();
            }

            if (SkipEnabled != null)
            {
                hash = hash * 59 + SkipEnabled.GetHashCode();
            }

            if (ExternalCampaign != null)
            {
                hash = hash * 59 + ExternalCampaign.GetHashCode();
            }

            if (TimeoutSeconds != null)
            {
                hash = hash * 59 + TimeoutSeconds.GetHashCode();
            }

            if (CallbackScheduledTime != null)
            {
                hash = hash * 59 + CallbackScheduledTime.GetHashCode();
            }

            if (AutomatedCallbackConfigId != null)
            {
                hash = hash * 59 + AutomatedCallbackConfigId.GetHashCode();
            }

            return hash;
        }
    }
}
