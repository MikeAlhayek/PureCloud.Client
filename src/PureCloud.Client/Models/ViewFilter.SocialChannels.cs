using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SocialChannels
/// </summary>

public enum ViewFilterSocialChannelsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Twitter for "Twitter"
    /// </summary>
    [EnumMember(Value = "Twitter")]
    Twitter,

    /// <summary>
    /// Enum Facebook for "Facebook"
    /// </summary>
    [EnumMember(Value = "Facebook")]
    Facebook,

    /// <summary>
    /// Enum Instagram for "Instagram"
    /// </summary>
    [EnumMember(Value = "Instagram")]
    Instagram,

    /// <summary>
    /// Enum Open for "Open"
    /// </summary>
    [EnumMember(Value = "Open")]
    Open
}
