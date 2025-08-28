using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The status of this time off request
/// </summary>
public enum CreateAdminTimeOffRequestStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "PENDING"
    /// </summary>
    [EnumMember(Value = "PENDING")]
    Pending,

    /// <summary>
    /// Enum Approved for "APPROVED"
    /// </summary>
    [EnumMember(Value = "APPROVED")]
    Approved
}