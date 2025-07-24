using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The status of the escalation rule.
/// </summary>
public enum Status
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
    /// Enum Paused for "Paused"
    /// </summary>
    [EnumMember(Value = "Paused")]
    Paused
}