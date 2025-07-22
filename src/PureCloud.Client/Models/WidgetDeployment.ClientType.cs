using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of display widget for which this Deployment is configured, which controls the administrator settings shown.
/// </summary>
public enum WidgetDeploymentClientType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum V1 for "v1"
    /// </summary>
    [EnumMember(Value = "v1")]
    V1,

    /// <summary>
    /// Enum V2 for "v2"
    /// </summary>
    [EnumMember(Value = "v2")]
    V2,

    /// <summary>
    /// Enum V1http for "v1-http"
    /// </summary>
    [EnumMember(Value = "v1-http")]
    V1http,

    /// <summary>
    /// Enum Thirdparty for "third-party"
    /// </summary>
    [EnumMember(Value = "third-party")]
    Thirdparty
}