using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".
/// </summary>
/// <value>A filter type for topic Ids. It's only used for objectives with topicIds. Default filter behavior is \"or\".</value>

public enum CreateObjectiveTopicIdsFilterTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum And for "and"
    /// </summary>
    [EnumMember(Value = "and")]
    And,

    /// <summary>
    /// Enum Or for "or"
    /// </summary>
    [EnumMember(Value = "or")]
    Or
}
