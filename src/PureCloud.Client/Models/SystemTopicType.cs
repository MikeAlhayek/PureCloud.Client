using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum SystemTopicType
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
    TokenRevoked,
}
