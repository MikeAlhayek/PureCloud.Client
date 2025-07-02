using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of dashboard being filtered
/// </summary>
/// <value>The type of dashboard being filtered</value>

public enum ViewFilterDashboardTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All,

    /// <summary>
    /// Enum Public for "Public"
    /// </summary>
    [EnumMember(Value = "Public")]
    Public,

    /// <summary>
    /// Enum Private for "Private"
    /// </summary>
    [EnumMember(Value = "Private")]
    Private,

    /// <summary>
    /// Enum Shared for "Shared"
    /// </summary>
    [EnumMember(Value = "Shared")]
    Shared,

    /// <summary>
    /// Enum Favorites for "Favorites"
    /// </summary>
    [EnumMember(Value = "Favorites")]
    Favorites
}
