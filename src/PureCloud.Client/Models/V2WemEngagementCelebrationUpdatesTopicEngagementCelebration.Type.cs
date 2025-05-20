using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum V2WemEngagementCelebrationUpdatesTopicEngagementCelebrationTypeEnum
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
    /// Enum Recognition for "RECOGNITION"
    /// </summary>
    [EnumMember(Value = "RECOGNITION")]
    Recognition,

    /// <summary>
    /// Enum ContestComplete for "CONTEST_COMPLETE"
    /// </summary>
    [EnumMember(Value = "CONTEST_COMPLETE")]
    ContestComplete
}
