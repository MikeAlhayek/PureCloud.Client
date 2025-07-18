using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CoachingNotificationActionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Create for "Create"
    /// </summary>
    [EnumMember(Value = "Create")]
    Create,

    /// <summary>
    /// Enum Update for "Update"
    /// </summary>
    [EnumMember(Value = "Update")]
    Update,

    /// <summary>
    /// Enum Delete for "Delete"
    /// </summary>
    [EnumMember(Value = "Delete")]
    Delete,

    /// <summary>
    /// Enum Statuschange for "StatusChange"
    /// </summary>
    [EnumMember(Value = "StatusChange")]
    Statuschange
}
