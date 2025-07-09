using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowVersionTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Publish for "PUBLISH"
    /// </summary>
    [EnumMember(Value = "PUBLISH")]
    Publish,

    /// <summary>
    /// Enum Checkin for "CHECKIN"
    /// </summary>
    [EnumMember(Value = "CHECKIN")]
    Checkin,

    /// <summary>
    /// Enum Save for "SAVE"
    /// </summary>
    [EnumMember(Value = "SAVE")]
    Save
}
