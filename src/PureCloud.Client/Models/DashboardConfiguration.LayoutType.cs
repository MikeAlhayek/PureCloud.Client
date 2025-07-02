using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DashboardConfigurationLayoutTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Grid for "Grid"
    /// </summary>
    [EnumMember(Value = "Grid")]
    Grid,

    /// <summary>
    /// Enum Flow for "Flow"
    /// </summary>
    [EnumMember(Value = "Flow")]
    Flow
}
