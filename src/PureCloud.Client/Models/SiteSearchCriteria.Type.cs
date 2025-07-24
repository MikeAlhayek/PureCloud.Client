using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Search Type
/// </summary>
/// <value>Search Type</value>

public enum SiteSearchCriteriaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Exact for "EXACT"
    /// </summary>
    [EnumMember(Value = "EXACT")]
    Exact,

    /// <summary>
    /// Enum Contains for "CONTAINS"
    /// </summary>
    [EnumMember(Value = "CONTAINS")]
    Contains
}
