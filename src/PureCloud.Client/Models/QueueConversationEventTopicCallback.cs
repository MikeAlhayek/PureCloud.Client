using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationEventTopicCallback
/// </summary>

public partial class QueueConversationEventTopicCallback : IEquatable<QueueConversationEventTopicCallback>
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
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

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
        /// Enum Scheduled for "scheduled"
        /// </summary>
        [EnumMember(Value = "scheduled")]
        Scheduled,

        /// <summary>
        /// Enum Uploading for "uploading"
        /// </summary>
        [EnumMember(Value = "uploading")]
        Uploading,

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
    /// The direction of the call
    /// </summary>
    /// <value>The direction of the call</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [JsonPropertyName("disconnectType")]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicCallback" /> class.
    /// </summary>
    /// <param name="State">State.</param>
    /// <param name="InitialState">InitialState.</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Direction">The direction of the call.</param>
    /// <param name="Held">True if this call is held and the person on this side hears silence..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartHoldTime">The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold..</param>
    /// <param name="DialerPreview">DialerPreview.</param>
    /// <param name="Voicemail">Voicemail.</param>
    /// <param name="CallbackNumbers">The phone number(s) to use to place the callback..</param>
    /// <param name="CallbackUserName">The name of the user requesting a callback..</param>
    /// <param name="ScriptId">The UUID of the script to use..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="ExternalCampaign">True if the call for the callback uses external dialing..</param>
    /// <param name="SkipEnabled">True if the ability to skip a callback should be enabled..</param>
    /// <param name="Provider">The source provider of the callback..</param>
    /// <param name="TimeoutSeconds">The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled..</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock..</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock..</param>
    /// <param name="CallbackScheduledTime">The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately..</param>
    /// <param name="AutomatedCallbackConfigId">The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">A communication&#39;s after-call work data..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    /// <param name="CallerId">The phone number displayed to recipients of the phone call. The value should conform to the E164 format..</param>
    /// <param name="CallerIdName">The name displayed to recipients of the phone call..</param>
    /// <param name="QueueMediaSettings">Represents the queue setting for this media..</param>
    public QueueConversationEventTopicCallback(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, DirectionEnum? Direction = null, bool? Held = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, QueueConversationEventTopicDialerPreview DialerPreview = null, QueueConversationEventTopicVoicemail Voicemail = null, List<string> CallbackNumbers = null, string CallbackUserName = null, string ScriptId = null, string PeerId = null, bool? ExternalCampaign = null, bool? SkipEnabled = null, string Provider = null, long? TimeoutSeconds = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, DateTime? CallbackScheduledTime = null, string AutomatedCallbackConfigId = null, QueueConversationEventTopicWrapup Wrapup = null, QueueConversationEventTopicAfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null, string CallerId = null, string CallerIdName = null, QueueConversationEventTopicQueueMediaSettings QueueMediaSettings = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.Direction = Direction;
        this.Held = Held;
        this.DisconnectType = DisconnectType;
        this.StartHoldTime = StartHoldTime;
        this.DialerPreview = DialerPreview;
        this.Voicemail = Voicemail;
        this.CallbackNumbers = CallbackNumbers;
        this.CallbackUserName = CallbackUserName;
        this.ScriptId = ScriptId;
        this.PeerId = PeerId;
        this.ExternalCampaign = ExternalCampaign;
        this.SkipEnabled = SkipEnabled;
        this.Provider = Provider;
        this.TimeoutSeconds = TimeoutSeconds;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.CallbackScheduledTime = CallbackScheduledTime;
        this.AutomatedCallbackConfigId = AutomatedCallbackConfigId;
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
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// True if this call is held and the person on this side hears silence.
    /// </summary>
    /// <value>True if this call is held and the person on this side hears silence.</value>
    [JsonPropertyName("held")]
    public bool? Held { get; set; }





    /// <summary>
    /// The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold.
    /// </summary>
    /// <value>The timestamp the callback was placed on hold in the cloud clock if the callback is currently on hold.</value>
    [JsonPropertyName("startHoldTime")]
    public DateTime? StartHoldTime { get; set; }



    /// <summary>
    /// Gets or Sets DialerPreview
    /// </summary>
    [JsonPropertyName("dialerPreview")]
    public QueueConversationEventTopicDialerPreview DialerPreview { get; set; }



    /// <summary>
    /// Gets or Sets Voicemail
    /// </summary>
    [JsonPropertyName("voicemail")]
    public QueueConversationEventTopicVoicemail Voicemail { get; set; }



    /// <summary>
    /// The phone number(s) to use to place the callback.
    /// </summary>
    /// <value>The phone number(s) to use to place the callback.</value>
    [JsonPropertyName("callbackNumbers")]
    public List<string> CallbackNumbers { get; set; }



    /// <summary>
    /// The name of the user requesting a callback.
    /// </summary>
    /// <value>The name of the user requesting a callback.</value>
    [JsonPropertyName("callbackUserName")]
    public string CallbackUserName { get; set; }



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
    /// True if the call for the callback uses external dialing.
    /// </summary>
    /// <value>True if the call for the callback uses external dialing.</value>
    [JsonPropertyName("externalCampaign")]
    public bool? ExternalCampaign { get; set; }



    /// <summary>
    /// True if the ability to skip a callback should be enabled.
    /// </summary>
    /// <value>True if the ability to skip a callback should be enabled.</value>
    [JsonPropertyName("skipEnabled")]
    public bool? SkipEnabled { get; set; }



    /// <summary>
    /// The source provider of the callback.
    /// </summary>
    /// <value>The source provider of the callback.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.
    /// </summary>
    /// <value>The number of seconds before the system automatically places a call for a callback.  0 means the automatic placement is disabled.</value>
    [JsonPropertyName("timeoutSeconds")]
    public long? TimeoutSeconds { get; set; }



    /// <summary>
    /// The timestamp when this communication was connected in the cloud clock.
    /// </summary>
    /// <value>The timestamp when this communication was connected in the cloud clock.</value>
    [JsonPropertyName("connectedTime")]
    public DateTime? ConnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication disconnected from the conversation in the provider clock.
    /// </summary>
    /// <value>The timestamp when this communication disconnected from the conversation in the provider clock.</value>
    [JsonPropertyName("disconnectedTime")]
    public DateTime? DisconnectedTime { get; set; }



    /// <summary>
    /// The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately.
    /// </summary>
    /// <value>The timestamp when this communication is scheduled in the provider clock. If this value is missing it indicates the callback will be placed immediately.</value>
    [JsonPropertyName("callbackScheduledTime")]
    public DateTime? CallbackScheduledTime { get; set; }



    /// <summary>
    /// The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.
    /// </summary>
    /// <value>The id of the config for automatically placing the callback (and handling the disposition). If null, the callback will not be placed automatically but routed to an agent as per normal.</value>
    [JsonPropertyName("automatedCallbackConfigId")]
    public string AutomatedCallbackConfigId { get; set; }



    /// <summary>
    /// Call wrap up or disposition data.
    /// </summary>
    /// <value>Call wrap up or disposition data.</value>
    [JsonPropertyName("wrapup")]
    public QueueConversationEventTopicWrapup Wrapup { get; set; }



    /// <summary>
    /// A communication&#39;s after-call work data.
    /// </summary>
    /// <value>A communication&#39;s after-call work data.</value>
    [JsonPropertyName("afterCallWork")]
    public QueueConversationEventTopicAfterCallWork AfterCallWork { get; set; }



    /// <summary>
    /// Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.
    /// </summary>
    /// <value>Indicates if after-call is required for a communication. Only used when the ACW Setting is Agent Requested.</value>
    [JsonPropertyName("afterCallWorkRequired")]
    public bool? AfterCallWorkRequired { get; set; }



    /// <summary>
    /// The phone number displayed to recipients of the phone call. The value should conform to the E164 format.
    /// </summary>
    /// <value>The phone number displayed to recipients of the phone call. The value should conform to the E164 format.</value>
    [JsonPropertyName("callerId")]
    public string CallerId { get; set; }



    /// <summary>
    /// The name displayed to recipients of the phone call.
    /// </summary>
    /// <value>The name displayed to recipients of the phone call.</value>
    [JsonPropertyName("callerIdName")]
    public string CallerIdName { get; set; }



    /// <summary>
    /// Represents the queue setting for this media.
    /// </summary>
    /// <value>Represents the queue setting for this media.</value>
    [JsonPropertyName("queueMediaSettings")]
    public QueueConversationEventTopicQueueMediaSettings QueueMediaSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicCallback {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
        sb.Append("  DialerPreview: ").Append(DialerPreview).Append("\n");
        sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
        sb.Append("  CallbackNumbers: ").Append(CallbackNumbers).Append("\n");
        sb.Append("  CallbackUserName: ").Append(CallbackUserName).Append("\n");
        sb.Append("  ScriptId: ").Append(ScriptId).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  ExternalCampaign: ").Append(ExternalCampaign).Append("\n");
        sb.Append("  SkipEnabled: ").Append(SkipEnabled).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  TimeoutSeconds: ").Append(TimeoutSeconds).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  CallbackScheduledTime: ").Append(CallbackScheduledTime).Append("\n");
        sb.Append("  AutomatedCallbackConfigId: ").Append(AutomatedCallbackConfigId).Append("\n");
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
        return Equals(obj as QueueConversationEventTopicCallback);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicCallback instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicCallback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicCallback other)
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
                PeerId == other.PeerId ||
                PeerId != null &&
                PeerId.Equals(other.PeerId)
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
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                TimeoutSeconds == other.TimeoutSeconds ||
                TimeoutSeconds != null &&
                TimeoutSeconds.Equals(other.TimeoutSeconds)
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

            if (PeerId != null)
            {
                hash = hash * 59 + PeerId.GetHashCode();
            }

            if (ExternalCampaign != null)
            {
                hash = hash * 59 + ExternalCampaign.GetHashCode();
            }

            if (SkipEnabled != null)
            {
                hash = hash * 59 + SkipEnabled.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (TimeoutSeconds != null)
            {
                hash = hash * 59 + TimeoutSeconds.GetHashCode();
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
