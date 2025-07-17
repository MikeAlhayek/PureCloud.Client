using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GDPRRequestRequestTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Export for "GDPR_EXPORT"
    /// </summary>
    [EnumMember(Value = "GDPR_EXPORT")]
    Export,

    /// <summary>
    /// Enum Update for "GDPR_UPDATE"
    /// </summary>
    [EnumMember(Value = "GDPR_UPDATE")]
    Update,

    /// <summary>
    /// Enum Delete for "GDPR_DELETE"
    /// </summary>
    [EnumMember(Value = "GDPR_DELETE")]
    Delete
}
