using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CallForwardingVoicemailEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum PureCloudEnvironment for "PURECLOUD"
    /// </summary>
    [EnumMember(Value = "PURECLOUD")]
    Purecloud,

    /// <summary>
    /// Enum Lastcall for "LASTCALL"
    /// </summary>
    [EnumMember(Value = "LASTCALL")]
    Lastcall,

    /// <summary>
    /// Enum None for "NONE"
    /// </summary>
    [EnumMember(Value = "NONE")]
    None
}
