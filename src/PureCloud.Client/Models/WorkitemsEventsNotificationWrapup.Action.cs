using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Action
/// </summary>

public enum WorkitemsEventsNotificationWrapupActionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Add for "Add"
    /// </summary>
    [EnumMember(Value = "Add")]
    Add,

    /// <summary>
    /// Enum Remove for "Remove"
    /// </summary>
    [EnumMember(Value = "Remove")]
    Remove
}
