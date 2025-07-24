using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The sort order for results
/// </summary>
/// <value>The sort order for results</value>

public enum ResponseAssetSearchRequestSortOrder
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Asc for "ASC"
    /// </summary>
    [EnumMember(Value = "ASC")]
    Asc,

    /// <summary>
    /// Enum Desc for "DESC"
    /// </summary>
    [EnumMember(Value = "DESC")]
    Desc
}
