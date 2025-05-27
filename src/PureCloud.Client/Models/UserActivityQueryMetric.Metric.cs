using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum UserActivityQueryMetricMetricEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Oactivequeues for "oActiveQueues"
    /// </summary>
    [EnumMember(Value = "oActiveQueues")]
    Oactivequeues,

    /// <summary>
    /// Enum Omemberqueues for "oMemberQueues"
    /// </summary>
    [EnumMember(Value = "oMemberQueues")]
    Omemberqueues
}
