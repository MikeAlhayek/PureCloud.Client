using System.Runtime.Serialization;

namespace PureCloud.Client.Models;


public enum SystemMessageReason
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
    UserTokensRevoked,
}

public sealed class SystemMessage
{
    /// <summary>
    /// Gets or Sets SystemTopicType
    /// </summary>
    public SystemTopicType? SystemTopicType { get; set; }

    /// <summary>
    /// Gets or Sets Reason
    /// </summary>
    public SystemMessageReason? Reason { get; set; }

    /// <summary>
    /// Gets or Sets ChannelId
    /// </summary>
    public string ChannelId { get; set; }

    /// <summary>
    /// Gets or Sets CorrelationId
    /// </summary>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Gets or Sets OrganizationId
    /// </summary>
    public string OrganizationId { get; set; }

    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    public string UserId { get; set; }

    /// <summary>
    /// Gets or Sets OauthClientId
    /// </summary>
    public string OauthClientId { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    public Dictionary<string, object> Data { get; set; }
}
