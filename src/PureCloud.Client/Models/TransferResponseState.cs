using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The state of the command.
/// </summary>
/// <value>The state of the command.</value>

public enum TransferResponseState
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
    /// Enum Complete for "Complete"
    /// </summary>
    [EnumMember(Value = "Complete")]
    Complete,

    /// <summary>
    /// Enum Canceled for "Canceled"
    /// </summary>
    [EnumMember(Value = "Canceled")]
    Canceled,

    /// <summary>
    /// Enum Failed for "Failed"
    /// </summary>
    [EnumMember(Value = "Failed")]
    Failed,

    /// <summary>
    /// Enum Timeout for "Timeout"
    /// </summary>
    [EnumMember(Value = "Timeout")]
    Timeout,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
