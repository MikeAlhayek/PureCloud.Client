using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Video
/// </summary>
[DataContract]
public partial class Video : IEquatable<Video>
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
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
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
    /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
    /// </summary>
    /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
    [DataMember(Name = "disconnectType", EmitDefaultValue = false)]
    public DisconnectTypeEnum? DisconnectType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Video" /> class.
    /// </summary>
    /// <param name="State">The connection state of this communication..</param>
    /// <param name="InitialState">The initial connection state of this communication..</param>
    /// <param name="Id">A globally unique identifier for this communication..</param>
    /// <param name="Context">The room id context (xmpp jid) for the conference session..</param>
    /// <param name="AudioMuted">Indicates whether this participant has muted their outgoing audio..</param>
    /// <param name="VideoMuted">Indicates whether this participant has muted/paused their outgoing video..</param>
    /// <param name="SharingScreen">Indicates whether this participant is sharing their screen to the session..</param>
    /// <param name="PeerCount">The number of peer participants from the perspective of the participant in the conference..</param>
    /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
    /// <param name="StartAlertingTime">The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Provider">The source provider for the video..</param>
    /// <param name="PeerId">The id of the peer communication corresponding to a matching leg for this communication..</param>
    /// <param name="Msids">List of media stream ids.</param>
    /// <param name="Self">Address and name data for a call endpoint..</param>
    /// <param name="Wrapup">Call wrap up or disposition data..</param>
    /// <param name="AfterCallWork">After-call work for the communication..</param>
    /// <param name="AfterCallWorkRequired">Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested..</param>
    public Video(StateEnum? State = null, InitialStateEnum? InitialState = null, string Id = null, string Context = null, bool? AudioMuted = null, bool? VideoMuted = null, bool? SharingScreen = null, int? PeerCount = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartAlertingTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, string Provider = null, string PeerId = null, List<string> Msids = null, Address Self = null, Wrapup Wrapup = null, AfterCallWork AfterCallWork = null, bool? AfterCallWorkRequired = null)
    {
        this.State = State;
        this.InitialState = InitialState;
        this.Id = Id;
        this.Context = Context;
        this.AudioMuted = AudioMuted;
        this.VideoMuted = VideoMuted;
        this.SharingScreen = SharingScreen;
        this.PeerCount = PeerCount;
        this.DisconnectType = DisconnectType;
        this.StartAlertingTime = StartAlertingTime;
        this.ConnectedTime = ConnectedTime;
        this.DisconnectedTime = DisconnectedTime;
        this.Provider = Provider;
        this.PeerId = PeerId;
        this.Msids = Msids;
        this.Self = Self;
        this.Wrapup = Wrapup;
        this.AfterCallWork = AfterCallWork;
        this.AfterCallWorkRequired = AfterCallWorkRequired;

    }







    /// <summary>
    /// A globally unique identifier for this communication.
    /// </summary>
    /// <value>A globally unique identifier for this communication.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The room id context (xmpp jid) for the conference session.
    /// </summary>
    /// <value>The room id context (xmpp jid) for the conference session.</value>
    [DataMember(Name = "context", EmitDefaultValue = false)]
    public string Context { get; set; }



    /// <summary>
    /// Indicates whether this participant has muted their outgoing audio.
    /// </summary>
    /// <value>Indicates whether this participant has muted their outgoing audio.</value>
    [DataMember(Name = "audioMuted", EmitDefaultValue = false)]
    public bool? AudioMuted { get; set; }



    /// <summary>
    /// Indicates whether this participant has muted/paused their outgoing video.
    /// </summary>
    /// <value>Indicates whether this participant has muted/paused their outgoing video.</value>
    [DataMember(Name = "videoMuted", EmitDefaultValue = false)]
    public bool? VideoMuted { get; set; }



    /// <summary>
    /// Indicates whether this participant is sharing their screen to the session.
    /// </summary>
    /// <value>Indicates whether this participant is sharing their screen to the session.</value>
    [DataMember(Name = "sharingScreen", EmitDefaultValue = false)]
    public bool? SharingScreen { get; set; }



    /// <summary>
    /// The number of peer participants from the perspective of the participant in the conference.
    /// </summary>
    /// <value>The number of peer participants from the perspective of the participant in the conference.</value>
    [DataMember(Name = "peerCount", EmitDefaultValue = false)]
    public int? PeerCount { get; set; }





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
    /// The source provider for the video.
    /// </summary>
    /// <value>The source provider for the video.</value>
    [DataMember(Name = "provider", EmitDefaultValue = false)]
    public string Provider { get; set; }



    /// <summary>
    /// The id of the peer communication corresponding to a matching leg for this communication.
    /// </summary>
    /// <value>The id of the peer communication corresponding to a matching leg for this communication.</value>
    [DataMember(Name = "peerId", EmitDefaultValue = false)]
    public string PeerId { get; set; }



    /// <summary>
    /// List of media stream ids
    /// </summary>
    /// <value>List of media stream ids</value>
    [DataMember(Name = "msids", EmitDefaultValue = false)]
    public List<string> Msids { get; set; }



    /// <summary>
    /// Address and name data for a call endpoint.
    /// </summary>
    /// <value>Address and name data for a call endpoint.</value>
    [DataMember(Name = "self", EmitDefaultValue = false)]
    public Address Self { get; set; }



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
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Video {\n");

        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  InitialState: ").Append(InitialState).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Context: ").Append(Context).Append("\n");
        sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
        sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
        sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
        sb.Append("  PeerCount: ").Append(PeerCount).Append("\n");
        sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
        sb.Append("  StartAlertingTime: ").Append(StartAlertingTime).Append("\n");
        sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
        sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  PeerId: ").Append(PeerId).Append("\n");
        sb.Append("  Msids: ").Append(Msids).Append("\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  AfterCallWork: ").Append(AfterCallWork).Append("\n");
        sb.Append("  AfterCallWorkRequired: ").Append(AfterCallWorkRequired).Append("\n");
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
        return this.Equals(obj as Video);
    }

    /// <summary>
    /// Returns true if Video instances are equal
    /// </summary>
    /// <param name="other">Instance of Video to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Video other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.State == other.State ||
                this.State != null &&
                this.State.Equals(other.State)
            ) &&
            (
                this.InitialState == other.InitialState ||
                this.InitialState != null &&
                this.InitialState.Equals(other.InitialState)
            ) &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Context == other.Context ||
                this.Context != null &&
                this.Context.Equals(other.Context)
            ) &&
            (
                this.AudioMuted == other.AudioMuted ||
                this.AudioMuted != null &&
                this.AudioMuted.Equals(other.AudioMuted)
            ) &&
            (
                this.VideoMuted == other.VideoMuted ||
                this.VideoMuted != null &&
                this.VideoMuted.Equals(other.VideoMuted)
            ) &&
            (
                this.SharingScreen == other.SharingScreen ||
                this.SharingScreen != null &&
                this.SharingScreen.Equals(other.SharingScreen)
            ) &&
            (
                this.PeerCount == other.PeerCount ||
                this.PeerCount != null &&
                this.PeerCount.Equals(other.PeerCount)
            ) &&
            (
                this.DisconnectType == other.DisconnectType ||
                this.DisconnectType != null &&
                this.DisconnectType.Equals(other.DisconnectType)
            ) &&
            (
                this.StartAlertingTime == other.StartAlertingTime ||
                this.StartAlertingTime != null &&
                this.StartAlertingTime.Equals(other.StartAlertingTime)
            ) &&
            (
                this.ConnectedTime == other.ConnectedTime ||
                this.ConnectedTime != null &&
                this.ConnectedTime.Equals(other.ConnectedTime)
            ) &&
            (
                this.DisconnectedTime == other.DisconnectedTime ||
                this.DisconnectedTime != null &&
                this.DisconnectedTime.Equals(other.DisconnectedTime)
            ) &&
            (
                this.Provider == other.Provider ||
                this.Provider != null &&
                this.Provider.Equals(other.Provider)
            ) &&
            (
                this.PeerId == other.PeerId ||
                this.PeerId != null &&
                this.PeerId.Equals(other.PeerId)
            ) &&
            (
                this.Msids == other.Msids ||
                this.Msids != null &&
                this.Msids.SequenceEqual(other.Msids)
            ) &&
            (
                this.Self == other.Self ||
                this.Self != null &&
                this.Self.Equals(other.Self)
            ) &&
            (
                this.Wrapup == other.Wrapup ||
                this.Wrapup != null &&
                this.Wrapup.Equals(other.Wrapup)
            ) &&
            (
                this.AfterCallWork == other.AfterCallWork ||
                this.AfterCallWork != null &&
                this.AfterCallWork.Equals(other.AfterCallWork)
            ) &&
            (
                this.AfterCallWorkRequired == other.AfterCallWorkRequired ||
                this.AfterCallWorkRequired != null &&
                this.AfterCallWorkRequired.Equals(other.AfterCallWorkRequired)
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
            if (this.State != null)
            {
                hash = hash * 59 + this.State.GetHashCode();
            }

            if (this.InitialState != null)
            {
                hash = hash * 59 + this.InitialState.GetHashCode();
            }

            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Context != null)
            {
                hash = hash * 59 + this.Context.GetHashCode();
            }

            if (this.AudioMuted != null)
            {
                hash = hash * 59 + this.AudioMuted.GetHashCode();
            }

            if (this.VideoMuted != null)
            {
                hash = hash * 59 + this.VideoMuted.GetHashCode();
            }

            if (this.SharingScreen != null)
            {
                hash = hash * 59 + this.SharingScreen.GetHashCode();
            }

            if (this.PeerCount != null)
            {
                hash = hash * 59 + this.PeerCount.GetHashCode();
            }

            if (this.DisconnectType != null)
            {
                hash = hash * 59 + this.DisconnectType.GetHashCode();
            }

            if (this.StartAlertingTime != null)
            {
                hash = hash * 59 + this.StartAlertingTime.GetHashCode();
            }

            if (this.ConnectedTime != null)
            {
                hash = hash * 59 + this.ConnectedTime.GetHashCode();
            }

            if (this.DisconnectedTime != null)
            {
                hash = hash * 59 + this.DisconnectedTime.GetHashCode();
            }

            if (this.Provider != null)
            {
                hash = hash * 59 + this.Provider.GetHashCode();
            }

            if (this.PeerId != null)
            {
                hash = hash * 59 + this.PeerId.GetHashCode();
            }

            if (this.Msids != null)
            {
                hash = hash * 59 + this.Msids.GetHashCode();
            }

            if (this.Self != null)
            {
                hash = hash * 59 + this.Self.GetHashCode();
            }

            if (this.Wrapup != null)
            {
                hash = hash * 59 + this.Wrapup.GetHashCode();
            }

            if (this.AfterCallWork != null)
            {
                hash = hash * 59 + this.AfterCallWork.GetHashCode();
            }

            if (this.AfterCallWorkRequired != null)
            {
                hash = hash * 59 + this.AfterCallWorkRequired.GetHashCode();
            }

            return hash;
        }
    }
}
