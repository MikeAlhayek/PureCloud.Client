using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The status of the request
/// </summary>
/// <value>The status of the request</value>

public enum GDPRRequestStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Initiated for "INITIATED"
    /// </summary>
    [EnumMember(Value = "INITIATED")]
    Initiated,

    /// <summary>
    /// Enum Searching for "SEARCHING"
    /// </summary>
    [EnumMember(Value = "SEARCHING")]
    Searching,

    /// <summary>
    /// Enum Updating for "UPDATING"
    /// </summary>
    [EnumMember(Value = "UPDATING")]
    Updating,

    /// <summary>
    /// Enum Deleting for "DELETING"
    /// </summary>
    [EnumMember(Value = "DELETING")]
    Deleting,

    /// <summary>
    /// Enum Completed for "COMPLETED"
    /// </summary>
    [EnumMember(Value = "COMPLETED")]
    Completed,

    /// <summary>
    /// Enum Error for "ERROR"
    /// </summary>
    [EnumMember(Value = "ERROR")]
    Error,

    /// <summary>
    /// Enum Finalizing for "FINALIZING"
    /// </summary>
    [EnumMember(Value = "FINALIZING")]
    Finalizing
}
