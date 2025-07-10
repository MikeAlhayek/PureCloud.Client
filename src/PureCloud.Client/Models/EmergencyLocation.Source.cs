using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum EmergencyLocationSourceEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Admin for "Admin"
    /// </summary>
    [EnumMember(Value = "Admin")]
    Admin,

    /// <summary>
    /// Enum User for "User"
    /// </summary>
    [EnumMember(Value = "User")]
    User
}
