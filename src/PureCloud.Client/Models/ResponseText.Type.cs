using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Response text type.
/// </summary>
public enum ResponseTextType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Body for "body"
    /// </summary>
    [EnumMember(Value = "body")]
    Body,

    /// <summary>
    /// Enum Subject for "subject"
    /// </summary>
    [EnumMember(Value = "subject")]
    Subject
}