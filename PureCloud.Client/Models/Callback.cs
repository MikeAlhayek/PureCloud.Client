using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Callback
/// </summary>
[DataContract]
public partial class Callback : IEquatable<Callback>
{
    /// <summary>
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
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
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
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
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
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
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
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
    /// The connection state of this communication.
    /// </summary>
    /// <value>The connection state of this communication.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// The initial connection state of this communication.
    /// </summary>
    /// <value>The initial connection state of this communication.</value>
    [DataMember(Name = "initialState", EmitDefaultValue = false)]
    public InitialStateEnum? InitialState { get; set; }
    /// <summary>
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    [DataMember(Name = "direction", EmitDefaultValue = false)]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Callback" /> class.
    /// </summary>
    /// <param name="State">The connection state of this communication..</param>
    /// <param name="InitialState">The initial connection state of this communication..</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Segments">The time line of the participant&#39;s callback, divided into activity segments..</param>
    /// <param name="Direction">The direction of the call.</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DialerPreview">The preview data to be used when this callback is a Preview..</param>
    /// <param name="Voicemail">The voicemail data to be used when this callback is an ACD voicemail..</param>
    /// <param name="CallbackNumbers">The phone number(s) to use to place the callback..</param>
    /// <param name="CallbackUserName">The name of the user requesting a callback..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="ExternalCampaign">True if the call for the callback uses external dialing..</param>
    /// <param name="SkipEnabled">True if the ability to skip a callback should be enabled..</param>
    /// <param name="TimeoutSeconds">The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled..</param>
    /// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CallbackScheduledTime">The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="AutomatedCallbackConfigId">The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal..</param>
    /// <param name="Provider">The source provider for the callback..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">After-call work for the communication..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="CallerId">The phone number displayed to recipients of the phone call. The value should conform to the E164 format..</param>
    /// <param name="CallerIdName">The name displayed to recipients of the phone call..</param>
    /// <param name="QueueMediaSettings">Represents the queue settings for this media type..</param>
    public Callback(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, List<Segment> Segments = null, DirectionEnum? Direction = null, bool? Held = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DialerPreview DialerPreview = null, Voicemail Voicemail = null, List<string> CallbackNumbers = null, string CallbackUserName = null, string ScriptId = null, bool? ExternalCampaign = null, bool? SkipEnabled = null, int? TimeoutSeconds = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, DateTime? CallbackScheduledTime = null, string AutomatedCallbackConfigId = null, string Provider = null, string PeerId = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string CallerId = null, string CallerIdName = null, ConversationQueueMediaSettings QueueMediaSettings = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.Segments = Segments;
        this.Direction = Direction;
        this.Held = Held;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.DialerPreview = DialerPreview;
        this.Voicemail = Voicemail;
        this.CallbackNumbers = CallbackNumbers;
        this.CallbackUserName = CallbackUserName;
        this.ScriptId = ScriptId;
        this.ExternalCampaign = ExternalCampaign;
        this.SkipEnabled = SkipEnabled;
        this.TimeoutSeconds = TimeoutSeconds;
        this.StartAlertingTime = StartAlertingTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.CallbackScheduledTime = CallbackScheduledTime;
        this.AutomatedCallbackConfigId = AutomatedCallbackConfigId;
        this.Provider = Provider;
        this.PeerId = PeerId;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;
        this.CallerId = CallerId;
        this.CallerIdName = CallerIdName;
        this.QueueMediaSettings = QueueMediaSettings;

    }







    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The time line of the participant&#39;s callback, divided into activity segments.
    /// </summary>
    /// <value>The time line of the participant&#39;s callback, divided into activity segments.</value>
    [DataMember(Name = "segments", EmitDefaultValue = false)]
    public List<Segment> Segments { get; set; }





    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [DataMember(Name = "held", EmitDefaultValue = false)]
    public bool? Held { get; set; }





    /// <summary>
    /// The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startHoldTime", EmitDefaultValue = false)]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// The preview data to be used when this callback is a Preview.
    /// </summary>
    /// <value>The preview data to be used when this callback is a Preview.</value>
    [DataMember(Name = "dialerPreview", EmitDefaultValue = false)]
    public DialerPreview DialerPreview { get; set; }



    /// <summary>
    /// The voicemail data to be used when this callback is an ACD voicemail.
    /// </summary>
    /// <value>The voicemail data to be used when this callback is an ACD voicemail.</value>
    [DataMember(Name = "voicemail", EmitDefaultValue = false)]
    public Voicemail Voicemail { get; set; }



    /// <summary>
    /// The phone number(s) to use to place the callback.
    /// </summary>
    /// <value>The phone number(s) to use to place the callback.</value>
    [DataMember(Name = "callbackNumbers", EmitDefaultValue = false)]
    public List<string> CallbackNumbers { get; set; }



    /// <summary>
    /// The name of the user requesting a callback.
    /// </summary>
    /// <value>The name of the user requesting a callback.</value>
    [DataMember(Name = "callbackUserName", EmitDefaultValue = false)]
    public string CallbackUserName { get; set; }



    /// <summary>
    /// The UUID of the script to use.
    /// </summary>
    /// <value>The UUID of the script to use.</value>
    [DataMember(Name = "scriptId", EmitDefaultValue = false)]
    public string ScriptId { get; set; }



    /// <summary>
    /// True if the call for the callback uses external dialing.
    /// </summary>
    /// <value>True if the call for the callback uses external dialing.</value>
    [DataMember(Name = "externalCampaign", EmitDefaultValue = false)]
    public bool? ExternalCampaign { get; set; }



    /// <summary>
    /// True if the ability to skip a callback should be enabled.
    /// </summary>
    /// <value>True if the ability to skip a callback should be enabled.</value>
    [DataMember(Name = "skipEnabled", EmitDefaultValue = false)]
    public bool? SkipEnabled { get; set; }



    /// <summary>
    /// The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.
    /// </summary>
    /// <value>The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.</value>
    [DataMember(Name = "timeoutSeconds", EmitDefaultValue = false)]
    public int? TimeoutSeconds { get; set; }



    /// <summary>
    /// The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "startAlertingTime", EmitDefaultValue = false)]
    public DateTime? StartAlertingTime { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "connectedTime", EmitDefaultValue = false)]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "disconnectedTime", EmitDefaultValue = false)]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "callbackScheduledTime", EmitDefaultValue = false)]
    public DateTime? CallbackScheduledTime { get; set; }



    /// <summary>
    /// The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.
    /// </summary>
    /// <value>The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.</value>
    [DataMember(Name = "automatedCallbackConfigId", EmitDefaultValue = false)]
    public string AutomatedCallbackConfigId { get; set; }



    /// <summary>
    /// The source provider for the callback.
    /// </summary>
    /// <value>The source provider for the callback.</value>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [DataMember(Name = "peerId", EmitDefaultValue = false)]
    public string PeerId { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public Wrapup Wrapup { get; set; }



    /// <summary>
    /// After-call work for the communication.
    /// </summary>
    /// <value>After-call work for the communication.</value>
    [DataMember(Name = "afterCallWork", EmitDefaultValue = false)]
    public AfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [DataMember(Name = "afterCallWorkRequired", EmitDefaultValue = false)]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// The phone number displayed to recipients of the phone call. The value should conform to the E164 format.
    /// </summary>
    /// <value>The phone number displayed to recipients of the phone call. The value should conform to the E164 format.</value>
    [DataMember(Name = "callerId", EmitDefaultValue = false)]
    public string CallerId { get; set; }



    /// <summary>
    /// The name displayed to recipients of the phone call.
    /// </summary>
    /// <value>The name displayed to recipients of the phone call.</value>
    [DataMember(Name = "callerIdName", EmitDefaultValue = false)]
    public string CallerIdName { get; set; }



    /// <summary>
    /// Represents the queue settings for this media type.
    /// </summary>
    /// <value>Represents the queue settings for this media type.</value>
    [DataMember(Name = "queueMediaSettings", EmitDefaultValue = false)]
    public ConversationQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Callback {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Segments: ").Append(Segments).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  DialerPreview: ").Append(DialerPreview).Append("\n");
        sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
        sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
        sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  ExternalCampaign: ").Append(ExternalCampaign).Append("\n");
        sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
        sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
        sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
        sb.Append("  AutomatedCallbackConfigId: ").Append(AutomatedCallbackConfigId).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
        sb.Append("  CallerId: ").Append(CallerId).Append("\n");
        sb.Append("  CallerIdName: ").Append(CallerIdName).Append("\n");
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
        return Equals(obj as Callback);
    }

    /// <summary>
    /// Returns true if Callback instances are equal
    /// </summary>
    /// <param name="other">Instance of Callback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Callback other)
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
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
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
                DialerPreview == other.DialerPreview ||
                DialerPreview != null &&
                DialerPreview.Equals(other.DialerPreview)
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
                ScriptId == other.ScriptId ||
                ScriptId != null &&
                ScriptId.Equals(other.ScriptId)
            ) &&
            (
                ExternalCampaign == other.ExternalCampaign ||
                ExternalCampaign != null &&
                ExternalCampaign.Equals(other.ExternalCampaign)
            ) &&
            (
                SkipEnabled == other.SkipEnabled ||
                SkipEnabled != null &&
                SkipEnabled.Equals(other.SkipEnabled)
            ) &&
            (
                TimeoutSeconds == other.TimeoutSeconds ||
                TimeoutSeconds != null &&
                TimeoutSeconds.Equals(other.TimeoutSeconds)
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
                CallbackScheduledTime == other.CallbackScheduledTime ||
                CallbackScheduledTime != null &&
                CallbackScheduledTime.Equals(other.CallbackScheduledTime)
            ) &&
            (
                AutomatedCallbackConfigId == other.AutomatedCallbackConfigId ||
                AutomatedCallbackConfigId != null &&
                AutomatedCallbackConfigId.Equals(other.AutomatedCallbackConfigId)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
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
                CallerId == other.CallerId ||
                CallerId != null &&
                CallerId.Equals(other.CallerId)
            ) &&
            (
                CallerIdName == other.CallerIdName ||
                CallerIdName != null &&
                CallerIdName.Equals(other.CallerIdName)
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

            if (Segments != null)
            {
                hash = hash * 59 + Segments.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (DisconnectType != null)
            {
                hash = hash * 59 + DisconnectType.GetHashCode();
            }

            if (StartHoldTime != null)
            {
                hash = hash * 59 + StartHoldTime.GetHashCode();
            }

            if (DialerPreview != null)
            {
                hash = hash * 59 + DialerPreview.GetHashCode();
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

            if (ScriptId != null)
            {
                hash = hash * 59 + ScriptId.GetHashCode();
            }

            if (ExternalCampaign != null)
            {
                hash = hash * 59 + ExternalCampaign.GetHashCode();
            }

            if (SkipEnabled != null)
            {
                hash = hash * 59 + SkipEnabled.GetHashCode();
            }

            if (TimeoutSeconds != null)
            {
                hash = hash * 59 + TimeoutSeconds.GetHashCode();
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

            if (CallbackScheduledTime != null)
            {
                hash = hash * 59 + CallbackScheduledTime.GetHashCode();
            }

            if (AutomatedCallbackConfigId != null)
            {
                hash = hash * 59 + AutomatedCallbackConfigId.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
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

            if (CallerId != null)
            {
                hash = hash * 59 + CallerId.GetHashCode();
            }

            if (CallerIdName != null)
            {
                hash = hash * 59 + CallerIdName.GetHashCode();
            }

            if (QueueMediaSettings != null)
            {
                hash = hash * 59 + QueueMediaSettings.GetHashCode();
            }

            return hash;
        }
    }
}
