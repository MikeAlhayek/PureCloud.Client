using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The certificate status
/// </summary>
/// <value>The certificate status</value>

public enum ActionCertificateStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Current for "Current"
    /// </summary>
    [EnumMember(Value = "Current")]
    Current,

    /// <summary>
    /// Enum Upcoming for "Upcoming"
    /// </summary>
    [EnumMember(Value = "Upcoming")]
    Upcoming
}
