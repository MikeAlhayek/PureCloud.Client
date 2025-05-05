using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Message
/// </summary>

public partial class Message : IEquatable<Message>
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    
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
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected
    }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    
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
        /// Enum Connected for "connected"
        /// </summary>
        [EnumMember(Value = "connected")]
        Connected,

        /// <summary>
        /// Enum Disconnected for "disconnected"
        /// </summary>
        [EnumMember(Value = "disconnected")]
        Disconnected
    }
    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    
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
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    
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
    /// Indicates the type of message platform from which the message originated.
    /// </summary>
    /// <value>Indicates the type of message platform from which the message originated.</value>
    
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
        /// Enum Apple for "apple"
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple,

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
        /// Enum Kakao for "kakao"
        /// </summary>
        [EnumMember(Value = "kakao")]
        Kakao,

        /// <summary>
        /// Enum Line for "line"
        /// </summary>
        [EnumMember(Value = "line")]
        Line,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Telegram for "telegram"
        /// </summary>
        [EnumMember(Value = "telegram")]
        Telegram,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Enum Webmessaging for "webmessaging"
        /// </summary>
        [EnumMember(Value = "webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown
    }
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    [JsonPropertyName("initialState")]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// The direction of the message.
    /// </summary>
    /// <value>The direction of the message.</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Indicates the type of message platform from which the message originated.
    /// </summary>
    /// <value>Indicates the type of message platform from which the message originated.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Message" /> class.
    /// </summary>
    /// <param name="State">The connection state of this communication..</param>
    /// <param name="InitialState">The initial connection state of this communication..</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="Segments">The time line of the participant&#39;s message, divided into activity segments..</param>
    /// <param name="Direction">The direction of the message..</param>
    /// <param name="RecordingId">A globally unique identifier for the recording associated with this message..</param>
    /// <param name="ErrorInfo">ErrorInfo.</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Provider">The source provider for the message..</param>
    /// <param name="Authenticated">If true, the participant member is authenticated..</param>
    /// <param name="Type">Indicates the type of message platform from which the message originated..</param>
    /// <param name="RecipientCountry">Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format..</param>
    /// <param name="RecipientType">The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="ToAddress">Address and name data for a call endpoint..</param>
    /// <param name="FromAddress">Address and name data for a call endpoint..</param>
    /// <param name="Messages">The messages sent on this communication channel..</param>
    /// <param name="JourneyContext">A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context)..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">After-call work for the communication..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="AgentAssistantId">UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation..</param>
    /// <param name="ByoSmsIntegrationId">The internal id representing the customer supplied sms integration message..</param>
    /// <param name="QueueMediaSettings">Represents the queue settings for this media type..</param>
    public Message(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, bool? Held = null, List<Segment> Segments = null, DirectionEnum? Direction = null, string RecordingId = null, ErrorBody ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string Provider = null, bool? Authenticated = null, TypeEnum? Type = null, string RecipientCountry = null, string RecipientType = null, string ScriptId = null, string PeerId = null, Address ToAddress = null, Address FromAddress = null, List<MessageDetails> Messages = null, JourneyContext JourneyContext = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string AgentAssistantId = null, string ByoSmsIntegrationId = null, ConversationQueueMediaSettings QueueMediaSettings = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.Held = Held;
        this.Segments = Segments;
        this.Direction = Direction;
        this.RecordingId = RecordingId;
        this.ErrorInfo = ErrorInfo;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.StartAlertingTime = StartAlertingTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.Provider = Provider;
        this.Authenticated = Authenticated;
        this.Type = Type;
        this.RecipientCountry = RecipientCountry;
        this.RecipientType = RecipientType;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.ToAddress = ToAddress;
        this.FromAddress = FromAddress;
        this.Messages = Messages;
        this.JourneyContext = JourneyContext;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.AgentAssistantId = AgentAssistantId;
        this.ByoSmsIntegrationId = ByoSmsIntegrationId;
        this.QueueMediaSettings = QueueMediaSettings;

    }







    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }



    /// <summary>
    /// The time line of the participant&#39;s message, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s message, divided into activity segments.</value>
    [JsonPropertyName("segments")]
    public List<Segment> Segments { get; set; }





    /// <summary>
    /// A globally unique identifier for the recording associated with this message.
    /// </summary>
    /// <value>A globally unique identifier for the recording associated with this message.</value>
    [JsonPropertyName("recordingId")]
    public string RecordingId { get; set; }



    /// <summary>
    /// Gets or Sets ErrorInfo
    /// </summary>
    [JsonPropertyName("errorInfo")]
    public ErrorBody ErrorInfo { get; set; }





    /// <summary>
    /// The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the message was placed on hold in the cloud clock if the message is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startAlertingTime")]
    public DateTime? StartAlertingTime { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("disconnectedTime")]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// The source provider for the message.
    /// </summary>
    /// <value>The source provider for the message.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// If true, the participant member is authenticated.
    /// </summary>
    /// <value>If true, the participant member is authenticated.</value>
    [JsonPropertyName("authenticated")]
    public bool? Authenticated { get; set; }





    /// <summary>
    /// Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.
    /// </summary>
    /// <value>Indicates the country where the recipient is associated in ISO 3166-1 alpha-2 format.</value>
    [JsonPropertyName("recipientCountry")]
    public string RecipientCountry { get; set; }



    /// <summary>
    /// The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.
    /// </summary>
    /// <value>The type of the recipient. Eg: Provisioned phoneNumber is the recipient for sms message type.</value>
    [JsonPropertyName("recipientType")]
    public string RecipientType { get; set; }



    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    [JsonPropertyName("scriptId")]
    public string ScriptId { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [JsonPropertyName("peerId")]
    public string PeerId { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("toAddress")]
    public Address ToAddress { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [JsonPropertyName("fromAddress")]
    public Address FromAddress { get; set; }



    /// <summary>
    /// The messages sent on this communication channel.
    /// </summary>
    /// <value>The messages sent on this communication channel.</value>
    [JsonPropertyName("messages")]
    public List<MessageDetails> Messages { get; set; }



    /// <summary>
    /// A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).
    /// </summary>
    /// <value>A subset of the Journey System&#39;s data relevant to a part of a conversation (for external linkage and internal usage/context).</value>
    [JsonPropertyName("journeyContext")]
    public JourneyContext JourneyContext { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [JsonPropertyName("wrapup")]
    public Wrapup Wrapup { get; set; }



    /// <summary>
    /// After-call work for the communication.
    /// </summary>
    /// <value>After-call work for the communication.</value>
    [JsonPropertyName("afterCallWork")]
    public AfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.
    /// </summary>
    /// <value>UUID of virtual agent assistant that provide suggestions to the agent participant during the conversation.</value>
    [JsonPropertyName("agentAssistantId")]
    public string AgentAssistantId { get; set; }



    /// <summary>
    /// The internal id representing the customer supplied sms integration message.
    /// </summary>
    /// <value>The internal id representing the customer supplied sms integration message.</value>
    [JsonPropertyName("byoSmsIntegrationId")]
    public string ByoSmsIntegrationId { get; set; }



    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    [JsonPropertyName("queueMediaSettings")]
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Message {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  Segments: ").Append(Segments).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
        sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  Authenticated: ").Append(Authenticated).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  RecipientCountry: ").Append(RecipientCountry).Append("\n");
        sb.Append("  RecipientType: ").Append(RecipientType).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
        sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
        sb.Append("  Messages: ").Append(Messages).Append("\n");
        sb.Append("  JourneyContext: ").Append(JourneyContext).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  AgentAssistantId: ").Append(AgentAssistantId).Append("\n");
        sb.Append("  ByoSmsIntegrationId: ").Append(ByoSmsIntegrationId).Append("\n");
        sb.Append("  QueueMediaSettings: ").Append(QueueMediaSettings).Append("\n");
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
        return Equals(obj as Message);
    }

    /// <summary>
    /// Returns true if Message instances are equal
    /// </summary>
    /// <param name="other">Instance of Message to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Message other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                Segments == other.Segments ||
                Segments != null &&
                Segments.SequenceEqual(other.Segments)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                RecordingId == other.RecordingId ||
                RecordingId != null &&
                RecordingId.Equals(other.RecordingId)
            ) &&
            (
                ErrorInfo == other.ErrorInfo ||
                ErrorInfo != null &&
                ErrorInfo.Equals(other.ErrorInfo)
            ) &&
            (
                DisconnectType == other.DisconnectType ||
                DisconnectType != null &&
                DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                StartHoldTime == other.StartHoldTime ||
                StartHoldTime != null &&
                StartHoldTime.Equals(other.StartHoldTime)
            ) &&
            (
                StartAlertingTime == other.StartAlertingTime ||
                StartAlertingTime != null &&
                StartAlertingTime.Equals(other.StartAlertingTime)
            ) &&
            (
                ConnectedTime == other.ConnectedTime ||
                ConnectedTime != null &&
                ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                DisconnectedTime == other.DisconnectedTime ||
                DisconnectedTime != null &&
                DisconnectedTime.Equals(other.DisconnectedTime)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                Authenticated == other.Authenticated ||
                Authenticated != null &&
                Authenticated.Equals(other.Authenticated)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                RecipientCountry == other.RecipientCountry ||
                RecipientCountry != null &&
                RecipientCountry.Equals(other.RecipientCountry)
            ) &&
            (
                RecipientType == other.RecipientType ||
                RecipientType != null &&
                RecipientType.Equals(other.RecipientType)
            ) &&
            (
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
            ) &&
            (
                ToAddress == other.ToAddress ||
                ToAddress != null &&
                ToAddress.Equals(other.ToAddress)
            ) &&
            (
                FromAddress == other.FromAddress ||
                FromAddress != null &&
                FromAddress.Equals(other.FromAddress)
            ) &&
            (
                Messages == other.Messages ||
                Messages != null &&
                Messages.SequenceEqual(other.Messages)
            ) &&
            (
                JourneyContext == other.JourneyContext ||
                JourneyContext != null &&
                JourneyContext.Equals(other.JourneyContext)
            ) &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                AfterCallWork == other.AfterCallWork ||
                AfterCallWork != null &&
                AfterCallWork.Equals(other.AfterCallWork)
            ) &&
            (
                AfterCallWorkRequired == other.AfterCallWorkRequired ||
                AfterCallWorkRequired != null &&
                AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
            ) &&
            (
                AgentAssistantId == other.AgentAssistantId ||
                AgentAssistantId != null &&
                AgentAssistantId.Equals(other.AgentAssistantId)
            ) &&
            (
                ByoSmsIntegrationId == other.ByoSmsIntegrationId ||
                ByoSmsIntegrationId != null &&
                ByoSmsIntegrationId.Equals(other.ByoSmsIntegrationId)
            ) &&
            (
                QueueMediaSettings == other.QueueMediaSettings ||
                QueueMediaSettings != null &&
                QueueMediaSettings.Equals(other.QueueMediaSettings)
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
            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (InitialState != null)
            {
                hash = hash * 59 + InitialState.GetHashCode();
            }

            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (RecordingId != null)
            {
                hash = hash * 59 + RecordingId.GetHashCode();
            }

            if (ErrorInfo != null)
            {
                hash = hash * 59 + ErrorInfo.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (StartAlertingTime != null)
            {
                hash = hash * 59 + StartAlertingTime.GetHashCode();
            }

            if (ConnectedTime != null)
            {
                hash = hash * 59 + ConnectedTime.GetHashCode();
            }

            if (DisconnectedTime != null)
            {
                hash = hash * 59 + DisconnectedTime.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (Authenticated != null)
            {
                hash = hash * 59 + Authenticated.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (RecipientCountry != null)
            {
                hash = hash * 59 + RecipientCountry.GetHashCode();
            }

            if (RecipientType != null)
            {
                hash = hash * 59 + RecipientType.GetHashCode();
            }

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (ToAddress != null)
            {
                hash = hash * 59 + ToAddress.GetHashCode();
            }

            if (FromAddress != null)
            {
                hash = hash * 59 + FromAddress.GetHashCode();
            }

            if (Messages != null)
            {
                hash = hash * 59 + Messages.GetHashCode();
            }

            if (JourneyContext != null)
            {
                hash = hash * 59 + JourneyContext.GetHashCode();
            }

            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (AfterCallWork != null)
            {
                hash = hash * 59 + AfterCallWork.GetHashCode();
            }

            if (AfterCallWorkRequired != null)
            {
                hash = hash * 59 + AfterCallWorkRequired.GetHashCode();
            }

            if (AgentAssistantId != null)
            {
                hash = hash * 59 + AgentAssistantId.GetHashCode();
            }

            if (ByoSmsIntegrationId != null)
            {
                hash = hash * 59 + ByoSmsIntegrationId.GetHashCode();
            }

            if (QueueMediaSettings != null)
            {
                hash = hash * 59 + QueueMediaSettings.GetHashCode();
            }

            return hash;
        }
    }
}
