using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum InclusionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Draft for "Draft"
    /// </summary>
    [EnumMember(Value = "Draft")]
    Draft,

    /// <summary>
    /// Enum Send for "Send"
    /// </summary>
    [EnumMember(Value = "Send")]
    Send,

    /// <summary>
    /// Enum Sendonce for "SendOnce"
    /// </summary>
    [EnumMember(Value = "SendOnce")]
    Sendonce,
}
