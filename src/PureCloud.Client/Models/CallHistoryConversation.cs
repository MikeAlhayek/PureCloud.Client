using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallHistoryConversation
/// </summary>

public partial class CallHistoryConversation : IEquatable<CallHistoryConversation>
{
    /// <summary>
    /// The direction of the call relating to the current user
    /// </summary>
    /// <value>The direction of the call relating to the current user</value>
    
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
    /// The direction of the call relating to the current user
    /// </summary>
    /// <value>The direction of the call relating to the current user</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallHistoryConversation" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Participants">The list of participants involved in the conversation..</param>
    /// <param name="Direction">The direction of the call relating to the current user.</param>
    /// <param name="WentToVoicemail">Did the call end in the current user&#39;s voicemail.</param>
    /// <param name="MissedCall">Did the user not answer this conversation.</param>
    /// <param name="StartTime">The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="WasConference">Was this conversation a conference.</param>
    /// <param name="WasCallback">Was this conversation a callback.</param>
    /// <param name="HadScreenShare">Did this conversation have a screen share session.</param>
    /// <param name="HadCobrowse">Did this conversation have a cobrowse session.</param>
    /// <param name="WasOutboundCampaign">Was this conversation associated with an outbound campaign.</param>
    public CallHistoryConversation(string Name = null, List<CallHistoryParticipant> Participants = null, DirectionEnum? Direction = null, bool? WentToVoicemail = null, bool? MissedCall = null, DateTime? StartTime = null, bool? WasConference = null, bool? WasCallback = null, bool? HadScreenShare = null, bool? HadCobrowse = null, bool? WasOutboundCampaign = null)
    {
        this.Name = Name;
        this.Participants = Participants;
        this.Direction = Direction;
        this.WentToVoicemail = WentToVoicemail;
        this.MissedCall = MissedCall;
        this.StartTime = StartTime;
        this.WasConference = WasConference;
        this.WasCallback = WasCallback;
        this.HadScreenShare = HadScreenShare;
        this.HadCobrowse = HadCobrowse;
        this.WasOutboundCampaign = WasOutboundCampaign;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The list of participants involved in the conversation.
    /// </summary>
    /// <value>The list of participants involved in the conversation.</value>
    [JsonPropertyName("participants")]
    public List<CallHistoryParticipant> Participants { get; set; }





    /// <summary>
    /// Did the call end in the current user&#39;s voicemail
    /// </summary>
    /// <value>Did the call end in the current user&#39;s voicemail</value>
    [JsonPropertyName("wentToVoicemail")]
    public bool? WentToVoicemail { get; set; }



    /// <summary>
    /// Did the user not answer this conversation
    /// </summary>
    /// <value>Did the user not answer this conversation</value>
    [JsonPropertyName("missedCall")]
    public bool? MissedCall { get; set; }



    /// <summary>
    /// The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time the user joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("startTime")]
    public DateTime? StartTime { get; set; }



    /// <summary>
    /// Was this conversation a conference
    /// </summary>
    /// <value>Was this conversation a conference</value>
    [JsonPropertyName("wasConference")]
    public bool? WasConference { get; set; }



    /// <summary>
    /// Was this conversation a callback
    /// </summary>
    /// <value>Was this conversation a callback</value>
    [JsonPropertyName("wasCallback")]
    public bool? WasCallback { get; set; }



    /// <summary>
    /// Did this conversation have a screen share session
    /// </summary>
    /// <value>Did this conversation have a screen share session</value>
    [JsonPropertyName("hadScreenShare")]
    public bool? HadScreenShare { get; set; }



    /// <summary>
    /// Did this conversation have a cobrowse session
    /// </summary>
    /// <value>Did this conversation have a cobrowse session</value>
    [JsonPropertyName("hadCobrowse")]
    public bool? HadCobrowse { get; set; }



    /// <summary>
    /// Was this conversation associated with an outbound campaign
    /// </summary>
    /// <value>Was this conversation associated with an outbound campaign</value>
    [JsonPropertyName("wasOutboundCampaign")]
    public bool? WasOutboundCampaign { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallHistoryConversation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  WentToVoicemail: ").Append(WentToVoicemail).Append("\n");
        sb.Append("  MissedCall: ").Append(MissedCall).Append("\n");
        sb.Append("  StartTime: ").Append(StartTime).Append("\n");
        sb.Append("  WasConference: ").Append(WasConference).Append("\n");
        sb.Append("  WasCallback: ").Append(WasCallback).Append("\n");
        sb.Append("  HadScreenShare: ").Append(HadScreenShare).Append("\n");
        sb.Append("  HadCobrowse: ").Append(HadCobrowse).Append("\n");
        sb.Append("  WasOutboundCampaign: ").Append(WasOutboundCampaign).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CallHistoryConversation);
    }

    /// <summary>
    /// Returns true if CallHistoryConversation instances are equal
    /// </summary>
    /// <param name="other">Instance of CallHistoryConversation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallHistoryConversation other)
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
                Participants == other.Participants ||
                Participants != null &&
                Participants.SequenceEqual(other.Participants)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                WentToVoicemail == other.WentToVoicemail ||
                WentToVoicemail != null &&
                WentToVoicemail.Equals(other.WentToVoicemail)
            ) &&
            (
                MissedCall == other.MissedCall ||
                MissedCall != null &&
                MissedCall.Equals(other.MissedCall)
            ) &&
            (
                StartTime == other.StartTime ||
                StartTime != null &&
                StartTime.Equals(other.StartTime)
            ) &&
            (
                WasConference == other.WasConference ||
                WasConference != null &&
                WasConference.Equals(other.WasConference)
            ) &&
            (
                WasCallback == other.WasCallback ||
                WasCallback != null &&
                WasCallback.Equals(other.WasCallback)
            ) &&
            (
                HadScreenShare == other.HadScreenShare ||
                HadScreenShare != null &&
                HadScreenShare.Equals(other.HadScreenShare)
            ) &&
            (
                HadCobrowse == other.HadCobrowse ||
                HadCobrowse != null &&
                HadCobrowse.Equals(other.HadCobrowse)
            ) &&
            (
                WasOutboundCampaign == other.WasOutboundCampaign ||
                WasOutboundCampaign != null &&
                WasOutboundCampaign.Equals(other.WasOutboundCampaign)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (WentToVoicemail != null)
            {
                hash = hash * 59 + WentToVoicemail.GetHashCode();
            }

            if (MissedCall != null)
            {
                hash = hash * 59 + MissedCall.GetHashCode();
            }

            if (StartTime != null)
            {
                hash = hash * 59 + StartTime.GetHashCode();
            }

            if (WasConference != null)
            {
                hash = hash * 59 + WasConference.GetHashCode();
            }

            if (WasCallback != null)
            {
                hash = hash * 59 + WasCallback.GetHashCode();
            }

            if (HadScreenShare != null)
            {
                hash = hash * 59 + HadScreenShare.GetHashCode();
            }

            if (HadCobrowse != null)
            {
                hash = hash * 59 + HadCobrowse.GetHashCode();
            }

            if (WasOutboundCampaign != null)
            {
                hash = hash * 59 + WasOutboundCampaign.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
