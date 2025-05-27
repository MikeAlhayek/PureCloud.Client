using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DevelopmentActivityArchivalModeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Graceful for "Graceful"
    /// </summary>
    [EnumMember(Value = "Graceful")]
    Graceful,

    /// <summary>
    /// Enum Immediate for "Immediate"
    /// </summary>
    [EnumMember(Value = "Immediate")]
    Immediate
}
