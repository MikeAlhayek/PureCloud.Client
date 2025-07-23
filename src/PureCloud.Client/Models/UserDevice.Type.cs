using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// type of the device; ios or android
/// </summary>
public enum UserDeviceType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Android for "android"
    /// </summary>
    [EnumMember(Value = "android")]
    Android,

    /// <summary>
    /// Enum Ios for "ios"
    /// </summary>
    [EnumMember(Value = "ios")]
    Ios
}