using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of email address. "value" is immutable if "type" is set to "other".
/// </summary>
public enum ScimEmailTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Work for "work"
    /// </summary>
    [EnumMember(Value = "work")]
    Work,

    /// <summary>
    /// Enum Other for "other"
    /// </summary>
    [EnumMember(Value = "other")]
    Other
}
