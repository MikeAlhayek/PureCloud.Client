using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The current status of the deployment
/// </summary>
public enum ExpandableWebDeploymentStatus
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

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
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Deleting for "Deleting"
    /// </summary>
    [EnumMember(Value = "Deleting")]
    Deleting
}
