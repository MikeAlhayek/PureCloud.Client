using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DashboardConfigurationQueryRequestSortByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Asc for "Asc"
    /// </summary>
    [EnumMember(Value = "Asc")]
    Asc,

    /// <summary>
    /// Enum Desc for "Desc"
    /// </summary>
    [EnumMember(Value = "Desc")]
    Desc
}
