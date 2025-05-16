using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

// Mike did this one Remember
// Missing getter and setter for Enum 
public enum SystemMessageReasonEnum
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
