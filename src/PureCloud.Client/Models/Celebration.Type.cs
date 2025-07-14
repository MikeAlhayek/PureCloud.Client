using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CelebrationTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Recognition for "Recognition"
    /// </summary>
    [EnumMember(Value = "Recognition")]
    Recognition,

    /// <summary>
    /// Enum Contestcomplete for "ContestComplete"
    /// </summary>
    [EnumMember(Value = "ContestComplete")]
    Contestcomplete
}
