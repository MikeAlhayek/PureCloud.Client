using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Groups;

public enum GroupType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Official for "official"
    /// </summary>
    [EnumMember(Value = "official")]
    Official,

    /// <summary>
    /// Enum Social for "social"
    /// </summary>
    [EnumMember(Value = "social")]
    Social
}
