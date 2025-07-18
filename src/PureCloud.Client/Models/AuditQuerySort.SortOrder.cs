using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Sort Order
/// </summary>
/// <value>Sort Order</value>

public enum AuditQuerySortSortOrderEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Ascending for "ascending"
    /// </summary>
    [EnumMember(Value = "ascending")]
    Ascending,

    /// <summary>
    /// Enum Descending for "descending"
    /// </summary>
    [EnumMember(Value = "descending")]
    Descending
}
