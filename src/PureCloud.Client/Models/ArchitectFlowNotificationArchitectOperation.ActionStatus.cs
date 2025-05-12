using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The action status
/// </summary>
/// <value>The action status</value>

public enum ArchitectFlowNotificationArchitectOperationActionStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Locked for "LOCKED"
    /// </summary>
    [EnumMember(Value = "LOCKED")]
    Locked,

    /// <summary>
    /// Enum Unlocked for "UNLOCKED"
    /// </summary>
    [EnumMember(Value = "UNLOCKED")]
    Unlocked,

    /// <summary>
    /// Enum Started for "STARTED"
    /// </summary>
    [EnumMember(Value = "STARTED")]
    Started,

    /// <summary>
    /// Enum PendingGeneration for "PENDING_GENERATION"
    /// </summary>
    [EnumMember(Value = "PENDING_GENERATION")]
    PendingGeneration,

    /// <summary>
    /// Enum PendingBackendNotification for "PENDING_BACKEND_NOTIFICATION"
    /// </summary>
    [EnumMember(Value = "PENDING_BACKEND_NOTIFICATION")]
    PendingBackendNotification,

    /// <summary>
    /// Enum Success for "SUCCESS"
    /// </summary>
    [EnumMember(Value = "SUCCESS")]
    Success,

    /// <summary>
    /// Enum Failure for "FAILURE"
    /// </summary>
    [EnumMember(Value = "FAILURE")]
    Failure
}
