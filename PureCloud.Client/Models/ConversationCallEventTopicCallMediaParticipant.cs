using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationCallEventTopicCallMediaParticipant
/// </summary>

public partial class ConversationCallEventTopicCallMediaParticipant : IEquatable<ConversationCallEventTopicCallMediaParticipant>
{
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    
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
    /// Gets or Sets RecordingState
    /// </summary>
    
    public enum RecordingStateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Paused for "paused"
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused
    }
    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Gets or Sets InitialState
    /// </summary>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// Gets or Sets Direction
    /// </summary>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Gets or Sets DisconnectType
    /// </summary>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Gets or Sets FlaggedReason
    /// </summary>
    [JsonPropertyName("flaggedReason")]
    public FlaggedReasonEnum? FlaggedReason { get; set; }
    /// <summary>
    /// Gets or Sets RecordingState
    /// </summary>
    [JsonPropertyName("recordingState")]
    public RecordingStateEnum? RecordingState { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationCallEventTopicCallMediaParticipant" /> class.
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
    /// <param name="Muted">Muted.</param>
    /// <param name="Confined">Confined.</param>
    /// <param name="Recording">Recording.</param>
    /// <param name="RecordingState">RecordingState.</param>
    /// <param name="SecurePause">SecurePause.</param>
    /// <param name="Group">Group.</param>
    /// <param name="Ani">Ani.</param>
    /// <param name="Dnis">Dnis.</param>
    /// <param name="DocumentId">DocumentId.</param>
    /// <param name="MonitoredParticipantId">MonitoredParticipantId.</param>
    /// <param name="CoachedParticipantId">CoachedParticipantId.</param>
    /// <param name="BargedParticipantId">BargedParticipantId.</param>
    /// <param name="BargedTime">BargedTime.</param>
    /// <param name="ConsultParticipantId">ConsultParticipantId.</param>
    /// <param name="FaxStatus">FaxStatus.</param>
    public ConversationCallEventTopicCallMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, InitialStateEnum? InitialState = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, ConversationCallEventTopicUriReference User = null, ConversationCallEventTopicUriReference Queue = null, ConversationCallEventTopicUriReference Team = null, Dictionary<string, string> Attributes = null, ConversationCallEventTopicErrorBody ErrorInfo = null, ConversationCallEventTopicUriReference Script = null, long? WrapupTimeoutMs = null, bool? WrapupSkipped = null, long? AlertingTimeoutMs = null, string Provider = null, ConversationCallEventTopicUriReference ExternalContact = null, string ExternalContactInitialDivisionId = null, ConversationCallEventTopicUriReference ExternalOrganization = null, ConversationCallEventTopicWrapup Wrapup = null, ConversationCallEventTopicConversationRoutingData ConversationRoutingData = null, string Peer = null, string ScreenRecordingState = null, FlaggedReasonEnum? FlaggedReason = null, ConversationCallEventTopicJourneyContext JourneyContext = null, DateTime? StartAcwTime = null, DateTime? EndAcwTime = null, DateTime? ResumeTime = null, DateTime? ParkTime = null, List<string> MediaRoles = null, ConversationCallEventTopicQueueMediaSettings QueueMediaSettings = null, bool? Muted = null, bool? Confined = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, bool? SecurePause = null, ConversationCallEventTopicUriReference Group = null, string Ani = null, string Dnis = null, string DocumentId = null, string MonitoredParticipantId = null, string CoachedParticipantId = null, string BargedParticipantId = null, DateTime? BargedTime = null, string ConsultParticipantId = null, ConversationCallEventTopicFaxStatus FaxStatus = null)
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
        this.Muted = Muted;
        this.Confined = Confined;
        this.Recording = Recording;
        this.RecordingState = RecordingState;
        this.SecurePause = SecurePause;
        this.Group = Group;
        this.Ani = Ani;
        this.Dnis = Dnis;
        this.DocumentId = DocumentId;
        this.MonitoredParticipantId = MonitoredParticipantId;
        this.CoachedParticipantId = CoachedParticipantId;
        this.BargedParticipantId = BargedParticipantId;
        this.BargedTime = BargedTime;
        this.ConsultParticipantId = ConsultParticipantId;
        this.FaxStatus = FaxStatus;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [JsonPropertyName("address")]
    public string Address { get; set; }



    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// Gets or Sets ConnectedTime
    /// </summary>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [JsonPropertyName("endTime")]
    public DateTime? EndTime { get; set; }



    /// <summary>
    /// Gets or Sets StartHoldTime
    /// </summary>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// Gets or Sets Purpose
    /// </summary>
    [JsonPropertyName("purpose")]
    public string Purpose { get; set; }











    /// <summary>
    /// Gets or Sets Held
    /// </summary>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// Gets or Sets WrapupRequired
    /// </summary>
    [JsonPropertyName("wrapupRequired")]
    public bool? WrapupRequired { get; set; }



    /// <summary>
    /// Gets or Sets WrapupPrompt
    /// </summary>
    [JsonPropertyName("wrapupPrompt")]
    public string WrapupPrompt { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public ConversationCallEventTopicUriReference User { get; set; }



    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [JsonPropertyName("queue")]
    public ConversationCallEventTopicUriReference Queue { get; set; }



    /// <summary>
    /// Gets or Sets Team
    /// </summary>
    [JsonPropertyName("team")]
    public ConversationCallEventTopicUriReference Team { get; set; }



    /// <summary>
    /// Gets or Sets Attributes
    /// </summary>
    [JsonPropertyName("attributes")]
    public Dictionary<string, string> Attributes { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public ConversationCallEventTopicErrorBody ErrorInfo { get; set; }



    /// <summary>
    /// Gets or Sets Script
    /// </summary>
    [JsonPropertyName("script")]
    public ConversationCallEventTopicUriReference Script { get; set; }



    /// <summary>
    /// Gets or Sets WrapupTimeoutMs
    /// </summary>
    [JsonPropertyName("wrapupTimeoutMs")]
    public long? WrapupTimeoutMs { get; set; }



    /// <summary>
    /// Gets or Sets WrapupSkipped
    /// </summary>
    [JsonPropertyName("wrapupSkipped")]
    public bool? WrapupSkipped { get; set; }



    /// <summary>
    /// Gets or Sets AlertingTimeoutMs
    /// </summary>
    [JsonPropertyName("alertingTimeoutMs")]
    public long? AlertingTimeoutMs { get; set; }



    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContact
    /// </summary>
    [JsonPropertyName("externalContact")]
    public ConversationCallEventTopicUriReference ExternalContact { get; set; }



    /// <summary>
    /// Gets or Sets ExternalContactInitialDivisionId
    /// </summary>
    [JsonPropertyName("externalContactInitialDivisionId")]
    public string ExternalContactInitialDivisionId { get; set; }



    /// <summary>
    /// Gets or Sets ExternalOrganization
    /// </summary>
    [JsonPropertyName("externalOrganization")]
    public ConversationCallEventTopicUriReference ExternalOrganization { get; set; }



    /// <summary>
    /// Gets or Sets Wrapup
    /// </summary>
    [JsonPropertyName("wrapup")]
    public ConversationCallEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// Gets or Sets ConversationRoutingData
    /// </summary>
    [JsonPropertyName("conversationRoutingData")]
    public ConversationCallEventTopicConversationRoutingData ConversationRoutingData { get; set; }



    /// <summary>
    /// Gets or Sets Peer
    /// </summary>
    [JsonPropertyName("peer")]
    public string Peer { get; set; }



    /// <summary>
    /// Gets or Sets ScreenRecordingState
    /// </summary>
    [JsonPropertyName("screenRecordingState")]
    public string ScreenRecordingState { get; set; }





    /// <summary>
    /// Gets or Sets JourneyContext
    /// </summary>
    [JsonPropertyName("journeyContext")]
    public ConversationCallEventTopicJourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Gets or Sets StartAcwTime
    /// </summary>
    [JsonPropertyName("startAcwTime")]
    public DateTime? StartAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets EndAcwTime
    /// </summary>
    [JsonPropertyName("endAcwTime")]
    public DateTime? EndAcwTime { get; set; }



    /// <summary>
    /// Gets or Sets ResumeTime
    /// </summary>
    [JsonPropertyName("resumeTime")]
    public DateTime? ResumeTime { get; set; }



    /// <summary>
    /// Gets or Sets ParkTime
    /// </summary>
    [JsonPropertyName("parkTime")]
    public DateTime? ParkTime { get; set; }



    /// <summary>
    /// Gets or Sets MediaRoles
    /// </summary>
    [JsonPropertyName("mediaRoles")]
    public List<string> MediaRoles { get; set; }



    /// <summary>
    /// Gets or Sets QueueMediaSettings
    /// </summary>
    [JsonPropertyName("queueMediaSettings")]
    public ConversationCallEventTopicQueueMediaSettings QueueMediaSettings { get; set; }



    /// <summary>
    /// Gets or Sets Muted
    /// </summary>
    [JsonPropertyName("muted")]
    public bool? Muted { get; set; }



    /// <summary>
    /// Gets or Sets Confined
    /// </summary>
    [JsonPropertyName("confined")]
    public bool? Confined { get; set; }



    /// <summary>
    /// Gets or Sets Recording
    /// </summary>
    [JsonPropertyName("recording")]
    public bool? Recording { get; set; }





    /// <summary>
    /// Gets or Sets SecurePause
    /// </summary>
    [JsonPropertyName("securePause")]
    public bool? SecurePause { get; set; }



    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [JsonPropertyName("group")]
    public ConversationCallEventTopicUriReference Group { get; set; }



    /// <summary>
    /// Gets or Sets Ani
    /// </summary>
    [JsonPropertyName("ani")]
    public string Ani { get; set; }



    /// <summary>
    /// Gets or Sets Dnis
    /// </summary>
    [JsonPropertyName("dnis")]
    public string Dnis { get; set; }



    /// <summary>
    /// Gets or Sets DocumentId
    /// </summary>
    [JsonPropertyName("documentId")]
    public string DocumentId { get; set; }



    /// <summary>
    /// Gets or Sets MonitoredParticipantId
    /// </summary>
    [JsonPropertyName("monitoredParticipantId")]
    public string MonitoredParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets CoachedParticipantId
    /// </summary>
    [JsonPropertyName("coachedParticipantId")]
    public string CoachedParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets BargedParticipantId
    /// </summary>
    [JsonPropertyName("bargedParticipantId")]
    public string BargedParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets BargedTime
    /// </summary>
    [JsonPropertyName("bargedTime")]
    public DateTime? BargedTime { get; set; }



    /// <summary>
    /// Gets or Sets ConsultParticipantId
    /// </summary>
    [JsonPropertyName("consultParticipantId")]
    public string ConsultParticipantId { get; set; }



    /// <summary>
    /// Gets or Sets FaxStatus
    /// </summary>
    [JsonPropertyName("faxStatus")]
    public ConversationCallEventTopicFaxStatus FaxStatus { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationCallEventTopicCallMediaParticipant {\n");

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
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Confined: ").Append(Confined).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
        sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
        sb.Append("  SecurePause: ").Append(SecurePause).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Ani: ").Append(Ani).Append("\n");
        sb.Append("  Dnis: ").Append(Dnis).Append("\n");
        sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
        sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
        sb.Append("  CoachedParticipantId: ").Append(CoachedParticipantId).Append("\n");
        sb.Append("  BargedParticipantId: ").Append(BargedParticipantId).Append("\n");
        sb.Append("  BargedTime: ").Append(BargedTime).Append("\n");
        sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
        sb.Append("  FaxStatus: ").Append(FaxStatus).Append("\n");
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
        return Equals(obj as ConversationCallEventTopicCallMediaParticipant);
    }

    /// <summary>
    /// Returns true if ConversationCallEventTopicCallMediaParticipant instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationCallEventTopicCallMediaParticipant to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationCallEventTopicCallMediaParticipant other)
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
                Muted == other.Muted ||
                Muted != null &&
                Muted.Equals(other.Muted)
            ) &&
            (
                Confined == other.Confined ||
                Confined != null &&
                Confined.Equals(other.Confined)
            ) &&
            (
                Recording == other.Recording ||
                Recording != null &&
                Recording.Equals(other.Recording)
            ) &&
            (
                RecordingState == other.RecordingState ||
                RecordingState != null &&
                RecordingState.Equals(other.RecordingState)
            ) &&
            (
                SecurePause == other.SecurePause ||
                SecurePause != null &&
                SecurePause.Equals(other.SecurePause)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                Ani == other.Ani ||
                Ani != null &&
                Ani.Equals(other.Ani)
            ) &&
            (
                Dnis == other.Dnis ||
                Dnis != null &&
                Dnis.Equals(other.Dnis)
            ) &&
            (
                DocumentId == other.DocumentId ||
                DocumentId != null &&
                DocumentId.Equals(other.DocumentId)
            ) &&
            (
                MonitoredParticipantId == other.MonitoredParticipantId ||
                MonitoredParticipantId != null &&
                MonitoredParticipantId.Equals(other.MonitoredParticipantId)
            ) &&
            (
                CoachedParticipantId == other.CoachedParticipantId ||
                CoachedParticipantId != null &&
                CoachedParticipantId.Equals(other.CoachedParticipantId)
            ) &&
            (
                BargedParticipantId == other.BargedParticipantId ||
                BargedParticipantId != null &&
                BargedParticipantId.Equals(other.BargedParticipantId)
            ) &&
            (
                BargedTime == other.BargedTime ||
                BargedTime != null &&
                BargedTime.Equals(other.BargedTime)
            ) &&
            (
                ConsultParticipantId == other.ConsultParticipantId ||
                ConsultParticipantId != null &&
                ConsultParticipantId.Equals(other.ConsultParticipantId)
            ) &&
            (
                FaxStatus == other.FaxStatus ||
                FaxStatus != null &&
                FaxStatus.Equals(other.FaxStatus)
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

            if (Muted != null)
            {
                hash = hash * 59 + Muted.GetHashCode();
            }

            if (Confined != null)
            {
                hash = hash * 59 + Confined.GetHashCode();
            }

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            if (RecordingState != null)
            {
                hash = hash * 59 + RecordingState.GetHashCode();
            }

            if (SecurePause != null)
            {
                hash = hash * 59 + SecurePause.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Ani != null)
            {
                hash = hash * 59 + Ani.GetHashCode();
            }

            if (Dnis != null)
            {
                hash = hash * 59 + Dnis.GetHashCode();
            }

            if (DocumentId != null)
            {
                hash = hash * 59 + DocumentId.GetHashCode();
            }

            if (MonitoredParticipantId != null)
            {
                hash = hash * 59 + MonitoredParticipantId.GetHashCode();
            }

            if (CoachedParticipantId != null)
            {
                hash = hash * 59 + CoachedParticipantId.GetHashCode();
            }

            if (BargedParticipantId != null)
            {
                hash = hash * 59 + BargedParticipantId.GetHashCode();
            }

            if (BargedTime != null)
            {
                hash = hash * 59 + BargedTime.GetHashCode();
            }

            if (ConsultParticipantId != null)
            {
                hash = hash * 59 + ConsultParticipantId.GetHashCode();
            }

            if (FaxStatus != null)
            {
                hash = hash * 59 + FaxStatus.GetHashCode();
            }

            return hash;
        }
    }
}
