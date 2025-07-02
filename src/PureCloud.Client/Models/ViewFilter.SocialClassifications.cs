using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SocialClassifications
/// </summary>

public enum ViewFilterSocialClassificationsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Public for "Public"
    /// </summary>
    [EnumMember(Value = "Public")]
    Public,

    /// <summary>
    /// Enum Private for "Private"
    /// </summary>
    [EnumMember(Value = "Private")]
    Private
}
