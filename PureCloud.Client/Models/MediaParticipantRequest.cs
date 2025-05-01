using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaParticipantRequest
/// </summary>
[DataContract]
public partial class MediaParticipantRequest : IEquatable<MediaParticipantRequest>
{
    /// <summary>
    /// The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.
    /// </summary>
    /// <value>The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.</value>
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
    /// The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.
    /// </summary>
    /// <value>The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaParticipantRequest" /> class.
    /// </summary>
    /// <param name="Wrapup">Wrap-up to assign to this participant..</param>
    /// <param name="State">The state to update to set for this participant&#39;s communications.  Possible values are: &#39;connected&#39; and &#39;disconnected&#39;..</param>
    /// <param name="Recording">True to enable recording of this participant, otherwise false to disable recording..</param>
    /// <param name="Muted">True to mute this conversation participant..</param>
    /// <param name="Confined">True to confine this conversation participant.  Should only be used for ad-hoc conferences.</param>
    /// <param name="Held">True to hold this conversation participant..</param>
    /// <param name="WrapupSkipped">True to skip wrap-up for this participant..</param>
    public MediaParticipantRequest(WrapupInput Wrapup = null, StateEnum? State = null, bool? Recording = null, bool? Muted = null, bool? Confined = null, bool? Held = null, bool? WrapupSkipped = null)
    {
        this.Wrapup = Wrapup;
        this.State = State;
        this.Recording = Recording;
        this.Muted = Muted;
        this.Confined = Confined;
        this.Held = Held;
        this.WrapupSkipped = WrapupSkipped;

    }



    /// <summary>
    /// Wrap-up to assign to this participant.
    /// </summary>
    /// <value>Wrap-up to assign to this participant.</value>
    [DataMember(Name = "wrapup", EmitDefaultValue = false)]
    public WrapupInput Wrapup { get; set; }





    /// <summary>
    /// True to enable recording of this participant, otherwise false to disable recording.
    /// </summary>
    /// <value>True to enable recording of this participant, otherwise false to disable recording.</value>
    [DataMember(Name = "recording", EmitDefaultValue = false)]
    public bool? Recording { get; set; }



    /// <summary>
    /// True to mute this conversation participant.
    /// </summary>
    /// <value>True to mute this conversation participant.</value>
    [DataMember(Name = "muted", EmitDefaultValue = false)]
    public bool? Muted { get; set; }



    /// <summary>
    /// True to confine this conversation participant.  Should only be used for ad-hoc conferences
    /// </summary>
    /// <value>True to confine this conversation participant.  Should only be used for ad-hoc conferences</value>
    [DataMember(Name = "confined", EmitDefaultValue = false)]
    public bool? Confined { get; set; }



    /// <summary>
    /// True to hold this conversation participant.
    /// </summary>
    /// <value>True to hold this conversation participant.</value>
    [DataMember(Name = "held", EmitDefaultValue = false)]
    public bool? Held { get; set; }



    /// <summary>
    /// True to skip wrap-up for this participant.
    /// </summary>
    /// <value>True to skip wrap-up for this participant.</value>
    [DataMember(Name = "wrapupSkipped", EmitDefaultValue = false)]
    public bool? WrapupSkipped { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaParticipantRequest {\n");

        sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Recording: ").Append(Recording).Append("\n");
        sb.Append("  Muted: ").Append(Muted).Append("\n");
        sb.Append("  Confined: ").Append(Confined).Append("\n");
        sb.Append("  Held: ").Append(Held).Append("\n");
        sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
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
        return Equals(obj as MediaParticipantRequest);
    }

    /// <summary>
    /// Returns true if MediaParticipantRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaParticipantRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaParticipantRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Wrapup == other.Wrapup ||
                Wrapup != null &&
                Wrapup.Equals(other.Wrapup)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Recording == other.Recording ||
                Recording != null &&
                Recording.Equals(other.Recording)
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
                Held == other.Held ||
                Held != null &&
                Held.Equals(other.Held)
            ) &&
            (
                WrapupSkipped == other.WrapupSkipped ||
                WrapupSkipped != null &&
                WrapupSkipped.Equals(other.WrapupSkipped)
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
            if (Wrapup != null)
            {
                hash = hash * 59 + Wrapup.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Recording != null)
            {
                hash = hash * 59 + Recording.GetHashCode();
            }

            if (Muted != null)
            {
                hash = hash * 59 + Muted.GetHashCode();
            }

            if (Confined != null)
            {
                hash = hash * 59 + Confined.GetHashCode();
            }

            if (Held != null)
            {
                hash = hash * 59 + Held.GetHashCode();
            }

            if (WrapupSkipped != null)
            {
                hash = hash * 59 + WrapupSkipped.GetHashCode();
            }

            return hash;
        }
    }
}
