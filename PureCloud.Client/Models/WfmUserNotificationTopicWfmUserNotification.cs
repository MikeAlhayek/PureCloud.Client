using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WfmUserNotificationTopicWfmUserNotification
/// </summary>
[DataContract]
public partial class WfmUserNotificationTopicWfmUserNotification : IEquatable<WfmUserNotificationTopicWfmUserNotification>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Shifttrade for "ShiftTrade"
        /// </summary>
        [EnumMember(Value = "ShiftTrade")]
        Shifttrade,

        /// <summary>
        /// Enum Timeoffrequest for "TimeOffRequest"
        /// </summary>
        [EnumMember(Value = "TimeOffRequest")]
        Timeoffrequest,

        /// <summary>
        /// Enum Adherenceexplanation for "AdherenceExplanation"
        /// </summary>
        [EnumMember(Value = "AdherenceExplanation")]
        Adherenceexplanation,

        /// <summary>
        /// Enum Alternativeshift for "AlternativeShift"
        /// </summary>
        [EnumMember(Value = "AlternativeShift")]
        Alternativeshift
    }
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WfmUserNotificationTopicWfmUserNotification" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="MutableGroupId">MutableGroupId.</param>
    /// <param name="Timestamp">Timestamp.</param>
    /// <param name="Type">Type.</param>
    /// <param name="ShiftTrade">ShiftTrade.</param>
    /// <param name="TimeOffRequest">TimeOffRequest.</param>
    /// <param name="AdherenceExplanation">AdherenceExplanation.</param>
    /// <param name="AlternativeShift">AlternativeShift.</param>
    /// <param name="AgentNotification">AgentNotification.</param>
    /// <param name="OtherNotificationIdsInGroup">OtherNotificationIdsInGroup.</param>
    /// <param name="MarkedAsRead">MarkedAsRead.</param>
    public WfmUserNotificationTopicWfmUserNotification(string Id = null, string MutableGroupId = null, DateTime? Timestamp = null, TypeEnum? Type = null, WfmUserNotificationTopicShiftTradeNotification ShiftTrade = null, WfmUserNotificationTopicTimeOffRequestNotification TimeOffRequest = null, WfmUserNotificationTopicAdherenceExplanationNotification AdherenceExplanation = null, WfmUserNotificationTopicAlternativeShiftNotification AlternativeShift = null, bool? AgentNotification = null, List<string> OtherNotificationIdsInGroup = null, bool? MarkedAsRead = null)
    {
        this.Id = Id;
        this.MutableGroupId = MutableGroupId;
        this.Timestamp = Timestamp;
        this.Type = Type;
        this.ShiftTrade = ShiftTrade;
        this.TimeOffRequest = TimeOffRequest;
        this.AdherenceExplanation = AdherenceExplanation;
        this.AlternativeShift = AlternativeShift;
        this.AgentNotification = AgentNotification;
        this.OtherNotificationIdsInGroup = OtherNotificationIdsInGroup;
        this.MarkedAsRead = MarkedAsRead;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets MutableGroupId
    /// </summary>
    [DataMember(Name = "mutableGroupId", EmitDefaultValue = false)]
    public string MutableGroupId { get; set; }



    /// <summary>
    /// Gets or Sets Timestamp
    /// </summary>
    [DataMember(Name = "timestamp", EmitDefaultValue = false)]
    public DateTime? Timestamp { get; set; }





    /// <summary>
    /// Gets or Sets ShiftTrade
    /// </summary>
    [DataMember(Name = "shiftTrade", EmitDefaultValue = false)]
    public WfmUserNotificationTopicShiftTradeNotification ShiftTrade { get; set; }



    /// <summary>
    /// Gets or Sets TimeOffRequest
    /// </summary>
    [DataMember(Name = "timeOffRequest", EmitDefaultValue = false)]
    public WfmUserNotificationTopicTimeOffRequestNotification TimeOffRequest { get; set; }



    /// <summary>
    /// Gets or Sets AdherenceExplanation
    /// </summary>
    [DataMember(Name = "adherenceExplanation", EmitDefaultValue = false)]
    public WfmUserNotificationTopicAdherenceExplanationNotification AdherenceExplanation { get; set; }



    /// <summary>
    /// Gets or Sets AlternativeShift
    /// </summary>
    [DataMember(Name = "alternativeShift", EmitDefaultValue = false)]
    public WfmUserNotificationTopicAlternativeShiftNotification AlternativeShift { get; set; }



    /// <summary>
    /// Gets or Sets AgentNotification
    /// </summary>
    [DataMember(Name = "agentNotification", EmitDefaultValue = false)]
    public bool? AgentNotification { get; set; }



    /// <summary>
    /// Gets or Sets OtherNotificationIdsInGroup
    /// </summary>
    [DataMember(Name = "otherNotificationIdsInGroup", EmitDefaultValue = false)]
    public List<string> OtherNotificationIdsInGroup { get; set; }



    /// <summary>
    /// Gets or Sets MarkedAsRead
    /// </summary>
    [DataMember(Name = "markedAsRead", EmitDefaultValue = false)]
    public bool? MarkedAsRead { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WfmUserNotificationTopicWfmUserNotification {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MutableGroupId: ").Append(MutableGroupId).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  ShiftTrade: ").Append(ShiftTrade).Append("\n");
        sb.Append("  TimeOffRequest: ").Append(TimeOffRequest).Append("\n");
        sb.Append("  AdherenceExplanation: ").Append(AdherenceExplanation).Append("\n");
        sb.Append("  AlternativeShift: ").Append(AlternativeShift).Append("\n");
        sb.Append("  AgentNotification: ").Append(AgentNotification).Append("\n");
        sb.Append("  OtherNotificationIdsInGroup: ").Append(OtherNotificationIdsInGroup).Append("\n");
        sb.Append("  MarkedAsRead: ").Append(MarkedAsRead).Append("\n");
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
        return Equals(obj as WfmUserNotificationTopicWfmUserNotification);
    }

    /// <summary>
    /// Returns true if WfmUserNotificationTopicWfmUserNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of WfmUserNotificationTopicWfmUserNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WfmUserNotificationTopicWfmUserNotification other)
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
                MutableGroupId == other.MutableGroupId ||
                MutableGroupId != null &&
                MutableGroupId.Equals(other.MutableGroupId)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                ShiftTrade == other.ShiftTrade ||
                ShiftTrade != null &&
                ShiftTrade.Equals(other.ShiftTrade)
            ) &&
            (
                TimeOffRequest == other.TimeOffRequest ||
                TimeOffRequest != null &&
                TimeOffRequest.Equals(other.TimeOffRequest)
            ) &&
            (
                AdherenceExplanation == other.AdherenceExplanation ||
                AdherenceExplanation != null &&
                AdherenceExplanation.Equals(other.AdherenceExplanation)
            ) &&
            (
                AlternativeShift == other.AlternativeShift ||
                AlternativeShift != null &&
                AlternativeShift.Equals(other.AlternativeShift)
            ) &&
            (
                AgentNotification == other.AgentNotification ||
                AgentNotification != null &&
                AgentNotification.Equals(other.AgentNotification)
            ) &&
            (
                OtherNotificationIdsInGroup == other.OtherNotificationIdsInGroup ||
                OtherNotificationIdsInGroup != null &&
                OtherNotificationIdsInGroup.SequenceEqual(other.OtherNotificationIdsInGroup)
            ) &&
            (
                MarkedAsRead == other.MarkedAsRead ||
                MarkedAsRead != null &&
                MarkedAsRead.Equals(other.MarkedAsRead)
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

            if (MutableGroupId != null)
            {
                hash = hash * 59 + MutableGroupId.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (ShiftTrade != null)
            {
                hash = hash * 59 + ShiftTrade.GetHashCode();
            }

            if (TimeOffRequest != null)
            {
                hash = hash * 59 + TimeOffRequest.GetHashCode();
            }

            if (AdherenceExplanation != null)
            {
                hash = hash * 59 + AdherenceExplanation.GetHashCode();
            }

            if (AlternativeShift != null)
            {
                hash = hash * 59 + AlternativeShift.GetHashCode();
            }

            if (AgentNotification != null)
            {
                hash = hash * 59 + AgentNotification.GetHashCode();
            }

            if (OtherNotificationIdsInGroup != null)
            {
                hash = hash * 59 + OtherNotificationIdsInGroup.GetHashCode();
            }

            if (MarkedAsRead != null)
            {
                hash = hash * 59 + MarkedAsRead.GetHashCode();
            }

            return hash;
        }
    }
}
