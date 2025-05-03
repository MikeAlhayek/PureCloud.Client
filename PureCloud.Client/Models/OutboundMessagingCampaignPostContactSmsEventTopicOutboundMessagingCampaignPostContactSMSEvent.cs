using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent
/// </summary>

public partial class OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent : IEquatable<OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent>
{
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    
    public enum OutboundCampaignTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Sms for "SMS"
        /// </summary>
        [EnumMember(Value = "SMS")]
        Sms
    }
    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    
    public enum WrapupCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unknown for "UNKNOWN"
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Enum OutboundMessageSent for "OUTBOUND_MESSAGE_SENT"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MESSAGE_SENT")]
        OutboundMessageSent,

        /// <summary>
        /// Enum OutboundMessageFailed for "OUTBOUND_MESSAGE_FAILED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MESSAGE_FAILED")]
        OutboundMessageFailed,

        /// <summary>
        /// Enum OutboundMessageThrottled for "OUTBOUND_MESSAGE_THROTTLED"
        /// </summary>
        [EnumMember(Value = "OUTBOUND_MESSAGE_THROTTLED")]
        OutboundMessageThrottled
    }
    /// <summary>
    /// Gets or Sets OutboundCampaignType
    /// </summary>
    [JsonPropertyName("outboundCampaignType")]
    public OutboundCampaignTypeEnum? OutboundCampaignType { get; set; }
    /// <summary>
    /// Gets or Sets WrapupCode
    /// </summary>
    [JsonPropertyName("wrapupCode")]
    public WrapupCodeEnum? WrapupCode { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent" /> class.
    /// </summary>
    /// <param name="EventTime">EventTime.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="OutboundCampaignType">OutboundCampaignType.</param>
    /// <param name="SmsAttributes">SmsAttributes.</param>
    /// <param name="WrapupCode">WrapupCode.</param>
    /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="ContentTemplateId">ContentTemplateId.</param>
    /// <param name="OutboundContactListId">OutboundContactListId.</param>
    /// <param name="OutboundContactId">OutboundContactId.</param>
    /// <param name="IsCampaignAlwaysRunning">IsCampaignAlwaysRunning.</param>
    public OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent(long? EventTime = null, Guid? ConversationId = null, OutboundCampaignTypeEnum? OutboundCampaignType = null, OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes SmsAttributes = null, WrapupCodeEnum? WrapupCode = null, Guid? OutboundCampaignId = null, Guid? DivisionId = null, Guid? ContentTemplateId = null, Guid? OutboundContactListId = null, string OutboundContactId = null, bool? IsCampaignAlwaysRunning = null)
    {
        this.EventTime = EventTime;
        this.ConversationId = ConversationId;
        this.OutboundCampaignType = OutboundCampaignType;
        this.SmsAttributes = SmsAttributes;
        this.WrapupCode = WrapupCode;
        this.OutboundCampaignId = OutboundCampaignId;
        this.DivisionId = DivisionId;
        this.ContentTemplateId = ContentTemplateId;
        this.OutboundContactListId = OutboundContactListId;
        this.OutboundContactId = OutboundContactId;
        this.IsCampaignAlwaysRunning = IsCampaignAlwaysRunning;

    }



    /// <summary>
    /// Gets or Sets EventTime
    /// </summary>
    [JsonPropertyName("eventTime")]
    public long? EventTime { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [JsonPropertyName("conversationId")]
    public Guid? ConversationId { get; set; }





    /// <summary>
    /// Gets or Sets SmsAttributes
    /// </summary>
    [JsonPropertyName("smsAttributes")]
    public OutboundMessagingCampaignPostContactSmsEventTopicSMSAttributes SmsAttributes { get; set; }





    /// <summary>
    /// Gets or Sets OutboundCampaignId
    /// </summary>
    [JsonPropertyName("outboundCampaignId")]
    public Guid? OutboundCampaignId { get; set; }



    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [JsonPropertyName("divisionId")]
    public Guid? DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets ContentTemplateId
    /// </summary>
    [JsonPropertyName("contentTemplateId")]
    public Guid? ContentTemplateId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactListId
    /// </summary>
    [JsonPropertyName("outboundContactListId")]
    public Guid? OutboundContactListId { get; set; }



    /// <summary>
    /// Gets or Sets OutboundContactId
    /// </summary>
    [JsonPropertyName("outboundContactId")]
    public string OutboundContactId { get; set; }



    /// <summary>
    /// Gets or Sets IsCampaignAlwaysRunning
    /// </summary>
    [JsonPropertyName("isCampaignAlwaysRunning")]
    public bool? IsCampaignAlwaysRunning { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent {\n");

        sb.Append("  EventTime: ").Append(EventTime).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  OutboundCampaignType: ").Append(OutboundCampaignType).Append("\n");
        sb.Append("  SmsAttributes: ").Append(SmsAttributes).Append("\n");
        sb.Append("  WrapupCode: ").Append(WrapupCode).Append("\n");
        sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  ContentTemplateId: ").Append(ContentTemplateId).Append("\n");
        sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
        sb.Append("  OutboundContactId: ").Append(OutboundContactId).Append("\n");
        sb.Append("  IsCampaignAlwaysRunning: ").Append(IsCampaignAlwaysRunning).Append("\n");
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
        return Equals(obj as OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent);
    }

    /// <summary>
    /// Returns true if OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutboundMessagingCampaignPostContactSmsEventTopicOutboundMessagingCampaignPostContactSMSEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EventTime == other.EventTime ||
                EventTime != null &&
                EventTime.Equals(other.EventTime)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                OutboundCampaignType == other.OutboundCampaignType ||
                OutboundCampaignType != null &&
                OutboundCampaignType.Equals(other.OutboundCampaignType)
            ) &&
            (
                SmsAttributes == other.SmsAttributes ||
                SmsAttributes != null &&
                SmsAttributes.Equals(other.SmsAttributes)
            ) &&
            (
                WrapupCode == other.WrapupCode ||
                WrapupCode != null &&
                WrapupCode.Equals(other.WrapupCode)
            ) &&
            (
                OutboundCampaignId == other.OutboundCampaignId ||
                OutboundCampaignId != null &&
                OutboundCampaignId.Equals(other.OutboundCampaignId)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                ContentTemplateId == other.ContentTemplateId ||
                ContentTemplateId != null &&
                ContentTemplateId.Equals(other.ContentTemplateId)
            ) &&
            (
                OutboundContactListId == other.OutboundContactListId ||
                OutboundContactListId != null &&
                OutboundContactListId.Equals(other.OutboundContactListId)
            ) &&
            (
                OutboundContactId == other.OutboundContactId ||
                OutboundContactId != null &&
                OutboundContactId.Equals(other.OutboundContactId)
            ) &&
            (
                IsCampaignAlwaysRunning == other.IsCampaignAlwaysRunning ||
                IsCampaignAlwaysRunning != null &&
                IsCampaignAlwaysRunning.Equals(other.IsCampaignAlwaysRunning)
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
            if (EventTime != null)
            {
                hash = hash * 59 + EventTime.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (OutboundCampaignType != null)
            {
                hash = hash * 59 + OutboundCampaignType.GetHashCode();
            }

            if (SmsAttributes != null)
            {
                hash = hash * 59 + SmsAttributes.GetHashCode();
            }

            if (WrapupCode != null)
            {
                hash = hash * 59 + WrapupCode.GetHashCode();
            }

            if (OutboundCampaignId != null)
            {
                hash = hash * 59 + OutboundCampaignId.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (ContentTemplateId != null)
            {
                hash = hash * 59 + ContentTemplateId.GetHashCode();
            }

            if (OutboundContactListId != null)
            {
                hash = hash * 59 + OutboundContactListId.GetHashCode();
            }

            if (OutboundContactId != null)
            {
                hash = hash * 59 + OutboundContactId.GetHashCode();
            }

            if (IsCampaignAlwaysRunning != null)
            {
                hash = hash * 59 + IsCampaignAlwaysRunning.GetHashCode();
            }

            return hash;
        }
    }
}
