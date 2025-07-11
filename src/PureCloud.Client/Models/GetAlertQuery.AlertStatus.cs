using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The status of the alerts the query will return.
/// </summary>
/// <value>The status of the alerts the query will return.</value>

public enum GetAlertQueryAlertStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Active for "Active"
    /// </summary>
    [EnumMember(Value = "Active")]
    Active,

    /// <summary>
    /// Enum Inactive for "Inactive"
    /// </summary>
    [EnumMember(Value = "Inactive")]
    Inactive,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}
