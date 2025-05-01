using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SystemMessageSystemMessage
/// </summary>
[DataContract]
public partial class SystemMessageSystemMessage : IEquatable<SystemMessageSystemMessage>
{
    /// <summary>
    /// Gets or Sets SystemTopicType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SystemTopicTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum NoLongerSubscribed for "no_longer_subscribed"
        /// </summary>
        [EnumMember(Value = "no_longer_subscribed")]
        NoLongerSubscribed,

        /// <summary>
        /// Enum SubscriptionChanged for "subscription_changed"
        /// </summary>
        [EnumMember(Value = "subscription_changed")]
        SubscriptionChanged,

        /// <summary>
        /// Enum TokenRevoked for "token_revoked"
        /// </summary>
        [EnumMember(Value = "token_revoked")]
        TokenRevoked
    }
    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum AnotherChannelSubscribed for "another_channel_subscribed"
        /// </summary>
        [EnumMember(Value = "another_channel_subscribed")]
        AnotherChannelSubscribed,

        /// <summary>
        /// Enum UserTokensRevoked for "user_tokens_revoked"
        /// </summary>
        [EnumMember(Value = "user_tokens_revoked")]
        UserTokensRevoked
    }
    /// <summary>
    /// Gets or Sets SystemTopicType
    /// </summary>
    [DataMember(Name = "systemTopicType", EmitDefaultValue = false)]
    public SystemTopicTypeEnum? SystemTopicType { get; set; }
    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SystemMessageSystemMessage" /> class.
    /// </summary>
    /// <param name="ChannelId">ChannelId.</param>
    /// <param name="SystemTopicType">SystemTopicType.</param>
    /// <param name="CorrelationId">CorrelationId.</param>
    /// <param name="OrganizationId">OrganizationId.</param>
    /// <param name="UserId">UserId.</param>
    /// <param name="OauthClientId">OauthClientId.</param>
    /// <param name="Reason">Reason.</param>
    /// <param name="Message">Message.</param>
    /// <param name="Data">Data.</param>
    public SystemMessageSystemMessage(string ChannelId = null, SystemTopicTypeEnum? SystemTopicType = null, string CorrelationId = null, string OrganizationId = null, string UserId = null, string OauthClientId = null, ReasonEnum? Reason = null, string Message = null, Dictionary<string, object> Data = null)
    {
        this.ChannelId = ChannelId;
        this.SystemTopicType = SystemTopicType;
        this.CorrelationId = CorrelationId;
        this.OrganizationId = OrganizationId;
        this.UserId = UserId;
        this.OauthClientId = OauthClientId;
        this.Reason = Reason;
        this.Message = Message;
        this.Data = Data;

    }



    /// <summary>
    /// Gets or Sets ChannelId
    /// </summary>
    [DataMember(Name = "channelId", EmitDefaultValue = false)]
    public string ChannelId { get; set; }





    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    [DataMember(Name = "correlationId", EmitDefaultValue = false)]
    public string CorrelationId { get; set; }



    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    [DataMember(Name = "organizationId", EmitDefaultValue = false)]
    public string OrganizationId { get; set; }



    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name = "userId", EmitDefaultValue = false)]
    public string UserId { get; set; }



    /// <summary>
    /// Gets or Sets OauthClientId
    /// </summary>
    [DataMember(Name = "oauthClientId", EmitDefaultValue = false)]
    public string OauthClientId { get; set; }





    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }



    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name = "data", EmitDefaultValue = false)]
    public Dictionary<string, object> Data { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SystemMessageSystemMessage {\n");

        sb.Append("  ChannelId: ").Append(ChannelId).Append("\n");
        sb.Append("  SystemTopicType: ").Append(SystemTopicType).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  OauthClientId: ").Append(OauthClientId).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
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
        return Equals(obj as SystemMessageSystemMessage);
    }

    /// <summary>
    /// Returns true if SystemMessageSystemMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of SystemMessageSystemMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SystemMessageSystemMessage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ChannelId == other.ChannelId ||
                ChannelId != null &&
                ChannelId.Equals(other.ChannelId)
            ) &&
            (
                SystemTopicType == other.SystemTopicType ||
                SystemTopicType != null &&
                SystemTopicType.Equals(other.SystemTopicType)
            ) &&
            (
                CorrelationId == other.CorrelationId ||
                CorrelationId != null &&
                CorrelationId.Equals(other.CorrelationId)
            ) &&
            (
                OrganizationId == other.OrganizationId ||
                OrganizationId != null &&
                OrganizationId.Equals(other.OrganizationId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                OauthClientId == other.OauthClientId ||
                OauthClientId != null &&
                OauthClientId.Equals(other.OauthClientId)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                Data == other.Data ||
                Data != null &&
                Data.SequenceEqual(other.Data)
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
            if (ChannelId != null)
            {
                hash = hash * 59 + ChannelId.GetHashCode();
            }

            if (SystemTopicType != null)
            {
                hash = hash * 59 + SystemTopicType.GetHashCode();
            }

            if (CorrelationId != null)
            {
                hash = hash * 59 + CorrelationId.GetHashCode();
            }

            if (OrganizationId != null)
            {
                hash = hash * 59 + OrganizationId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (OauthClientId != null)
            {
                hash = hash * 59 + OauthClientId.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (Data != null)
            {
                hash = hash * 59 + Data.GetHashCode();
            }

            return hash;
        }
    }
}
