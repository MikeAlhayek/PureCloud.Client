using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The state of dashboard being filtered
/// </summary>
/// <value>The state of dashboard being filtered</value>

public enum ViewFilterDashboardStateEnum
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
    /// Enum Deleted for "Deleted"
    /// </summary>
    [EnumMember(Value = "Deleted")]
    Deleted
}
