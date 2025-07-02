using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The sort key of the table.
/// </summary>
/// <value>The sort key of the table.</value>

public enum WidgetSortKeyEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Name for "Name"
    /// </summary>
    [EnumMember(Value = "Name")]
    Name,

    /// <summary>
    /// Enum Duration for "Duration"
    /// </summary>
    [EnumMember(Value = "Duration")]
    Duration
}
