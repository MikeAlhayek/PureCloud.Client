using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The view status of the alerts the query will return.
/// </summary>
/// <value>The view status of the alerts the query will return.</value>

public enum GetAlertQueryViewedStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unread for "Unread"
    /// </summary>
    [EnumMember(Value = "Unread")]
    Unread,

    /// <summary>
    /// Enum Read for "Read"
    /// </summary>
    [EnumMember(Value = "Read")]
    Read,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}
